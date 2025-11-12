namespace Juniper.Core.ViewModels;
public class ASNViewModel : BaseHasCanSendViewModel, IHaveIncrementals
{
    [JsonIgnore]
    public PurchaseOrderViewModel povm { get; set; }
    [JsonIgnore]
    public ShipmentsTable? DBTable { get; set; }

    #region props
    [JsonIgnore]
    public string PrintDirectory => Path.Combine(MainViewModel.Current.SettingsViewModel.SavedDataFilePath, "PDF", ShipmentHeader.ShipmentIdentification);
    [JsonIgnore]
    public InternalASNSettings InternalASNSettings { get; set; }

    public ObservableCollection<POOrderLineModel> POOrderLines { get; set; } = new ObservableCollection<POOrderLineModel>();

    private double pOOrderLinesmaxQty = 0;
    public double POOrderLinesMaxQty
    {
        get => pOOrderLinesmaxQty;
        set
        {
            if (pOOrderLinesmaxQty != value)
            {
                SetProperty(ref pOOrderLinesmaxQty, value);
            }
        }
    }
    private bool useMax;
    public bool UseMax
    {
        get => useMax;
        set => SetProperty(ref useMax, value);
    }

    public bool IsNordstrom
    {
        get
        {
            return TradingPartner.Name == TradingPartnerModel.TPDN_Nordstrom || TradingPartner.Name == TradingPartnerModel.TPDN_Nordstromcom; //ShipmentHeader.TradingPartnerId == MainViewModel.Current.SettingsViewModel.NordstromPartnerID;
        }
    }
    public bool IsNordstromCAN
    {
        get
        {
            return TradingPartner.Name == TradingPartnerModel.TPDN_NordstromCAN;
        }
    }
    public bool IsSaks
    {
        get
        {
            return TradingPartner.Name == TradingPartnerModel.TPDN_Sacks || TradingPartner.Name == TradingPartnerModel.TPDN_Sackscom;
        }
    }

    public bool IsBloomingdales
    {
        get
        {
            return TradingPartner.Name == TradingPartnerModel.TPDN_Blommies;
        }
    }
    public bool IsBloomingdalesOutlet
    {
        get
        {
            return TradingPartner.Name == TradingPartnerModel.TPDN_BlommiesOutlet;
        }
    }
    #endregion

    #region shipment props
    /// <summary>
    /// shipping
    /// </summary>
    public BaseShipmentHeaderModel ShipmentHeader { get; set; } = new BaseShipmentHeaderModel();
    private string shipmentHeaderJson;
    [JsonIgnore]
    public string ShipmentHeaderJson
    {
        get => shipmentHeaderJson;
        set => SetProperty(ref shipmentHeaderJson, value);
    }
    public ObservableCollection<BaseCarrierInformationModel> CarrierInformationCollection { get; set; } = new ObservableCollection<BaseCarrierInformationModel>();
    public BaseCarrierInformationModel CarrierInformation => CarrierInformationCollection[0];
    [JsonIgnore]
    public ObservableCollection<BaseCarrierInformationModel> SettingsCarrierInformationCollection
    {
        get
        {
            return MainViewModel.Current.SettingsViewModel.BaseCarrierInformation;
        }
    }
    private BaseCarrierInformationModel selectedSettingsCarrierInformationCollection;
    public BaseCarrierInformationModel SelectedSettingsCarrierInformationCollection
    {
        get => selectedSettingsCarrierInformationCollection;
        set
        {
            if (value is not null)
            {
                if (selectedSettingsCarrierInformationCollection != value)
                {
                    if (!CarrierInformationCollection.Contains(value) && CarrierInformationCollection.Count > 0)
                    {
                        CarrierInformationCollection.Clear();
                        CarrierInformationCollection.Add(value);
                    }
                    SetProperty(ref selectedSettingsCarrierInformationCollection, value);
                }

                if (ShipmentHeader.CarrierProNumber is null || Status != DocumentStatus.Sent)
                    ShipmentHeader.CarrierProNumber = value.CarrierAlphaCode;
            }
        }
    }

    public ObservableCollection<BaseQuantityAndWeightModel> QuantityAndWeightCollection { get; set; } = new ObservableCollection<BaseQuantityAndWeightModel>();
    public BaseQuantityAndWeightModel QuantityAndWeight => QuantityAndWeightCollection[0];

    public ObservableCollection<BaseAddressModel> Address { get; set; } = new ObservableCollection<BaseAddressModel>();
    [JsonIgnore]
    public BaseAddressModel SFAddress => Address[0];
    [NotNullOrEmptyCollection(ErrorMessage = "Theres No Ship To Addresses")]
    public ObservableCollection<BaseAddressModel> STAddresses { get; set; } = new ObservableCollection<BaseAddressModel>();

    [NotNullOrEmptyCollection(ErrorMessage = "Theres No Products Listed")]
    public ObservableCollection<OrderPackItemModel> OrderLevel { get; set; } = new ObservableCollection<OrderPackItemModel>();
    #endregion

    #region inv props
    public ObservableCollection<InvoiceViewModel> InvoiceViewModels { get; } = new ObservableCollection<InvoiceViewModel>();
    public ObservableCollection<GroupInfoList> DoneInvoicesData { get; } = new ObservableCollection<GroupInfoList>();
    public ObservableCollection<InvoiceViewModel> PreviewInvoicesData { get; } = new ObservableCollection<InvoiceViewModel>();
    #endregion

    #region init
    //public static Dictionary<string, string> Duplicatessccpoasnid = new Dictionary<string, string>();
    public ASNViewModel() : base()
    {
        CanAddRemoveables = true;

        InvoiceViewModels.CollectionChanged += MainViewModel.Current.ShipmentOrInvoiceOrPO_CollectionChanged;
        OrderLevel.CollectionChanged += OrderLevel_CollectionChanged;
    }
    public async Task Init(bool loadLocal)
    {
        //var fpath = Path.Combine(SaveSettingsDirectory, SaveSettingsFileName);
        //IFieldsNSettings = File.Exists(fpath) ? await FilesService.ReadToValueAsync<InternalASNSettings>(fpath) ?? new InternalASNSettings() : new InternalASNSettings();
        SetTradingPartnerID();
        AddOrderItemLines();
        if (loadLocal)
            LoadLocalSaved();
    }
    public void AddOrderItemLines()
    {
        foreach (var sl in povm.POOrderStyleLines)
        {
            var li = sl.LineItem;
            var polm = new POOrderLineModel() { LineItem = li };

            if (POOrderLines.FirstOrDefault(poli =>
                    poli.LineItem.OrderLine?.VendorPartNumber == li.OrderLine?.VendorPartNumber &&
                    poli.LineItem.OrderLine?.ProductColorDescription == li.OrderLine?.ProductColorDescription) is { } i)
            {
                i.SubLineItems.Add(polm);
            }
            else
            {
                polm.AddSelf();
                POOrderLines.Add(polm);
            }



            if (polm.LineItem.QuantitiesSchedulesLocations is not null)
                foreach (var location in polm.LineItem.QuantitiesSchedulesLocations)
                {
                    if (location.LocationQuantity is not null)
                        foreach (var l in location.LocationQuantity)
                        {
                            var opim = OrderLevel.FirstOrDefault(o => o.Address.AddressLocationNumber == l.Location);
                            if (opim is not null)
                            {
                                foreach (var pack in opim.PackLevelList)
                                {
                                    if (pack.ItemLevel.ShipmentLines.Any(sl => sl.ConsumerPackageCode == polm.LineItem?.OrderLine?.ConsumerPackageCode))
                                    {
                                        polm.WasSent = polm.IsSelected = true;
                                    }
                                }
                            }
                        }
                }

            if (li.Address is not null)
            {
                foreach (var addy in li.Address)
                {
                    if (addy.AddressTypeCode is null || addy.AddressName is null) continue;
                    if (STAddresses.Any(a => a.AddressLocationNumber == addy.AddressName)) continue;

                    var bams = new BaseAddressModel();
                    bams.SIAddressTypeCode = bams.AddressTypeCode.GetToupleByItem(addy.AddressTypeCode) ?? 41;
                    bams.SILocationCodeQualifier = bams.LocationCodeQualifier.GetToupleByItem("92") ?? 9;
                    bams.AddressLocationNumber = addy.AddressName;
                    STAddresses.Add(bams);
                }
            }
        }

        SortAndAddAddresses(true);
    }
    internal void LoadLocalSaved(IEnumerable<InvoicesTable> invs)
    {
        foreach (var inv in invs)
        {
            if (InvoiceViewModels.Any(i => i.InvoiceHeader.InvoiceNumber == inv.INVNumber))
                continue;

            InvoicesViewModel.Current.ReadInvoices.Add(new ReadInvoicesFile()
            {
                Filename = inv.S3KeyName
            });

            var ivm = new InvoiceViewModel()
            {
                asnvm = this,
                InvoiceHeader = new InvoiceHeaderModel(),
                FromDynamo = true,
                DBTable = inv,
                Status = DocumentStatus.Sent,
                InternalINVSettings = inv.Settings ?? new InternalINVSettings(),
            };
            ivm.InvoiceHeader.InvoiceNumber = inv.INVNumber;
            ivm.InvoiceHeader.BillOfLadingNumber = inv.BOLNumber;
            ivm.InvoiceHeader.InvoiceDate = DateTimeOffset.Parse(inv.INVDate);
            InvoiceViewModels.Add(ivm);
        }
    }
    public void LoadLocalSaved()
    {
        if (ShipmentHeader.ShipmentIdentification.IsNullEmptyOrWhiteSpace())
            return;

        // MainViewModel.Current.DisplayInfobarMessage("Loading...", $"PO# {PoId} ASN# {StringId}", InfoSeverity.Informational);

        foreach (var i in (from i in InvoicesViewModel.Current.ReadInvoices
                           where i.Invoice != null &&
                               i.Invoice.Header?.InvoiceHeader?.BillOfLadingNumber == ShipmentHeader.BillOfLadingNumber &&
                               LineItemsAndShipToMatch(i.Invoice) &&
                               !InvoiceViewModels.Any(a => a.InvoiceHeader.InvoiceNumber == i.Invoice.Header?.InvoiceHeader?.InvoiceNumber)
                           select i))
        {
            try
            {
                var ivm = new InvoiceViewModel() { asnvm = this };
                ivm.SetFromInvoice(i.Invoice);
                InvoiceViewModels.Add(ivm);
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, "LoadLocalSaved InvoicesViewModel.Invoices query");
            }
        }

