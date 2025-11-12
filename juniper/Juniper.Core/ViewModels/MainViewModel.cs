namespace Juniper.Core.ViewModels;

public class MainViewModel : BaseViewModel, IAsyncInitialization
{
    public static MainViewModel Current { get; private set; }

    public event Action<bool> Initialized;
    public event Action<string, string, InfoSeverity> OnDisplayInfoBarRequest;

    public Task Initialization { get; private set; }

    public readonly IFieldsService FieldsService = Ioc.Default.GetRequiredService<IFieldsService>();
    public readonly IFilesService FilesService = Ioc.Default.GetRequiredService<IFilesService>();
    public readonly ISettingsService SettingsService = Ioc.Default.GetRequiredService<ISettingsService>(); 

    public DynamoService DynamoService { get; }
    public S3BucketService S3BucketService { get; }
    public SettingsViewModel SettingsViewModel { get; }
    public OrdersViewModel OrdersViewModel { get; }
    public ShipmentsViewModel ShipmentsViewModel { get; }
    public InvoicesViewModel InvoicesViewModel { get; }
    public LoggerUtil LoggerUtil { get; }
    public ExcelInteropUtil ExcelUtil { get; }
    public WordInteropUtil WordUtil { get; }
    public TagsLibrary TagsLibrary { get; }

    public ObservableCollection<TradingPartnerModel> TradingPartners { get; } = new ObservableCollection<TradingPartnerModel>();

    public MainViewModel()
    {
        Current = this;

        LoggerUtil = Ioc.Default.GetRequiredService<LoggerUtil>();
        ExcelUtil = Ioc.Default.GetRequiredService<ExcelInteropUtil>();
        WordUtil = Ioc.Default.GetRequiredService<WordInteropUtil>();
        DynamoService = Ioc.Default.GetRequiredService<DynamoService>();
        S3BucketService = Ioc.Default.GetRequiredService<S3BucketService>();
        SettingsViewModel = Ioc.Default.GetRequiredService<SettingsViewModel>();
        OrdersViewModel = Ioc.Default.GetRequiredService<OrdersViewModel>();
        ShipmentsViewModel = Ioc.Default.GetRequiredService<ShipmentsViewModel>();
        InvoicesViewModel = Ioc.Default.GetRequiredService<InvoicesViewModel>();
        TagsLibrary = Ioc.Default.GetRequiredService<TagsLibrary>();

        Initialization = Init(true);
    }

