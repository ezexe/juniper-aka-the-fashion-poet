namespace Juniper.Core.Models
{
    ///<summary>
    ///"CarrierInformation": {
    ///     "type": "array",
    ///     "items": {
    ///         "type": "object",
    ///         "additionalProperties": false,
    ///         "required": [],
    ///         "properties": {
    ///             "StatusCode": {
    ///                 "description": "Code indicating the status of an order or shipment or the disposition of any difference between the quantity ordered and the quantity shipped for a line item or transaction",
    ///                 "type": "string"
    ///             },
    ///             "CarrierTransMethodCode": {
    ///                 "description": "Code specifying the method or type of transportation for the shipment",
    ///                 "type": "string"
    ///             },
    ///             "CarrierAlphaCode": {
    ///                 "description": "Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National Motor Freight Traffic Association identifying transportation companies",
    ///                 "examples": [
    ///                     "EMSY",
    ///                     "UPGF"
    ///                 ],
    ///                 "type": "string"
    ///             },
    ///             "CarrierRouting": {
    ///                 "description": "Free-form description of the routing/requested routing for shipment or the originating carrier's identity",
    ///                 "examples": [
    ///                     "ONTRAC",
    ///                     "UPS Ground Freight"
    ///                 ],
    ///                 "type": "string"
    ///             },
    ///             "EquipmentDescriptionCode": {
    ///                 "description": "Code identifying type of equipment used for shipment",
    ///                 "type": "string"
    ///             },
    ///             "CarrierEquipmentInitial": {
    ///                 "description": "Prefix or alphabetic part of an equipment unit's identifying number",
    ///                 "examples": [
    ///                     "FEDX",
    ///                     "XBGQ"
    ///                 ],
    ///                 "type": "string"
    ///             },
    ///             "CarrierEquipmentNumber": {
    ///                 "description": "Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for equipment number is preferred]",
    ///                 "examples": [
    ///                     "4806196209"
    ///                 ],
    ///                 "type": "string"
    ///             },
    ///             "EquipmentType": {
    ///                 "type": "string"
    ///             },
    ///             "OwnershipCode": {
    ///                 "type": "string"
    ///             },
    ///             "RoutingSequenceCode": {
    ///                 "type": "string"
    ///             },
    ///             "TransitDirectionCode": {
    ///                 "description": "The point of origin and point of direction",
    ///                 "type": "string"
    ///             },
    ///             "TransitTimeQual": {
    ///                 "type": "string"
    ///             },
    ///             "TransitTime": {
    ///                 "type": "number"
    ///             },
    ///             "ServiceLevelCodes": {
    ///                 "type": "array",
    ///                 "items": {
    ///                     "type": "object",
    ///                     "additionalProperties": false,
    ///                     "required": [],
    ///                     "properties": {
    ///                         "ServiceLevelCode": {
    ///                             "description": "Code indicating the level of transportation service or the billing service offered by the transportation carrier",
    ///                             "type": "string"
    ///                         }
    ///                     }
    ///                 }
    ///             },
    ///             "Address": {
    ///                 "type": "array",
    ///                 "items": {
    ///                     "type": "object",
    ///                     "additionalProperties": false,
    ///                     "required": [],
    ///                     "properties": {
    ///                         "AddressTypeCode": {
    ///                             "description": "Code identifying an organizational entity, a physical location, property, or an individual",
    ///                             "type": "string"
    ///                         },
    ///                         "LocationCodeQualifier": {
    ///                             "description": "Code identifying the structure or format of the related location number[s]",
    ///                             "type": "string"
    ///                         },
    ///                         "AddressLocationNumber": {
    ///                             "description": "Unique value assigned to identify a location",
    ///                             "examples": [
    ///                                 "11111"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "AddressName": {
    ///                             "description": "Primary free-form textual description of a location",
    ///                             "examples": [
    ///                                 "SPS Commerce",
    ///                                 "The White House"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "AddressAlternateName": {
    ///                             "description": "Additional free-form description of a location",
    ///                             "examples": [
    ///                                 "ATTN: Marketing"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "AddressAlternateName2": {
    ///                             "description": "Additional free-form description of a location",
    ///                             "examples": [
    ///                                 "ATTN: John Doe"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "Address1": {
    ///                             "description": "Address information",
    ///                             "examples": [
    ///                                 "1600 Pennsylvania Ave NW",
    ///                                 "333 South 7th Street"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "Address2": {
    ///                             "description": "Address information",
    ///                             "examples": [
    ///                                 "ATTN: The President",
    ///                                 "Suite 1000"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "Address3": {
    ///                             "description": "Address information",
    ///                             "examples": [
    ///                                 "333 South Seventh Street Tower"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "Address4": {
    ///                             "description": "Address information",
    ///                             "examples": [
    ///                                 "10th Floor"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "City": {
    ///                             "description": "Free-form text for city name",
    ///                             "examples": [
    ///                                 "Minneapolis",
    ///                                 "Washington"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "State": {
    ///                             "description": "Code[Standard State/Province] as defined by appropriate government agency",
    ///                             "examples": [
    ///                                 "DC",
    ///                                 "MN"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "PostalCode": {
    ///                             "description": "International postal zone excluding punctuation and blanks[Zip Code for United States]",
    ///                             "examples": [
    ///                                 "20500",
    ///                                 "55402"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "Country": {
    ///                             "description": "Human readable description identifying the country",
    ///                             "examples": [
    ///                                 "US",
    ///                                 "USA"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "LocationID": {
    ///                             "description": "Provides further description to the address information. This can be either text or an ID",
    ///                             "examples": [
    ///                                 "555555",
    ///                                 "East Location, next to interstate"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "CountrySubDivision": {
    ///                             "type": "string"
    ///                         },
    ///                         "AddressTaxIdNumber": {
    ///                             "description": "Unique number assigned by the relevant tax authority to identify a party for use in relation to Value Added Tax[VAT]",
    ///                             "examples": [
    ///                                 "999999"
    ///                             ],
    ///                             "type": "string"
    ///                         },
    ///                         "AddressTaxExemptNumber": {
    ///                             "type": "string"
    ///                         },
    ///                         "Dates": {
    ///                             "type": "array",
    ///                             "items": {
    ///                                 "type": "object",
    ///                                 "additionalProperties": false,
    ///                                 "required": [],
    ///                                 "properties": {
    ///                                     "DateTimeQualifier": {
    ///                                         "description": "Code specifying the type of date",
    ///                                         "type": "string"
    ///                                     },
    ///                                     "Date": {
    ///                                         "type": "string",
    ///                                         "format": "date"
    ///                                     },
    ///                                     "Time": {
    ///                                         "description": "All standard XML formats are accepted.",
    ///                                         "examples": [
    ///                                             "16:13:03-05:00"
    ///                                         ],
    ///                                         "type": "string",
    ///                                         "format": "time"
    ///                                     },
    ///                                     "DateTimePeriod": {
    ///                                         "type": "string"
    ///                                     }
    ///                                 }
    ///                             }
    ///                         }
    ///                     }
    ///                 }
    ///             },
    ///             "SealNumbers": {
    ///                 "type": "array",
    ///                 "items": {
    ///                     "type": "object",
    ///                     "additionalProperties": false,
    ///                     "required": [],
    ///                     "properties": {
    ///                         "SealStatusCode": {
    ///                             "description": "Code indicating condition of door seal upon arrival",
    ///                             "type": "string"
    ///                         },
    ///                         "SealNumber": {
    ///                             "description": "Stamped lock that is on the container",
    ///                             "examples": [
    ///                                 "AA1111111"
    ///                             ],
    ///                             "type": "string"
    ///                         }
    ///                     }
    ///                 }
    ///             }
    ///         }
    ///     }
    /// },
    /// </summary>

    ///<example>
    ///"CarrierInformation" : [ {
    ///   "CarrierTransMethodCode" : "M",
    ///   "CarrierAlphaCode" : "DYN",
    ///   "CarrierRouting" : "DYNAMIC GROUND"
    /// } ]
    /// </example>
    public class BaseCarrierInformationModel : ABaseHasRequiredObject
    {
        [JsonConstructor]
        public BaseCarrierInformationModel()
           : this(MainViewModel.Current.FieldsService.ShipmentsFields)
        {
        }
        public BaseCarrierInformationModel(FieldsBase shipmentFields)
        {
            CarrierTransMethodCodesList.AddRange(shipmentFields.GetFieldsBy("CarrierTransMethodCode"));
            StatusCodes.AddRange(shipmentFields.GetFieldsBy("StatusCode"));
        }
        /// <summary>
        /// CarrierAlphaCode : Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National Motor Freight Traffic Association identifying transportation companies
        /// </summary>
        private string carrierAlphaCode = "DYN";
        [Required(ErrorMessage = "Carrier Alpha Code is required", AllowEmptyStrings = false)]
        public string CarrierAlphaCode
        {
            get => carrierAlphaCode;
            set => SetProperty(ref carrierAlphaCode, value);
        }

        /// <summary>
        /// CarrierTransMethodCode: Code specifying the method or type of transportation for the shipment
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> CarrierTransMethodCodesList { get; set; } = new List<Tuple<string, string>>();
        private string siCarrierTransMethodCodes = "M";
        public string CarrierTransMethodCode
        {
            get => siCarrierTransMethodCodes;
            set => SetProperty(ref siCarrierTransMethodCodes, value);
        }

        /// <summary>
        /// StatusCode: Code specifying the method or type of transportation for the shipment
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> StatusCodes { get; set; } = new List<Tuple<string, string>>();
        private string siStatusCode= "CL";
        public string StatusCode
        {
            get => siStatusCode;
            set => SetProperty(ref siStatusCode, value);
        }
        /// <summary>
        /// CarrierRouting: Free-form description of the routing/requested routing for shipment or the originating carrier's identity
        /// </summary>
        private string carrierRouting = "DYNAMIC GROUND";
        [Required(ErrorMessage = "Carrier Routing is required", AllowEmptyStrings = false)]
        public string CarrierRouting
        {
            get => carrierRouting;
            set => SetProperty(ref carrierRouting, value);
        }

        
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
    }
}