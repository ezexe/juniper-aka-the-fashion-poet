using SPSCommerceSDK.Models.Invoices;
using System.Collections;
using System.Linq;

namespace Juniper.Core.ViewModels
{
    public class InvoiceViewModel : BaseHasCanSendViewModel, IHaveIncrementals
    {
        [JsonIgnore]
        public ASNViewModel asnvm { get; set; }
        [JsonIgnore]
        public InvoicesTable? DBTable { get; set; }
        [JsonIgnore]
        public InternalINVSettings InternalINVSettings { get; set; }//=> (InternalINVSettings)IFieldsNSettings;
        private string duplicateOf;
        [JsonIgnore]
        public string DuplicateOf
        {
            get => duplicateOf;
            set => SetProperty(ref duplicateOf, value);
        }

        private InvoiceHeaderModel invoiceHeader;
        public InvoiceHeaderModel InvoiceHeader
        {
            get => invoiceHeader;
            set => SetProperty(ref invoiceHeader, value);
        }
        [NotNullOrEmptyCollection(ErrorMessage = "Theres No Products Listed To Charge")]
        public ObservableCollection<InvoiceLineItemModel> InvoiceLines { get; set; } = new ObservableCollection<InvoiceLineItemModel>();
        public BaseSummaryModel Summary { get; set; } = new BaseSummaryModel();

