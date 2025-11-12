namespace Juniper.Core.ViewModels;
public class OrdersViewModel : ABaseMainPageViewModel
{
    public  static OrdersViewModel Current { get; private set; }

    #region fields
    private PurchaseOrderViewModel? selectedPO;
    #endregion

    /// <summary>
    /// AWS Purchase Orders from db 
    /// </summary>
    public List<PurchaseOrderTable> OrdersTable { get; internal set; }

    /// <summary>
    /// Purchase Orders loaded from s3
    /// </summary>
    public ObservableCollection<PurchaseOrderViewModel> PurchaseOrders { get; set; }
    public PurchaseOrderViewModel? SelectedPO
    {
        get => selectedPO;
        set
        {
            SetProperty(ref selectedPO, value);
        }
    }

    #region ABaseMainPageViewModel
    public override IEnumerable<IHaveIncrementals> IncViewModels => PurchaseOrders.Cast<IHaveIncrementals>();
    public override void OrderBy()
    {
        PurchaseOrders.OrderByIncrementals();
    }
    #endregion

    public OrdersViewModel():base()
    {
        Current = this;

        PurchaseOrders = new ObservableCollection<PurchaseOrderViewModel>();
        PurchaseOrders.CollectionChanged += MainViewModel.Current.ShipmentOrInvoiceOrPO_CollectionChanged;
    }
    public async Task Init(bool loadloacal)
    {
        IsLoading = true;
        if (loadloacal)
        {
            await MainViewModel.Current.ShipmentsViewModel.Init(false);
            await MainViewModel.Current.InvoicesViewModel.Init(false);
            await ReloadOrders(false);
        }
        else
        {
            ConcurrentBag<Tuple<Order, string>> loadedPurchaseOrderViewModel = new();

            await Parallel.ForEachAsync(OrdersTable, ExtensionMethods.GetNewParallelOptions(),
                     async (o, token) =>
                     {
                         var json = await S3BucketService.Current.ReadObjectDataAsync("orders", o.S3KeyName);

                         var order = JsonSerializer.Deserialize<Order>(json);
                         if (order?.Header is null ||
                             PurchaseOrders.Any(p => p.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber == order?.Header?.OrderHeader?.PurchaseOrderNumber))
                         {
                             Debug.WriteLine("order?.Header is null || PurchaseOrders.Any(p => p.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber == order?.Header?.OrderHeader?.PurchaseOrderNumber)");
                         }
                         else
                         {
                             loadedPurchaseOrderViewModel.Add(new Tuple<Order, string>(order, o.TradingPartner));
                         }
                     });

            foreach (var o in loadedPurchaseOrderViewModel)
            {
                PurchaseOrderViewModel p = new(new POResultDataModel()
                {
                    Order = o.Item1,
                    FromDynamo = true,
                });
                PurchaseOrders.Add(p);

                await p.LoadLocalSaved(ShipmentsViewModel.Current.Init(from s in ShipmentsViewModel.Current.ShipmentsTable
                                                                       where s.PONumber == p.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber
                                                                       select s));
            }
        }
        IsLoading = false;
    }

