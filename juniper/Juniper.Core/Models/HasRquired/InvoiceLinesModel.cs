namespace Juniper.Core.Models
{
    public class InvoiceLineModel : ABaseHasRequiredObject
    {
        private string lineSequenceNumber;
        [Required(ErrorMessage = "Line Sequence Number is required", AllowEmptyStrings = false)]
        public string LineSequenceNumber
        {
            get => lineSequenceNumber;
            set => SetProperty(ref lineSequenceNumber, value);
        }

        private string? consumerPackageCode;
        public string? ConsumerPackageCode
        {
            get => consumerPackageCode;
            set => SetProperty(ref consumerPackageCode, value);
        }

        private string vendorPartNumber;
        [Required(ErrorMessage = "Vendor Part Number is required", AllowEmptyStrings = false)]
        public string VendorPartNumber
        {
            get => vendorPartNumber;
            set => SetProperty(ref vendorPartNumber, value);
        }

        private double invoiceQty;
        public double InvoiceQty
        {
            get => invoiceQty;
            set => SetProperty(ref invoiceQty, value);
        }

        [JsonIgnore]
        public List<Tuple<string, string>> InvoiceQtyUOMList { get; set; } = new List<Tuple<string, string>>();
        private string siInvoiceQtyUOM = "EA";
        public string InvoiceQtyUOM
        {
            get => siInvoiceQtyUOM.ToLower() == "each" ? "EA" : siInvoiceQtyUOM;
            set
            {
                if (value != null && value != siInvoiceQtyUOM)
                {
                    if (value.ToLower() == "each")
                        value = "EA";

                    SetProperty(ref siInvoiceQtyUOM, value);
                }
            }
        }

        [JsonIgnore]
        public List<Tuple<string, string>> PurchasePriceTypeList { get; set; } = new List<Tuple<string, string>>();
        private string siPurchasePriceType;
        public string PurchasePriceType
        {
            get => siPurchasePriceType;
            set => SetProperty(ref siPurchasePriceType, value);
        }

        private double purchasePrice;
        public double PurchasePrice
        {
            get => purchasePrice;
            set => SetProperty(ref purchasePrice, value);
        }

        private string? purchasePriceBasis;
        public string? PurchasePriceBasis
        {
            get => purchasePriceBasis;
            set => SetProperty(ref purchasePriceBasis, value);
        }


        public InvoiceLineModel(FieldsBase invoiceFields)
        {
            InvoiceQtyUOMList.AddRange(invoiceFields.GetFieldsBy("InvoiceQtyUOM"));
            PurchasePriceTypeList.AddRange(invoiceFields.GetFieldsBy("PurchasePriceType"));
        }
        [JsonConstructor]
        public InvoiceLineModel()
            : this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }
    }
}