        #region init
        public InvoiceViewModel() : base()
        {

        }
        public async Task Init(ASNViewModel aSNViewModel)
        {
            asnvm = aSNViewModel;

            InvoiceHeader = new InvoiceHeaderModel();

            var ttl = $"{MainViewModel.Current.SettingsViewModel.LastUsedInvoiceNumber}";
            if (ttl.Length > InvoiceHeader.MaxInvoiceNumberLength)
                throw new Exception($"Max Invoice Number Length exceeded Max:{InvoiceHeader.MaxInvoiceNumberLength}");

            InvoiceHeader.InvoiceNumber = ttl;
            InvoiceHeader.TradingPartnerId = asnvm.IsSaks ? TradingPartnerModel.Default_SaksInvoiceTradingPartnerId : asnvm.ShipmentHeader.TradingPartnerId;
            InvoiceHeader.BillOfLadingNumber = asnvm.ShipmentHeader.BillOfLadingNumber;
            InvoiceHeader.InvoiceDate = asnvm.InternalASNSettings.InternalActuallShip ?? DateTime.Now;// throw new ArgumentNullException("InternalASNSettings.InternalActuallShip", "The Actual Ship Date setting must be set before creating an invoice.");//asnvm.ShipmentHeader.ShipDate;
            InvoiceHeader.ShipDate = asnvm.ShipmentHeader.ShipDate.ToString("yyyy-MM-dd");
            InvoiceHeader.MaxInvoiceNumberLength = asnvm.IsNordstrom || asnvm.IsNordstromCAN ? 10 : 22;
            InvoiceHeader.PurchaseOrderDate = asnvm.povm.POData?.Order?.Header?.OrderHeader?.PurchaseOrderDate;
            InvoiceHeader.PurchaseOrderNumber = asnvm.povm.POData?.Order?.Header?.OrderHeader?.PurchaseOrderNumber;
            InvoiceHeader.Department = asnvm.povm.POData?.Order?.Header?.OrderHeader?.Department;
            InvoiceHeader.Vendor = asnvm.povm.POData?.Order?.Header?.OrderHeader?.Vendor;



            //PaymentTerms
            if (asnvm.povm.POData?.Order?.Header?.PaymentTerms is List<HeaderPaymentTerm> pterms)
                foreach (var term in pterms)
                {
                    if (term.TermsType is null || term.TermsBasisDateCode is null)
                        continue;

                    var paymentTerm = new BasePaymentTermsModel();
                    paymentTerm.PropertyChanged += PaymentTerm_PropertyChanged;

                    paymentTerm.TermsType = term.TermsType;
                    paymentTerm.TermsBasisDateCode = term.TermsBasisDateCode;
                    paymentTerm.TermsNetDueDate = term.TermsNetDueDate ?? InvoiceHeader.InvoiceDate;

                    if (term.TermsNetDueDays is long tndd)
                    {
                        paymentTerm.TermsNetDueDays = tndd;
                        paymentTerm.TermsNetDueDate.AddDays(tndd);
                    }
                    if (term.TermsDiscountPercentage is double tddp)
                        paymentTerm.TermsDiscountPercentage = tddp;
                    if (term.TermsDiscountDueDays is long tddd)
                        paymentTerm.TermsDiscountDueDays = tddd;

                    InvoiceHeader.PaymentTerms.Add(paymentTerm);
                }

            //Dates
            var shipDate = new BaseDatesModel();
            shipDate.DateTimeQualifier = "011";
            shipDate.Date = asnvm.ShipmentHeader.ShipDate;
            InvoiceHeader.Dates.Add(shipDate);

            //FOBRelatedInstruction
            var fobRelatedInstruction = new BaseFOBRelatedInstruction();
            fobRelatedInstruction.FOBPayCode = "CC";
            fobRelatedInstruction.FOBLocationQualifier = "DE";
            fobRelatedInstruction.FOBTitlePassageCode = "AC";
            fobRelatedInstruction.FOBTitlePassageLocation = await MainViewModel.Current.SettingsViewModel.GetSavedAsync(SettingStorageKeys.FOBTitlePassageLocation);
            InvoiceHeader.FOBRelatedInstruction.Add(fobRelatedInstruction);

            //CarrierInformation
            InvoiceHeader.CarrierInformation.Add(new BaseCarrierInformationModel()
            {
                CarrierTransMethodCode = asnvm.CarrierInformation.CarrierTransMethodCode,
                StatusCode = asnvm.CarrierInformation.StatusCode,
                CarrierAlphaCode = asnvm.CarrierInformation.CarrierAlphaCode,
                CarrierRouting = asnvm.CarrierInformation.CarrierRouting
            });
        }
        public void AddSTandRIAddress(OrderPackItemModel? store)
        {
            if (!InvoiceHeader.QuantityTotals.Any())
            {
                //QuantityTotals
                var quantityTotals = new BaseQuantityTotalsModel()
                {
                    Weight = asnvm.QuantityAndWeight.Weight,
                    Quantity = store is null ? asnvm.QuantityAndWeight.LadingQuantity : store.QuantityAndWeight.LadingQuantity,
                };
                //QuantityUOM bloomingdales
                //CA: Case
                //EA: Each
                //QuantityUOM nordstrom
                //BX: Box
                //CA: Case
                //PK: Package
                quantityTotals.WeightUOM = asnvm.QuantityAndWeight.WeightUOM;
                quantityTotals.QuantityTotalsQualifier = "SQT";
                quantityTotals.QuantityUOM = asnvm.IsBloomingdales || asnvm.IsNordstrom || asnvm.IsNordstromCAN ? "CA" : "CT";
                InvoiceHeader.QuantityTotals.Add(quantityTotals);
            }

            foreach (var stAddress in asnvm.STAddresses)
            {
                var addNum = asnvm.IsNordstrom ? SettingsViewModel.FCtoDCHardcod(stAddress.AddressLocationNumber) : stAddress.AddressLocationNumber;
                if (store is null || (store is not null &&
                     (addNum == store?.Address?.DCAddressLocationNumber || addNum == store?.Address?.DC)))
                {
                    var bam = new BaseAddressModel()
                    {
                        SAddressTypeCode = "ST",
                        SLocationCodeQualifier = "92",
                        DC = stAddress.DC,
                        AddressLocationNumber = addNum,
                        AddressModel = stAddress.AddressModel
                    };
                    InvoiceHeader.Address.Add(bam);

                    InvoiceHeader.Address.Add(new BaseAddressModel()
                    {
                        SAddressTypeCode = "RI",
                        SLocationCodeQualifier = "1",
                        AddressLocationNumber = bam.AddressLocationNumber,
                        DC = bam.DC,
                        AddressModel = bam.AddressModel
                    });
                }
            }

            if (store is not null)
                InvoiceHeader.Address.Add(store.Address);
            else
                foreach (var asnListItem in asnvm.OrderLevel)
                {
                    if (asnListItem.Address.AddressLocationNumber == null)
                        continue;

                    InvoiceHeader.Address.Add(new BaseAddressModel()
                    {
                        SAddressTypeCode = asnListItem.Address.SelectedAddressTypeCode ?? "BY",
                        SLocationCodeQualifier = asnListItem.Address.SelectedLocationCodeQualifier ?? "92",
                        //SIAddressTypeCode = asnListItem.Address.SIAddressTypeCode,
                        //SILocationCodeQualifier = asnListItem.Address.SILocationCodeQualifier,
                        AddressLocationNumber = asnListItem.Address.AddressLocationNumber,
                        DCAddressLocationNumber = asnvm.STAddresses.FirstOrDefault(a => a.AddressLocationNumber == asnListItem.Address.DCAddressLocationNumber)?.AddressLocationNumber ?? asnvm.STAddresses[0].AddressLocationNumber,
                        DC = asnListItem.Address.DC is string s ? s : asnvm.STAddresses[0].AddressLocationNumber,
                        AddressModel = asnListItem.Address.AddressModel,
                    });

                    AddOrderLevelPack(asnListItem);
                }
        }
        public void AddOrderLevelPack(OrderPackItemModel asnListItem)
        {
            foreach (var pack in asnListItem.PackLevelList)
            {
                foreach (var sl in pack.ItemLevel.ShipmentLines)
                {
                    var invoiceLine = InvoiceLines.FirstOrDefault(l => l.InvoiceLine.ConsumerPackageCode == sl.ConsumerPackageCode);
                    if (invoiceLine is null)
                    {
                        invoiceLine = new InvoiceLineItemModel();
                        invoiceLine.InvoiceLine.PropertyChanged += PaymentTerm_PropertyChanged;
                        invoiceLine.InvoiceLine.LineSequenceNumber = Convert.ToString(InvoiceLines.Count + 1);
                        invoiceLine.InvoiceLine.ConsumerPackageCode = sl.ConsumerPackageCode;
                        invoiceLine.InvoiceLine.InvoiceQtyUOM = sl.ShipQtyUOM ?? "EA";

                        foreach (var item in asnvm.POOrderLines)
                        {
                            var li = item.SubLineItems.FirstOrDefault(l => l.LineItem?.OrderLine?.ConsumerPackageCode == sl.ConsumerPackageCode);
                            if (li is not null)
                            {
                                invoiceLine.InvoiceLine.PurchasePriceType = "QTE";
                                invoiceLine.InvoiceLine.PurchasePrice = li.LineItem?.OrderLine?.PurchasePrice ?? 0.0;
                                invoiceLine.InvoiceLine.PurchasePriceBasis = li.LineItem?.OrderLine?.PurchasePriceBasis;
                                invoiceLine.InvoiceLine.VendorPartNumber = li.LineItem?.OrderLine?.VendorPartNumber ?? "";
                                if (li.LineItem?.ProductOrItemDescription is not null)
                                    foreach (var poid in from poid in li.LineItem?.ProductOrItemDescription
                                                         where poid.ProductCharacteristicCode == "08"
                                                         select poid)
                                    {
                                        var bpoid = new BaseProductOrItemDescriptionModel();
                                        invoiceLine.ProductOrItemDescription.Add(bpoid);
                                        bpoid.ProductCharacteristicCode = "08";
                                        bpoid.ProductDescription = poid.ProductDescription ?? "";
                                        break;
                                    }
                                if (li.LineItem?.ChargesAllowances is not null)
                                    foreach (var ca in li.LineItem.ChargesAllowances)
                                    {
                                        if (ca.AllowChrgCode != null && ca.AllowChrgIndicator != null && ca.AllowChrgAgencyCode != null)
                                        {
                                            var baseChargesAllowence = new BaseChargesAllowances()
                                            {
                                                AllowChrgAgency = ca.AllowChrgAgency ?? "",
                                                AllowChrgHandlingDescription = ca.AllowChrgHandlingDescription,
                                                AllowChrgAmt = ca.AllowChrgAmt ?? 0.0,
                                                AllowChrgIndicator = ca.AllowChrgIndicator,
                                                AllowChrgAgencyCode = ca.AllowChrgAgencyCode,
                                                AllowChrgCode = ca.AllowChrgCode,//List[item.SIAllowChrgCode].Item1,
                                            };
                                            //invoiceLine.ChargesAllowances.Add(baseChargesAllowence);
                                            //baseChargesAllowence.AllowChrgIndicator = ca.AllowChrgIndicator ?? "N";
                                            //baseChargesAllowence.AllowChrgAgencyCode = ca.AllowChrgAgencyCode ?? "VI";
                                        }
                                    }
                                break;
                            }
                        }
                        InvoiceLines.Add(invoiceLine);
                    }
                    invoiceLine.InvoiceLine.InvoiceQty += sl.ShipQty;
                }
            }
        }
        public void SetFromInvoice(Invoice invoice)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8601 // Possible null reference assignment.

