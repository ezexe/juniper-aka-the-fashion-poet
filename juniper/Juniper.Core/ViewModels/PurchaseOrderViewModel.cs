namespace Juniper.Core.ViewModels;
public class PurchaseOrderViewModel : BaseViewModel, IHaveIncrementals
{
    public TradingPartnerModel TradingPartner { get; set; }

    public readonly List<LocationQuantity> storesTotals = new();
    public readonly List<LocationQuantity> uniqueStoresTotals = new();

    #region fields
    private string displayName;
    private string displayStatus;
    private string displayASNStatus;
    private DocumentStatus status = DocumentStatus.Saved;
    private bool hasPrepackError;
    private POResultDataModel pod;
    private ASNViewModel? selectedASNViewModel;
    private InvoiceViewModel? selectedInvoiceViewModel;
    #endregion

    #region props
    public string DisplayName => TradingPartner.Name;
    public string DisplayStatus
    {
        get => displayStatus;
        set => SetProperty(ref displayStatus, value);
    }
    public string DisplayASNStatus
    {
        get => displayASNStatus;
        set => SetProperty(ref displayASNStatus, value);
    }
    public DocumentStatus Status
    {
        get => status;
        set
        {
            if (status != value )
            SetProperty(ref status, value);
        }
    }
    public DateTimeOffset OrderDate
    {
        get
        {
            var sp = POData.Order?.Header?.OrderHeader?.PurchaseOrderDate?.Split('-') ?? new string[] { "2000", "1", "1" };
            return new DateTimeOffset(new DateTime(System.Convert.ToInt32(sp[0]), System.Convert.ToInt32(sp[1]), System.Convert.ToInt32(sp[2])));
        }
    }
    public bool HassPrepackError
    {
        get { return hasPrepackError; }
        set { SetProperty(ref hasPrepackError, value); }
    }

    public ObservableCollection<GroupInfoList> PrepackErrorData { get; } = new ObservableCollection<GroupInfoList>();
    public ObservableCollection<GroupInfoList> OrderCompletionStatusList { get; } = new ObservableCollection<GroupInfoList>();
    public ObservableCollection<GroupInfoList> OrderIncompletionStatusList { get; } = new ObservableCollection<GroupInfoList>();
    public ObservableCollection<POOrderLineModel> POOrderStyleLines { get; } = new ObservableCollection<POOrderLineModel>();

    public ObservableCollection<ASNViewModel> ASNCollection { get; } = new();
    public ASNViewModel? SelectedASNViewModel
    {
        get => selectedASNViewModel;
        set
        {
            if (selectedASNViewModel != value)
            {
                SetProperty(ref selectedASNViewModel, value);
                if (value is not null)
                {
                    value.Status = value.Status;
                    //OnNavigateToRequested?.Invoke(OrdersViewModel.Navigate_ToASN);
                }
                //else
                //    OnNavigateToRequested?.Invoke(OrdersViewModel.Navigate_ToNull);
            }
        }
    }
    public ObservableCollection<InvoiceViewModel>? InvoiceViewModels
    {
        get
        {
            return SelectedASNViewModel?.InvoiceViewModels;
        } //; } = new ObservableCollection<InvoiceViewModel>();
    }
    public InvoiceViewModel? SelectedInvoiceViewModel
    {
        get => selectedInvoiceViewModel;
        set
        {
            if (selectedInvoiceViewModel != value)
            {
                SetProperty(ref selectedInvoiceViewModel, value);
                if (value is not null)
                {
                    value.Status = value.Status;
                    //OnNavigateToRequested?.Invoke(OrdersViewModel.Navigate_ToINV);
                }
                //else
                //{
                //    OnNavigateToRequested?.Invoke(OrdersViewModel.Navigate_ToASN);
                //}
            }
        }
    }
    #endregion

    #region IHaveIncrementals
    [JsonIgnore]
    public int Id
    {
        get
        {
            if (int.TryParse(POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber, out int id))
                return id;
            else
                return 0;
        }

        set => throw new NotImplementedException();
    }
    [JsonIgnore]
    public string PoId { get => POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber ?? ""; }
    [JsonIgnore]
    public DateTimeOffset Date => OrderDate;

    [JsonIgnore]
    public string StringId { get => PoId; }
    [JsonIgnore]
    public string ASNId => throw new NotImplementedException();
    [JsonIgnore]
    public int Bol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    private bool isDupe;
    [JsonIgnore]
    public bool IsDupe
    {
        get => isDupe;
        set => SetProperty(ref isDupe, value);
    }
    private DateTime fileCreationTime;
    [JsonIgnore]
    public DateTime FileCreationTime
    {
        get => fileCreationTime;
        set => SetProperty(ref fileCreationTime, value);
    }
    #endregion

