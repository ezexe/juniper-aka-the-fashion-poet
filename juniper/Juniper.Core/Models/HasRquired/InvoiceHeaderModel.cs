namespace Juniper.Core.Models
{
    /// <summary>
    ///     "InvoiceHeader" : {
    ///  "TradingPartnerId" : "AUOALLJUNIPER08",
    ///  "InvoiceNumber" : "11683",
    ///  "InvoiceDate" : "2021-09-21",
    ///  "PurchaseOrderDate" : "2021-10-08",
    ///  "PurchaseOrderNumber" : "4440680",
    ///  "Department" : "0828",
    ///  "Vendor" : "0005179153",
    ///  "ShipDate" : "2021-10-25"
    ///},
    /// </summary>
    public class InvoiceHeaderModel : ABaseHasRequiredObject
    {
        private string tradingPartnerId;
        [Required(ErrorMessage = "Trading Partner Id is required", AllowEmptyStrings = false)]
        public string TradingPartnerId
        {
            get => tradingPartnerId;
            set => SetProperty(ref tradingPartnerId, value);
        }

        public int MaxInvoiceNumberLength { get; set; } = 22;
        private string invoiceNumber = "0";
        [Required(ErrorMessage = "Invoice Number is required", AllowEmptyStrings = false)]
        public string InvoiceNumber
        {
            get => invoiceNumber;
            set 
            {
                if (value != null && invoiceNumber != value)
                {
                    value = value.Trim();

                    if (value.Length > MaxInvoiceNumberLength)
                        value = value.Remove(MaxInvoiceNumberLength - 1);


                    SetProperty(ref invoiceNumber, value);
                }
            }
        }

        private string billOfLadingNumber;
        [Required(ErrorMessage = "Bill Of Lading Number is required", AllowEmptyStrings = false)]
        public string BillOfLadingNumber
        {
            get => billOfLadingNumber;
            set
            {
                if (value != null && billOfLadingNumber != value)
                {
                    value = value.Trim();

                    if (value.Length > MaxInvoiceNumberLength)
                        value = value.Remove(MaxInvoiceNumberLength - 1);


                    SetProperty(ref billOfLadingNumber, value);
                }
            }
        }

        private DateTimeOffset invoiceDate = new DateTimeOffset(DateTime.Now);
        public DateTimeOffset InvoiceDate
        {
            get => invoiceDate;
            set => SetProperty(ref invoiceDate, value);
        }

        private string? purchaseOrderDate;
        public string? PurchaseOrderDate
        {
            get => purchaseOrderDate;
            set => SetProperty(ref purchaseOrderDate, value);
        }

        private string? purchaseOrderNumber;
        public string? PurchaseOrderNumber
        {
            get => purchaseOrderNumber;
            set => SetProperty(ref purchaseOrderNumber, value);
        }

        private string? department;
        public string? Department
        {
            get => department;
            set => SetProperty(ref department, value);
        }

        private string? vendor;
        public string? Vendor
        {
            get => vendor;
            set => SetProperty(ref vendor, value);
        }

        private string? shipDate;
        public string? ShipDate
        {
            get => shipDate;
            set => SetProperty(ref shipDate, value);
        }

        [NotNullOrEmptyCollection]
        public ObservableCollection<BasePaymentTermsModel> PaymentTerms { get; set; } = new ObservableCollection<BasePaymentTermsModel>();
        [NotNullOrEmptyCollection]
        public ObservableCollection<BaseDatesModel> Dates { get; set; } = new ObservableCollection<BaseDatesModel>();
        [NotNullOrEmptyCollection(2, ErrorMessage = "There is not enough addresses listed")]
        public ObservableCollection<BaseAddressModel> Address { get; set; } = new ObservableCollection<BaseAddressModel>();
        [NotNullOrEmptyCollection]
        public ObservableCollection<BaseCarrierInformationModel> CarrierInformation { get; set; } = new ObservableCollection<BaseCarrierInformationModel>();
        [NotNullOrEmptyCollection]
        public ObservableCollection<BaseQuantityTotalsModel> QuantityTotals { get; set; } = new ObservableCollection<BaseQuantityTotalsModel>();
        [NotNullOrEmptyCollection]
        public ObservableCollection<BaseFOBRelatedInstruction> FOBRelatedInstruction { get; set; } = new ObservableCollection<BaseFOBRelatedInstruction>();

        public ObservableCollection<BaseTaxesModel> Taxes { get; set; } = new ObservableCollection<BaseTaxesModel>();
    }
}