        DoneInvoicesData.AddAll(InvoiceViewModels.GroupLines());


        //var saveFilePath = Path.Combine(FilesService.SavedInvoiceFolder, povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber ?? "unknown", ShipmentHeader.ShipmentIdentification);
        //foreach (var invm in await FilesService.ReadValuesAsync<InvoiceViewModel>(saveFilePath, (from i in InvoiceViewModels select i.StringId).ToArray()))
        //{
        //    invm.asnvm = this;
        //    await invm.Init();
        //    invm.Status = DocumentStatus.Saved;
        //    InvoiceViewModels.Add(invm);
        //}

        InvoiceViewModels.OrderByIncrementals();

        //check fore dupes
        for (int i = 0; i < InvoiceViewModels.Count; i++)
        {
            var iivm = InvoiceViewModels[i];
            for (int j = 0; j < InvoiceViewModels.Count; j++)
            {
                if (i != j)
                {
                    var jivm = InvoiceViewModels[j];
                    var sameAddys = iivm.InvoiceHeader.Address.Count == jivm.InvoiceHeader.Address.Count;
                    if (sameAddys)
                    {
                        for (int k = 0; k < iivm.InvoiceHeader.Address.Count; k++)
                        {
                            var iaddy = iivm.InvoiceHeader.Address[k];
                            var jaddy = jivm.InvoiceHeader.Address[k];

                            if (iaddy.AddressLocationNumber != jaddy.AddressLocationNumber)
                            { sameAddys = false; break; }
                        }
                    }

                    if (sameAddys)
                    {
                        var sameInvLines = iivm.InvoiceLines.Count == jivm.InvoiceLines.Count;
                        if (sameInvLines)
                        {
                            for (int k = 0; k < iivm.InvoiceLines.Count; k++)
                            {
                                var iil = iivm.InvoiceLines[k];
                                var jil = jivm.InvoiceLines[k];

                                if (iil.InvoiceLine.ConsumerPackageCode != jil.InvoiceLine.ConsumerPackageCode)
                                { sameInvLines = false; break; }
                                else
                                {
                                    if (iil.InvoiceLine.InvoiceQty != jil.InvoiceLine.InvoiceQty)
                                    { sameInvLines = false; break; }
                                }
                            }
                        }

                        if (sameInvLines)
                        {
                            iivm.IsDupe = jivm.IsDupe = true;

                            //var iivmPath = Path.Combine(MainViewModel.Current.SettingsViewModel.SavedDataFilePath, iivm.SendFileSaveDirectory, iivm.SaveFileName);
                            //if (!File.Exists(iivmPath))
                            //    iivmPath = Path.Combine(MainViewModel.Current.SettingsViewModel.SentInvoicesFilePath, iivm.SaveFileName);

                            //if (File.Exists(iivmPath))
                            //    iivm.FileCreationTime = File.GetCreationTime(iivmPath);


                            //var jivmPath = Path.Combine(MainViewModel.Current.SettingsViewModel.SavedDataFilePath, jivm.SendFileSaveDirectory, jivm.SaveFileName);
                            //if (!File.Exists(jivmPath))
                            //    jivmPath = Path.Combine(MainViewModel.Current.SettingsViewModel.SentInvoicesFilePath, jivm.SaveFileName);

                            //if (File.Exists(jivmPath))
                            //    jivm.FileCreationTime = File.GetCreationTime(jivmPath);

                            jivm.DuplicateOf += $"{iivm.StringId} ";
                        }
                    }
                }
            }
        }
        //foreach (var i in InvoiceViewModels)
        //{
        //    if(i.IsDupe)
        //        Debug.WriteLine($"INV Dupe po - {PoId}, asn - {StringId}, inv - {i.StringId}, dupe of - {i.DuplicateOf}");
        //}

