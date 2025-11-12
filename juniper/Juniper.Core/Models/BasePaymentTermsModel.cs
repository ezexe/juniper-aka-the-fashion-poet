namespace Juniper.Core.Models
{
    public class BasePaymentTermsModel : ObservableObject
    {
        [JsonConstructor]
        public BasePaymentTermsModel()
            : this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }

        public BasePaymentTermsModel(FieldsBase invoiceFields)
        {
            TermsTypeList.AddRange(invoiceFields.GetFieldsBy("TermsType"));
            TermsBasisDateCodeList.AddRange(invoiceFields.GetFieldsBy("TermsBasisDateCode"));
        }

        [JsonIgnore]
        public List<Tuple<string, string>> TermsTypeList { get; set; } = new List<Tuple<string, string>>();
        private string siTermsType;
        public string TermsType
        {
            get => siTermsType;
            set => SetProperty(ref siTermsType, value);
        }

        [JsonIgnore]
        public List<Tuple<string, string>> TermsBasisDateCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siTermsBasisDateCode;
        public string TermsBasisDateCode
        {
            get => siTermsBasisDateCode;
            set => SetProperty(ref siTermsBasisDateCode, value);
        }

        private DateTimeOffset termsNetDueDate;
        public DateTimeOffset TermsNetDueDate
        {
            get => termsNetDueDate;
            set => SetProperty(ref termsNetDueDate, value);
        }


        private long termsNetDueDays;
        public long TermsNetDueDays
        {
            get => termsNetDueDays;
            set => SetProperty(ref termsNetDueDays, value);
        }

        private double termsDiscountPercentage;
        public double TermsDiscountPercentage
        {
            get => termsDiscountPercentage;
            set => SetProperty(ref termsDiscountPercentage, value);
        }

        private long termsDiscountDueDays;
        public long TermsDiscountDueDays
        {
            get => termsDiscountDueDays;
            set => SetProperty(ref termsDiscountDueDays, value);
        }

    }
}