    public async Task Init(bool invoke)
    {
        #region address comment
        //var t1 = await FilesService.ReadToStringValueAsync(@"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Address Lists\Nordstrom - Copy.csv");
        //var t2 = await FilesService.ReadToStringValueAsync(@"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Address Lists\Nordstrom - Copy - Copy.csv");
        //string[] d1 = t1.Split(Environment.NewLine);
        //string[] d2 = t2.Split(Environment.NewLine);
        //string? tmpNordstromSTDC=null;
        //List<string> d = new List<string>();
        //foreach (var al in d1)
        //{
        //    List<string> data = al.Split(',').ToList();
        //    foreach (var l in d2)
        //    {
        //        if (l.StartsWith("SHIP TO DC"))
        //        {
        //            tmpNordstromSTDC = l.Split(' ')[3];
        //            continue;
        //        }
        //        string[] paddedLines = l.Split(' ');
        //            if (paddedLines.Contains(data[0]) || paddedLines.Contains(data[0]+ ",,,,,,"))
        //            {
        //                if (tmpNordstromSTDC != null)
        //                {
        //                    data.Insert(1, tmpNordstromSTDC);
        //                    data.Insert(1, tmpNordstromSTDC);
        //                break;
        //                }
        //            }

        //    }
        //    string nlin = "";
        //    foreach (var item in data)
        //    {
        //        nlin += item + ",";
        //    }
        //    nlin = nlin.Remove(nlin.Length - 1);
        //    d.Add(nlin);
        //}
        //string s = "";
        //foreach (var item in d)
        //{
        //    s += item + Environment.NewLine;
        //}
        #endregion
        try
        {
            TradingPartners.Clear();

            await FieldsService.Initialization;
            await SettingsViewModel.Init();

            if (SettingsViewModel.IsLoggedIn)
            {
                var tpartners = await DynamoService.GetAllItemsAsync<TradingPartnersTable>();
                if (tpartners == null)
                    throw new NullReferenceException("tpartners == null");
                foreach (var p in tpartners)
                {
                    #region adddress comment
                    //         if (p.Addresses == null || p.Addresses.Count == 0)
                    //         {
                    //             if (p.Addresses == null)
                    //                 p.Addresses = new List<BaseAddressModel>();
                    //             var filepath =
                    //p.TradingPartnerId == SettingsViewModel.BloomingdalesPartnerID ? @"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Address Lists\Bloomingdales - Copy.csv" :
                    //p.TradingPartnerId == SettingsViewModel.BloomingdalesOutletPartnerID ? @"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Address Lists\Bloomingdales Outlet - Copy.csv" :
                    //p.TradingPartnerId == SettingsViewModel.NordstromPartnerID ? @"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Address Lists\Nordstrom - Copy.csv" :
                    //p.TradingPartnerId == SettingsViewModel.NordstromCANPartnerID ? @"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Address Lists\Nordstrom Canada - Copy.csv" :
                    //p.TradingPartnerId == SettingsViewModel.SacksPartnerID ? @"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project\Address Lists\Saks - Copy.csv" :
                    //null;
                    //             if (filepath != null)
                    //             {
                    //                 var txt = await FilesService.ReadToStringValueAsync(filepath);
                    //                 if (txt is not null)
                    //                 {
                    //                     string[] lines = txt.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                    //                     foreach (string line in lines)
                    //                     {
                    //                         string[] data = line.Split(',');

                    //                         try
                    //                         {
                    //                             p.Addresses.Add(new BaseAddressModel
                    //                             {
                    //                                 SAddressTypeCode = data[0].Trim() == data[1].Trim() ? "ST" : "BY",
                    //                                 SLocationCodeQualifier = "92",
                    //                                 AddressLocationNumber = data[0].Trim(),
                    //                                 DCAddressLocationNumber = data[1].Trim(),
                    //                                 DC = data[2].Trim(),
                    //                                 AddressModel = new AddressModel
                    //                                 {
                    //                                     Name = data[3].Trim(),
                    //                                     Address = data[4].Trim(),
                    //                                     City = data[5].Trim(),
                    //                                     State = data[6].Trim(),
                    //                                     Zip = data[7].Trim(),
                    //                                     PhoneNumber = data.Length >= 9 ? data[8].Trim() : "<na>",
                    //                                     Country = data.Length >= 10 ? data[9].Trim() : "US",
                    //                                     Address2 = data.Length >= 11 ? data[10].Trim() : "<na>",
                    //                                 }
                    //                             });
                    //                         }
                    //                         catch (Exception e)
                    //                         {

                    //                         }
                    //                     }
                    //                 }
                    //             }
                    //             await DynamoService.Store(p);
                    //         }
                    #endregion
                    TradingPartners.Add(new TradingPartnerModel(p.TradingPartnerName, p.TradingPartnerId)
                    {
                        DBTable = p,
                        DefaultCarrier = p.DefaultCarrier,
                        Addresses = p.Addresses
                    });
                }
                //var spsHIstory = await RestClientService.Current.GetHistoryRequest();

                InvoicesViewModel.InvoicesTable = await DynamoService.GetAllItemsAsync<InvoicesTable>() ?? new List<InvoicesTable>();
                ShipmentsViewModel.ShipmentsTable = await DynamoService.GetAllItemsAsync<ShipmentsTable>() ?? new List<ShipmentsTable>();
                ShipmentsViewModel.SSCCsTableList = await DynamoService.GetAllItemsAsync<SSCCsTable>() ?? new List<SSCCsTable>();
                OrdersViewModel.OrdersTable = await DynamoService.GetAllItemsAsync<PurchaseOrderTable>() ?? new List<PurchaseOrderTable>();

                await OrdersViewModel.Init(false);
                //await OrdersViewModel.ReloadOrders(true);
                if (SettingsViewModel.StateofSandbox)
                {
                    //load all
                    //await OrdersViewModel.Init();
                    //downlods from sps n loads into aws
                    //await OrdersViewModel.ReloadOrders(false);
                    //also downloads but only deletse
                    //await OrdersViewModel.ReloadOrders(true);

                    //List<string> ssccs = new();
                    //List<string> asns = new();
                    //foreach (var tp in TradingPartners)
                    //{
                    //    #region shipments
                    //    //List<SSCCsTable> ssccsList = new();
                    //    //foreach (var asn in tp.ASNShipments)
                    //    //{
                    //    //    try
                    //    //    {
                    //    //        if (!asn.FromDynamoLoaded)
                    //    //        {
                    //    //            await asn.LoadS3Data();
                    //    //            await asn.GetDBTableRow(false);
                    //    //            asn.FromDynamoLoaded = true;
                    //    //        }
                    //    // await asn.PutIntoSSCCTable();
                    //    //        foreach (var item in asn.OrderLevel)
                    //    //        {
                    //    //                //var l = asn.ASNId + "-" + pack.ShippingSerialID;
                    //    //                //if (ssccs.Contains(pack.ShippingSerialID))
                    //    //                //{
                    //    //                //    //Debug.WriteLine(l);
                    //    //                //    //asns.Add(pack.ShippingSerialID);
                    //    //                //}
                    //    //                //else
                    //    //                //{
                    //    //                //    Debug.WriteLine(l);
                    //    //                //    //ssccs.Add(pack.ShippingSerialID);
                    //    //                //}
                    //    //            }
                    //    //        }
                    //    //    }
                    //    //    catch (Exception e)
                    //    //    {

                    //    //    }
                    //    //}
                    //    //await DynamoService.Current.PutTableBatch(ssccsList);
                    //    #endregion

                    //    #region invs
                    //    //List<List<InvoicesTable>> invTables = new();
                    //    //invTables.Add(new List<InvoicesTable>());
                    //    //foreach (var inv in tp.InvoiceViewModels)
                    //    //{
                    //    //    try
                    //    //    {
                    //    //        if (!inv.FromDynamoLoaded)
                    //    //        {
                    //    //            await inv.LoadS3Data();
                    //    //            await inv.GetDBTableRow(false);
                    //    //            inv.FromDynamoLoaded = true;
                    //    //        }


                    //    //        foreach (var item in inv.InvoiceHeader.Address)
                    //    //        {
                    //    //            if (item.SAddressTypeCode.StartsWith("B") && !inv.DBTable.BYAddressIds.Contains(item.AddressLocationNumber))
                    //    //            {
                    //    //                inv.DBTable.BYAddressIds.Add(item.AddressLocationNumber);
                    //    //                if (invTables[invTables.Count - 1].Count >= 1000)
                    //    //                    invTables.Add(new List<InvoicesTable>());

                    //    //                invTables[invTables.Count - 1].Add(inv.DBTable);
                    //    //            }
                    //    //        }
                    //    //    }
                    //    //    catch (Exception e)
                    //    //    {

                    //    //    }
                    //    //}
                    //    //foreach (var item in invTables)
                    //    //    await DynamoService.Current.PutTableBatch(item);
                    //    #endregion
                    //}
                }
                TradingPartners.SortAll();

                DisplayInfobarMessage("Loadin Complete", $"PO's - {OrdersViewModel.PurchaseOrders.Count}, ASN's - {ShipmentsViewModel.ReadShipments.Count}, INV's - {InvoicesViewModel.ReadInvoices.Count}", InfoSeverity.Success);
            }


            if (invoke)
                Initialized?.Invoke(SettingsViewModel.IsLoggedIn);
        }
        catch (Exception ee)
        {
            LoggerUtil.AddException(ee, "Main Init()");
        }
    }