            if (invoice.Header != null && invoice.Header.InvoiceHeader != null)
            {
                InvoiceHeader = new InvoiceHeaderModel();
                InvoiceHeader.TradingPartnerId = invoice.Header.InvoiceHeader.TradingPartnerId;
                InvoiceHeader.InvoiceNumber = invoice.Header.InvoiceHeader.InvoiceNumber;
                InvoiceHeader.BillOfLadingNumber = invoice.Header.InvoiceHeader.BillOfLadingNumber;
                InvoiceHeader.InvoiceDate = invoice.Header.InvoiceHeader.InvoiceDate != null ? DateTimeOffset.Parse(invoice.Header.InvoiceHeader.InvoiceDate) : asnvm.ShipmentHeader.ShipNoticeDate;
                InvoiceHeader.PurchaseOrderDate = invoice.Header.InvoiceHeader.PurchaseOrderDate;
                InvoiceHeader.PurchaseOrderNumber = invoice.Header.InvoiceHeader.PurchaseOrderNumber;
                InvoiceHeader.Department = invoice.Header.InvoiceHeader.Department;
                InvoiceHeader.Vendor = invoice.Header.InvoiceHeader.Vendor;
                InvoiceHeader.ShipDate = invoice.Header.InvoiceHeader.ShipDate;


                if (invoice.Header.PaymentTerms?.Count > 0)
                {
                    foreach (var item in invoice.Header.PaymentTerms)
                    {
                        InvoiceHeader.PaymentTerms.Add(new BasePaymentTermsModel()
                        {
                            TermsType = item.TermsType,
                            TermsBasisDateCode = item.TermsBasisDateCode,
                            TermsNetDueDays = item.TermsNetDueDays ?? 0,
                            TermsDiscountPercentage = item.TermsDiscountPercentage ?? 0,
                            TermsDiscountDueDays = item.TermsDiscountDueDays ?? 0,
                            TermsNetDueDate = item.TermsNetDueDate != null ? DateTimeOffset.Parse(item.TermsNetDueDate) : InvoiceHeader.InvoiceDate.AddDays(item.TermsNetDueDays ?? 0),
                        });
                    }
                }

                if (invoice.Header.Dates?.Count > 0)
                {
                    foreach (var item in invoice.Header.Dates)
                    {
                        InvoiceHeader.Dates.Add(new BaseDatesModel()
                        {
                            DateTimeQualifier = item.DateTimeQualifier,
                            Date = item.Date != null ? DateTimeOffset.Parse(item.Date) : DateTimeOffset.Now
                        });
                    }
                }

                var addresses = "";
                if (invoice.Header.Address?.Count > 0)
                {
                    foreach (var item in invoice.Header.Address)
                    {
                        InvoiceHeader.Address.Add(new BaseAddressModel()
                        {
                            SAddressTypeCode = item.AddressTypeCode,
                            SLocationCodeQualifier = item.LocationCodeQualifier,
                            AddressLocationNumber = item.AddressLocationNumber,
                            AddressModel = new AddressModel()
                            {
                                Name = item.AddressName,
                                Address = item.Address1,
                                City = item.City,
                                State = item.State,
                                Zip = item.PostalCode,
                                Country = item.Country,
                            },
                        });

                        if (item.AddressTypeCode == "BY")
                            addresses += item.AddressLocationNumber + " ";
                    }
                }

                if (invoice.Header.CarrierInformation?.Count > 0)
                {
                    foreach (var item in invoice.Header.CarrierInformation)
                    {
                        InvoiceHeader.CarrierInformation.Add(new BaseCarrierInformationModel()
                        {
                            CarrierAlphaCode = item.CarrierAlphaCode,
                            CarrierTransMethodCode = item.CarrierTransMethodCode,
                            CarrierRouting = item.CarrierRouting,
                        });
                    }
                }

                if (invoice.Header.Taxes?.Count > 0)
                {
                    foreach (var item in invoice.Header.Taxes)
                    {
                        InvoiceHeader.Taxes.Add(new BaseTaxesModel()
                        {
                            TaxTypeCode = item.TaxTypeCode,
                            JurisdictionQual = item.JurisdictionQual,
                            TaxExemptCode = item.TaxExemptCode,
                            TaxAmount = item.TaxAmount ?? 0,
                            TaxPercent = item.TaxPercent ?? 0,
                            JurisdictionCode = item.JurisdictionCode,
                            TaxId = item.TaxId,
                        });
                    }
                }

                if (invoice.Header.QuantityTotals?.Count > 0)
                {
                    foreach (var item in invoice.Header.QuantityTotals)
                    {
                        InvoiceHeader.QuantityTotals.Add(new BaseQuantityTotalsModel()
                        {
                            QuantityTotalsQualifier = item.QuantityTotalsQualifier,
                            QuantityUOM = item.QuantityUom,
                            WeightUOM = item.WeightUom,
                            Quantity = item.Quantity ?? 0,
                            Weight = item.Weight ?? 0,
                        });
                    }
                }

                if (invoice.Header.FobRelatedInstruction?.Count > 0)
                {
                    foreach (var item in invoice.Header.FobRelatedInstruction)
                    {
                        InvoiceHeader.FOBRelatedInstruction.Add(new BaseFOBRelatedInstruction()
                        {
                            FOBPayCode = item.FobPayCode,
                            FOBLocationQualifier = item.FobLocationQualifier,
                            FOBTitlePassageCode = item.FobTitlePassageCode,
                            FOBTitlePassageLocation = item.FobTitlePassageLocation,
                        });
                    }
                }

                if (invoice.LineItem?.Count > 0)
                {
                    foreach (var line in invoice.LineItem)
                    {
                        InvoiceLineItemModel ilm = new();
                        ilm.InvoiceLine.LineSequenceNumber = line.InvoiceLine.LineSequenceNumber;
                        ilm.InvoiceLine.InvoiceQtyUOM = line.InvoiceLine.InvoiceQtyUom;
                        ilm.InvoiceLine.VendorPartNumber = line.InvoiceLine.VendorPartNumber;
                        ilm.InvoiceLine.ConsumerPackageCode = line.InvoiceLine.ConsumerPackageCode;
                        ilm.InvoiceLine.InvoiceQty = line.InvoiceLine.InvoiceQty ?? 0;
                        ilm.InvoiceLine.PurchasePriceType = line.InvoiceLine.PurchasePriceType;
                        ilm.InvoiceLine.PurchasePrice = line.InvoiceLine.PurchasePrice ?? 0;
                        ilm.InvoiceLine.PurchasePriceBasis = line.InvoiceLine.PurchasePriceBasis;


                        if (line.ChargesAllowances != null)
                            foreach (var item in line.ChargesAllowances)
                            {
                                ilm.ChargesAllowances.Add(new BaseChargesAllowances()
                                {
                                    AllowChrgIndicator = item.AllowChrgIndicator,
                                    AllowChrgAgencyCode = item.AllowChrgAgencyCode,
                                    AllowChrgAgency = item.AllowChrgAgency,
                                    AllowChrgCode = item.AllowChrgCode,//List[item.SIAllowChrgCode].Item1,
                                    AllowChrgHandlingDescription = item.AllowChrgHandlingDescription,
                                    AllowChrgAmt = item.AllowChrgAmt ?? 0,
                                });
                            }

                        if (line.ProductOrItemDescription != null)
                        {
                            foreach (var item in line.ProductOrItemDescription)
                            {
                                ilm.ProductOrItemDescription.Add(new BaseProductOrItemDescriptionModel()
                                {
                                    ProductCharacteristicCode = item.ProductCharacteristicCode,
                                    ProductDescription = item.ProductDescription,
                                });
                            }
                        }

                        //var lines = await MainViewModel.Current.SettingsViewModel.GetUPCLines();
                        //var li = lines.FirstOrDefault(l => l.GTIN == line.InvoiceLine.ConsumerPackageCode);
                        //var message = string.Join(",",
                        //    PoId, ASNId, Bol, Id, addresses,
                        //    line.InvoiceLine.ConsumerPackageCode, li?.Product, li?.ProductDescription, li?.ColorDescripton, ilm.InvoiceLine.InvoiceQty, ilm.InvoiceLine.PurchasePrice,
                        //    InvoiceHeader.InvoiceDate.ToString("MM-dd-yyyy"), invoice.Summary?.TotalAmount);
                        //Debug.WriteLine(message);

                        InvoiceLines.Add(ilm);
                    }
                }

                Summary.TotalAmount = invoice.Summary?.TotalAmount ?? 0;
                Summary.TotalSalesAmount = invoice.Summary?.TotalSalesAmount ?? 0;
                Summary.TotalTermsDiscountAmount = invoice.Summary?.TotalTermsDiscountAmount ?? 0;
                Summary.InvoiceAmtDueByTermsDate = invoice.Summary?.InvoiceAmtDueByTermsDate ?? 0;
                Summary.TotalLineItemNumber = invoice.Summary?.TotalLineItemNumber ?? 0;
            }

#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Status = DocumentStatus.Sent;
        }
        public void SetSummary()
        {
            Summary.TotalSalesAmount = 0;
            Summary.TotalLineItemNumber = InvoiceLines.Count;
            foreach (var item in InvoiceLines)
            {
                Summary.TotalSalesAmount += item.InvoiceLine.PurchasePrice * item.InvoiceLine.InvoiceQty;
                Summary.TotalAmount = Summary.TotalSalesAmount;
                foreach (var ca in item.ChargesAllowances)
                {
                    if (ca.AllowChrgIndicator == "A")
                        Summary.TotalAmount -= ca.AllowChrgAmt;
                    else if (ca.AllowChrgIndicator == "C")
                        Summary.TotalAmount += ca.AllowChrgAmt;
                }
            }
        }
        #endregion

