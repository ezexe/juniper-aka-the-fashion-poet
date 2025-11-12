namespace Juniper.Core.Models
{
    ///<example>
    ///"QuantityAndWeight" : [ {
    ///  "PackingMedium" : "CTN",
    ///  "PackingMaterial" : "CT",
    ///  "LadingQuantity" : 25,
    ///  "WeightQualifier" : "G",
    ///  "Weight" : 3.0,
    ///  "WeightUOM" : "LB"
    ///} ]
    ///</example>
    public class BaseQuantityAndWeightModel : ABaseHasRequiredObject
    {

        [JsonConstructor]
        public BaseQuantityAndWeightModel()
         : this(MainViewModel.Current.FieldsService.ShipmentsFields)
        {
        }
        public BaseQuantityAndWeightModel(FieldsBase shipmentFields)
        {
            PackingMediumList.AddRange(shipmentFields.GetFieldsBy("PackingMedium"));
            PackingMaterialList.AddRange(shipmentFields.GetFieldsBy("PackingMaterial"));
            WeightQualifierList.AddRange(shipmentFields.GetFieldsBy("WeightQualifier"));
            WeightUOMList.AddRange(shipmentFields.GetFieldsBy("WeightUOM"));
        }
        /// <summary>
        /// PackingMedium: Code identifying the type of packaging
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> PackingMediumList { get; set; } = new List<Tuple<string, string>>();
        private string siPackingMedium = "CTN";
        public string PackingMedium
        {
            get => siPackingMedium;
            set => SetProperty(ref siPackingMedium, value);
        }

        /// <summary>
        /// PackingMaterial: Code identifying the type of packaging material 
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> PackingMaterialList { get; set; } = new List<Tuple<string, string>>();
        private string siPackingMaterial;
        public string PackingMaterial
        {
            get => siPackingMaterial;
            set => SetProperty(ref siPackingMaterial, value);
        }

        /// <summary>
        /// WeightQualifier: Qualifier Code defining the type of weight
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> WeightQualifierList { get; set; } = new List<Tuple<string, string>>();
        private string siWeightQualifier;
        public string WeightQualifier
        {
            get => siWeightQualifier;
            set => SetProperty(ref siWeightQualifier, value);
        }

        /// <summary>
        /// WeightUOM: The unit of measure used in relation to a weight
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> WeightUOMList { get; set; } = new List<Tuple<string, string>>();
        private string siWeightUOM;
        public string WeightUOM
        {
            get => siWeightUOM;
            set => SetProperty(ref siWeightUOM, value);
        }

        /// <summary>
        /// LadingQuantity: Number of units/pieces of the lading commodity
        /// </summary>
        private long ladingQuantity;
        public long LadingQuantity
        {
            get => ladingQuantity;
            set => SetProperty(ref ladingQuantity, value);
        }

        /// <summary>
        /// Weight:  A unit of weight
        /// </summary>
        private double weight;
        [Required(ErrorMessage = "Weight is required", AllowEmptyStrings = false)]
        public double Weight
        {
            get => weight;
            set => SetProperty(ref weight, value);
        }
    }
}