    public async Task Init()
    {
        
    }
    public async Task ReloadOrders(bool delete)
    {
        //List<string> loadpotasklist = new();
        //List<string> ignoreFilenames = new(ignors);
        var purchaseOrdersResult = await RestClientService.Current.GetTransactionsByDirPathAsync();
        if (purchaseOrdersResult == null)
        {
            MainViewModel.Current.DisplayInfobarMessage("Error in GetTransactionsByDirPathAsync(out)", "purchaseOrdersResult == null", InfoSeverity.Error);
        }
        else
        {
            var orderd = purchaseOrdersResult.results.OrderBy(o => o.path).ToArray();
            List<Tuple<Order?, string>> tmpPurchaseO = new();
            for (int i = orderd.Length - 1; i >= 0; i--)
            {
                var poResult = orderd[i];
                if (poResult.type == "file")
                {
                    var json = await RestClientService.Current.GetTransactionAsync(poResult.url);
                    Order? orderded = JsonSerializer.Deserialize<Order>(json);
                    if (orderded?.Header is null ||
                        tmpPurchaseO.Any(p => p.Item1?.Header?.OrderHeader?.PurchaseOrderNumber == orderded?.Header?.OrderHeader?.PurchaseOrderNumber))
                    {
                        var pofilename = $"{poResult.path.Substring(poResult.path.LastIndexOf("/") + 1)}";
                        await FilesService.WriteAsync(FilesService.ArchivedPurchaseOrdersFolder, pofilename, orderd);
                        await RestClientService.Current.DeleteRequest(poResult.url);
                    }
                    else
                    {
                        tmpPurchaseO.Add(new Tuple<Order?, string>(orderded, poResult.url));
                    }
                }
            }
            foreach (var o in tmpPurchaseO)
            {
                var pofilename = $"PO{o.Item1?.Header?.OrderHeader?.PurchaseOrderNumber}.json";
                var jsonFpath = Path.Combine(FilesService.SavedPurchaseOrdersFolder, pofilename);

                await FilesService.WriteAsync(FilesService.SavedPurchaseOrdersFolder, pofilename, o.Item1);
                if (delete)
                {
                    await RestClientService.Current.DeleteRequest(o.Item2);
                    continue;
                }

                var p = new PurchaseOrderViewModel(
                    new POResultDataModel()
                    {
                        Order = o.Item1,
                        JsonPath = jsonFpath
                    });

                PurchaseOrders.Add(p);
            }
            if (delete)
                return;
        }

        PurchaseOrders.OrderByIncrementals();
        if (Debugger.IsAttached)
        {
            List<PurchaseOrderTable> poTableList = new();
            List<ShipmentsTable> asnTableList = new();
            List<InvoicesTable> invTableList = new();
            foreach (var tp in TradingPartners)
            {
                tp.Sort();

                foreach (var p in tp.PurchaseOrders)
                {
                    if (p.POData.FromDynamo)
                        continue;
                    var file = p.POData.JsonPath;
                    if (!File.Exists(file))
                        file = Path.Combine(FilesService.GetLocalStorageFolder(), file);
                    if (!File.Exists(file))
                    {

                    }
                    else
                    {
                        await S3BucketService.Current.UploadFileAsync(file, "orders", p.PoId);

                        poTableList.Add(new PurchaseOrderTable
                        {
                            TradingPartner = tp.Name,
                            PONumber = p.PoId,
                            JsonFilePath = file,
                            S3KeyName = p.PoId,
                        });
                    }
                }

                foreach (var asn in tp.ASNShipments)
                {
                    if (asn.FromDynamo)
                        continue;

                    if (!File.Exists(asn.JsonFilePath))
                    {

                    }
                    else
                    {
                        if (asnTableList.Any(t => t.ASNNumber == asn.ASNId))
                        {
                            Debug.WriteLine(asn.ASNId + " " + asn.JsonFilePath);
                        }
                        else
                        {
                            await S3BucketService.Current.UploadFileAsync(asn.JsonFilePath, "shipments", asn.S3KeyName);
                            asnTableList.Add(new ShipmentsTable
                            {
                                ASNNumber = asn.ASNId,
                                PONumber = asn.PoId,
                                ShipDate = asn.ShipmentHeader.ShipDate.ToSpsDateString(),
                                S3KeyName = asn.S3KeyName,
                            });
                        }
                    }
                }

                foreach (var inv in tp.InvoiceViewModels)
                {
                    if (inv.FromDynamo)
                        continue;

                    if (!File.Exists(inv.JsonFilePath))
                    {

                    }
                    else
                    {
                        if (invTableList.Any(t => t.INVNumber == inv.InvoiceHeader.InvoiceNumber))
                        {
                            Debug.WriteLine(inv.PoId + " " + inv.ASNId + " " + inv.InvoiceHeader.InvoiceNumber + " " + inv.JsonFilePath);
                        }
                        else
                        {
                            await S3BucketService.Current.UploadFileAsync(inv.JsonFilePath, "invoices", inv.S3KeyName);
                            invTableList.Add(new InvoicesTable
                            {
                                ASNNumber = inv.ASNId,
                                INVNumber = inv.InvoiceHeader.InvoiceNumber,
                                PONumber = inv.PoId,
                                INVDate = inv.InvoiceHeader.InvoiceDate.ToSpsDateString(),
                                S3KeyName = inv.S3KeyName,
                            });
                        }
                    }
                }
            }
            if (poTableList.Count > 0)
                await DynamoService.Current.PutTableBatch(poTableList);
            if (asnTableList.Count > 0)
                await DynamoService.Current.PutTableBatch(asnTableList);
            if (invTableList.Count > 0)
                await DynamoService.Current.PutTableBatch(invTableList);
        }

        MainViewModel.Current.DisplayInfobarMessage("Done Loading", $"", InfoSeverity.Success);
    }

