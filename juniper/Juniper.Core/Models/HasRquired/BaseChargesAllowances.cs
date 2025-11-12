namespace Juniper.Core.Models
{
    /// <summary>
    /// "ChargesAllowances": [
    ///   {
    ///     "AllowChrgIndicator": "N",
    ///     "AllowChrgAgencyCode": "VI",
    ///     "AllowChrgAgency": "HA",
    ///     "AllowChrgHandlingDescription": "HANG"
    ///   }
    /// ]
    /// </summary>
    public class BaseChargesAllowances : ABaseHasRequiredObject
    {
        [JsonConstructor]
        public BaseChargesAllowances()
            :this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }
        public BaseChargesAllowances(FieldsBase invoiceFields)
        {
            AllowChrgIndicatorList.AddRange(invoiceFields.GetFieldsBy("AllowChrgIndicator"));
            AllowChrgAgencyCodeList.AddRange(invoiceFields.GetFieldsBy("AllowChrgAgencyCode"));
            AllowChrgCodeList.AddRange(invoiceFields.GetFieldsBy("AllowChrgCode"));
        }
        [JsonIgnore]
        public List<Tuple<string, string>> AllowChrgIndicatorList { get; set; } = new List<Tuple<string, string>>();
        private string? siAllowChrgIndicator;
        public string? AllowChrgIndicator
        {
            get => siAllowChrgIndicator;
            set => SetProperty(ref siAllowChrgIndicator, value);
        }
        [JsonIgnore]
        public List<Tuple<string, string>> AllowChrgAgencyCodeList { get; set; } = new List<Tuple<string, string>>();
        private string? siAllowChrgAgencyCode;
        public string? AllowChrgAgencyCode
        {
            get => siAllowChrgAgencyCode;
            set => SetProperty(ref siAllowChrgAgencyCode, value);
        }
        [JsonIgnore]
        public List<Tuple<string, string>> AllowChrgCodeList { get; set; } = new List<Tuple<string, string>>();
        private string allowChrgCode = "UNDF";
        public string AllowChrgCode
        {
            get => allowChrgCode;
            set => SetProperty(ref allowChrgCode, value);
        }

        private string allowChrgAgency;
        [Required(ErrorMessage = "Allow Chrg Agency is required", AllowEmptyStrings = false)]
        public string AllowChrgAgency
        {
            get => allowChrgAgency;
            set => SetProperty(ref allowChrgAgency, value);
        }

        private string? allowChrgHandlingDescription;
        public string? AllowChrgHandlingDescription
        {
            get => allowChrgHandlingDescription;
            set => SetProperty(ref allowChrgHandlingDescription, value);
        }

        private double allowChrgAmt;
        public double AllowChrgAmt
        {
            get => allowChrgAmt;
            set => SetProperty(ref allowChrgAmt, value);
        }


    }
}