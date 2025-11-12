namespace Juniper.Core.Models
{
    ///    "FOBRelatedInstruction" : [ {
    ///       "FOBPayCode" : "CC",
    ///       "FOBTitlePassageCode" : "AC",
    ///       "FOBTitlePassageLocation" : "Brooklyn, NY"
    ///     } ],
    public class BaseFOBRelatedInstruction : ABaseHasRequiredObject
    {
        [JsonConstructor]
        public BaseFOBRelatedInstruction()
            : this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }
        public BaseFOBRelatedInstruction(FieldsBase invoiceFields)
        {
            FOBPayCodeList.AddRange(invoiceFields.GetFieldsBy("FOBPayCode"));
            FOBTitlePassageCodeList.AddRange(invoiceFields.GetFieldsBy("FOBTitlePassageCode"));
            FOBLocationQualifierList.AddRange(invoiceFields.GetFieldsBy("FOBLocationQualifier"));
        }
        [JsonIgnore]
        public List<Tuple<string, string>> FOBPayCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siFOBPayCode;
        public string FOBPayCode
        {
            get => siFOBPayCode;
            set => SetProperty(ref siFOBPayCode, value);
        }
        [JsonIgnore]
        public List<Tuple<string, string>> FOBTitlePassageCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siFOBTitlePassageCode;
        public string FOBTitlePassageCode
        {
            get => siFOBTitlePassageCode;
            set => SetProperty(ref siFOBTitlePassageCode, value);
        }
        [JsonIgnore]
        public List<Tuple<string, string>> FOBLocationQualifierList { get; set; } = new List<Tuple<string, string>>();
        private string siFOBLocationQualifier;
        public string FOBLocationQualifier
        {
            get => siFOBLocationQualifier;
            set => SetProperty(ref siFOBLocationQualifier, value);
        }

        private string fOBTitlePassageLocation = "Brooklyn, NY";
        [Required(ErrorMessage = "FOB Title Passage Location is required", AllowEmptyStrings = false)]
        public string FOBTitlePassageLocation
        {
            get => fOBTitlePassageLocation;
            set => SetProperty(ref fOBTitlePassageLocation, value);
        }

    }
}