    #region OnCommandActivated
    public override async Task<Exception?> OnCommandActivated(string? commandParam)
    {
        if (!OnCommand.IsRunning)
        {
            IsLoading = true;
            try
            {
                switch (commandParam)
                {
                    case "CommandReloadOrders":
                        ShipmentsViewModel.Current.ClearLists();
                        InvoicesViewModel.Current.ClearList();
                        ClearLists();
                        await MainViewModel.Current.Init(false);
                        break;

                    case "CommandCheckPrepack":
                        CheckPrepack();
                        break;

                    default:
                        return commandParam != null ? await base.RaiseOnCommandActivated(commandParam) : null;
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
                return ex;
            }
        }

        IsLoading = false;
        return null;
    }
    public void ClearLists()
    {
        foreach (var po in PurchaseOrders)
        {
            foreach (var asn in po.ASNCollection)
            {
                asn.InvoiceViewModels.Clear();
            }
            po.ASNCollection.Clear();
        }
        PurchaseOrders.Clear();
        foreach (var p in TradingPartners)
        {
            p.PurchaseOrders.Clear();
        }
    }
    private void CheckPrepack()
    {
        var lines = MainViewModel.Current.ExcelUtil.LastReadUPCList;

        if (lines is not null)
        {
            var erroredprepack = new Dictionary<PurchaseOrderViewModel, KeyValuePair<string, Dictionary<UPCsModel, double>>>();
            foreach (var o in PurchaseOrders)
            {
                o.HassPrepackError = false;
                o.PrepackErrorData.Clear();
                List<PrepackErrorDataModel> pped = new();
                var prepacks = new Dictionary<string, Dictionary<UPCsModel, double>>();
                if (o.POData.Order?.LineItem is List<LineItem> lis)
                    foreach (var li in lis)
                    {
                        if (li.QuantitiesSchedulesLocations is not null)
                            foreach (var location in li.QuantitiesSchedulesLocations)
                            {
                                if (location.LocationQuantity is not null)
                                    foreach (var l in location.LocationQuantity)
                                    {
                                        if (l.Location is string llocation && l.Qty is double qty)
                                        {
                                            var upcLine = lines?.FirstOrDefault(l => l.GTIN == li.OrderLine?.ConsumerPackageCode);
                                            if (upcLine is not null && upcLine.PrePackSizeNumber != "-1")
                                            {
                                                if (prepacks.TryGetValue(llocation, out Dictionary<UPCsModel, double>? sizelist))
                                                {
                                                    sizelist.Add(upcLine, qty);
                                                }
                                                else
                                                {
                                                    prepacks.Add(llocation, new Dictionary<UPCsModel, double>() { { upcLine, qty } });
                                                }
                                            }
                                        }
                                    }
                            }
                    }

                foreach (var p in prepacks)
                    foreach (var v in p.Value)
                    {
                        int checkVal, checkNum = checkVal = (int)v.Value;
                        if (int.TryParse(v.Key.ASST, out int asst) && asst > 0)
                            checkNum = asst;
                        else if (int.TryParse(v.Key.PrePackSizeNumber, out int sn) && sn > -1)
                            checkNum = sn;

                        if (checkVal != checkNum && checkVal % checkNum != 0)
                        {
                            o.HassPrepackError = true;
                            var pedm = new PrepackErrorDataModel()
                            {
                                Store = p.Key,
                                Product = v.Key,
                                OrderdNumber = v.Value,
                            };
                            var timesn = 0;
                            for (int i = 0; i < p.Value.Count; i++)
                            {
                                var vv = p.Value.ElementAt(i);
                                if (vv.Key.Product == v.Key.Product && vv.Key.ColorDescripton == v.Key.ColorDescripton)
                                {
                                    //if (timesn > 0)
                                    //    pedm.OrderdBreakdown += " ";
                                    pedm.OrderdBreakdown += $"{vv.Value} ";
                                    timesn++;
                                }
                            }
                            pped.Add(pedm);
                        }
                    }

                foreach (var ed in from i in pped
                                   group i by i.Product.Product into g
                                   orderby g.Key
                                   from g2 in
                                   from i in g
                                   group i by i.Store
                                   select new GroupInfoList(g2) { Key = $"{g.Key} Store: {g2.Key}" })
                {
                    o.PrepackErrorData.Add(ed);
                }
            }
        }
    }
    #endregion

    internal void RemoveFromAllPOs(PurchaseOrderViewModel po)
    {
        po.TradingPartner?.RemovePurchaseOrder(po);

        DocumentDates.RemoveUnique(PurchaseOrders, po.Date);
    }
    internal void AddToAllPOs(PurchaseOrderViewModel po)
    {
        po.TradingPartner.AddPurchaseOrder(po);

        DocumentDates.AddUnique(po.Date);
    }

    public static List<LocationQuantity> GetPOOrderStyleLinesStores(PurchaseOrderViewModel povm, bool unique)
    {
        if (povm.storesTotals.Count == 0 || povm.uniqueStoresTotals.Count == 0)
        {
            foreach (var p in povm.POOrderStyleLines)
            {
                if (p.LineItem.QuantitiesSchedulesLocations is not null)
                    foreach (var location in p.LineItem.QuantitiesSchedulesLocations)
                    {
                        if (location.LocationQuantity is not null)
                            foreach (var lq in location.LocationQuantity)
                            {
                                if (!povm.uniqueStoresTotals.Any(s => s.Location == lq.Location))
                                {
                                    povm.uniqueStoresTotals.Add(lq);
                                }

                                if (!povm.storesTotals.Contains(lq))
                                    povm.storesTotals.Add(lq);
                            }
                    }

            }
        }

        return unique ? povm.uniqueStoresTotals : povm.storesTotals;
    }
}