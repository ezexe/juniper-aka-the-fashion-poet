namespace Juniper.Core.Models
{
    public class BaseDatesModel : ObservableObject
    {
        [JsonConstructor]
        public BaseDatesModel()
            : this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }
        public BaseDatesModel(FieldsBase invoiceFields)
        {
            DateTimeQualifierList.AddRange(invoiceFields.GetFieldsBy("DateTimeQualifier"));
        }
        [JsonIgnore]
        public List<Tuple<string, string>> DateTimeQualifierList { get; set; } = new List<Tuple<string, string>>();
        private string siDateTimeQualifier;
        public string DateTimeQualifier
        {
            get => siDateTimeQualifier;
            set => SetProperty(ref siDateTimeQualifier, value);
        }

        private DateTimeOffset date = DateTime.Now;
        public DateTimeOffset Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }
    }
}