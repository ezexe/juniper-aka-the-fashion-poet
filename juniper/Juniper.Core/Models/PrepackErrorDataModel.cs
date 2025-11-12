namespace Juniper.Core.Models
{
    public class PrepackErrorDataModel : ObservableObject
    {
        private string store;
        public string Store
        {
            get { return store; }
            set { SetProperty(ref store, value); }
        }

        private string orderdBreakdown;
        public string OrderdBreakdown
        {
            get { return orderdBreakdown; }
            set { SetProperty(ref orderdBreakdown, value); }
        }

        private double orderdNumber;
        public double OrderdNumber
        {
            get { return orderdNumber; }
            set { SetProperty(ref orderdNumber, value); }
        }

        private UPCsModel product;
        public UPCsModel Product
        {
            get { return product; }
            set { SetProperty(ref product, value); }
        }
    }
}
