namespace Juniper.Core.Models
{
    public class BaseTaxesModel : ABaseHasRequiredObject
    {
        [JsonConstructor]
        public BaseTaxesModel()
            : this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }
        public BaseTaxesModel(FieldsBase invoiceFields)
        {
            TaxTypeCodeList.AddRange(invoiceFields.GetFieldsBy("TaxTypeCode"));
            JurisdictionQualList.AddRange(invoiceFields.GetFieldsBy("JurisdictionQual"));
            TaxExemptCodeList.AddRange(invoiceFields.GetFieldsBy("TaxExemptCode"));
        }

        [JsonIgnore]
        public List<Tuple<string, string>> TaxTypeCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siTaxTypeCode;
        public string TaxTypeCode
        {
            get => siTaxTypeCode;
            set => SetProperty(ref siTaxTypeCode, value);
        }

        private double taxAmount;
        public double TaxAmount
        {
            get => taxAmount;
            set => SetProperty(ref taxAmount, value);
        }

        private double taxPercent;
        public double TaxPercent
        {
            get => taxPercent;
            set => SetProperty(ref taxPercent, value);
        }

        [JsonIgnore]
        public List<Tuple<string, string>> JurisdictionQualList { get; set; } = new List<Tuple<string, string>>();
        private string siJurisdictionQual;
        public string JurisdictionQual
        {
            get => siJurisdictionQual;
            set => SetProperty(ref siJurisdictionQual, value);
        }

        private string jurisdictionCode;
        [Required(ErrorMessage = "Jurisdiction Code is required", AllowEmptyStrings = false)]
        public string JurisdictionCode
        {
            get => jurisdictionCode;
            set => SetProperty(ref jurisdictionCode, value);
        }


        [JsonIgnore]
        public List<Tuple<string, string>> TaxExemptCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siTaxExemptCode;
        public string TaxExemptCode
        {
            get => siTaxExemptCode;
            set => SetProperty(ref siTaxExemptCode, value);
        }

        private string taxID;
        [Required(ErrorMessage = "Tax Id is required", AllowEmptyStrings = false)]
        public string TaxId
        {
            get => taxID;
            set => SetProperty(ref taxID, value);
        }
    }
}