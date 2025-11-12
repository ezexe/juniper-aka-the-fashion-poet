namespace Juniper.Core.Models
{
    public class POResultDataModel : ObservableObject
    {
        private Result result;
        public Result Result
        {
            get => result;
            set => SetProperty(ref result, value);
        }

        private Order? order;
        public Order? Order
        {
            get => order;
            set => SetProperty(ref order, value);
        }
        private string json;
        public string JsonPath
        {
            get => json;
            set => SetProperty(ref json, value);
        }
        public bool FromDynamo { get; set; }

        //private string json;
        //public string Json
        //{
        //    get => json;
        //    set => SetProperty(ref json, value);
        //}
    }
    
    public class POOrderLineModel : ObservableObject
    {
        private LineItem lineItem;
        public LineItem LineItem
        {
            get => lineItem;
            set => SetProperty(ref lineItem, value);
        }
        public string Item1 => LineItem.OrderLine?.ConsumerPackageCode ?? "null";

        private bool isSelected;
        public bool IsSelected
        {
            get => isSelected;
            set 
            {
                if(isSelected != value)
                {
                    SetProperty(ref isSelected, value);
                }
            }
        }

        private bool wasSent;
        public bool WasSent
        {
            get => wasSent;
            set => SetProperty(ref wasSent, value);
        }


        private double maxQty = 0;
        public double MaxQty
        {
            get => maxQty;
            set => SetProperty(ref maxQty, value);
        }

        [JsonIgnore]
        public ObservableCollection<POOrderLineModel> SubLineItems { get; } = new ObservableCollection<POOrderLineModel>();

        public void AddSelf()
        {
            SubLineItems.Add(this);
        }

        public POOrderLineModel()
        {
            SubLineItems = new ObservableCollection<POOrderLineModel>();
        }
    }
}