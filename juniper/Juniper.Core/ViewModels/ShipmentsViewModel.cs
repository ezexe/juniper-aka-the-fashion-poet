using System.Linq;

namespace Juniper.Core.ViewModels
{
    public class ReadShipmentFile
    {
        public string Filename { get; set; }
        public Shipment Shipment { get; set; }
    }
    public class ShipmentsViewModel : ABaseMainPageViewModel
    {
        public static ShipmentsViewModel Current { get; private set; }

        public Action OnInvoicePreviewReady { get; set; }

        public List<SSCCsTable> SSCCsTableList { get; set; }
        public List<ShipmentsTable> ShipmentsTable { get; set; }

        public List<ReadShipmentFile> ReadShipments { get; private set; } 
        public ObservableCollection<Shipment> Shipments { get; } = new ObservableCollection<Shipment>();
        public ObservableCollection<ASNViewModel> ASNShipments { get; } = new ObservableCollection<ASNViewModel>();
        public ObservableCollection<TradingPartnerModel> PreviewASNInvoicesData { get; } = new ObservableCollection<TradingPartnerModel>();

        private DateTimeOffset actualShipDate = new(DateTime.Now);
        public DateTimeOffset ActualShipDate
        {
            get => actualShipDate;
            set => SetProperty(ref actualShipDate, value);
        }

        private string? laltSerialShippingId;
        public string? LastSerialShippingId
        {
            get => laltSerialShippingId;
            set => SetProperty(ref laltSerialShippingId, value);
        }

        public IAsyncRelayCommand<string> SendAllShipmentInvoicesCommand { get; }

        public ShipmentsViewModel() : base()
        {
            Current = this;

            SendAllShipmentInvoicesCommand = new AsyncRelayCommand<string>(SendAllInvoices);


            ReadShipments = new List<ReadShipmentFile>();
        }
        internal List<Tuple<ShipmentsTable, IEnumerable<InvoicesTable>>> Init(IEnumerable<ShipmentsTable> res)
        {
            List<Tuple<ShipmentsTable, IEnumerable<InvoicesTable>>> shipments = new();

            foreach (var s in res)
            {
                var query = from i in InvoicesViewModel.Current.InvoicesTable
                            where s.PONumber == i.PONumber && s.ASNNumber == i.ASNNumber
                            select i;

                shipments.Add(new Tuple<ShipmentsTable, IEnumerable<InvoicesTable>>(s, query));
                ReadShipments.Add(new ReadShipmentFile() { Filename = s.S3KeyName  });
            }

            return shipments;
        }
        public async Task Init(bool clear)
        {
            if (clear)
            {
                ClearLists();
            }

            await LoadLocalShipments(FilesService.SentShipmentsFolder);
            //await LoadLocalShipments(MainViewModel.Current.SettingsViewModel.SentShipmentsFilePath);

            ASNShipments.OrderByIncrementals();
        }

        public void ClearLists()
        {
            foreach (var p in TradingPartners)
            {
                p.ASNShipments.Clear();
            }

            Shipments.Clear();
            ASNShipments.Clear();
            ReadShipments.Clear();
            if (SSCCsTableList != null)
                SSCCsTableList.Clear();
        }

        public async Task LoadLocalShipments(string path)
        {
            foreach (var item in await FilesService.ReadValuesAsync<Shipment>(path, (from rs in ReadShipments select rs.Filename).ToArray()))
            {
                ReadShipments.Add(new ReadShipmentFile()
                {
                    Filename = item.Item1,
                    Shipment = item.Item2,
                });
            }

            path = path.ToFullDirectory();

            if (Directory.Exists(path))
            {
                await Parallel.ForEachAsync(Directory.EnumerateFiles(path, "*.csv").Where(
                    f => !(from rs in ReadShipments select rs.Filename).Any(rf => f == rf || Path.GetFileName(f) == Path.GetFileName(rf))).ToArray(),
                    ExtensionMethods.GetNewParallelOptions(),
                    async (file, token) =>
                {
                    //ASN #,ASN Date,Ship Date,BOL,Carrier Tracking,Carrier,Ship To Name,Ship To Location,Ship To Address,Ship To City,Ship To State,Ship To Zip,Ship From Name,FOB Terms,Lading Qty,PO #,Location #,Carton ID,Line #,Buyer Item #,Vdr Item #,UPC,GTIN,Desc,Color,Size,Qty Ship,CTN Qty,UOM,LOT NUMBER,EXPIRATION DATE,SCAC,Customer Order #,Invoice #,# of Packs,Pack Weight,Pack Weight UOM,Length,Width,Height,Dimensions UOM,# of Inner Packs,Pack Level Carrier Tracking ID,Ready For Pick Up Date,Actual Pick Up Date
                    var lines = await FilesService.ReadToStringValueAsync(file);


                    lock (ReadShipments)
                    {
                        if (lines != null)
                        {
                            var shipment = CreateFromCsv(lines, null);
                            if (!ReadShipments.Any(
                                s =>
                                (s.Shipment != null && s.Shipment.Header?.ShipmentHeader?.ShipmentIdentification == shipment.Header?.ShipmentHeader?.ShipmentIdentification) ||
                                (Path.GetFileName(s.Filename) == Path.GetFileName(file))))
                                ReadShipments.Add(new ReadShipmentFile()
                                {
                                    Filename = file,
                                    Shipment = shipment,
                                });
                            else
                            {
                                Debug.WriteLine(file);
                            }
                        }
                    }

                });
            }

            foreach (var readShipment in from rs in ReadShipments
                                         where rs.Shipment != null && rs.Shipment.OrderLevel != null && rs.Shipment.Header?.ShipmentHeader?.ShipmentIdentification != null &&
                                               !Shipments.Any(s => s.Header?.ShipmentHeader?.ShipmentIdentification == rs.Shipment.Header?.ShipmentHeader?.ShipmentIdentification)
                                         select rs)
            {

                Shipments.Add(readShipment.Shipment);
            }
        }