        if (InvoiceViewModels.Count > 0)
            povm.SelectedInvoiceViewModel = InvoiceViewModels[^1];
    }
    public void SetTradingPartnerID()
    {
        if (ShipmentHeader.TradingPartnerId is null)
            ShipmentHeader.TradingPartnerId = TradingPartner.TradingPartnerId;
        //        povm.POData.Order?.Header?.OrderHeader?.TradingPartnerId is string s ?
        //        s == MainViewModel.Current.SettingsViewModel.SacksPartnerID ? SettingsViewModel.Default_SaksASNTradingPartnerId2 :
        //s : "0";
    }
    public async Task SetFromShipment(Shipment shipment)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8604 // Possible null reference argument.

        ShipmentHeader.TradingPartnerId = shipment.Header.ShipmentHeader.TradingPartnerId;
        ShipmentHeader.ShipmentIdentification = shipment.Header.ShipmentHeader.ShipmentIdentification;
        ShipmentHeader.BillOfLadingNumber = shipment.Header.ShipmentHeader.BillOfLadingNumber;
        ShipmentHeader.CarrierProNumber = shipment.Header.ShipmentHeader.CarrierProNumber;

        ShipmentHeader.ShipDate = DateTimeOffset.Parse(shipment.Header.ShipmentHeader.ShipDate);
        ShipmentHeader.ShipNoticeDate = DateTimeOffset.Parse(shipment.Header.ShipmentHeader.ShipNoticeDate);
        if (shipment.Header.ShipmentHeader.ShipNoticeTime is not null)
            ShipmentHeader.ShipNoticeTime = TimeSpan.Parse(shipment.Header.ShipmentHeader.ShipNoticeTime);

        ShipmentHeader.TsetPurposeCode = shipment.Header.ShipmentHeader.TsetPurposeCode;
        ShipmentHeader.ASNStructureCode = shipment.Header.ShipmentHeader.AsnStructureCode;

        foreach (var item in shipment.Header.CarrierInformation)
        {
            var bci = new BaseCarrierInformationModel(MainViewModel.Current.FieldsService.ShipmentsFields)
            {
                CarrierAlphaCode = item.CarrierAlphaCode,
                CarrierRouting = item.CarrierRouting,
                CarrierTransMethodCode = item.CarrierTransMethodCode
            };
            CarrierInformationCollection.Add(bci);
        }

        foreach (var item in shipment.Header.QuantityAndWeight)
        {
            var bci = new BaseQuantityAndWeightModel
            {
                LadingQuantity = item.LadingQuantity ?? 1,
                Weight = item.Weight ?? 3.0,
                PackingMedium = item.PackingMedium,
                PackingMaterial = item.PackingMaterial,
                WeightQualifier = item.WeightQualifier,
                WeightUOM = item.WeightUom
            };
            QuantityAndWeightCollection.Add(bci);
        }

        foreach (var item in shipment.Header.Address)
        {
            var b = new BaseAddressModel()
            {
                AddressLocationNumber = item.AddressLocationNumber,
                AddressModel = new AddressModel()
                {
                    Address = item.Address1,
                    Address2 = item.Address2,
                    City = item.City,
                    State = item.State,
                    Zip = item.PostalCode,
                    Name = item.AddressName,
                },
            };
            b.SIAddressTypeCode = b.AddressTypeCode.GetToupleByItem(item.AddressTypeCode) ?? 41;
            b.SILocationCodeQualifier = b.LocationCodeQualifier.GetToupleByItem(item.LocationCodeQualifier) ?? 9;
            if (item.AddressTypeCode == "SF")
            {
                Address.Add(b);
            }
            else
            {
                STAddresses.Add(b);
            }
        }
        //var lines = await MainViewModel.Current.SettingsViewModel.GetUPCLines();
        //List<string> debuglist = new();
        foreach (var item in shipment.OrderLevel)
        {
            var o = new OrderPackItemModel()
            {
                PurchaseOrderNumber = item.OrderHeader.PurchaseOrderNumber,
                Department = item.OrderHeader.Department ?? povm.POData.Order?.Header?.OrderHeader?.Department,
            };
            foreach (var qw in item.PackLevel)
            {
                #region debug 
                if (ShipmentHeader.ShipNoticeDate > new DateTimeOffset(new DateTime(2022, 4, 20)))
                {
                    //if (Duplicatessccpoasnid.ContainsKey(qw.Pack.ShippingSerialId))
                    //{
                    //    Debug.WriteLine(Duplicatessccpoasnid[qw.Pack.ShippingSerialId]);
                    //    Debug.WriteLine($"2,{qw.Pack.ShippingSerialId},{item.OrderHeader.PurchaseOrderNumber},{ShipmentHeader.ShipmentIdentification}");
                    //}
                    //else
                    //{
                    //    Duplicatessccpoasnid.Add(qw.Pack.ShippingSerialId, $"1,{qw.Pack.ShippingSerialId},{item.OrderHeader.PurchaseOrderNumber},{ShipmentHeader.ShipmentIdentification}");
                    //}
                    //Debug.WriteLine($"{qw.Pack.ShippingSerialId},{item.OrderHeader.PurchaseOrderNumber},{ShipmentHeader.ShipmentIdentification},{ShipmentHeader.ShipNoticeDate}");
                }
                //                if (qw.Pack.ShippingSerialId.IsOneOf(
                //"00081006543999999700",
                //"00081006543999999687",
                //"00081006543999999717",
                //"00081006543999999694",
                //"00081006543999999731",
                //"00081006543999999632",
                //"00081006543999999748",
                //"00081006543999999663",
                //"00081006543999999649",
                //"00081006543999999724",
                //"00081006543999999779",
                //"00081006543999999670",
                //"00081006543999999656",
                //"00081006543999999762",
                //"00081006543999999755",
                //"00081006543999999212",
                //"00081006543999999175",
                //"00081006543999999229",
                //"00081006543999999182",
                //"00081006543999999205",
                //"00081006543999999199",
                //"00081006543999999168"
                //                    ))
                //                {
                //                    Debug.WriteLine($"NOF sscc - {qw.Pack.ShippingSerialId}, po - {item.OrderHeader.PurchaseOrderNumber}, asn - {ShipmentHeader.ShipmentIdentification}");
                //                }
                //                if (qw.Pack.ShippingSerialId.IsOneOf(
                //"00081006543999999588",
                //"00081006543999999618",
                //"00081006543999999472",
                //"00081006543999999595",
                //"00081006543999999571",
                //"00081006543999999465",
                //"00081006543999999526",
                //"00081006543999999557",
                //"00081006543999999502",
                //"00081006543999999519",
                //"00081006543999999601",
                //"00081006543999999533",
                //"00081006543999999489",
                //"00081006543999999625",
                //"00081006543999999540",
                //"00081006543999999496",
                //"00081006543999999564",
                //"00081006543999999458",
                //"00081006543999999441",
                //"00081006543999999434",
                //"00081006543999998697",
                //"00081006543999998710",
                //"00081006543999998765",
                //"00081006543999998734",
                //"00081006543999998772",
                //"00081006543999998680",
                //"00081006543999998758",
                //"00081006543999998741",
                //"00081006543999998703",
                //"00081006543999998833",
                //"00081006543999998888",
                //"00081006543999998673",
                //"00081006543999998826",
                //"00081006543999998840",
                //"00081006543999998925",
                //"00081006543999998819",
                //"00081006543999998864",
                //"00081006543999998949",
                //"00081006543999998802",
                //"00081006543999998857",
                //"00081006543999998918",
                //"00081006543999998796",
                //"00081006543999998895",
                //"00081006543999998932",
                //"00081006543999998789",
                //"00081006543999998871",
                //"00081006543999998901",
                //"00081006543999998727",
                //"00081006543999999250",
                //"00081006543999999342",
                //"00081006543999999243",
                //"00081006543999999298",
                //"00081006543999999366",
                //"00081006543999999267",
                //"00081006543999999311",
                //"00081006543999999359",
                //"00081006543999999427",
                //"00081006543999999281",
                //"00081006543999999328",
                //"00081006543999999380",
                //"00081006543999999274",
                //"00081006543999999236",
                //"00081006543999999397",
                //"00081006543999999403",
                //"00081006543999999304",
                //"00081006543999999373",
                //"00081006543999999410",
                //"00081006543999999335"
                //                    ))
                //                {
                //                    Debug.WriteLine($"Pre sscc - {qw.Pack.ShippingSerialId}, po - {item.OrderHeader.PurchaseOrderNumber}, asn - {ShipmentHeader.ShipmentIdentification}");
                //                }
                //                if (qw.Pack.ShippingSerialId.IsOneOf(
                //"00081006543999999588",
                //"00081006543999999618",
                //"00081006543999999472",
                //"00081006543999999595",
                //"00081006543999999571",
                //"00081006543999999465",
                //"00081006543999999526",
                //"00081006543999999557",
                //"00081006543999999502",
                //"00081006543999999519",
                //"00081006543999999601",
                //"00081006543999999533",
                //"00081006543999999489",
                //"00081006543999999625",
                //"00081006543999999540",
                //"00081006543999999496",
                //"00081006543999999564",
                //"00081006543999999458",
                //"00081006543999999441",
                //"00081006543999999434",
                //"00081006543999999700",
                //"00081006543999999687",
                //"00081006543999999717",
                //"00081006543999999694",
                //"00081006543999999731",
                //"00081006543999999632",
                //"00081006543999999748",
                //"00081006543999999663",
                //"00081006543999999649",
                //"00081006543999999724",
                //"00081006543999999779",
                //"00081006543999999670",
                //"00081006543999999656",
                //"00081006543999999762",
                //"00081006543999999755"
                //                    ))
                //                {
                //                    Debug.WriteLine($"sscc - {qw.Pack.ShippingSerialId}, po - {item.OrderHeader.PurchaseOrderNumber}, asn - {ShipmentHeader.ShipmentIdentification}");
                //                    foreach (var a in item.Address)
                //                    {
                //                        Debug.WriteLine($"store - {a.AddressLocationNumber}");
                //                    }
                //                }
                #endregion
                //var debugupcs = $"";
                var p = new PackItemModel();
                p.SIPackLevelType = p.PackLevelType.GetToupleByItem(qw.Pack.PackLevelType) ?? 0;
                p.ShippingSerialID = qw.Pack.ShippingSerialId;
                foreach (var q in qw.ItemLevel)
                {
                    var sl = new ShipmentLine()
                    {
                        ConsumerPackageCode = q.ShipmentLine.ConsumerPackageCode,
                        ShipQty = q.ShipmentLine.ShipQty ?? 0,
                        ShipQtyUOM = q.ShipmentLine.ShipQtyUom
                    };
                    p.ItemLevel.ShipmentLines.Add(sl);

                    //debugupcs += $"{q.ShipmentLine.ConsumerPackageCode} ";

                    //var li = lines.FirstOrDefault(l => l.GTIN == sl.ConsumerPackageCode);
                    //if (li is not null)
                    //{
                    //    debugupcs += $",size {li.SizeDescriptionNumVal} ";
                    //    debugupcs += $",product {li.Product} ";
                    //    debugupcs += $",color {li.ColorDescripton} ";
                    //    debugupcs += $",ship qty {sl.ShipQty} ";
                    //}
                }
                o.PackLevelList.Add(p);

                //if (Duplicatessccpoasnid.ContainsKey(qw.Pack.ShippingSerialId))
                //{
                //    Debug.WriteLine("1 " + Duplicatessccpoasnid[qw.Pack.ShippingSerialId]);
                //    Debug.WriteLine($" 2 sscc - {qw.Pack.ShippingSerialId}, po - {item.OrderHeader.PurchaseOrderNumber}, asn - {ShipmentHeader.ShipmentIdentification}, upcs - {debugupcs}");
                //}
                //else
                //{
                //    Duplicatessccpoasnid.Add(qw.Pack.ShippingSerialId, $"sscc - {qw.Pack.ShippingSerialId}, po - {item.OrderHeader.PurchaseOrderNumber}, asn - {ShipmentHeader.ShipmentIdentification}, upcs - {debugupcs}");
                //}

                //debuglist.Add($"sscc - {qw.Pack.ShippingSerialId}, po - {item.OrderHeader.PurchaseOrderNumber}, asn - {ShipmentHeader.ShipmentIdentification}, upcs - {debugupcs}");
                //Debug.WriteLine($"sscc - {qw.Pack.ShippingSerialId}, po - {item.OrderHeader.PurchaseOrderNumber}, asn - {ShipmentHeader.ShipmentIdentification}, upcs - {debugupcs}");
            }
            foreach (var qaw in item.QuantityAndWeight)
            {
                o.QuantityAndWeight = new BaseQuantityAndWeightModel
                {
                    LadingQuantity = qaw.LadingQuantity ?? 1,
                    Weight = qaw.Weight ?? 3.0,
                    PackingMedium = qaw.PackingMedium,
                    PackingMaterial = qaw.PackingMaterial,
                    WeightQualifier = qaw.WeightQualifier,
                    WeightUOM = qaw.WeightUom
                };
                o.QuantityAndWeightCollection.Add(o.QuantityAndWeight);
            }
            foreach (var a in item.Address)
            {
                if (a.AddressLocationNumber is string llocation)
                {
                    string? dclocnumb;
                    string? dc;
                    var addyModel = TradingPartner.GetAddressModelFor(llocation, false); //await ShipmentsViewModel.GetAddressModelAsync(ShipmentHeader.TradingPartnerId, llocation, IsNordstrom);
                    if (addyModel is not null)
                    {
                        dclocnumb = addyModel.DCAddressLocationNumber;
                        dc = addyModel.DC;
                    }
                    else
                    {
                        var staddy = STAddresses[0];
                        dclocnumb = staddy.AddressLocationNumber;
                        dc = staddy.AddressLocationNumber;

                    }

                    o.Address = new BaseAddressModel()
                    {
                        AddressLocationNumber = a.AddressLocationNumber,
                        DC = dc,
                        DCAddressLocationNumber = dclocnumb
                    };
                    o.Address.SIAddressTypeCode = o.Address.AddressTypeCode.GetToupleByItem(a.AddressTypeCode) ?? 41;
                    o.Address.SILocationCodeQualifier = o.Address.LocationCodeQualifier.GetToupleByItem(a.LocationCodeQualifier) ?? 9;
                    o.AddressCollection.Add(o.Address);
                }
            }

            //string uppppps = "";
            //foreach (var dl in debuglist)
            //{
            //    uppppps += $"{dl} ";
            //}
            //Debug.WriteLine($"{debugparams},DC {o.Address.AddressLocationNumber} - {o.Address.DC} - {o.Address.DCAddressLocationNumber},{uppppps}");

            OrderLevel.Add(o);
        }
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        Status = DocumentStatus.Sent;
    }
    public async Task SetupNewHeader()
    {
        SetTradingPartnerID();

        if (InternalASNSettings == null)
            InternalASNSettings = new();

        MainViewModel.Current.SettingsViewModel.LastUsedASNNumber =
            SettingsViewModel.GetNextIdNumber(MainViewModel.Current.ShipmentsViewModel.ASNShipments.ToList<IHaveIncrementals>(), MainViewModel.Current.SettingsViewModel.LastUsedASNNumber, false);
        ShipmentHeader.ShipmentIdentification = $"{MainViewModel.Current.SettingsViewModel.LastUsedASNNumber}"; //povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber + "-" + (povm.ASNCollection.Count + 1);

        MainViewModel.Current.SettingsViewModel.LastUsedASNBOLNumber =
            SettingsViewModel.GetNextIdNumber(MainViewModel.Current.ShipmentsViewModel.ASNShipments.ToList<IHaveIncrementals>(), MainViewModel.Current.SettingsViewModel.LastUsedASNBOLNumber, true);
        ShipmentHeader.BillOfLadingNumber = $"{MainViewModel.Current.SettingsViewModel.LastUsedASNBOLNumber}";

        var bcim = MainViewModel.Current.SettingsViewModel.BaseCarrierInformation.FirstOrDefault(c => c.Title == TradingPartner.DefaultCarrier) ?? MainViewModel.Current.SettingsViewModel.BaseCarrierInformation[0];
        SelectedSettingsCarrierInformationCollection = bcim;
        CarrierInformationCollection.Add(bcim);

        var bqawm = MainViewModel.Current.SettingsViewModel.QuantityAndWeightModel;
        QuantityAndWeightCollection.Add(bqawm);

        var bam = new BaseAddressModel();
        bam.SIAddressTypeCode = bam.AddressTypeCode.GetToupleByItem("SF") ?? 39;
        //bam.AddressName = await MainViewModel.Current.SettingsViewModel.GetSavedAsync(SettingStorageKeys.SFAddressName);//await SettingsService.GetStringValueAsync(nameof(SettingsViewModel.SFAddressName)) ?? "Juniper 08 LLC";
        bam.AddressModel = MainViewModel.Current.SettingsViewModel.ShipFromSettings;
        bam.AddressModel.Name = await MainViewModel.Current.SettingsViewModel.GetSavedAsync(SettingStorageKeys.SFAddressName);
        Address.Add(bam);

        if (!IsBloomingdales && !IsBloomingdalesOutlet &&
            povm.POData.Order?.Header?.Address is List<SPSCommerceSDK.Models.Orders.HeaderAddress> st)
        {
            foreach (var a in st)
            {
                if (a.AddressTypeCode == "TO")
                    continue;

                var staddy = new BaseAddressModel();
                staddy.SIAddressTypeCode = staddy.AddressTypeCode.GetToupleByItem(a.AddressTypeCode ?? "ST") ?? 41;
                staddy.SILocationCodeQualifier = staddy.LocationCodeQualifier.GetToupleByItem(a.LocationCodeQualifier ?? "92") ?? 9;
                staddy.AddressLocationNumber = a.AddressLocationNumber ?? "";//ShipmentHeader.TradingPartnerId == MainViewModel.Current.SettingsViewModel.NordstromPartnerID ? "0005179153" : "";
                STAddresses.Add(staddy);
            }
        }
    }
    private bool LineItemsAndShipToMatch(SPSCommerceSDK.Models.Invoices.Invoice i)
    {
        if (i.Header?.Address is null || i.LineItem is null)
            return false;

        var matches = false;
        foreach (var address in i.Header.Address)
        {
            if (STAddresses.Any(a => a.AddressLocationNumber == address.AddressLocationNumber))
            {
                matches = true;
                break;
            }
        }
        if (!matches)
            return false;

        foreach (var address in i.Header.Address)
        {
            foreach (var item in OrderLevel)
            {
                if (item.Address.AddressLocationNumber == address.AddressLocationNumber)
                {
                    foreach (var p in item.PackLevelList)
                    {
                        foreach (var li in i.LineItem)
                        {
                            if (p.ItemLevel.ShipmentLines.Any(sl => sl.ConsumerPackageCode == li.InvoiceLine?.ConsumerPackageCode))
                                return true;
                        }
                    }
                }
            }
        }
        return false;
    }
    #endregion

    #region OnCommandActivated
    public override async Task<Exception?> OnCommandActivated(string? commandParam)
    {
        IsLoading = true;
        try
        {
            switch (commandParam)
            {
                case "CommandExportPackingList":
                    await MainViewModel.Current.ExcelUtil.ExportPackingList(new List<Tuple<string, string, List<OrderPackItemModel>>>() { new Tuple<string, string, List<OrderPackItemModel>>(
                            ShipmentHeader.ShipmentIdentification,
                            ShipmentHeader.BillOfLadingNumber,
                            new List<OrderPackItemModel>(OrderLevel.OrderBy(o => o.Address.DCAddressLocationNumber)))},
                        povm.DisplayName,
                        povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber,
                        povm.POData.Order?.Header?.Dates?.FirstOrDefault(d => d.DateTimeQualifier == "001")?.Date,
                        ShipmentHeader.ShipDate.ToString("MM-dd-yyyy"),
                        povm.POOrderStyleLines.ToList());
                    break;
                case "CommandShippingLabels":
                    var inputFilePaths = await GenerateShippingLabels(PrintDirectory);
                    if (inputFilePaths != null)
                    {
                        var l = await FilesService.CombinePDF(PrintDirectory, ASNId, inputFilePaths);
                        await FilesService.OpenPrindPrivewFor(l.Item2, PrintDirectory, l.Item1);
                    }
                    break;

                case "CommandPreviewShippingLabels":
                    await PreviewShippingLabels();
                    break;

                case "CommandApply":
                    await AppllySelectedStyles();
                    break;

                case "CommandCreateInvoice":
                    await CreateNewInvoices(false);
                    break;

                case "CommandCreateMultipleInvoice":
                    await CreateNewInvoices(false, OrderLevel.ToArray());
                    break;

                case "CommandCreateMultipleInvoicePreview":
                    await CreateNewInvoices(true, OrderLevel.ToArray());
                    break;

                case "CommandAddToOrderLevelList":
                    await AddSelectedStyleLines(true);
                    SortAndAddAddresses(false);
                    break;

                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            IsLoading = false;
            MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
            return ex;
        }
        IsLoading = false;
        return null;
    }
    private async Task AppllySelectedStyles()
    {
        //00 0 81006543 00181649 0
        MainViewModel.Current.ShipmentsViewModel.LastSerialShippingId = null;
        OrderLevel.Clear();

        await AddSelectedStyleLines(false);

        if (UseMax && POOrderLinesMaxQty > 0)
        {
            for (int h = OrderLevel.Count - 1; h >= 0; h--)
            {
                var opim = OrderLevel[h];
                var spmntLines = opim.PackLevelList[0].ItemLevel.ShipmentLines.OrderByDescending(o => o.ShipQty).ToList();
                var count = spmntLines.Count;
                for (int i = 0; i < count; i++)
                {
                    var sl = spmntLines[i];
                    var shipqty = (int)sl.ShipQty;
                    while (shipqty > POOrderLinesMaxQty)
                    {
                        shipqty--;
                    }
                    if ((int)sl.ShipQty > shipqty)
                    {
                        var left = (int)sl.ShipQty - shipqty;
                        sl.ShipQty = shipqty;
                        spmntLines.Insert(i + 1,
                            ShipmentsViewModel.GetNewShipmentLine(sl.ConsumerPackageCode, left, sl.ShipQtyUOM, sl.VendorPartNumber, false));
                        count++;
                    }
                }
                spmntLines = spmntLines.OrderBy(o => o.ShipQty).ToList();
                for (int i = 0; i < spmntLines.Count; i++)
                {
                    var line = spmntLines[i];
                    int serialReference = MainViewModel.Current.ShipmentsViewModel.GetLastSerialReference(this);
                    PackItemModel np = ShipmentsViewModel.GetNewPack(ref serialReference);
                    opim.PackLevelList.Add(np);
                    np.ItemLevel.ShipmentLines.Add(
                        ShipmentsViewModel.GetNewShipmentLine(line.ConsumerPackageCode, line.ShipQty, line.ShipQtyUOM, line.VendorPartNumber, false));

                    int total = (int)line.ShipQty;
                    if (i <= spmntLines.Count - 2 && total <= POOrderLinesMaxQty)
                    {
                        for (int j = i + 1; j < spmntLines.Count; j++)
                        {
                            var jline = spmntLines[j];
                            if (total + (int)jline.ShipQty <= POOrderLinesMaxQty)
                            {
                                total += (int)jline.ShipQty;
                                np.ItemLevel.ShipmentLines.Add(
                                    ShipmentsViewModel.GetNewShipmentLine(jline.ConsumerPackageCode, jline.ShipQty, jline.ShipQtyUOM, jline.VendorPartNumber, false));
                                i = j;
                            }
                        }
                    }
                }
                opim.PackLevelList.RemoveAt(0);
                var orderd2 = opim.PackLevelList.OrderByDescending(oo => oo.ItemLevel.ShipmentLines.Count).ThenBy(o => o.ItemLevel.ShipmentLines.Sum(s => Convert.ToInt64(s.ConsumerPackageCode))).ToList();
                opim.PackLevelList.Clear();
                foreach (var item in orderd2)
                {
                    opim.PackLevelList.Add(item);
                }
            }
        }



        if ((IsBloomingdales || IsBloomingdalesOutlet) && STAddresses.Count > 1)
        {
            OrderLevel.CollectionChanged -= OrderLevel_CollectionChanged;

            for (int i = STAddresses.Count - 1; i >= 1; i--)
            {
                var address = STAddresses[i];

                var asnvm = new ASNViewModel()
                {
                    povm = povm,
                    InternalASNSettings = new InternalASNSettings()
                };
                await asnvm.SetupNewHeader();


                foreach (var o in OrderLevel)
                {
                    if (o.Address.DC == address.DC)
                    {
                        asnvm.OrderLevel.Add(o);
                    }
                }
                foreach (var o in asnvm.OrderLevel)
                {
                    OrderLevel.Remove(o);
                }

                asnvm.STAddresses.Add(address);
                STAddresses.Remove(address);

                asnvm.AddOrderItemLines();

                povm.ASNCollection.Add(asnvm);
            }

           //5210 SortAndAddAddresses(false);

            OrderLevel.CollectionChanged += OrderLevel_CollectionChanged;
        }

        SortAndAddAddresses(true);
    }
    private async Task AddSelectedStyleLines(bool once)
    {
        var companyprefix = await MainViewModel.Current.SettingsViewModel.GetSavedAsync(SettingStorageKeys.Gs1CompanyPrefix);
        int serialReference = MainViewModel.Current.ShipmentsViewModel.GetLastSerialReference(this);

        foreach (var poLine in POOrderLines)
        {
            if (!poLine.IsSelected) continue;
            bool fresh = true;
            foreach (var line in poLine.SubLineItems)
            {
                if (line.LineItem.QuantitiesSchedulesLocations is not null)
                    foreach (var location in line.LineItem.QuantitiesSchedulesLocations)
                    {
                        if (location.LocationQuantity is not null)
                            foreach (var l in location.LocationQuantity)
                            {
                                var opim = once ? OrderLevel.Count == 0 || fresh ? null : OrderLevel[0] : OrderLevel.FirstOrDefault(o => o.Address.AddressLocationNumber == l.Location);
                                fresh = false;
                                if (opim is null)
                                {
                                    if (l.Location is null)
                                        throw new IndexOutOfRangeException("l.Location is null");

                                    var addyModel = TradingPartner.GetAddressModelFor(l.Location, false); //await ShipmentsViewModel.GetAddressModelAsync(ShipmentHeader.TradingPartnerId, llocation, true);
                                    if (addyModel is not null)
                                    {
                                        if ((IsBloomingdales || IsBloomingdalesOutlet && !STAddresses.Any(a => a.DC == addyModel.DC)) ||
                                            (!IsBloomingdales && !IsBloomingdalesOutlet && !STAddresses.Any(a => a.AddressLocationNumber == addyModel.DCAddressLocationNumber)))
                                        {
                                            AddSTAddress(addyModel.DCAddressLocationNumber);
                                        }

                                        opim = new OrderPackItemModel()
                                        {
                                            PurchaseOrderNumber = povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber,
                                            Department = povm.POData.Order?.Header?.OrderHeader?.Department,
                                            QuantityAndWeight = new BaseQuantityAndWeightModel()
                                            {
                                                LadingQuantity = 1,
                                                Weight = QuantityAndWeight.Weight,
                                                PackingMaterial = QuantityAndWeight.PackingMaterial,
                                                PackingMedium = QuantityAndWeight.PackingMedium,
                                                WeightQualifier = QuantityAndWeight.WeightQualifier,
                                                WeightUOM = QuantityAndWeight.WeightUOM,
                                            },
                                            Address = new BaseAddressModel("BY", "92")
                                            {
                                                AddressLocationNumber = l.Location,
                                                DCAddressLocationNumber = addyModel.DCAddressLocationNumber,
                                                DC = addyModel.DC
                                            },
                                        };
                                        opim.PackLevelList.Add(ShipmentsViewModel.GetNewPack(ref serialReference));

                                        if (once)
                                            OrderLevel.Insert(0, opim);
                                        else
                                            OrderLevel.Add(opim);
                                    }
                                    else
                                    {
                                        throw new IndexOutOfRangeException("addyModel is null");
                                    }
                                }

                                opim.QuantityAndWeight.LadingQuantity = opim.PackLevelList.Count;
                                opim.PackLevelList[0].ItemLevel.ShipmentLines.Add(ShipmentsViewModel.GetNewShipmentLine(
                                    once ? null : line.LineItem.OrderLine?.ConsumerPackageCode,
                                    l.Qty,
                                    location.TotalQtyUom,
                                    line.LineItem.OrderLine?.VendorPartNumber,
                                    true));
                                Debug.WriteLine(opim.Address.AddressLocationNumber);

                                if (once)
                                    return;
                            }

                        //if (once)
                        //    break;
                    }
            }
        }
    }
    public async Task<string[]?> GenerateShippingLabels(string printDir)
    {
        var requests = new List<ShipingLabelAll>();
        for (int i = 0; i < STAddresses.Count; i++)
        {
            var addy = STAddresses[i];
            if (addy.AddressLocationNumber is not null)
            {
                var stAddyModel = TradingPartner.GetAddressModelFor(addy.AddressLocationNumber, true); //await ShipmentsViewModel.GetAddressModelAsync(ShipmentHeader.TradingPartnerId, SettingsViewModel.DCtoFCHardcod(addy.AddressLocationNumber), true);
                if (stAddyModel is not null)
                {
                    ShipingLabelAll? request = null;
                    if (!IsBloomingdales && !IsBloomingdalesOutlet)
                    {
                        request = GenNewShippinglabelHeaderBase(stAddyModel);
                        requests.Add(request);
                    }

                    foreach (var p in GenNewPacks(stAddyModel))
                    {
                        ShipingLabelAll? r = null;

                        if (request is null)
                        {
                            if ((IsBloomingdales || IsBloomingdalesOutlet) && p.Address.Count == 1)
                                stAddyModel.AddressModel.Name = p.Address[0].AddressName;
                            else
                                throw new IndexOutOfRangeException("p.Address.Count == 1");


                            r = GenNewShippinglabelHeaderBase(stAddyModel);
                            requests.Add(r);
                        }
                        else
                            r = request;

                        r.Pack.Add(p);
                        r.Header.Address.AddRange(p.Address);
                    }
                }
            }
        }

        List<string> inputFilePaths = new();
        await FilesService.OpenDirectory(printDir);
        foreach (var r in requests)
        {
            MainViewModel.Current.DisplayInfobarMessage("Starting", $"{requests.IndexOf(r) + 1} Label Request of {requests.Count}", InfoSeverity.Informational);

            await Task.Delay(250);

            var responseP =
                await RestClientService.Current.GetLabelesRequestAsync(
                    IsSaks ? "eabc8672" :
                    IsBloomingdales ? "5b8094d8" :
                    IsBloomingdalesOutlet ? "2d3dbc9c" :
                    "fdd9095f", "pdf/batches", r);

            await Task.Run(() =>
            {
                var filepath = Path.Combine(printDir, $"{Directory.GetFiles(printDir).Length}-{ASNId}-lables.pdf");
                if(printDir != PrintDirectory)
                {
                    if (!Directory.Exists(PrintDirectory))
                        Directory.CreateDirectory(PrintDirectory);
                    File.WriteAllBytes(Path.Combine(PrintDirectory, $"{Directory.GetFiles(PrintDirectory).Length}-{ASNId}-lables.pdf"), responseP);
                }
                File.WriteAllBytes(filepath, responseP);

                inputFilePaths.Add(filepath);
            });
        }

        var s3LabelsPath = await S3BucketService.Current.UploadDirAsync(PrintDirectory, "labels", S3KeyName);
        if (s3LabelsPath != null)
        {
            if (DBTable == null) DBTable = new();
            DBTable.S3LabelsPath = s3LabelsPath;
            await GetSetDBTableRow();
        }

        MainViewModel.Current.DisplayInfobarMessage("Done", $"Label Requests", InfoSeverity.Success);

        return inputFilePaths.ToArray();
    }
    private ShipingLabelAll GenNewShippinglabelHeaderBase(BaseAddressModel addyModel)
    {
        var sl = new ShipingLabelAll()
        {
            Header = new SPSCommerceSDK.Models.ShipingLabel.Header()
            {
                BillOfLadingNumber = ShipmentHeader.BillOfLadingNumber,
                PurchaseOrderNumber = povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber,
                CarrierProNumber = ShipmentHeader.CarrierProNumber ?? CarrierInformation.CarrierAlphaCode,
                Department = povm.POData.Order?.Header?.OrderHeader?.Department,
                Vendor = IsNordstrom || IsNordstromCAN ? povm.POData.Order?.Header?.OrderHeader?.Vendor : null,
                CarrierInformation = new List<SPSCommerceSDK.Models.ShipingLabel.Carrierinformation>()
                {
                    new SPSCommerceSDK.Models.ShipingLabel.Carrierinformation()
                    {
                        CarrierAlphaCode = IsSaks || IsNordstrom || IsNordstromCAN ? CarrierInformation.CarrierAlphaCode : null,
                        CarrierRouting = IsSaks ? null : CarrierInformation.CarrierRouting,
                    }
                },
                Address = new List<SPSCommerceSDK.Models.ShipingLabel.Address>()
                {
                    //new SPSCommerceSDK.Models.ShipingLabel.Address()
                    //{
                    //    AddressTypeCode = "SF",
                    //    AddressName = SFAddress.AddressModel?.Name,
                    //    Address1 = IsBloomingdales || IsBloomingdalesOutlet ? 
                    //        SFAddress.AddressModel?.Name : SFAddress.AddressModel?.Address,
                    //    Address2 = IsBloomingdales || IsBloomingdalesOutlet ?   
                    //        SFAddress.AddressModel?.Address : SFAddress.AddressModel?.Address2,
                    //    City = IsBloomingdales || IsBloomingdalesOutlet ? 
                    //        SFAddress.AddressModel?.Address2 : SFAddress.AddressModel?.City,
                    //    State = IsBloomingdales || IsBloomingdalesOutlet ? 
                    //        SFAddress.AddressModel?.City + ", " + SFAddress.AddressModel?.State : SFAddress.AddressModel?.State,
                    //    PostalCode = SFAddress.AddressModel?.Zip,
                    //},
                    //new SPSCommerceSDK.Models.ShipingLabel.Address()
                    //{
                    //    AddressTypeCode = "ST",
                    //    LocationCodeQualifier = "92",
                    //    AddressName = addyModel?.AddressModel?.Name,
                    //    Address1 = IsBloomingdales || IsBloomingdalesOutlet ? TradingPartner.Name : addyModel?.AddressModel?.Address,
                    //    Address2 =IsBloomingdales || IsBloomingdalesOutlet ? addyModel?.AddressModel?.Address : addyModel?.AddressModel?.Address2 != "<na>"?addyModel?.AddressModel?.Address2 : null,
                    //    City = addyModel?.AddressModel?.City,
                    //    State = addyModel?.AddressModel?.State,
                    //    PostalCode = addyModel?.AddressModel?.Zip,
                    //    AddressLocationNumber = SettingsViewModel.FCtoDCHardcod(addyModel?.AddressLocationNumber),
                    //}
                                        new SPSCommerceSDK.Models.ShipingLabel.Address()
                    {
                        AddressTypeCode = "SF",
                        AddressName = SFAddress.AddressModel?.Name,
                        Address1 = IsBloomingdales || IsBloomingdalesOutlet ?
                            SFAddress.AddressModel?.Name : SFAddress.AddressModel?.Address,
                        Address2 = IsBloomingdales || IsBloomingdalesOutlet ?
                            SFAddress.AddressModel?.Address : SFAddress.AddressModel?.Address2,
                        City = IsBloomingdales || IsBloomingdalesOutlet ?
                            SFAddress.AddressModel?.Address2 +" "+SFAddress.AddressModel?.City : SFAddress.AddressModel?.City,
                        State = SFAddress.AddressModel?.State,
                        PostalCode = SFAddress.AddressModel?.Zip,
                    },
                    new SPSCommerceSDK.Models.ShipingLabel.Address()
                    {
                        AddressTypeCode = "ST",
                        LocationCodeQualifier = "92",
                        AddressName = addyModel?.AddressModel?.Name,
                        Address1 = IsBloomingdales || IsBloomingdalesOutlet ? TradingPartner.Name : addyModel?.AddressModel?.Address,
                        Address2 =IsBloomingdales || IsBloomingdalesOutlet ? addyModel?.AddressModel?.Address : addyModel?.AddressModel?.Address2 != "<na>"?addyModel?.AddressModel?.Address2 : null,
                        City = addyModel?.AddressModel?.City,
                        State = addyModel?.AddressModel?.State,
                        PostalCode = addyModel?.AddressModel?.Zip,
                        AddressLocationNumber = SettingsViewModel.FCtoDCHardcod(addyModel?.AddressLocationNumber),
                    }
                },
            },
            Pack = new List<SPSCommerceSDK.Models.ShipingLabel.Pack>(),
            //Pallet = IsNordstrom?new List<SPSCommerceSDK.Models.ShipingLabel.Pallet>() : null,
        };
        if (!IsNordstrom && !IsNordstromCAN)
        {
            sl.Header.References = new List<SPSCommerceSDK.Models.ShipingLabel.Reference>();
            if (IsSaks)
                sl.Header.References.Add(new SPSCommerceSDK.Models.ShipingLabel.Reference()
                {
                    ReferenceID = "10",
                    ReferenceQual = "PPGP",
                });
            if (IsBloomingdales || IsBloomingdalesOutlet)
            {
                sl.Header.References.Add(new SPSCommerceSDK.Models.ShipingLabel.Reference()
                {
                    Description = "repl",
                    ReferenceQual = "AGL",
                });
                sl.Header.References.Add(new SPSCommerceSDK.Models.ShipingLabel.Reference()
                {
                    Description = "STORY",
                    ReferenceQual = "PPGP",
                });
            }
        }
        return sl;
    }
    private List<SPSCommerceSDK.Models.ShipingLabel.Pack> GenNewPacks(BaseAddressModel dcAddyModel)
    {
        List<SPSCommerceSDK.Models.ShipingLabel.Pack> packs = new();
        for (int j = 0; j < OrderLevel.Count; j++)
        {
            var item = OrderLevel[j];
            if (item.Address.AddressLocationNumber != null)
            {
                var addyModelB = TradingPartner.GetAddressModelFor(item.Address.AddressLocationNumber, false);//await ShipmentsViewModel.GetAddressModelAsync(ShipmentHeader.TradingPartnerId, item.Address.AddressLocationNumber, true);
                if (addyModelB?.DCAddressLocationNumber == dcAddyModel.AddressLocationNumber ||
                    addyModelB?.DCAddressLocationNumber == dcAddyModel.DCAddressLocationNumber ||
                    (addyModelB?.DC == dcAddyModel.DC && dcAddyModel.DC == dcAddyModel.DCAddressLocationNumber) ||
                    addyModelB?.AddressLocationNumber == dcAddyModel.AddressLocationNumber ||
                    addyModelB?.AddressLocationNumber == dcAddyModel.DCAddressLocationNumber)
                {
                    foreach (var pack in item.PackLevelList)
                    {
                        var p = new SPSCommerceSDK.Models.ShipingLabel.Pack()
                        {
                            ShippingSerialID = pack.ShippingSerialID,
                            Item = new List<SPSCommerceSDK.Models.ShipingLabel.Item>(),
                            Address = new List<SPSCommerceSDK.Models.ShipingLabel.Address>()
                            {
                                new SPSCommerceSDK.Models.ShipingLabel.Address()
                                {
                                    AddressTypeCode = "Z7",
                                    LocationCodeQualifier = item.Address.SelectedLocationCodeQualifier,
                                    AddressLocationNumber = addyModelB?.AddressLocationNumber ?? item.Address.AddressLocationNumber,
                                    AddressName =addyModelB?.AddressModel?.Name,
                                    Address1 = addyModelB?.AddressModel?.Address,
                                    City =  addyModelB?.AddressModel?.City,
                                    State =  addyModelB?.AddressModel?.State,
                                    PostalCode =  addyModelB?.AddressModel?.Zip,
                                },
                            },
                        };
                        packs.Add(p);

                        foreach (var sl in pack.ItemLevel.ShipmentLines)
                        {
                            var li = MainViewModel.Current.ExcelUtil.LastReadUPCList.FirstOrDefault(l => l.GTIN == sl.ConsumerPackageCode);
                            if (li is not null)
                            {
                                var ii = new SPSCommerceSDK.Models.ShipingLabel.Item()
                                {
                                    BuyerPartNumber = sl.ConsumerPackageCode,
                                    ConsumerPackageCode = sl.ConsumerPackageCode,
                                    VendorPartNumber = sl.VendorPartNumber ?? li.Product,
                                    ProductSizeDescription = li.SizeDescription,
                                    ProductColorDescription = li.ColorDescripton,
                                    ProductMaterialDescription = li.ProductDescription,
                                    ProductMaterialCode = li.ColorCode,
                                    ProductColorCode = li.ColorCode,
                                    ProductSizeCode = li.SizeDescription,
                                    ShipQty = sl.ShipQty,
                                    ProductID = new SPSCommerceSDK.Models.ShipingLabel.Productid[1]
                                    {
                                        new SPSCommerceSDK.Models.ShipingLabel.Productid()
                                        {
                                            PartNumber = string.Join(", ",li.Product,li.ColorDescripton),
                                            PartNumberQual = "VA",
                                        }
                                    },
                                };
                                p.Item.Add(ii);
                            }
                        }
                    }
                }
            }
        }

        return packs;
    }
    private async Task PreviewShippingLabels()
    {
        if (DBTable?.S3LabelsPath is null)
            MainViewModel.Current.DisplayInfobarMessage("No Labels", $"{DBTable?.S3LabelsPath}", InfoSeverity.Informational);
        else
        {
            await S3BucketService.Current.SaveObjectDirectory(DBTable.S3LabelsPath, PrintDirectory);

            if (Directory.Exists(PrintDirectory))
            {
                var l = await FilesService.CombinePDF(PrintDirectory, ASNId, Directory.GetFiles(PrintDirectory));
                await FilesService.OpenPrindPrivewFor(l.Item2, PrintDirectory, l.Item1);
            }
        }
    }
    private async Task CreateNewInvoices(bool preview, params OrderPackItemModel[] forOrders)
    {
        if (!SettingsViewModel.StateofSandbox && InternalASNSettings.InternalActuallShip is null)
            throw new ArgumentNullException("InternalASNSettings.InternalActuallShip", "The Actual Ship Date setting must be set before creating an invoice.");

        if (preview)
            PreviewInvoicesData.Clear();

        var toadd = new List<OrderPackItemModel?>();

        if (forOrders.Any())
        {
            var q = from s in forOrders
                    where s.Address.DCAddressLocationNumber is string dcl &&
                     s.Address.AddressLocationNumber is string aln &&
                    !InvoiceViewModels.Any(i => i.InvoiceHeader.Address.Any(ii => ii.AddressLocationNumber == aln)) &&
                    !InvoiceViewModels.Any(i => i.DBTable?.BYAddressIds.Contains(aln) == true)
                    select s;
            toadd.AddRange(q);
        }
        else
            toadd.Add(null);

        foreach (var store in toadd)
        {
            var ivm = new InvoiceViewModel();
            var tosend = MainViewModel.Current.InvoicesViewModel.InvoiceViewModels.ToList<IHaveIncrementals>();
            if (preview)
            {
                tosend.AddRange(PreviewInvoicesData);
                foreach (var i in MainViewModel.Current.ShipmentsViewModel.PreviewASNInvoicesData)
                {
                    tosend.AddRange(i.InvoiceViewModels);
                }

                PreviewInvoicesData.Add(ivm);
            }
            MainViewModel.Current.SettingsViewModel.LastUsedInvoiceNumber =
                SettingsViewModel.GetNextIdNumber(tosend, MainViewModel.Current.SettingsViewModel.LastUsedInvoiceNumber, false);

            await ivm.Init(this);

            if (store is not null)
            {
                store.Address.SAddressTypeCode = store.Address.SelectedAddressTypeCode ?? "BY";
                store.Address.SLocationCodeQualifier = store.Address.SelectedLocationCodeQualifier ?? "92";
                ivm.AddOrderLevelPack(store);
            }

            ivm.AddSTandRIAddress(store);

            if (ivm.InvoiceLines.Count > 0)
                ivm.SetSummary();

            if (!preview)
                InvoiceViewModels.Add(ivm);
        }

        //if (!preview && InvoiceViewModels.Count > 0)
        //    povm.SelectedInvoiceViewModel = InvoiceViewModels[InvoiceViewModels.Count - 1];
    }
    #endregion

    #region IHaveIncrementals
    [JsonIgnore]
    public int Id
    {
        get
        {
            if (int.TryParse(ShipmentHeader.ShipmentIdentification, out int id))
                return id;
            else
                return 0;
        }

        set => ShipmentHeader.ShipmentIdentification = Convert.ToString(value);
    }
    [JsonIgnore]
    public int Bol
    {
        get
        {
            if (int.TryParse(ShipmentHeader.BillOfLadingNumber, out int id))
                return id;
            else
                return 0;
        }
        set => ShipmentHeader.BillOfLadingNumber = Convert.ToString(value);
    }
    [JsonIgnore]
    public string PoId { get => povm.PoId; }
    [JsonIgnore]
    public string ASNId { get => ShipmentHeader.ShipmentIdentification; }
    [JsonIgnore]
    public DateTimeOffset Date => ShipmentHeader.ShipDate;
    [JsonIgnore]
    public string StringId { get => ShipmentHeader.ShipmentIdentification; }
    [JsonIgnore]
    public TradingPartnerModel TradingPartner { get => povm.TradingPartner; set => throw new NotImplementedException(); }
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
    public string CheckId(DocumentType dt) => dt switch
    {
        DocumentType.PO850 => PoId,
        DocumentType.ASN856 => ASNId,
        DocumentType.BOL => Convert.ToString(Bol),
        DocumentType.IN810 => throw new NotImplementedException(),
        _ => StringId,
    };
    #endregion

    #region BaseHasCanSendViewModel
    [JsonIgnore]
    public override string TradingPartnerId => ShipmentHeader.TradingPartnerId;
    [JsonIgnore]
    public override string SendFileName => $"SH{ShipmentHeader.ShipmentIdentification.Replace("-", "")}.json";
    [JsonIgnore]
    public override string SendFileSaveDirectory => FilesService.SentShipmentsFolder;
    [JsonIgnore]
    public override string SaveFileName => ShipmentHeader.ShipmentIdentification + ".json";
    [JsonIgnore]
    public override string SaveFileDirectory => Path.Combine(FilesService.SavedShipmentsFolder, povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber ?? "unknown");
    [JsonIgnore]
    public override PurchaseOrderViewModel PurchaseOrder => povm;

    public override void DocumentStatusChanged()
    {
        if (povm is null)
            return;

        if (Status == DocumentStatus.Sent)
        {
            foreach (var poo in from p in POOrderLines where p.IsSelected && !p.WasSent select p)
            {
                poo.WasSent = true;
            }
        }

        povm.DisplayStatus = $"Shipment: {ShipmentHeader.ShipmentIdentification}";
        povm.DisplayStatus += MainViewModel.Current.GetDocumentStatusText(Status);

        OnPropertyChanged("Status");
    }
    public override void RemoveFromVMItemsList()
    {
        povm.ASNCollection.Remove(this);
    }
    public override object GetSendObject()
    {
        return GenShipmnt();
    }
    public override void SetForceEnabled()
    {
        foreach (var o in OrderLevel)
        {
            o.ForceEnabled = ForceEnabled;
        }
    }
    public override object GetImplementorObject()
    {
        return this;
    }
    public override object GetInternalSettingsObject()
    {
        return InternalASNSettings;
    }

    [JsonIgnore]
    public override string S3KeyName => $"{PoId}-{ASNId}";
    [JsonIgnore]
    public override string S3DirName => "shipments";

    public override async Task GetSetDBTableRow()
    {
        if (DBTable == null)
            DBTable = new();


        DBTable.ASNNumber = ASNId;
        DBTable.PONumber = PoId;
        DBTable.BOLNumber = ShipmentHeader.BillOfLadingNumber;
        DBTable.ShipDate = ShipmentHeader.ShipDate.ToSpsDateString();
        DBTable.S3KeyName = S3KeyName;
        DBTable.Settings = InternalASNSettings;
        await DynamoService.Current.Store(DBTable);
    }

    public async Task PutIntoSSCCTable()
    {
        List<SSCCsTable> ssccsList = new();

        foreach (var item in OrderLevel)
        {
            foreach (var pack in item.PackLevelList)
            {
                List<string> upcs = new();
                foreach (var sl in pack.ItemLevel.ShipmentLines)
                {
                    upcs.Add(sl.ConsumerPackageCode);
                }
                ssccsList.Add(new SSCCsTable
                {
                    ASNId = ASNId,
                    SSCC = pack.ShippingSerialID,
                    StoreId = item.Address.AddressLocationNumber,
                    UPCs = upcs,
                });
            }
        }

        await DynamoService.Current.PutTableBatch(ssccsList);
    }

    internal override async Task<bool> LoadFromS3(string json)
    {
        Shipment? o;
        if (json.StartsWith("ASN #,") || json.StartsWith(ASNId))
        {
            o = ShipmentsViewModel.CreateFromCsv(json, TradingPartner);
        }
        else
        {
            o = JsonSerializer.Deserialize<Shipment>(json);
        }

        if (o != null)
        {
            if (ShipmentsViewModel.Current.ReadShipments.FirstOrDefault(rs =>rs.Filename == S3KeyName) is ReadShipmentFile rf)
            {
                rf.Shipment = o;
            }
            else
            {
                ShipmentsViewModel.Current.ReadShipments.Add(new ReadShipmentFile()
                {
                    Filename = S3KeyName,
                    Shipment = o,
                });
            }
            ShipmentsViewModel.Current.Shipments.Add(o);
            await SetFromShipment(o);
            SetTradingPartnerID();

            if(InternalASNSettings == null)
                InternalASNSettings = new InternalASNSettings();
            //await vm.Init(false);

            SetSelectedStylesChecked();
            SortAndAddAddresses(false);

            return true;
        }

        return false;
    }
    #endregion

    #region from view
    public List<OrderPackItemModel> RemoveSTAddress(BaseAddressModel bam)
    {
        List<OrderPackItemModel> removed = new();

        OrderLevel.CollectionChanged -= OrderLevel_CollectionChanged;
        for (int i = OrderLevel.Count - 1; i >= 0; i--)
        {
            var o = OrderLevel[i];
            if (o.Address.DCAddressLocationNumber == bam.AddressLocationNumber ||
                o.Address.DC == bam.DC)
            {
                OrderLevel.Remove(o);
                removed.Add(o);
            }
        }
        STAddresses.Remove(bam);
        OrderLevel.CollectionChanged += OrderLevel_CollectionChanged;

        return removed;
    }
    #endregion

    #region methods
    public void SetSelectedStylesChecked()
    {
        foreach (var polm in POOrderLines)
        {
            if (polm.LineItem.QuantitiesSchedulesLocations is not null)
                foreach (var location in polm.LineItem.QuantitiesSchedulesLocations)
                {
                    if (location.LocationQuantity is not null)
                        foreach (var l in location.LocationQuantity)
                        {
                            var opim = OrderLevel.FirstOrDefault(o => o.Address.AddressLocationNumber == l.Location);
                            if (opim is not null)
                            {
                                foreach (var pack in opim.PackLevelList)
                                {
                                    if (pack.ItemLevel.ShipmentLines.Any(sl => sl.ConsumerPackageCode == polm.LineItem?.OrderLine?.ConsumerPackageCode))
                                    {
                                        polm.WasSent = polm.IsSelected = true;
                                    }
                                }
                            }
                        }
                }
        }
    }
    public void SortAndAddAddresses(bool sort)
    {
        if (OrderLevel.Count > 0)
        {
            if (sort)
                OrderLevel.AddAll(OrderLevel.OrderBy(o => o.Address.AddressLocationNumber).ToList());

            List<string> AllAddresses = new();

            foreach (var poLine in POOrderLines)
            {
                if (!poLine.IsSelected)
                    continue;

                foreach (var line in poLine.SubLineItems)
                {
                    if (line.LineItem.QuantitiesSchedulesLocations is not null)
                        foreach (var location in line.LineItem.QuantitiesSchedulesLocations)
                        {
                            if (location.LocationQuantity is not null)
                                foreach (var l in location.LocationQuantity)
                                {
                                    if (l.Location is string llocation && !AllAddresses.Contains(llocation))
                                    {
                                        AllAddresses.Add(llocation);
                                    }
                                }
                        }
                }

                foreach (var o in OrderLevel)
                {
                    if (o.Address.AddressLocationNumber is string llocation && !AllAddresses.Contains(llocation))
                        AllAddresses.Add(llocation);

                    foreach (var p in o.PackLevelList)
                    {
                        foreach (var l in p.ItemLevel.ShipmentLines)
                        {
                            foreach (var i in poLine.SubLineItems.GetAllSublineItems())
                            {
                                if (!l.CPCLineItems.Contains(i))
                                    l.CPCLineItems.Add(i);
                            }
                            l.CPCLineItem = l.ConsumerPackageCode;
                        }
                    }
                }
            }


            foreach (var o in OrderLevel)
            {
                if (o.Address.AddressLocationNumbersList.Count != AllAddresses.Count)
                    o.Address.AddressLocationNumbersList.AddAll(AllAddresses);

                o.Address.PropertyChanged -= Address_PropertyChanged;
                o.Address.PropertyChanged += Address_PropertyChanged;
            }

            QuantityAndWeight.LadingQuantity = OrderLevel.Sum(P => P.PackLevelList.Count);
        }
    }
    private void AddSTAddress(string? dcAddressLocationNumber)
    {
        if (dcAddressLocationNumber is not null)
        {
            var addyModel = TradingPartner.GetAddressModelFor(dcAddressLocationNumber, true); //await ShipmentsViewModel.GetAddressModelAsync(ShipmentHeader.TradingPartnerId, dcAddressLocationNumber, true);
            if (addyModel != null)
            {
                STAddresses.Add(addyModel);
            }
        }
    }
    private void CheckRemoveSTAddressHeader()
    {
        for (int i = STAddresses.Count - 1; i >= 0; i--)
        {
            var st = STAddresses[i];
            if (!OrderLevel.Any(o => o.Address.DCAddressLocationNumber == st.AddressLocationNumber))
                STAddresses.Remove(st);
        }
    }
    private Shipment GenShipmnt()
    {
        var shipment = new Shipment
        {
            Header = new SPSCommerceSDK.Models.Shipments.Header()
            {
                ShipmentHeader = new ShipmentHeader()
                {
                    TradingPartnerId = ShipmentHeader.TradingPartnerId,
                    ShipmentIdentification = ShipmentHeader.ShipmentIdentification,
                    ShipDate = ShipmentHeader.ShipDate.ToString("yyyy-MM-dd"),
                    CurrentScheduledDeliveryDate = ShipmentHeader.CurrentScheduledDeliveryDate.ToString("yyyy-MM-dd"),
                    ShipNoticeDate = ShipmentHeader.ShipNoticeDate.ToString("yyyy-MM-dd"),
                    ShipNoticeTime = ShipmentHeader.ShipNoticeTime?.ToString(@"hh\:mm\:ss"),
                    TsetPurposeCode = ShipmentHeader.TsetPurposeCode,
                    AsnStructureCode = ShipmentHeader.ASNStructureCode,
                    BillOfLadingNumber = ShipmentHeader.BillOfLadingNumber,
                    CarrierProNumber = ShipmentHeader.CarrierProNumber,

                },
                CarrierInformation = new List<SPSCommerceSDK.Models.Shipments.HeaderCarrierInformation>()
                {
                    new SPSCommerceSDK.Models.Shipments.HeaderCarrierInformation()
                    {
                        CarrierAlphaCode = CarrierInformation.CarrierAlphaCode,
                        CarrierTransMethodCode = CarrierInformation.CarrierTransMethodCode,
                        StatusCode = IsNordstromCAN && CarrierInformation.StatusCode == "CL" ? "CC" : CarrierInformation.StatusCode,
                        CarrierRouting = CarrierInformation.CarrierRouting
                    }
                },
                QuantityAndWeight = new List<HeaderQuantityAndWeight>()
                {
                    new HeaderQuantityAndWeight()
                    {
                        PackingMedium = QuantityAndWeight.PackingMedium,
                        PackingMaterial = QuantityAndWeight.PackingMaterial,
                        LadingQuantity = QuantityAndWeight.LadingQuantity,
                        WeightQualifier = QuantityAndWeight.WeightQualifier,
                        Weight = QuantityAndWeight.Weight,
                        WeightUom = QuantityAndWeight.WeightUOM
                    }
                },
                Address = new List<SPSCommerceSDK.Models.Shipments.HeaderAddress>(),

            },
            OrderLevel = new List<OrderLevelElement>(),
        };

        foreach (var stAddress in STAddresses)
        {
            if (stAddress.AddressLocationNumber == null)
                throw new ArgumentNullException("stAddress.AddressLocationNumber == null");

            BaseAddressModel bam = stAddress;
           // var staddylocnum = stAddress.AddressLocationNumber;
            if (IsBloomingdales || IsBloomingdalesOutlet)
            {
                bam = TradingPartner.GetAddressModelFor(stAddress.AddressLocationNumber, true) ?? stAddress;
                //staddylocnum = am?.AddressLocationNumber;
            }
            //while (staddylocnum?.Length < 4)
            //    staddylocnum = "0" + staddylocnum;

            shipment.Header.Address.Add(new SPSCommerceSDK.Models.Shipments.HeaderAddress()
            {
                AddressTypeCode = bam.SelectedAddressTypeCode,
                AddressLocationNumber = bam.AddressLocationNumber,
                LocationCodeQualifier = bam.SelectedLocationCodeQualifier,
                AddressName = bam.AddressModel?.Name,
                Address1 = IsBloomingdales || IsBloomingdalesOutlet ? null : bam.AddressModel?.Address,
                City = IsBloomingdales || IsBloomingdalesOutlet ? null : bam.AddressModel?.City,
                State = IsBloomingdales || IsBloomingdalesOutlet ? null : bam.AddressModel?.State,
                PostalCode = IsBloomingdales || IsBloomingdalesOutlet ? null : bam.AddressModel?.Zip,
                Country = IsBloomingdales || IsBloomingdalesOutlet ? null : bam.AddressModel?.Country,
            });
        }
        shipment.Header.Address.Add(new SPSCommerceSDK.Models.Shipments.HeaderAddress()
                    {
                        AddressTypeCode = SFAddress.SelectedAddressTypeCode,
                        AddressName = SFAddress.AddressModel?.Name,
                        Address1 = MainViewModel.Current.SettingsViewModel.ShipFromSettings.Address, 
                        Address2 = MainViewModel.Current.SettingsViewModel.ShipFromSettings.Address2,
                        City = MainViewModel.Current.SettingsViewModel.ShipFromSettings.City,
                        State = MainViewModel.Current.SettingsViewModel.ShipFromSettings.State,
                        PostalCode = MainViewModel.Current.SettingsViewModel.ShipFromSettings.Zip,
                        Country = MainViewModel.Current.SettingsViewModel.ShipFromSettings.Country,
                    }
        );

        shipment.OrderLevel = new List<OrderLevelElement>();
        foreach (var item in OrderLevel)
        {
            var ole = new OrderLevelElement
            {
                OrderHeader = new FluffyOrderHeader
                {
                    PurchaseOrderNumber = item.PurchaseOrderNumber,
                    Department = item.Department,
                    Vendor = povm.POData.Order?.Header?.OrderHeader?.Vendor
                },
                QuantityAndWeight = new List<FluffyQuantityAndWeight>()
            };
            ole.QuantityAndWeight.Add(new FluffyQuantityAndWeight()
            {
                PackingMedium = item.QuantityAndWeight.PackingMedium,
                PackingMaterial = item.QuantityAndWeight.PackingMaterial,
                LadingQuantity = item.PackLevelList.Count,
                WeightQualifier = item.QuantityAndWeight.WeightQualifier,
                Weight = item.QuantityAndWeight.Weight,
                WeightUom = item.QuantityAndWeight.WeightUOM,
            });

            ole.Address = new List<CunningAddress>
            {
                new CunningAddress()
                {
                    AddressTypeCode = IsBloomingdales && item.Address.SelectedAddressTypeCode == "BY" ? "BT" : item.Address.SelectedAddressTypeCode,
                    LocationCodeQualifier = item.Address.SelectedLocationCodeQualifier,
                    AddressLocationNumber = item.Address.AddressLocationNumber
                }
            };


            ole.PackLevel = new List<OrderLevelPackLevel>();
            foreach (var pack in item.PackLevelList)
            {
                var pacItems = new List<PurpleItemLevel>();
                foreach (var li in pack.ItemLevel.ShipmentLines)
                {
                    var pil = new PurpleItemLevel()
                    {
                        ShipmentLine = new TentacledShipmentLine()
                        {
                            ConsumerPackageCode = li.ConsumerPackageCode,
                            ShipQty = li.ShipQty,
                            ShipQtyUom = li.ShipQtyUOM,
                        },
                    };

                    if (IsBloomingdales || IsBloomingdalesOutlet)
                    {
                        pil.ProductOrItemDescription = new List<IndigoProductOrItemDescription>()
                         {
                             new IndigoProductOrItemDescription()
                             {
                                  ProductCharacteristicCode = "08",
                                  ProductDescriptionCode = "FL",
                                  ProductDescription =  "Compliant with Fair Labor Standards Act",
                             }
                         };
                        pil.RegulatoryCompliances = new List<HilariousRegulatoryCompliance>()
                        {
                            new HilariousRegulatoryCompliance()
                            {
                                RegulatoryComplianceQual = "DOLFL" ,
                                 YesOrNoResponse = "Y",
                                  RegulatoryComplianceId= "FL",
                                   Description=  "Compliant with Fair Labor Standards Act",
                            }
                        };
                    }

                    pacItems.Add(pil);
                }
                ole.PackLevel.Add(new OrderLevelPackLevel()
                {
                    Pack = new FluffyPack()
                    {
                        PackLevelType = pack.SelectedPackLevelType,
                        ShippingSerialId = pack.ShippingSerialID,

                    },
                    ItemLevel = pacItems,

                });
            }

            shipment.OrderLevel.Add(ole);
        }

        return shipment;
    }
    #endregion

    private void OrderLevel_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if(e.Action == NotifyCollectionChangedAction.Remove)
        {
            CheckRemoveSTAddressHeader();
        }
    }
    private void Address_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "AddressLocationNumber" && sender is BaseAddressModel bam && bam.AddressLocationNumber is string locnumb)
        {
            var addyModel = TradingPartner.GetAddressModelFor(locnumb, false);//await ShipmentsViewModel.GetAddressModelAsync(ShipmentHeader.TradingPartnerId, locnumb, true);
            if (addyModel is not null && bam.DCAddressLocationNumber != addyModel.DCAddressLocationNumber)
            {
                bam.DCAddressLocationNumber = addyModel.DCAddressLocationNumber;
                bam.DC = addyModel.DC;

                if (!STAddresses.Any(a => a.AddressLocationNumber == addyModel.DCAddressLocationNumber))
                {
                     AddSTAddress(addyModel.DCAddressLocationNumber);
                }
            }

            CheckRemoveSTAddressHeader();
        }
    }

    //todo
    public void SetJasonText()
    {
        ShipmentHeaderJson = GenShipmnt().Serialize(writeIndented: true);
    }
}
