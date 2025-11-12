namespace Juniper.Core.Models
{
    public class UPCsModel : ObservableObject
    {
        private string product;
        /// <summary>
        /// VendorPartNumber
        /// </summary>
        public string Product
        {
            get => product;
            set => SetProperty(ref product, value);
        }

        private string productDescription;
        public string ProductDescription
        {
            get => productDescription;
            set => SetProperty(ref productDescription, value);
        }

        private string gTIN;
        /// <summary>
        /// ConsumerPackageCode
        /// </summary>
        public string GTIN
        {
            get => gTIN;
            set => SetProperty(ref gTIN, value);
        }

        private string colorCode;
        /// <summary>
        /// ProductColorCode
        /// </summary>
        public string ColorCode
        {
            get => colorCode;
            set => SetProperty(ref colorCode, value);
        }

        private string colorDescripton;
        /// <summary>
        /// ProductColorDescription
        /// </summary>
        public string ColorDescripton
        {
            get => colorDescripton;
            set => SetProperty(ref colorDescripton, value);
        }

        private string sizeDescription;
        /// <summary>
        /// ProductSizeDescription
        /// </summary>
        public string SizeDescription
        {
            get => sizeDescription;
            set => SetProperty(ref sizeDescription, value);
        }
        public string ShortSizeDescription =>
           SizeDescription == "X Large" ? "XL" :
           SizeDescription == "Large" ? "L" :
           SizeDescription == "Medium" ? "M" :
           SizeDescription == "Small" ? "S" :
           SizeDescription == "X Small" ? "XS" :
           SizeDescription == "Assorted" ? "ASST" :
           "-1";
        public int SizeDescriptionNumVal =>
           SizeDescription == "X Large" ? 5 :
           SizeDescription == "Large" ? 4 :
           SizeDescription == "Medium" ? 3 :
           SizeDescription == "Small" ? 2 :
           SizeDescription == "X Small" ? 1 :
           SizeDescription == "Assorted" ? 0 :
           -1;

        private string createDate;
        public string CreateDate
        {
            get => createDate;
            set => SetProperty(ref createDate, value);
        }

        private string xs;
        public string XS
        {
            get => xs;
            set => SetProperty(ref xs, value);
        }

        private string s;
        public string S
        {
            get => s;
            set => SetProperty(ref s, value);
        }

        private string m;
        public string M
        {
            get => m;
            set => SetProperty(ref m, value);
        }

        private string l;
        public string L
        {
            get => l;
            set => SetProperty(ref l, value);
        }

        private string xl;
        public string XL
        {
            get => xl;
            set => SetProperty(ref xl, value);
        }
        public string PrePackSizeNumber =>
            SizeDescription == "X Large" ? XL :
            SizeDescription == "Large" ? L :
            SizeDescription == "Medium" ? M :
            SizeDescription == "Small" ? S :
            SizeDescription == "X Small" ? XS :
            SizeDescription == "Assorted" ? ASST :
            "-1";

        private string asst;
        public string ASST
        {
            get => asst;
            set => SetProperty(ref asst, value);
        }

        //private string category;
        //public string Category
        //{
        //    get => category;
        //    set => SetProperty(ref category, value);
        //}

        //private string name;
        //public string Name
        //{
        //    get => name;
        //    set => SetProperty(ref name, value);
        //}

        //private string salesprice;
        //public string Salesprice
        //{
        //    get => salesprice;
        //    set => SetProperty(ref salesprice, value);
        //}

        //private string cost;
        //public string Cost
        //{
        //    get => cost;
        //    set => SetProperty(ref cost, value);
        //}

        //private string bloomiesSize;
        //public string BloomiesSize
        //{
        //    get => bloomiesSize;
        //    set => SetProperty(ref bloomiesSize, value);
        //}
    }
}