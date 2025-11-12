namespace Juniper.Core.Models
{
    public class BaseQuantityTotalsModel : ObservableObject
    {
        [JsonConstructor]
        public BaseQuantityTotalsModel()
            : this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }
        public BaseQuantityTotalsModel(FieldsBase invoiceFields)
        {
            QuantityTotalsQualifierList.AddRange(invoiceFields.GetFieldsBy("QuantityTotalsQualifier"));
            QuantityUOMList.AddRange(invoiceFields.GetFieldsBy("QuantityUOM"));
            WeightUOMList.AddRange(invoiceFields.GetFieldsBy("WeightUOM"));
        }
        [JsonIgnore]
        public List<Tuple<string, string>> QuantityTotalsQualifierList { get; set; } = new List<Tuple<string, string>>();
        private string siQuantityTotalsQualifier;
        public string QuantityTotalsQualifier
        {
            get => siQuantityTotalsQualifier;
            set => SetProperty(ref siQuantityTotalsQualifier, value);
        }
        [JsonIgnore]
        public List<Tuple<string, string>> QuantityUOMList { get; set; } = new List<Tuple<string, string>>();
        private string siQuantityUOM;
        public string QuantityUOM
        {
            get => siQuantityUOM;
            set => SetProperty(ref siQuantityUOM, value);
        }

        [JsonIgnore]
        public List<Tuple<string, string>> WeightUOMList { get; set; } = new List<Tuple<string, string>>();
        private string siWeightUOM;
        public string WeightUOM
        {
            get => siWeightUOM;
            set => SetProperty(ref siWeightUOM, value);
        }


        private double quantity;
        public double Quantity
        {
            get => quantity;
            set => SetProperty(ref quantity, value);
        }

        private double weight;
        public double Weight
        {
            get => weight;
            set => SetProperty(ref weight, value);
        }
    }
}