    public TradingPartnerModel GetTradingPartnerModelById(string? tradingPartnerId) =>
        TradingPartners.SingleOrDefault(tp => tp.TradingPartnerId == tradingPartnerId) ?? 
        new TradingPartnerModel(tradingPartnerId ?? "N/A", tradingPartnerId ?? "N/A");
    public TradingPartnerModel GetTradingPartnerModelByName(string? name) =>
        TradingPartners.SingleOrDefault(tp => tp.Name == name) ??
        new TradingPartnerModel(name ?? "N/A", name ?? "N/A");

    public string GetDocumentStatusText(DocumentStatus status) => status switch
    {
        DocumentStatus.New => $" New",
        DocumentStatus.Saved => $" Saved",
        DocumentStatus.Sent => $" Sent",
        _ => " - unknown",
    };
    public DocumentType GetDocumentTypeFromText(string status) => status switch
    {
        "ASBpo" => DocumentType.PO850,
        "ASBasn" => DocumentType.ASN856,
        "ASBinv" => DocumentType.IN810,
        "ASBOL" => DocumentType.BOL,
        _ => DocumentType.PO850,
    };

    public void DisplayInfobarMessage(string title, string message, InfoSeverity severity = InfoSeverity.Informational)
    {
        OnDisplayInfoBarRequest?.Invoke(title, message, severity);
    }


