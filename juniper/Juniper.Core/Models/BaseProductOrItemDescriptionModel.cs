namespace Juniper.Core.Models
{
    public class BaseProductOrItemDescriptionModel : ObservableObject
    {
        [JsonConstructor]
        public BaseProductOrItemDescriptionModel()
            : this(MainViewModel.Current.FieldsService.InvoiceFields)
        {
        }
        public BaseProductOrItemDescriptionModel(FieldsBase invoiceFields)
        {
            ProductCharacteristicCodeList.AddRange(invoiceFields.GetFieldsBy("ProductCharacteristicCode"));
        }
        [JsonIgnore]
        public List<Tuple<string, string>> ProductCharacteristicCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siProductCharacteristicCode;
        public string ProductCharacteristicCode
        {
            get => siProductCharacteristicCode;
            set => SetProperty(ref siProductCharacteristicCode, value);
        }

        //"description": "Product Description",
       // public string ProductCharacteristicCode => "08";

        private string productDescription;
        public string ProductDescription
        {
            get => productDescription;
            set => SetProperty(ref productDescription, value);
        }

        ////"description": "Color Description",
        //public string ColorDescriptionCode => "73";
        //private string? colorDescription;
        //public string? ColorDescription
        //{
        //    get => colorDescription;
        //    set => SetProperty(ref colorDescription, value);
        //}

        ////"description": "Size Description",
        //public string SizeDescriptionCode => "74";
        //private string? sizeDescription;
        //public string? SizeDescription
        //{
        //    get => sizeDescription;
        //    set => SetProperty(ref sizeDescription, value);
        //}
    }
}