        #region OnCommandActivated
        public override async Task<Exception?> OnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {
                    case "CommandBack":
                        asnvm.povm.SelectedInvoiceViewModel = null;
                        break;

                    case "CommandExportAsCSV":
                        await MainViewModel.Current.ExcelUtil.ExportInvoice(this);
                        break;

                    case "CommandAddPaymentTerms":
                        var paymentTerm = new BasePaymentTermsModel();
                        paymentTerm.PropertyChanged += PaymentTerm_PropertyChanged;
                        InvoiceHeader.PaymentTerms.Add(paymentTerm);
                        break;

                    case "CommandSend":
                        await CommandSend(true);
                        break;

                    case "CommandAddDates":
                        InvoiceHeader.Dates.Add(new BaseDatesModel());
                        break;

                    case "CommandAddFOBRelatedInstruction":
                        InvoiceHeader.FOBRelatedInstruction.Add(new BaseFOBRelatedInstruction());
                        break;

                    case "CommandAddCarrierInformation":
                        InvoiceHeader.CarrierInformation.Add(new BaseCarrierInformationModel());
                        break;

                    case "CommandAddQuantityTotals":
                        InvoiceHeader.QuantityTotals.Add(new BaseQuantityTotalsModel());
                        break;

                    case "CommandAddAddress":
                        InvoiceHeader.Address.Add(new BaseAddressModel()
                        {
                            SAddressTypeCode = "BY",
                            SLocationCodeQualifier = "92",
                        });
                        break;

                    case "CommandAddInvoiceLine":
                        InvoiceLines.Add(new InvoiceLineItemModel());
                        break;

                    case "CommandAddTax":
                        InvoiceHeader.Taxes.Add(new BaseTaxesModel());
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
        private Invoice GenInvoice()
        {
            var invoice = new Invoice();
            invoice.Header = new SPSCommerceSDK.Models.Invoices.Header();
            invoice.Header.InvoiceHeader = new InvoiceHeader();
            invoice.Header.InvoiceHeader.TradingPartnerId = asnvm.IsSaks ? TradingPartnerModel.Default_SaksInvoiceTradingPartnerId : InvoiceHeader.TradingPartnerId;
            invoice.Header.InvoiceHeader.InvoiceNumber = InvoiceHeader.InvoiceNumber;
            invoice.Header.InvoiceHeader.BillOfLadingNumber = InvoiceHeader.BillOfLadingNumber;
            invoice.Header.InvoiceHeader.InvoiceDate = InvoiceHeader.InvoiceDate.ToSpsDateString();
            invoice.Header.InvoiceHeader.PurchaseOrderDate = InvoiceHeader.PurchaseOrderDate;
            invoice.Header.InvoiceHeader.PurchaseOrderNumber = InvoiceHeader.PurchaseOrderNumber;
            invoice.Header.InvoiceHeader.Department = InvoiceHeader.Department;
            invoice.Header.InvoiceHeader.Vendor = InvoiceHeader.Vendor;
            invoice.Header.InvoiceHeader.ShipDate = InvoiceHeader.ShipDate;
            if (asnvm.IsNordstrom || asnvm.IsNordstromCAN)
                invoice.Header.InvoiceHeader.InternalOrderNumber = InvoiceHeader.InvoiceNumber;

            invoice.Header.References = new List<SPSCommerceSDK.Models.Invoices.HeaderReference>();
            invoice.Header.References.Add(new SPSCommerceSDK.Models.Invoices.HeaderReference()
            {
                ReferenceQual = "SI",
                ReferenceId = asnvm.ShipmentHeader.ShipmentIdentification,
            });

            if (InvoiceHeader.PaymentTerms.Count > 0)
            {
                invoice.Header.PaymentTerms = new List<PaymentTerm>();
                foreach (var item in InvoiceHeader.PaymentTerms)
                {
                    invoice.Header.PaymentTerms.Add(new PaymentTerm()
                    {
                        TermsType = item.TermsType,
                        TermsBasisDateCode = item.TermsBasisDateCode,
                        TermsNetDueDays = item.TermsNetDueDays,
                        TermsDiscountPercentage = item.TermsDiscountPercentage,
                        TermsDiscountDueDays = item.TermsDiscountDueDays,
                        TermsNetDueDate = item.TermsNetDueDate.ToSpsDateString(),
                    });
                }
            }

            if (InvoiceHeader.Dates.Count > 0)
            {
                invoice.Header.Dates = new List<SPSCommerceSDK.Models.Invoices.HeaderDate>();
                foreach (var item in InvoiceHeader.Dates)
                {
                    invoice.Header.Dates.Add(new SPSCommerceSDK.Models.Invoices.HeaderDate()
                    {
                        DateTimeQualifier = item.DateTimeQualifier,
                        Date = item.Date.ToString("yyyy-MM-dd")
                    });
                }
            }

            if (InvoiceHeader.Address.Count > 0)
            {
                invoice.Header.Address = new List<SPSCommerceSDK.Models.Invoices.HeaderAddress>();
                foreach (var item in InvoiceHeader.Address)
                {
                    var staddylocnum = item.AddressLocationNumber;
                    invoice.Header.Address.Add(new SPSCommerceSDK.Models.Invoices.HeaderAddress()
                    {
                        AddressTypeCode = asnvm.IsBloomingdales && item.SelectedAddressTypeCode == "BY" ? "BT" : item.SelectedAddressTypeCode,

                        LocationCodeQualifier = item.SelectedLocationCodeQualifier,
                        AddressLocationNumber = staddylocnum,
                        Address1 = item.AddressModel?.Address,
                        City = item.AddressModel?.City,
                        State = item.AddressModel?.State,
                        PostalCode = item.AddressModel?.Zip,
                        Country = item.AddressModel?.Country,
                        AddressName = item.AddressModel?.Name,
                    });
                }
            }

            if (InvoiceHeader.CarrierInformation.Count > 0)
            {
                invoice.Header.CarrierInformation = new List<SPSCommerceSDK.Models.Invoices.HeaderCarrierInformation>();
                foreach (var item in InvoiceHeader.CarrierInformation)
                {
                    invoice.Header.CarrierInformation.Add(new SPSCommerceSDK.Models.Invoices.HeaderCarrierInformation()
                    {
                        CarrierAlphaCode = item.CarrierAlphaCode,
                        CarrierTransMethodCode = item.CarrierTransMethodCode,
                        CarrierRouting = item.CarrierRouting,
                    });
                }
            }

            if (InvoiceHeader.Taxes.Count > 0)
            {
                invoice.Header.Taxes = new List<SPSCommerceSDK.Models.Invoices.HeaderTax>();
                foreach (var item in InvoiceHeader.Taxes)
                {
                    invoice.Header.Taxes.Add(new SPSCommerceSDK.Models.Invoices.HeaderTax()
                    {
                        TaxTypeCode = item.TaxTypeCode,
                        JurisdictionQual = item.JurisdictionQual,
                        TaxExemptCode = item.TaxExemptCode,
                        TaxAmount = item.TaxAmount,
                        TaxPercent = item.TaxPercent,
                        JurisdictionCode = item.JurisdictionCode,
                        TaxId = item.TaxId,
                    });
                }
            }

            if (InvoiceHeader.QuantityTotals.Count > 0)
            {
                invoice.Header.QuantityTotals = new List<SPSCommerceSDK.Models.Invoices.QuantityTotal>();
                foreach (var item in InvoiceHeader.QuantityTotals)
                {
                    invoice.Header.QuantityTotals.Add(new SPSCommerceSDK.Models.Invoices.QuantityTotal()
                    {
                        QuantityTotalsQualifier = item.QuantityTotalsQualifier,
                        QuantityUom = asnvm.IsBloomingdales || asnvm.IsNordstrom || asnvm.IsNordstromCAN ? "CA" : item.QuantityUOM,
                        WeightUom = item.WeightUOM,
                        Quantity = item.Quantity,
                        Weight = item.Weight,
                    });
                }
            }

            if (InvoiceHeader.FOBRelatedInstruction.Count > 0)
            {
                invoice.Header.FobRelatedInstruction = new List<SPSCommerceSDK.Models.Invoices.FobRelatedInstruction>();
                foreach (var item in InvoiceHeader.FOBRelatedInstruction)
                {
                    invoice.Header.FobRelatedInstruction.Add(new SPSCommerceSDK.Models.Invoices.FobRelatedInstruction()
                    {
                        FobPayCode = item.FOBPayCode,
                        FobLocationQualifier = item.FOBLocationQualifier,
                        FobTitlePassageCode = item.FOBTitlePassageCode,
                        FobTitlePassageLocation = item.FOBTitlePassageLocation,
                    });
                }
            }

            invoice.LineItem = new List<SPSCommerceSDK.Models.Invoices.LineItem>();
            foreach (var line in InvoiceLines)
            {
                var lineItem = new SPSCommerceSDK.Models.Invoices.LineItem();
                lineItem.InvoiceLine = new InvoiceLine()
                {
                    LineSequenceNumber = line.InvoiceLine.LineSequenceNumber,
                    ConsumerPackageCode = line.InvoiceLine.ConsumerPackageCode,
                    VendorPartNumber = line.InvoiceLine.VendorPartNumber,
                    InvoiceQty = line.InvoiceLine.InvoiceQty,
                    PurchasePrice = line.InvoiceLine.PurchasePrice,
                    InvoiceQtyUom = line.InvoiceLine.InvoiceQtyUOM,
                    PurchasePriceType = line.InvoiceLine.PurchasePriceType,
                    PurchasePriceBasis = line.InvoiceLine.PurchasePriceBasis,
                };
                if (line.ChargesAllowances.Count > 0)
                {
                    lineItem.ChargesAllowances = new List<SPSCommerceSDK.Models.Invoices.LineItemChargesAllowance>();
                    foreach (var item in line.ChargesAllowances)
                    {
                        lineItem.ChargesAllowances.Add(new SPSCommerceSDK.Models.Invoices.LineItemChargesAllowance()
                        {
                            AllowChrgIndicator = item.AllowChrgIndicator,
                            AllowChrgAgencyCode = item.AllowChrgAgencyCode,
                            AllowChrgAgency = item.AllowChrgAgency,
                            AllowChrgCode = item.AllowChrgCode,//List[item.SIAllowChrgCode].Item1,
                            AllowChrgHandlingDescription = item.AllowChrgHandlingDescription,
                            AllowChrgAmt = item.AllowChrgAmt,
                        });
                    }
                }
                if (line.ProductOrItemDescription.Count > 0)
                {
                    lineItem.ProductOrItemDescription = new List<SPSCommerceSDK.Models.Invoices.LineItemProductOrItemDescription>();
                    foreach (var item in line.ProductOrItemDescription)
                    {
                        lineItem.ProductOrItemDescription.Add(new SPSCommerceSDK.Models.Invoices.LineItemProductOrItemDescription()
                        {
                            ProductCharacteristicCode = item.ProductCharacteristicCode,
                            ProductDescription = item.ProductDescription,
                        });
                    }
                }

                invoice.LineItem.Add(lineItem);
            }

            invoice.Summary = new SPSCommerceSDK.Models.Invoices.Summary()
            {
                TotalAmount = Summary.TotalAmount,
                TotalSalesAmount = Summary.TotalSalesAmount,
                TotalTermsDiscountAmount = Summary.TotalTermsDiscountAmount > 0 ? Summary.TotalTermsDiscountAmount : null,
                InvoiceAmtDueByTermsDate = Summary.InvoiceAmtDueByTermsDate > 0 ? Summary.InvoiceAmtDueByTermsDate : null,
                TotalLineItemNumber = InvoiceLines.Count
            };

            return invoice;
        }
        #endregion

        #region IHaveIncrementals
        private DateTime fileCreationTime;
        [JsonIgnore]
        public DateTime FileCreationTime
        {
            get => fileCreationTime;
            set => SetProperty(ref fileCreationTime, value);
        }
        private bool isDupe;
        [JsonIgnore]
        public bool IsDupe
        {
            get => isDupe;
            set => SetProperty(ref isDupe, value);
        }
        [JsonIgnore]
        public int Id
        {
            get
            {
                if (int.TryParse(InvoiceHeader.InvoiceNumber, out int id))
                    return id;
                else
                    return 0;
            }
            set => InvoiceHeader.InvoiceNumber = Convert.ToString(value);
        }
        [JsonIgnore]
        public int Bol
        {
            get
            {
                if (int.TryParse(InvoiceHeader.BillOfLadingNumber, out int id))
                    return id;
                else
                    return 0;
            }
            set => InvoiceHeader.BillOfLadingNumber = Convert.ToString(value);
        }
        [JsonIgnore]
        public string PoId { get => asnvm.PoId; }
        [JsonIgnore]
        public string ASNId { get => asnvm.ASNId; }
        [JsonIgnore]
        public string StringId { get => InvoiceHeader.InvoiceNumber; }
        [JsonIgnore]
        public TradingPartnerModel TradingPartner { get => asnvm.TradingPartner; set => throw new NotImplementedException(); }
        [JsonIgnore]
        public DateTimeOffset Date => InvoiceHeader.InvoiceDate;

        public string CheckId(DocumentType dt) => dt switch
        {
            DocumentType.PO850 => PoId,
            DocumentType.ASN856 => ASNId,
            DocumentType.IN810 => StringId,
            DocumentType.BOL => Convert.ToString(Bol),
            _ => StringId,
        };
        #endregion

        #region BaseHasCanSendViewModel
        [JsonIgnore]
        public override string TradingPartnerId => InvoiceHeader.TradingPartnerId;
        [JsonIgnore]
        public override string SendFileName => $"IN{InvoiceHeader.InvoiceNumber.Replace("-", "")}.json";
        [JsonIgnore]
        public override string SendFileSaveDirectory => FilesService.SentInvoiceFolder;
        [JsonIgnore]
        public override string SaveFileName => InvoiceHeader.InvoiceNumber + ".json";
        [JsonIgnore]
        public override string SaveFileDirectory => Path.Combine(FilesService.SavedInvoiceFolder, InvoiceHeader.PurchaseOrderNumber ?? "unknown", asnvm.ShipmentHeader.ShipmentIdentification);
        [JsonIgnore]
        public override PurchaseOrderViewModel PurchaseOrder => asnvm.povm;

        public override void DocumentStatusChanged()
        {
            foreach (var l in InvoiceLines)
                l.CanAddRemoveables = CanAddRemoveables;

            if (asnvm is null || InvoiceHeader is null)
                return;
            asnvm.povm.DisplayStatus = $"Shipment: {asnvm.ShipmentHeader.ShipmentIdentification} {MainViewModel.Current.GetDocumentStatusText(asnvm.Status)} Invoice: {InvoiceHeader.InvoiceNumber}";
            asnvm.povm.DisplayStatus += MainViewModel.Current.GetDocumentStatusText(Status);

            OnPropertyChanged("Status");
        }
        public override void RemoveFromVMItemsList()
        {
            asnvm.InvoiceViewModels.Remove(this);
        }
        public override object GetSendObject()
        {
            return GenInvoice();
        }
        public override void SetForceEnabled()
        {
            foreach (var o in InvoiceLines)
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
            return InternalINVSettings;
        }

        [JsonIgnore]
        public override string S3KeyName => $"{PoId}-{ASNId}-{InvoiceHeader.InvoiceNumber}";
        [JsonIgnore]
        public override string S3DirName => "invoices";

        public override async Task GetSetDBTableRow()
        {
            if (DBTable == null)
                DBTable = new();

            DBTable.ASNNumber = ASNId;
            DBTable.INVNumber = InvoiceHeader.InvoiceNumber;
            DBTable.BOLNumber = InvoiceHeader.BillOfLadingNumber;
            DBTable.PONumber = PoId;
            DBTable.INVDate = invoiceHeader.InvoiceDate.ToSpsDateString();
            DBTable.S3KeyName = S3KeyName;
            DBTable.Settings = InternalINVSettings;

            DBTable.BYAddressIds.Clear();
            foreach (var item in InvoiceHeader.Address)
            {
                if (item.AddressLocationNumber == null)
                    throw new IndexOutOfRangeException("item.AddressLocationNumber == null");

                if (item.SAddressTypeCode.StartsWith("B"))
                    DBTable.BYAddressIds.Add(item.AddressLocationNumber);
                
            }

            await DynamoService.Current.Store(DBTable);
        }
        internal override Task<bool> LoadFromS3(string jsonStream)
        {
            var o = JsonSerializer.Deserialize<SPSCommerceSDK.Models.Invoices.Invoice>(jsonStream);
            if (o != null)
            {
                if (InvoicesViewModel.Current.ReadInvoices.FirstOrDefault(rs => rs.Filename == S3KeyName) is ReadInvoicesFile rf)
                {
                    rf.Invoice = o;
                }
                else
                {
                    InvoicesViewModel.Current.ReadInvoices.Add(new ReadInvoicesFile()
                    {
                        Filename = S3KeyName,
                        Invoice = o,
                    });
                }
                SetFromInvoice(o);

                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        } 
        #endregion

        private void PaymentTerm_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is InvoiceLineModel il)
            {
                if (e.PropertyName == "InvoiceQty" ||
                    e.PropertyName == "PurchasePrice")
                    SetSummary();
            }
            else if (sender is BasePaymentTermsModel pt)
            {
                if (e.PropertyName == "TermsDiscountPercentage" ||
                    e.PropertyName == "TermsDiscountDueDays")
                {
                    if (pt.TermsDiscountPercentage <= 0)
                    {
                        Summary.TotalTermsDiscountAmount = 0;
                        Summary.InvoiceAmtDueByTermsDate = Summary.TotalAmount;
                    }
                    else
                    {
                        Summary.TotalTermsDiscountAmount = (pt.TermsDiscountPercentage / 100) * Summary.TotalAmount; //(percentage / 100) * totalNumber;
                        Summary.InvoiceAmtDueByTermsDate = Summary.TotalAmount - Summary.TotalTermsDiscountAmount;
                    }
                }
            }
        }
    }
}