    public override Task OnCommandActivated(string? commandParam)
    {
        throw new NotImplementedException();
    }

    internal void ShipmentOrInvoiceOrPO_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add)
        {
            if (e.NewItems is not null)
                foreach (var item in e.NewItems)
                    if (item is not null)
                        if (item is InvoiceViewModel vm)
                        {
                            InvoicesViewModel.AddToAllInvoicesList(vm);
                            vm.asnvm.povm.RaisePropertyChanged("InvoiceViewModels");
                        }
                        else if (item is ASNViewModel avm)
                        {
                            ShipmentsViewModel.AddToAllASNShipmentsList(avm);
                        }
                        else if (item is PurchaseOrderViewModel po)
                        {
                            OrdersViewModel.AddToAllPOs(po);
                        }
        }
        else if (e.Action == NotifyCollectionChangedAction.Remove)
        {
            if (e.OldItems is not null)
                foreach (var item in e.OldItems)
                    if (item is not null)
                        if (item is InvoiceViewModel vm)
                        {
                            InvoicesViewModel.RemoveFromAllInvoicesList(vm);

                            vm.asnvm.povm.RaisePropertyChanged("InvoiceViewModels");

                            if (vm.asnvm.povm.SelectedInvoiceViewModel == vm)
                            {
                                if (vm.asnvm.InvoiceViewModels.Count > 0)
                                    vm.asnvm.povm.SelectedInvoiceViewModel = vm.asnvm.InvoiceViewModels[vm.asnvm.InvoiceViewModels.Count - 1];
                                else
                                {
                                    vm.asnvm.povm.SelectedInvoiceViewModel = null;
                                    vm.asnvm.Status = vm.asnvm.Status;
                                }
                            }
                        }
                        else if (item is ASNViewModel avm)
                        {
                            ShipmentsViewModel.RemoveFromAllASNShipmentsList(avm);

                            if (avm.povm.SelectedASNViewModel == avm)
                            {
                                if (avm.povm.ASNCollection.Count > 0)
                                    avm.povm.SelectedASNViewModel = avm.povm.ASNCollection[avm.povm.ASNCollection.Count - 1];
                                else
                                    avm.povm.SelectedASNViewModel = null;
                            }
                        }
                        else if (item is PurchaseOrderViewModel po)
                        {
                            OrdersViewModel.RemoveFromAllPOs(po);
                        }

        }
        else if (e.Action == NotifyCollectionChangedAction.Reset)
        {
            if (sender is ObservableCollection<PurchaseOrderViewModel>)
            {
                foreach (var p in TradingPartners)
                {
                    p.PurchaseOrders.Clear();
                }
            }
            //else if(sender is ObservableCollection<InvoiceViewModel>)
            //{
            //    foreach (var p in TradingPartners)
            //    {
            //        p.InvoiceViewModels.Clear();
            //    }
            //}
            //else if (sender is ObservableCollection<ASNViewModel>)
            //{
            //    foreach (var p in TradingPartners)
            //    {
            //        p.ASNShipments.Clear();
            //    }
            //}
            //else
            //{

            //}
        }
    }
}