    #region init
    public PurchaseOrderViewModel(POResultDataModel pOResultDataModel) : base()
    {
        POData = pOResultDataModel;
        ASNCollection.CollectionChanged += MainViewModel.Current.ShipmentOrInvoiceOrPO_CollectionChanged;
    }

    internal async Task LoadLocalSaved(List<Tuple<ShipmentsTable, IEnumerable<InvoicesTable>>> list)
    {
        foreach (var st in list)
        {
            if (ASNCollection.Any(a => a.ShipmentHeader.ShipmentIdentification == st.Item1.ASNNumber))
                continue;


            var asnvm = new ASNViewModel
            {
                povm = this,
                FromDynamo = true,
                DBTable = st.Item1, //ShipmentsTable
                Status = DocumentStatus.Sent,
                InternalASNSettings = st.Item1.Settings ?? new InternalASNSettings(),
            };
            await asnvm.Init(false);

            asnvm.ShipmentHeader.ShipmentIdentification = st.Item1.ASNNumber;
            asnvm.ShipmentHeader.BillOfLadingNumber = st.Item1.BOLNumber;
            asnvm.ShipmentHeader.ShipDate = DateTimeOffset.Parse(st.Item1.ShipDate);
            asnvm.LoadLocalSaved(st.Item2);

            ASNCollection.Add(asnvm);
        }
    }
    #endregion

    public POResultDataModel POData
    {
        get => pod;
        set
        {
            if (pod != value)
            {
                //POOrderStyleLines
                if (value.Order?.LineItem is List<LineItem> lis)
                    foreach (LineItem li in lis)
                    {
                        POOrderLineModel polm = new() { LineItem = li };

                        if (polm.LineItem.OrderLine is OrderLine ol &&
                            ExcelInteropUtil.Current.LastReadUPCList.FirstOrDefault(l => l.GTIN == li.OrderLine?.ConsumerPackageCode) is UPCsModel upcLine)
                        {
                            ol.VendorPartNumber = upcLine.Product;
                            ol.ProductColorCode = upcLine.ColorCode;
                            ol.ProductColorDescription = upcLine.ColorDescripton;
                            ol.ProductSizeDescription = upcLine.SizeDescription;
                        }
                        if (!POOrderStyleLines.Any(po => po.LineItem.OrderLine?.ConsumerPackageCode == polm.LineItem.OrderLine?.ConsumerPackageCode))
                        {
                            POOrderStyleLines.Add(polm);
                        }
                    }

                try
                {
                    if (value.Order?.Header?.OrderHeader?.TradingPartnerId == TradingPartnerModel.TPID_Nord)
                    {
                        foreach (var l in from r in value.Order?.LineItem select r.QuantitiesSchedulesLocations)
                        {
                            foreach (var lq in from q in l select q.LocationQuantity)
                            {
                                foreach (var loc in from lo in lq select lo.Location)
                                {
                                    if (TradingPartnerModel.NordstromRackcom.Contains(loc))
                                    {
                                        TradingPartner = MainViewModel.Current.GetTradingPartnerModelByName(TradingPartnerModel.TPDN_Nordstromcom);
                                        break;
                                    }
                                }
                                if (TradingPartner != null)
                                    break;
                            }

                            if (TradingPartner != null)
                                break;
                        }

                        if (TradingPartner == null)
                            TradingPartner = MainViewModel.Current.GetTradingPartnerModelByName(TradingPartnerModel.TPDN_Nordstrom);
                    }
                    else if (value.Order?.Header?.OrderHeader?.TradingPartnerId == TradingPartnerModel.TPID_Sacks)
                        if (value.Order?.LineItem?[0].Address?[0].AddressName == "9999")
                            TradingPartner = MainViewModel.Current.GetTradingPartnerModelByName(TradingPartnerModel.TPDN_Sackscom);
                        else
                            TradingPartner = MainViewModel.Current.GetTradingPartnerModelByName(TradingPartnerModel.TPDN_Sacks);

                    if (TradingPartner == null)
                        TradingPartner = MainViewModel.Current.GetTradingPartnerModelById(value.Order?.Header?.OrderHeader?.TradingPartnerId);
                }
                catch (Exception e)
                {
                    MainViewModel.Current.LoggerUtil.AddException(e, "POResultDataModel POData");
                }
                SetProperty(ref pod, value);
            }
        }
    }