        public static Shipment CreateFromCsv(string lines, TradingPartnerModel? tp)
        {
            var shipment = new Shipment();
            var csvlines = lines.Split(SettingsViewModel.NewLineSplitter, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in csvlines)
            {
                var col = line.Split(',');
                if (col[0].Contains("ASN #"))
                    continue;

                if (shipment.Header is null)
                {
                    #region header
                    shipment.Header = new SPSCommerceSDK.Models.Shipments.Header();

                    shipment.Header.ShipmentHeader = new ShipmentHeader();
                    shipment.Header.ShipmentHeader.ShipmentIdentification = col[0];
                    shipment.Header.ShipmentHeader.ShipNoticeDate = col[1];
                    shipment.Header.ShipmentHeader.ShipDate = col[2];
                    shipment.Header.ShipmentHeader.BillOfLadingNumber = col[3];
                    shipment.Header.ShipmentHeader.TradingPartnerId = tp != null ? tp.TradingPartnerId :
                        col[6] is string stname ?
                        stname == "Saks" || stname == "WBDC CTR" ? TradingPartnerModel.TPID_Sacks :
                        stname == "Bloomingdale's Outlet" ? TradingPartnerModel.TPID_BloomOut :
                        stname == "Bloomingdale's" ? TradingPartnerModel.TPID_Bloom :
                        stname == "San Bernardino Off Price FC" ? TradingPartnerModel.TPID_Nord : null : null;

                    shipment.Header.ShipmentHeader.TsetPurposeCode = "00";
                    shipment.Header.ShipmentHeader.AsnStructureCode = "0001";
                    //shipment.Header.ShipmentHeader.CurrentScheduledDeliveryDate = ShipmentHeader.CurrentScheduledDeliveryDate.ToString("yyyy-MM-dd");
                    //shipment.Header.ShipmentHeader.ShipNoticeTime = ShipmentHeader.ShipNoticeTime?.ToString(@"hh\:mm\:ss");
                    //shipment.Header.ShipmentHeader.CarrierProNumber = ShipmentHeader.CarrierProNumber;

                    var ci = new SPSCommerceSDK.Models.Shipments.HeaderCarrierInformation()
                    {
                        CarrierRouting = col[5],
                        CarrierAlphaCode = col[31],
                        CarrierTransMethodCode = "M",
                        StatusCode = "CL",
                    };
                    if (ci.CarrierAlphaCode.IsNullEmptyOrWhiteSpace() && ci.CarrierRouting == "FEDEX FREIGHT")
                        ci.CarrierAlphaCode = "FXFE";

                    shipment.Header.CarrierInformation = new List<SPSCommerceSDK.Models.Shipments.HeaderCarrierInformation>();
                    shipment.Header.CarrierInformation.Add(ci);


                    var bqawm = MainViewModel.Current.SettingsViewModel.QuantityAndWeightModel;//.GetBaseQuantityAndWeightModel();
                    shipment.Header.QuantityAndWeight = new List<HeaderQuantityAndWeight>();
                    shipment.Header.QuantityAndWeight.Add(new HeaderQuantityAndWeight()
                    {
                        LadingQuantity = long.Parse(col[14]),
                        PackingMedium = bqawm.PackingMedium,
                        PackingMaterial = bqawm.PackingMaterial,
                        WeightQualifier = bqawm.WeightQualifier,
                        Weight = col[35].IsNullEmptyOrWhiteSpace() ? bqawm.Weight : Convert.ToDouble(col[35]),
                        WeightUom = col[36].IsNullEmptyOrWhiteSpace() ? bqawm.WeightUOM : col[36],
                    });

                    shipment.Header.Address = new List<SPSCommerceSDK.Models.Shipments.HeaderAddress>();
                    shipment.Header.Address.Add(new SPSCommerceSDK.Models.Shipments.HeaderAddress()
                    {
                        AddressName = col[6],
                        AddressLocationNumber = DCNameToAddressLocationNumber(shipment.Header.ShipmentHeader.TradingPartnerId ?? "", col[7]),
                        Address1 = col[8],
                        City = col[9],
                        State = col[10],
                        PostalCode = col[11],
                        AddressTypeCode = "ST",
                        LocationCodeQualifier = "92",
                    });

                    shipment.Header.Address.Add(new SPSCommerceSDK.Models.Shipments.HeaderAddress()
                    {
                        AddressName = col[12],
                        AddressTypeCode = "SF",
                        Address1 = MainViewModel.Current.SettingsViewModel.ShipFromSettings.Address,
                        City = MainViewModel.Current.SettingsViewModel.ShipFromSettings.City,
                        State = MainViewModel.Current.SettingsViewModel.ShipFromSettings.State,
                        PostalCode = MainViewModel.Current.SettingsViewModel.ShipFromSettings.Zip,
                        Country = MainViewModel.Current.SettingsViewModel.ShipFromSettings.Country,
                    });
                    #endregion
                    shipment.OrderLevel = new List<OrderLevelElement>();
                }

                var ole = shipment.OrderLevel?.FirstOrDefault(o => o.Address?.FirstOrDefault(a => a.AddressLocationNumber == col[16]) is not null);
                if (ole is null)
                {
                    ole = new OrderLevelElement();
                    ole.OrderHeader = new FluffyOrderHeader();
                    ole.OrderHeader.PurchaseOrderNumber = col[15];
                    //ole.OrderHeader.Department = item.Department;
                    //if (IsNordstrom)
                    //    ole.OrderHeader.Vendor = povm.POData.Order?.Header?.OrderHeader?.Vendor;

                    long.TryParse(col[27], out long lq);
                    ole.QuantityAndWeight = new List<FluffyQuantityAndWeight>();
                    ole.QuantityAndWeight.Add(new FluffyQuantityAndWeight()
                    {
                        LadingQuantity = lq,
                        PackingMedium = shipment.Header.QuantityAndWeight?[0].PackingMedium,
                        PackingMaterial = shipment.Header.QuantityAndWeight?[0].PackingMaterial,
                        WeightQualifier = shipment.Header.QuantityAndWeight?[0].WeightQualifier,
                        Weight = shipment.Header.QuantityAndWeight?[0].Weight,
                        WeightUom = shipment.Header.QuantityAndWeight?[0].WeightUom,
                    });

                    ole.Address = new List<CunningAddress>();
                    ole.Address.Add(new CunningAddress()
                    {
                        AddressLocationNumber = col[16],
                        AddressTypeCode = "BY",
                        LocationCodeQualifier = "92",
                    });

                    ole.PackLevel = new List<OrderLevelPackLevel>();
                    shipment.OrderLevel?.Add(ole);
                }

                var opl = ole.PackLevel?.FirstOrDefault(p => p.Pack?.ShippingSerialId == col[17]);
                if (opl is null)
                {
                    opl = new OrderLevelPackLevel()
                    {
                        Pack = new FluffyPack()
                        {
                            ShippingSerialId = col[17],
                            PackLevelType = "P",
                        },
                        ItemLevel = new List<PurpleItemLevel>()
                    };
                    ole.PackLevel?.Add(opl);
                }
                opl.ItemLevel?.Add(new PurpleItemLevel()
                {
                    ShipmentLine = new TentacledShipmentLine()
                    {
                        ConsumerPackageCode = col[21],
                        LineSequenceNumber = col[18],
                        ShipQty = Convert.ToDouble(col[26]),
                        ShipQtyUom = col[28],
                    }
                });
            }

            return shipment;
        }

