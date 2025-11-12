namespace Juniper.Core.Models
{
    public class OrderPackItemModel : ABaseHasRequiredObject
    {
        #region OrderHeader
        ///<summary>
        /// "OrderHeader": {
        ///    "type": "object",
        ///    "additionalProperties": false,
        ///    "required": [],
        ///    "properties": {
        ///        "DepositorOrderNumber": {
        ///            "description": "Identifying number for a warehouse shipping order assigned by the depositor",
        ///            "examples": [
        ///                "8888888877"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "InternalOrderNumber": {
        ///            "description": "ERP generated number assigned as unique identifier for each incoming order",
        ///            "examples": [
        ///                "456789-123"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "InternalOrderDate": {
        ///            "description": "ERP generated internal date for each incoming order",
        ///            "examples": [
        ///                "2013-09-18"
        ///            ],
        ///            "type": "string",
        ///            "format": "date"
        ///        },
        ///        "InvoiceNumber": {
        ///            "description": "Unique identifier assigned by the billing party",
        ///            "examples": [
        ///                "99999-123"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "InvoiceDate": {
        ///            "description": "Date Invoice was created",
        ///            "examples": [
        ///                "2013-10-05"
        ///            ],
        ///            "type": "string",
        ///            "format": "date"
        ///        },
        ///        "PurchaseOrderNumber": {
        ///            "description": "Identifying number for the purchase order assigned by the buying organization",
        ///            "examples": [
        ///                "1010101010101"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "ReleaseNumber": {
        ///            "description": "Identifying number for the purchase order relating back to the original blanket order",
        ///            "examples": [
        ///                "XYZ999999"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "PurchaseOrderDate": {
        ///            "description": "Date the purchase order was created",
        ///            "examples": [
        ///                "2013-08-29"
        ///            ],
        ///            "type": "string",
        ///            "format": "date"
        ///        },
        ///        "Department": {
        ///            "description": "Name or number identifying an area wherein merchandise is categorized within a store",
        ///            "examples": [
        ///                "026"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "DepartmentDescription": {
        ///            "description": "Free form text to describe the name or number identifying an area wherein merchandise is categorized within a store",
        ///            "examples": [
        ///                "Electronics"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "Vendor": {
        ///            "description": "Number assigned by buyer that uniquely identifies the vendor",
        ///            "examples": [
        ///                "99999999"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "JobNumber": {
        ///            "description": "Project number assigned to a standard reorder purchase order",
        ///            "examples": [
        ///                "777770000555555"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "Division": {
        ///            "description": "Different entities belonging to the same parent company",
        ///            "examples": [
        ///                "Sam's Club"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "CustomerAccountNumber": {
        ///            "description": "End consumer's account number",
        ///            "examples": [
        ///                "123456789"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "CustomerOrderNumber": {
        ///            "description": "End consumer's order number",
        ///            "examples": [
        ///                "987654321"
        ///            ],
        ///            "type": "string"
        ///        },
        ///        "DeliveryDate": {
        ///            "type": "string",
        ///            "format": "date"
        ///        },
        ///        "DeliveryTime": {
        ///            "type": "string",
        ///            "format": "time"
        ///        }
        ///    }
        ///},
        /// </summary>

        ///<example>
        /// "OrderHeader" : {
        ///  "PurchaseOrderNumber" : "0007743608",
        ///  "Department" : "0832"
        ///}
        /// </example>

        ///<summary>
        ///PurchaseOrderNumber: Identifying number for the purchase order assigned by the buying organization
        /// </summary>
        private string? purchaseOrderNumber;
        public string? PurchaseOrderNumber
        {
            get => purchaseOrderNumber;
            set => SetProperty(ref purchaseOrderNumber, value);
        }

        ///<summary>
        ///Department: Name or number identifying an area wherein merchandise is categorized within a store
        /// </summary>
        private string? department;
        public string? Department
        {
            get => department;
            set => SetProperty(ref department, value);
        }

        #endregion

        #region QuantityAndWeight
        ///<example>
        ///   "QuantityAndWeight" : [ {
        ///      "PackingMedium" : "CTN",
        ///      "PackingMaterial" : "25",
        ///      "LadingQuantity" : 1,
        ///      "WeightQualifier" : "G",
        ///      "Weight" : 3.0,
        ///      "WeightUOM" : "LB"
        ///    } ],
        /// </example>

        public ObservableCollection<BaseQuantityAndWeightModel> QuantityAndWeightCollection { get; } = new ObservableCollection<BaseQuantityAndWeightModel>();
        public BaseQuantityAndWeightModel QuantityAndWeight { get; set; } //= new BaseQuantityAndWeightModel();
        #endregion

        #region Address
        /// <example>
        ///    "Address" : [ {
        ///      "AddressTypeCode" : "BY",
        ///      "LocationCodeQualifier" : "92",
        ///      "AddressLocationNumber" : "0402"
        ///    } ]
        /// </example>

        public ObservableCollection<BaseAddressModel> AddressCollection { get; } = new ObservableCollection<BaseAddressModel>();
        public BaseAddressModel Address { get; set; } //= new BaseAddressModel();
        #endregion

        #region PackLevel
        ///<example>
        /// "PackLevel" : [ {
        ///      "Pack" : {
        ///        "PackLevelType" : "P",
        ///        "ShippingSerialID" : "00081006543001816490"
        ///      },
        ///      "ItemLevel" : [ {
        ///        "ShipmentLine" : {
        ///          "ConsumerPackageCode" : "810094061432",
        ///          "ShipQty" : 1.0,
        ///          "ShipQtyUOM" : "EA"
        ///        }
        ///      }]
        ///} ]
        /// </example>

        [NotNullOrEmptyCollection(ErrorMessage = "Theres No Products Listed")]
        public ObservableCollection<PackItemModel> PackLevelList { get; set; } = new ObservableCollection<PackItemModel>();
        //public PackItemModel PackLevel { get; set; } //= new PackItemModel();
        #endregion

        public override async Task<Exception?> OnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {

                    case "CommandAddPack":
                        if (MainViewModel.Current.OrdersViewModel.SelectedPO?.SelectedASNViewModel != null)
                        {
                            int serialReference = MainViewModel.Current.ShipmentsViewModel.GetLastSerialReference(MainViewModel.Current.OrdersViewModel.SelectedPO.SelectedASNViewModel);
                            PackLevelList.Add(ShipmentsViewModel.GetNewPack(ref serialReference));
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
                return await Task.FromResult(ex);
            }
            return null;
        }
    }

    public class PackItemModel : ABaseHasRequiredObject
    {
        #region Pack
        /// <summary>
        /// PackLevelType: Qualifier Indicator that defines the level the label information is provided or a carton reference number
        /// </summary>
        public List<Tuple<string, string>> PackLevelType { get; } = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("P","Pack"),
                new Tuple<string, string>("T","Tare/Pallet"),
            };
        private int siPackLevelType = 0;
        public int SIPackLevelType
        {
            get => siPackLevelType;
            set => SetProperty(ref siPackLevelType, value);
        }
        public string SelectedPackLevelType => PackLevelType[siPackLevelType].Item1;

        /// <summary>
        /// ShippingSerialID:  
        /// Serial Shipping Container Code[SSCC] and Application Identifier[00] indicates the shipment or parts of shipment.
        /// This field includes both the SSCC[18 digits] and the Application Identifier[2 digits], which should be 20 digits in length
        /// </summary>
        private string shippingSerialID;

        [Required(ErrorMessage = "Serial Shipping Container Code[SSCC] is required", AllowEmptyStrings = false)]
        public string ShippingSerialID
        {
            get => shippingSerialID;
            set => SetProperty(ref shippingSerialID, value);
        }
        #endregion

        //public ObservableCollection<ItemModel> ItemLevel { get; } = new ObservableCollection<ItemModel>();
        private ItemModel itemLevel;
        public ItemModel ItemLevel
        {
            get { return itemLevel; }
            set { SetProperty(ref itemLevel, value); }
        }

        public PackItemModel()
        {
            itemLevel = new ItemModel();
            itemLevel.ShipmentLines.CollectionChanged += ShipmentLines_CollectionChanged;
        }
        public override async Task<Exception?> OnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {

                    case "CommandAddShipmentLine":
                        if (MainViewModel.Current.OrdersViewModel.SelectedPO?.SelectedASNViewModel?.POOrderLines is ObservableCollection<POOrderLineModel> POOrderLines)
                        {
                            foreach (var poLine in POOrderLines)
                            {
                                if (!poLine.IsSelected) continue;
                                foreach (var line in poLine.SubLineItems)
                                {
                                    ItemLevel.ShipmentLines.Add(ShipmentsViewModel.GetNewShipmentLine(null,
                                        1,
                                        line.LineItem.OrderLine?.OrderQtyUom,
                                        line.LineItem.OrderLine?.VendorPartNumber,
                                        true,
                                        poLine.SubLineItems.GetAllSublineItems()));
                                    break;
                                }
                            }       
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
                return await Task.FromResult(ex);
            }
            return null;
        }
        private void ShipmentLines_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ItemLevel));
        }
        //public ItemModel ItemLevel { get; set; } = new ItemModel();
    }

    public class ItemModel : ABaseHasRequiredObject
    {
        [NotNullOrEmptyCollection(ErrorMessage = "Theres No Products Listed")]
        public ObservableCollection<ShipmentLine> ShipmentLines { get; set; } = new ObservableCollection<ShipmentLine>();
    }

    public class ShipmentLine : ABaseHasRequiredObject
    {

        [JsonIgnore]
        public ObservableCollection<string> CPCLineItems { get; set; } = new ObservableCollection<string>();
        private string? cpcLineItems;
        public string? CPCLineItem
        {
            get => cpcLineItems;
            set
            {
                SetProperty(ref cpcLineItems, value);
                if (value != null)
                    ConsumerPackageCode = value;
            }
        }



        /// <summary>
        /// ShipQty: Quantity that has already or is scheduled to be shipped/delivered
        /// </summary>
        private double shipQty;
        public double ShipQty
        {
            get => shipQty;
            set => SetProperty(ref shipQty, value);
        }
        public double OriginalShip { get; set; }

        ///<summary>
        ///ShipQtyUOM: Unit of measure used with the ShipQty
        /// </summary>
        private string? shipQtyUOM;
        public string? ShipQtyUOM
        {
            get => shipQtyUOM;
            set
            {
                if(value != shipQtyUOM)
                {
                    if (value != null && value.ToLower() == "each")
                        value = "EA";

                    SetProperty(ref shipQtyUOM, value);
                }
            }
        }
        /// <summary>
        /// ConsumerPackageCode: Consumer level or customer unit product identification number
        /// </summary>
        private string consumerPackageCode;

        [Required(ErrorMessage = "Consumer Package Code is required", AllowEmptyStrings = false)]
        public string ConsumerPackageCode
        {
            get => consumerPackageCode;
            set
            {
                if (value != null && consumerPackageCode != value)
                {
                    if (MainViewModel.Current.ExcelUtil.LastReadUPCList.FirstOrDefault(l => l.GTIN == value) is { } li)
                    {
                        SizeDescriptionNum = li.SizeDescriptionNumVal;
                        ColorDescription = li.ColorDescripton;
                        VendorPartNumber = li.Product;
                        SizeDescription = li.SizeDescription;
                    }

                    SetProperty(ref consumerPackageCode, value);
                }
            }
        }
        /// <summary>
        /// ProductId
        /// </summary>
        public string? VendorPartNumber { get; set; }
        public int SizeDescriptionNum { get; set; }
        public string ColorDescription { get; set; }
        public string SizeDescription { get; set; }
    }
}