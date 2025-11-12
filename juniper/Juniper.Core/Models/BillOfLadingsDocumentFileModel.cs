namespace Juniper.Core.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BOLDocumentFileAttribute : Attribute
    {
        // Private fields.
        private string name;

        // This constructor defines required parameters: name.
        public BOLDocumentFileAttribute(string key)
        {
            this.name = key;
        }

        // Define properties.
        // This is a read-only attribute.
        public virtual string Name
        {
            get { return name; }
        }
    }

    public class BillOfLadingsDocumentFileModel : ObservableObject
    {
        private string path;
        public string Path
        {
            get => path;
            set => SetProperty(ref path, value);
        }

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { SetProperty(ref displayName, value); }
        }

        private string addressLocationNumber;
        public string AddressLocationNumber
        {
            get { return addressLocationNumber; }
            set 
            {
                if (int.TryParse(value, out _))
                    value = value.AddInFrontTill("0", 4);
                SetProperty(ref addressLocationNumber, value);
            }
        }


        private string docDate;
        [BOLDocumentFile("DOCDATE")]
        public string DocDate
        {
            get { return docDate; }
            set { SetProperty(ref docDate, value); }
        }

        private string billOfLadingNumber;
        [BOLDocumentFile("BOLNUM")]
        public string BillOfLadingNumber
        {
            get { return billOfLadingNumber; }
            set { SetProperty(ref billOfLadingNumber, value); }
        }

        private string carrierName;
        [BOLDocumentFile("CNSTRING")]
        public string CarrierName
        {
            get { return carrierName; }
            set { SetProperty(ref carrierName, value); }
        }

        private string scac;
        [BOLDocumentFile("SCACSTRING")]
        public string SCAC
        {
            get { return scac; }
            set { SetProperty(ref scac, value); }
        }

        private string addressName;
        [BOLDocumentFile("STNAME")]
        public string STAddressName
        {
            get { return addressName; }
            set { SetProperty(ref addressName, value); }
        }

        private string btName;
        [BOLDocumentFile("TPFCBTNAME")]
        public string BTAddressName
        {
            get { return btName; }
            set { SetProperty(ref btName, value); }
        }

        private string stAddress;
        [BOLDocumentFile("STSTREET")]
        public string STAddress
        {
            get { return stAddress; }
            set { SetProperty(ref stAddress, value); }
        }

        private string btAddress;
        [BOLDocumentFile("TPFCBTSTREET")]
        public string BTAddress
        {
            get { return btAddress; }
            set { SetProperty(ref btAddress, value); }
        }

        private string stCity;
        [BOLDocumentFile("STCITY")]
        public string STCity
        {
            get { return stCity; }
            set { SetProperty(ref stCity, value); }
        }

        private string btCity;
        [BOLDocumentFile("TPFCBTCITY,")]
        public string BTCity
        {
            get { return btCity; }
            set { SetProperty(ref btCity, value); }
        }

        private string stState;
        [BOLDocumentFile("STSTATE")]
        public string STState
        {
            get { return stState; }
            set { SetProperty(ref stState, value); }
        }

        private string btState;
        [BOLDocumentFile("TPFCBTSTATE")]
        public string BTState
        {
            get { return btState; }
            set { SetProperty(ref btState, value); }
        }

        private string stZip;
        [BOLDocumentFile("STZIP")]
        public string STZip
        {
            get { return stZip; }
            set { SetProperty(ref stZip, value); }
        }

        private string btZip;
        [BOLDocumentFile("TPFCBTZIP")]
        public string BTZip
        {
            get { return btZip; }
            set { SetProperty(ref btZip, value); }
        }

        private int carrierInformationQtyTtl;
        [BOLDocumentFile("CIQTYTOTAL")]
        public int CarrierInformationQtyTtl
        {
            get { return carrierInformationQtyTtl; }
            set { SetProperty(ref carrierInformationQtyTtl, value); }
        }

        private double carrierInformationWeightTtl;
        [BOLDocumentFile("CIWEIGHTTOTAL")]
        public double CarrierInformationWeightTtl
        {
            get { return carrierInformationWeightTtl; }
            set { SetProperty(ref carrierInformationWeightTtl, value); }
        }

        private int cOIGTP;
        [BOLDocumentFile("COIGTP")]
        public int GrandTotalPackagesgs
        {
            get => cOIGTP;
            set => SetProperty(ref cOIGTP, value);
        }

        private double cOIGTW;
        [BOLDocumentFile("COIGTW")]
        public double GrandTotalWeight
        {
            get => cOIGTW;
            set => SetProperty(ref cOIGTW, value);
        }


        public List<PurchaseOrderBOLTotals> PurchaseOrders { get; } = new List<PurchaseOrderBOLTotals>();
    }

    public class PurchaseOrderBOLTotals
    {
        public PurchaseOrderViewModel PurchaseOrder { get; set; }

        public int CarrierInformationQtyTtl { get; set; }
        public int CarrierInformationWeightTtl { get; set; }
        public string AdditionalStyleInfo { get; set; }
    }
}