        public override async Task<Exception?> OnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {
                    case "CommandStopSendAllInvoices":
                        SendAllShipmentInvoicesCommand.Cancel();
                        break;

                    case "ActualDate":
                        Filter((from s in ASNShipments
                                where
                                     s.InternalASNSettings.InternalActuallShip is not null &&
                                     s.InternalASNSettings.InternalActuallShip?.Date == SelectedDocumentDates
                                select s).Cast<IHaveIncrementals>());
                        break;

                    default:
                        return commandParam != null ? await base.RaiseOnCommandActivated(commandParam) : null;
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
                return await Task.FromResult(ex);
            }

            return null;
        }
        private async Task SendAllInvoices(string? param, CancellationToken cancellationToken)
        {
            var listtoSernd = (from s in ASNShipments
                               where s.Status == DocumentStatus.Sent
                               select s).Cast<object>().ToList();
            await SendInvoicesToSelected(listtoSernd, true);
        }

        #region from view
        public static async Task SendSelectedShipments(IList<object> selectedItems)
        {
            foreach (var o in selectedItems)
            {
                if (o is ASNViewModel asn)
                {
                    await asn.LoadS3Data();
                    await asn.CommandSend(false);
                }
            }
        }

        public async Task SetSelectedActualShipDate(IList<object> selectedItems)
        {
            IsActionsEnabled = false;

            foreach (var o in selectedItems)
            {
                if (o is ASNViewModel asn)
                {
                    await asn.LoadS3Data();

                    if (asn.InternalASNSettings == null)
                        asn.InternalASNSettings = new InternalASNSettings();

                    asn.InternalASNSettings.InternalActuallShip = ActualShipDate;

                    //await asn.SaveSettings();
                    await asn.RaiseOnCommandActivated("CommandSaveSettings");//.SaveSettings();
                }
            }

            IsActionsEnabled = true;
        }
        public static async Task CreateMasterBolFor(IList<object> selectedItems)
        {
            try
            {
                var dir = await MainViewModel.Current.FilesService.SelectDirectory();
                if (dir is not null)
                {
                    var bolDocuments = new List<BillOfLadingsDocumentFileModel>();
                    foreach (var o in selectedItems)
                    {
                        if (o is ASNViewModel asn)
                        {
                            await asn.LoadS3Data();
                            // var f = await GenBolFile(asn, dir, addypolist);
                            foreach (var addy in asn.STAddresses)
                            {
                                if (addy.AddressLocationNumber is not null)
                                {
                                    var addyModel = asn.TradingPartner.GetAddressModelFor(addy.AddressLocationNumber, true);
                                    if (addyModel is not null && addyModel.AddressModel is not null && addyModel.AddressLocationNumber is not null)
                                    {
                                        BillOfLadingsDocumentFileModel? bold = bolDocuments.FirstOrDefault(a => a.AddressLocationNumber == addyModel.AddressLocationNumber);
                                        if (bold is null)
                                        {
                                            // await GetAddressModelAsync(asn.ShipmentHeader.TradingPartnerId, addy.AddressLocationNumber, true);

                                            bold = new BillOfLadingsDocumentFileModel()
                                            {
                                                AddressLocationNumber = addyModel.AddressLocationNumber,
                                                STAddressName = addyModel.AddressModel.Name,
                                                STAddress = addyModel.AddressModel.Address,
                                                STCity = addyModel.AddressModel.City,
                                                STState = addyModel.AddressModel.State,
                                                STZip = addyModel.AddressModel.Zip,
                                                CarrierName = asn.CarrierInformation.CarrierRouting,
                                                SCAC = asn.CarrierInformation.CarrierAlphaCode,
                                                DocDate = $"{DateTime.Now:MMM dd}, {DateTime.Now.Year}",
                                                BillOfLadingNumber = Convert.ToString(MainViewModel.Current.SettingsViewModel.LastUsedASNMasterBOLNumber)
                                            };
                                            // if (!bolDocuments.Contains(thisthisbolDoc))
                                            bolDocuments.Add(bold);

                                            MainViewModel.Current.SettingsViewModel.LastUsedASNMasterBOLNumber++;

                                            if (asn.IsSaks)
                                            {
                                                bold.BTAddressName = addyModel.AddressModel.Name;
                                                bold.BTAddress = addyModel.AddressModel.Address;
                                                bold.BTCity = addyModel.AddressModel.City;
                                                bold.BTState = addyModel.AddressModel.State;
                                                bold.BTZip = addyModel.AddressModel.Zip;
                                                bold.DisplayName = asn.povm.DisplayName;
                                            }
                                            else
                                            {
                                                bold.DisplayName = $"{addyModel.DCAddressLocationNumber} - {asn.ASNId}";
                                            }

                                            bold.Path = await GetUniqueBOLPath(dir, bold.DisplayName);
                                            asn.InternalASNSettings.MasterBOLPath = bold.Path;
                                            await asn.SaveSettings();

                                        }

                                        if (bold is not null)
                                        {
                                            PurchaseOrderBOLTotals? thisbolPo = bold.PurchaseOrders.FirstOrDefault(a => a.PurchaseOrder.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber == asn.povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber);
                                            if (thisbolPo is null)
                                            {
                                                thisbolPo = new PurchaseOrderBOLTotals() { PurchaseOrder = asn.povm };
                                                bold.PurchaseOrders.Add(thisbolPo);
                                            }

                                            var thisttlpkg = 0;
                                            var thisttlwht = 0;
                                            foreach (var ol in asn.OrderLevel)
                                            {
                                                if (bold?.AddressLocationNumber == ol.Address.DCAddressLocationNumber ||
                                                    bold?.AddressLocationNumber == ol.Address.DC)
                                                {
                                                    thisttlpkg += ol.PackLevelList.Count;
                                                    thisbolPo.CarrierInformationQtyTtl += ol.PackLevelList.Count;
                                                    thisttlwht += ol.PackLevelList.Count * (int)ol.QuantityAndWeight.Weight;
                                                    thisbolPo.CarrierInformationWeightTtl += ol.PackLevelList.Count * (int)ol.QuantityAndWeight.Weight;
                                                    foreach (var p in ol.PackLevelList)
                                                        foreach (var sl in p.ItemLevel.ShipmentLines)
                                                        {
                                                            var li = MainViewModel.Current.ExcelUtil.LastReadUPCList.FirstOrDefault(l => l.GTIN == sl.ConsumerPackageCode);
                                                            if (li is not null)
                                                            {
                                                                var txt = $"Style: {li.Product} {li.ColorDescripton}";
                                                                if (!thisbolPo.AdditionalStyleInfo.IsNullEmptyOrWhiteSpace() && !thisbolPo.AdditionalStyleInfo.Contains(txt))
                                                                {
                                                                    thisbolPo.AdditionalStyleInfo += Environment.NewLine;
                                                                }
                                                                if (thisbolPo.AdditionalStyleInfo == null || !thisbolPo.AdditionalStyleInfo.Contains(txt))
                                                                    thisbolPo.AdditionalStyleInfo += txt;
                                                            }
                                                        }
                                                }
                                            }

                                            bold.CarrierInformationQtyTtl += thisttlpkg;
                                            bold.CarrierInformationWeightTtl += thisttlwht;
                                            bold.GrandTotalPackagesgs = bold.CarrierInformationQtyTtl;
                                            bold.GrandTotalWeight = bold.CarrierInformationWeightTtl;
                                        }
                                        else
                                        {

                                        }
                                    }
                                }
                                else
                                {

                                }
                            }
                        }
                    }

                    if (bolDocuments.Count > 1)
                    {
                        var thisthisbolDoc = new BillOfLadingsDocumentFileModel()
                        {
                            CarrierName = (selectedItems[0] as ASNViewModel)?.CarrierInformation.CarrierRouting ?? "FEDEX ECONOMY",
                            SCAC = (selectedItems[0] as ASNViewModel)?.CarrierInformation.CarrierAlphaCode ?? "FXNL",
                            DocDate = $"{DateTime.Now:MMM dd}, {DateTime.Now.Year}",
                            BillOfLadingNumber = Convert.ToString(MainViewModel.Current.SettingsViewModel.LastUsedASNMasterBOLNumber),
                        };

                        MainViewModel.Current.SettingsViewModel.LastUsedASNMasterBOLNumber++;

                        foreach (var doc in bolDocuments)
                        {
                            foreach (var po in doc.PurchaseOrders)
                            {
                                var thisbolPo = thisthisbolDoc.PurchaseOrders.FirstOrDefault(a =>
                                a.PurchaseOrder.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber ==
                                po.PurchaseOrder.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber);
                                if (thisbolPo is null)
                                {
                                    thisbolPo = new PurchaseOrderBOLTotals()
                                    {
                                        PurchaseOrder = po.PurchaseOrder,
                                        AdditionalStyleInfo = po.AdditionalStyleInfo ?? "",
                                        CarrierInformationQtyTtl = po.CarrierInformationQtyTtl,
                                        CarrierInformationWeightTtl = po.CarrierInformationWeightTtl
                                    };
                                    thisthisbolDoc.PurchaseOrders.Add(thisbolPo);
                                }
                                else
                                {
                                    if (thisbolPo.AdditionalStyleInfo != null && po.AdditionalStyleInfo != null
                                        && !thisbolPo.AdditionalStyleInfo.Contains(po.AdditionalStyleInfo))
                                    {
                                        var infollines = po.AdditionalStyleInfo.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                                        foreach (var l in infollines)
                                        {
                                            if (!thisbolPo.AdditionalStyleInfo.Contains(l))
                                                thisbolPo.AdditionalStyleInfo += Environment.NewLine + l;
                                        }

                                    }

                                    thisbolPo.CarrierInformationQtyTtl += po.CarrierInformationQtyTtl;
                                    thisbolPo.CarrierInformationWeightTtl += po.CarrierInformationWeightTtl;
                                }
                            }

                            thisthisbolDoc.GrandTotalPackagesgs += doc.GrandTotalPackagesgs;
                            thisthisbolDoc.GrandTotalWeight += doc.GrandTotalWeight;
                            thisthisbolDoc.CarrierInformationQtyTtl += doc.CarrierInformationQtyTtl;
                            thisthisbolDoc.CarrierInformationWeightTtl += doc.CarrierInformationWeightTtl;
                        }

                        if (thisthisbolDoc.PurchaseOrders
                            .All(o => o.PurchaseOrder.DisplayName == TradingPartnerModel.TPDN_Nordstromcom))
                            thisthisbolDoc.DisplayName = $"NR Master - ";
                        else if (thisthisbolDoc.PurchaseOrders
                            .All(o => o.PurchaseOrder.DisplayName == TradingPartnerModel.TPDN_Blommies || o.PurchaseOrder.DisplayName == TradingPartnerModel.TPDN_BlommiesOutlet))
                            thisthisbolDoc.DisplayName = $"BL Master - ";
                        else
                            thisthisbolDoc.DisplayName = $"Master - ";

                        thisthisbolDoc.Path = await GetUniqueBOLPath(dir, thisthisbolDoc.DisplayName);
                        bolDocuments.Add(thisthisbolDoc);
                    }

                    await MainViewModel.Current.WordUtil.CreateBOL(bolDocuments);
                }

            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, "CreateMasterBolFor");
            }
        }
        public async Task SendInvoicesToSelected(IList<object> selectedItems, bool preview)
        {
            try
            {
                IsActionsEnabled = false;

                List<ASNViewModel> actualList = new();
                if (preview)
                {
                    foreach (var tp in PreviewASNInvoicesData)
                    {
                        tp.PurchaseOrders.Clear();
                        tp.ASNShipments.Clear();
                        tp.InvoiceViewModels.Clear();
                    }
                    PreviewASNInvoicesData.Clear();

                    foreach (object o in selectedItems)
                        if (o is ASNViewModel item)
                            actualList.Add(item);
                }
                else
                {
                    foreach (var tp in PreviewASNInvoicesData)
                    {
                        actualList.AddRange(tp.ASNShipments);
                    }
                }

                var sentShipments = 0;
                var sentInvoices = 0;
                var errs = new List<Exception>();
                ObservableCollection<ASNViewModel> invasnPreview = new();

                foreach (var o in selectedItems)
                {
                    if (o is ASNViewModel asn)
                    {
                        if (SendAllShipmentInvoicesCommand.IsCancellationRequested)
                            break;
                        await asn.LoadS3Data();

                        var added = false;
                        var asnErr = preview ? await asn.OnCommandActivated("CommandCreateMultipleInvoicePreview") : null;// : "CommandCreateMultipleInvoice");
                        if (asnErr == null)
                            if (preview)
                            {
                                if (asn.PreviewInvoicesData.Count > 0)
                                {
                                    var tpname = $"{asn.TradingPartner.Name} - {asn.ShipmentHeader.ShipmentIdentification}";
                                    var tp = PreviewASNInvoicesData.FirstOrDefault(t => t.Name == tpname);
                                    if (tp is null)
                                    {
                                        tp = new TradingPartnerModel(tpname, asn.TradingPartner.TradingPartnerId);
                                        PreviewASNInvoicesData.Add(tp);
                                    }
                                    tp.AddPurchaseOrder(asn.povm);
                                    tp.AddASN(asn);
                                    foreach (var inv in asn.PreviewInvoicesData)
                                    {
                                        tp.AddInvoice(inv);
                                    }
                                }
                                continue;
                            }
                            else
                                foreach (var inv in asn.PreviewInvoicesData)
                                {
                                    if (SendAllShipmentInvoicesCommand.IsCancellationRequested)
                                        break;
                                    asn.InvoiceViewModels.Add(inv);
                                    var err = await inv.OnCommandActivated("CommandSend");
                                    if (err != null)
                                        errs.Add(err);
                                    else
                                    {
                                        sentInvoices++;
                                        if (!added)
                                        {
                                            added = true;
                                            sentShipments++;
                                        }

                                        await Task.Delay(250);
                                    }
                                }
                        else
                            errs.Add(asnErr);

                        if (added)
                            asn.DoneInvoicesData.AddAll(asn.InvoiceViewModels.GroupLines());
                    }
                }


                IsActionsEnabled = true;

                if (preview)
                {
                    OnInvoicePreviewReady?.Invoke();
                }
                else
                {
                    if (errs.Count > 0)
                        MainViewModel.Current.DisplayInfobarMessage("Errors", $"There was {errs.Count}, in Sending invoices to {ASNShipments.Count} shipments check log for more details.", InfoSeverity.Error);
                    else
                        MainViewModel.Current.DisplayInfobarMessage("Done", $"Done Sending invoices to {sentShipments} shipments total of {sentInvoices} Invoices", InfoSeverity.Success);

                }
            }catch(Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, "SendInvoicesToSelected");
            }
        }
        public static void RemovePreviewINV(params InvoiceViewModel[] invoiceViewModels)
        {
            var list = MainViewModel.Current.InvoicesViewModel.InvoiceViewModels.ToList<IHaveIncrementals>();
            foreach (var i in MainViewModel.Current.ShipmentsViewModel.PreviewASNInvoicesData)
            {
                list.AddRange(i.InvoiceViewModels);
            }
            foreach (var i in invoiceViewModels)
            {
                MainViewModel.Current.SettingsViewModel.LastUsedInvoiceNumber =
                    SettingsViewModel.SetLastIdNumber(i, list, false);

                list.Remove(i);
                i.asnvm.PreviewInvoicesData.Remove(i);
                foreach (var tp in MainViewModel.Current.ShipmentsViewModel.PreviewASNInvoicesData)
                {
                    tp.RemoveInvoice(i);
                }
            }
        }
        public static async Task CreatePackingListFoeSelected(IList<object> selectedItems, bool single)
        {
            List<Tuple<string, string, List<OrderPackItemModel>>> orders = new();
            List<POOrderLineModel> orderLines = new();
            //List<string> sId = new(), sBol = new();
            string? displayname = null, poNum = null, cDate = null, sDate = null;//, sId = null, sBol = null;
            foreach (var o in selectedItems)
            {
                if (o is ASNViewModel asn)
                {
                    await asn.LoadS3Data();
                    if (!single)
                        await asn.OnCommandActivated("CommandExportPackingList");
                    else
                    {
                        orders.Add(new Tuple<string, string, List<OrderPackItemModel>>(
                            asn.ShipmentHeader.ShipmentIdentification,
                            asn.ShipmentHeader.BillOfLadingNumber,
                            new List<OrderPackItemModel>(asn.OrderLevel.OrderBy(o=>o.Address.DCAddressLocationNumber))));

                        foreach (var l in asn.povm.POOrderStyleLines)
                        {
                            if (!orderLines.Contains(l))
                                orderLines.Add(l);
                        }

                        if (displayname is null)
                            displayname = asn.povm.DisplayName;
                        else if (!displayname.Contains(asn.povm.DisplayName))
                            displayname += ", " + asn.povm.DisplayName;

                        if (poNum is null)
                            poNum = asn.povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber;
                        else if (asn.povm.POData.Order?.Header?.OrderHeader?.PurchaseOrderNumber is string n &&
                            !poNum.Contains(n))
                            poNum += ", " + n;

                        if (cDate is null)
                            cDate = asn.povm.POData.Order?.Header?.Dates?.FirstOrDefault(d => d.DateTimeQualifier == "001")?.Date;

                        if (sDate is null)
                            sDate = asn.ShipmentHeader.ShipDate.ToString("MM-dd-yyyy");
                        else if (!sDate.Contains(asn.ShipmentHeader.ShipDate.ToString("MM-dd-yyyy")))
                            sDate += ", " + asn.ShipmentHeader.ShipDate.ToString("MM-dd-yyyy");

                        //if (sId is null)
                        //    sId = asn.ShipmentHeader.ShipmentIdentification;
                        //else 
                        //if (!sId.Contains(asn.ShipmentHeader.ShipmentIdentification))
                        //    sId.Add(asn.ShipmentHeader.ShipmentIdentification);// += ", " + asn.ShipmentHeader.ShipmentIdentification;

                        //if (sBol is null)
                        //    sBol = asn.ShipmentHeader.BillOfLadingNumber;
                        //else 
                        //if (!sBol.Contains(asn.ShipmentHeader.BillOfLadingNumber))
                        //    sBol.Add(asn.ShipmentHeader.BillOfLadingNumber);//sBol += ", " + asn.ShipmentHeader.BillOfLadingNumber;
                    }
                }
            }

            if (single && displayname != null)
            {
                await MainViewModel.Current.ExcelUtil.ExportPackingList(orders,
                     displayname,
                      poNum,
                      cDate,
                      sDate,
                      orderLines);
            }
        }
        public async static Task CreateLabelsForSelected(IList<object> selectedItems)
        {
            try
            {
                var dir = await MainViewModel.Current.FilesService.SelectDirectory();
                if (dir is not null)
                {
                    List<string> paths = new();
                    string fileid = "";
                    foreach (var o in selectedItems)
                    {
                        if (o is ASNViewModel asn)
                        {
                            await asn.LoadS3Data();

                            var arrpaths = await asn.GenerateShippingLabels(dir);
                            if (arrpaths != null)
                            {
                                paths.AddRange(arrpaths);
                                fileid += asn.ASNId + "-";
                            }
                        }
                    }
                    var l = await MainViewModel.Current.FilesService.CombinePDF(dir, fileid, paths.ToArray());
                    await MainViewModel.Current.FilesService.OpenPrindPrivewFor(l.Item2, dir, l.Item1);
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, "CreateLabelsForSelected");
            }
        }
        #endregion

        #region methods
        public void RemoveFromAllASNShipmentsList(ASNViewModel asn)
        {
            MainViewModel.Current.SettingsViewModel.LastUsedASNBOLNumber =
                SettingsViewModel.SetLastIdNumber(asn, ASNShipments.ToList<IHaveIncrementals>(), true);
            MainViewModel.Current.SettingsViewModel.LastUsedASNNumber =
                SettingsViewModel.SetLastIdNumber(asn, ASNShipments.ToList<IHaveIncrementals>(), false);

            asn.povm.TradingPartner?.RemoveASN(asn);

            if (ASNShipments.Contains(asn))
                ASNShipments.Remove(asn);

            DocumentDates.RemoveUnique(ASNShipments, asn.Date);
        }
        public void AddToAllASNShipmentsList(ASNViewModel asn)
        {
            asn.povm.TradingPartner?.AddASN(asn);

            if(!ASNShipments.Contains(asn))
                ASNShipments.Add(asn);

            DocumentDates.AddUnique(asn.Date);

            if(asn.InternalASNSettings is not null && asn.InternalASNSettings.InternalActuallShip is not null)
                DocumentDates.AddUnique(asn.InternalASNSettings.InternalActuallShip);
        }
        public int GetLastSerialReference(ASNViewModel asn)
        {
            if (LastSerialShippingId is null || LastSerialShippingId.Length != 20)
            {
                var lastInt = 99999999;
                foreach (var s in SSCCsTableList)
                {
                    if (s.SSCC.Length != 20)
                        continue;

                    var lastId = s.SSCC[11..];
                    if (int.TryParse(lastId?.Remove(lastId.Length - 1), out int thisInt))
                    {
                        if (thisInt < 10000000)
                            continue;
                        else if (lastInt > thisInt)
                            lastInt = thisInt;
                    }
                }

                return lastInt;
            }
            else
            {
                var lastId = MainViewModel.Current.ShipmentsViewModel.LastSerialShippingId?.Substring(11);
                lastId = lastId?.Remove(lastId.Length - 1);
                return Convert.ToInt32(lastId);
            }
        }
        public string GenerateSSCC(string companyprefix, ref int serialReference)
        {
            //if (serialReference != 99999999)
            //{
            if (serialReference > 5000000)
                serialReference -= 1;
            else
                serialReference += 1;
            //}

            string serialReferenceS = "" + serialReference;
            while (serialReferenceS.Length < 8)
                serialReferenceS = "0" + serialReferenceS;

            var full = $"0{companyprefix}{serialReference}";
            var total = 0;
            for (int i = 0; i < full.Length; i++)
            {
                int n;
                if (i % 2 == 0)
                    n = (int)char.GetNumericValue(full[i]) * 3;
                else
                    n = (int)char.GetNumericValue(full[i]) * 1;
                total += n;
            }

            // Smaller multiple
            int a = (total / 10) * 10;
            // Larger multiple
            int b = a + 10;
            // Return of closest of two
            //var nearest = (total - a > b - total) ? b : a;
            var checkDigit = b - total;
            if (checkDigit == 10)
                checkDigit = 0;

            LastSerialShippingId = $"000{companyprefix}{serialReference}{checkDigit}";
            return LastSerialShippingId;
        }
        #endregion

        #region ABaseMainPageViewModel
        public override IEnumerable<IHaveIncrementals> IncViewModels => ASNShipments.Cast<IHaveIncrementals>();
        public override void OrderBy()
        {
            ASNShipments.OrderByIncrementals();
        }
        #endregion

        public static async Task<string> GetUniqueBOLPath(string dir, string displayName)
        {
            return await Task.Run(() =>
            {
                var sourceFile = MainViewModel.Current.SettingsViewModel.BolTemplateFilePath;
                if (displayName.Contains("Master - "))
                {
                    var fname = "BOL Master.docx";

                    if (displayName.StartsWith("NR"))
                        fname = "Nord BOL Master.docx";
                    else if (displayName.StartsWith("BL"))
                        fname = "Bloomies BOL Master.docx";

                    sourceFile = sourceFile.Replace(Path.GetFileName(sourceFile), fname);
                }
                var dsFilename = Path.Combine(dir, $"{displayName} {DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Year - 2000}");
                var destinationFile = $"{dsFilename}.docx";

                try
                {
                    int files = 0;
                    while (File.Exists(destinationFile))
                    {
                        files++;
                        destinationFile = $"{dsFilename} - {files}.docx";
                    }
                    File.Copy(sourceFile, destinationFile, true);
                }
                catch (Exception e)
                {
                    MainViewModel.Current.LoggerUtil.AddException(e, $"GetUniqueBOLPath");
                }
                return destinationFile;
            });
        }
        public static PackItemModel GetNewPack(ref int serialReference)
        {
            var sscc = MainViewModel.Current.ShipmentsViewModel.GenerateSSCC(MainViewModel.Current.SettingsViewModel.Gs1CompanyPrefix, ref serialReference);
            return new PackItemModel()
            {
                SIPackLevelType = 0,
                ShippingSerialID = sscc
            };
        }
        public static ShipmentLine GetNewShipmentLine(string? consumerPackageCode, double? qtyReceived, string? totalQtyUom,string? vendorPartNumber, bool isOriginal, IEnumerable<string>? subLineItems = null)
        {
            var sl = new ShipmentLine()
            {
                ShipQty = qtyReceived ?? 0.0,
                OriginalShip = isOriginal ? qtyReceived ?? 0.0 : 0.0,
                VendorPartNumber = vendorPartNumber,
                ShipQtyUOM = totalQtyUom
            };
            if(subLineItems != null)
                sl.CPCLineItems.AddAll(subLineItems.ToArray());
            //sl.ConsumerPackageCode = consumerPackageCode ?? "";
            sl.CPCLineItem = consumerPackageCode;
            return sl ;
        }
        private static string DCNameToAddressLocationNumber(string partnerid, string location)
        {
            var tp = MainViewModel.Current.TradingPartners.FirstOrDefault(tp=>tp.TradingPartnerId == partnerid);
            if(tp!= null)
            {
                location = tp.GetAddressModelByName(location) ?? location;
            }
            return location;
        }
    }
}