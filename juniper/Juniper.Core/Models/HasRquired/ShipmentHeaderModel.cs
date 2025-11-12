namespace Juniper.Core.Models
{
    ///<example>
    ///"ShipmentHeader" : {
    ///  "TradingPartnerId" : "591855JUNIPER08",
    ///  "ShipmentIdentification" : "266",
    ///  "ShipDate" : "2021-12-07",
    ///  "TsetPurposeCode" : "00",
    ///  "ShipNoticeDate" : "2021-12-06",
    ///  "ShipNoticeTime" : "14:27:00",
    ///  "ASNStructureCode" : "0001",
    ///  "BillOfLadingNumber" : "1865"
    ///},
    ///</example>
    public class BaseShipmentHeaderModel : ABaseHasRequiredObject
    {
        [JsonConstructor]
        public BaseShipmentHeaderModel()
         : this(MainViewModel.Current.FieldsService.ShipmentsFields)
        {
        }
        public BaseShipmentHeaderModel(FieldsBase shipmentFields)
        {
            TsetPurposeCodeList.AddRange(shipmentFields.GetFieldsBy("TsetPurposeCode"));
            ASNStructureCodeList.AddRange(shipmentFields.GetFieldsBy("ASNStructureCode"));
        }

        /// <summary>
        /// TsetPurposeCode: Code identifying purpose or function of the transmission
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> TsetPurposeCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siTsetPurposeCode = "00";
        public string TsetPurposeCode
        {
            get => siTsetPurposeCode;
            set => SetProperty(ref siTsetPurposeCode, value);
        }

        /// <summary>
        /// ASNStructureCode: Code is the reflection of the structure of the document
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> ASNStructureCodeList { get; set; } = new List<Tuple<string, string>>();
        private string siASNStructureCode = "0001";
        public string ASNStructureCode
        {
            get => siASNStructureCode;
            set => SetProperty(ref siASNStructureCode, value);
        }

        /// <summary>
        /// TradingPartnerId :Unique internal identifier defined by SPS Commerce which identifies the relationship
        /// </summary>
        private string tradingPartnerId;
        [Required(ErrorMessage = "Trading Partner Id is required", AllowEmptyStrings = false)]
        public string TradingPartnerId
        {
            get => tradingPartnerId;
            set => SetProperty(ref tradingPartnerId, value);
        }

        /// <summary>
        /// TODO: 
        /// ShipmentIdentification: Identification number assigned to the shipment by the shipper that uniquely identifies the shipment from origin to ultimate destination and is not subject to modification
        /// </summary>
        private string shipmentIdentification = "0";
        [Required(ErrorMessage = "Shipment Identification is required", AllowEmptyStrings = false)]
        public string ShipmentIdentification
        {
            get => shipmentIdentification;
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    SetProperty(ref shipmentIdentification, value);
                }
            }
        }


        /// <summary>
        /// BillOfLadingNumber :A shipper assigned number that outlines the ownership, terms of carriage and is a receipt of goods
        /// </summary>
        private string billOfLadingNumber = "0";
        [Required(ErrorMessage = "Bill Of Lading Number is required", AllowEmptyStrings = false)]
        public string BillOfLadingNumber
        {
            get => billOfLadingNumber;
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    SetProperty(ref billOfLadingNumber, value);
                }
            }
        }



        private string? carrierProNumber;
        [Required(ErrorMessage = "Carrier Pro Number is required", AllowEmptyStrings = false)]
        public string? CarrierProNumber
        {
            get => carrierProNumber;
            set => SetProperty(ref carrierProNumber, value);
        }

        /// <summary>
        /// ShipDate: Date shipment will leave the ship from location
        /// </summary>
        private DateTimeOffset shipDate = new DateTimeOffset(DateTime.Now);
        public DateTimeOffset ShipDate
        {
            get => shipDate;
            set => SetProperty(ref shipDate, value);
        }


        /// <summary>
        /// CurrentScheduledDeliveryDate: Current scheduled date of delivery
        /// </summary>
        private DateTimeOffset currentScheduledDeliveryDate = new DateTimeOffset(DateTime.Now);
        public DateTimeOffset CurrentScheduledDeliveryDate
        {
            get => currentScheduledDeliveryDate;
            set => SetProperty(ref currentScheduledDeliveryDate, value);
        }


        /// <summary>
        /// ShipNoticeDate: Date the document was created
        /// </summary>
        private DateTimeOffset shipNoticeDate = new DateTimeOffset(DateTime.Now);
        public DateTimeOffset ShipNoticeDate
        {
            get => shipNoticeDate;
            set => SetProperty(ref shipNoticeDate, value);
        }

        /// <summary>
        /// TODO:
        /// ShipNoticeTime: Time the document was created. [All standard XML formats are accepted]
        /// </summary>
        private TimeSpan? shipNoticeTime = DateTime.Now.TimeOfDay;
        public TimeSpan? ShipNoticeTime
        {
            get => shipNoticeTime;
            set => SetProperty(ref shipNoticeTime, value);
        }

    }
}