    public async Task<ASNViewModel> AddShipment(bool loadlocal, Shipment? shipment)
    {
        var asnvm = new ASNViewModel() { povm = this };

        if (shipment != null)
            await asnvm.SetFromShipment(shipment);
        else
            await asnvm.SetupNewHeader();

        await asnvm.Init(loadlocal);

        return asnvm;
    }
    public void SetASNStatuses()
    {
        var orderCSList = new List<PurchaseOrderCompletionStatus>();
        var orderISList = new List<PurchaseOrderCompletionStatus>();
        OrderCompletionStatusList.Clear();
        OrderIncompletionStatusList.Clear();

        foreach (var l in POOrderStyleLines)
        {
            //l.LineItem.OrderLine?.ConsumerPackageCode
            if (l.LineItem.QuantitiesSchedulesLocations is not null)
                foreach (var location in l.LineItem.QuantitiesSchedulesLocations)
                {
                    if (location.LocationQuantity is not null)
                        foreach (var lq in location.LocationQuantity)
                        {
                            //lq.Location
                            //lq.Qty
                            var missing = new List<LocationQuantity>();
                            if (ASNCollection.Count > 0)
                            {
                                foreach (var asn in ASNCollection)
                                    if (asn.Status == DocumentStatus.Sent)
                                    {
                                        if (asn.OrderLevel.FirstOrDefault(o => o.Address.AddressLocationNumber == lq.Location) is OrderPackItemModel o)
                                        {
                                            foreach (var pack in o.PackLevelList)
                                            {
                                                var li = pack.ItemLevel.ShipmentLines.FirstOrDefault(sl => sl.ConsumerPackageCode == l.LineItem.OrderLine?.ConsumerPackageCode);
                                                if (li != null)
                                                {
                                                    var pcs = orderCSList.FirstOrDefault(sl => sl.Polm == l);
                                                    if (pcs is null)
                                                    {
                                                        pcs = new PurchaseOrderCompletionStatus() { Polm = l };
                                                        orderCSList.Add(pcs);
                                                    }
                                                    pcs.LocationsStatus.Add(new PurchaseOrderCompletionStatusLocations() { Location = lq, ASNNumber = asn.ShipmentHeader.ShipmentIdentification });

                                                    if (lq.Qty <= li.ShipQty)
                                                    {
                                                        //missing = false;
                                                    }
                                                    else
                                                    {
                                                        //missing = true;
                                                    }
                                                }
                                                else
                                                {
                                                    if (!missing.Contains(lq))
                                                        missing.Add(lq);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (!missing.Contains(lq))
                                                missing.Add(lq);
                                        }
                                    }
                            }
                            else
                                missing.Add(lq);

                            if (missing.Count > 0)
                            {
                                var ocs = orderISList.FirstOrDefault(sl => sl.Polm == l);
                                if (ocs is null)
                                {
                                    ocs = new PurchaseOrderCompletionStatus() { Polm = l };
                                    orderISList.Add(ocs);
                                }
                                foreach (var m in missing)
                                {
                                    ocs.LocationsStatus.Add(new PurchaseOrderCompletionStatusLocations() { Location = lq, ASNNumber = "<U/N>" });
                                }
                            }
                        }
                }
        }

        DisplayASNStatus = 
            $"ASNs: {ASNCollection.Count} - Stores: {OrdersViewModel.GetPOOrderStyleLinesStores(this,true).Count} - UPCs: {POOrderStyleLines.Count} - Styles: {POOrderStyleLines.GroupPOOrderStyleLines().Count()}";
       
        foreach (var g in orderISList.GroupPOCompletionStatusLis())
        {
            OrderIncompletionStatusList.Add(g);
        }
        foreach (var g in orderCSList.GroupPOCompletionStatusLis())
        {
            OrderCompletionStatusList.Add(g);
        }
        if (OrderCompletionStatusList.Count > 0)
            if (OrderIncompletionStatusList.Count == 0)
                Status = DocumentStatus.Sent;
            else
                Status = DocumentStatus.InProgress;
    }

    public override async Task<Exception?> OnCommandActivated(string? commandParam)
    {
        try
        {
            switch (commandParam)
            {
                case "CommandCreateASN":
                    ASNCollection.Add(await CreateASN());
                    SelectedASNViewModel = ASNCollection[^1];
                    break;

                case "CommandCreateInvoice":
                    if(SelectedASNViewModel is not null)
                        await SelectedASNViewModel.OnCommandActivated("CommandCreateInvoice");
                    break;

                    case "CommandCreateMultipleInvoice":
                    if (SelectedASNViewModel is not null)
                        await SelectedASNViewModel.OnCommandActivated("CommandCreateMultipleInvoice");
                    break;

                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
            return ex;
        }

        return null;
    }
    private async Task<ASNViewModel> CreateASN()
    {
        var s = await AddShipment(true, null);
        return s;
    }




    public string CheckId(DocumentType dt) => dt switch
    {
        DocumentType.PO850 => PoId,
        DocumentType.ASN856 => throw new NotImplementedException(),
        DocumentType.IN810 => throw new NotImplementedException(),
        DocumentType.BOL => throw new NotImplementedException(),
        _ => StringId,
    };   
}