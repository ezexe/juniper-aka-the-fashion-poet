namespace Juniper.Core.Models
{
    ///<summary>
    ///"Address": {
    ///      "type": "array",
    ///      "items": {
    ///          "type": "object",
    ///          "additionalProperties": false,
    ///          "required": [],
    ///          "properties": {
    ///              "AddressTypeCode": {
    ///                  "description": "Code identifying an organizational entity, a physical location, property, or an individual",
    ///                  "type": "string"
    ///              },
    ///              "LocationCodeQualifier": {
    ///                  "description": "Code identifying the structure or format of the related location number[s]",
    ///                  "type": "string"
    ///              },
    ///              "AddressLocationNumber": {
    ///                  "description": "Unique value assigned to identify a location",
    ///                  "examples": [
    ///                      "11111"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "AddressName": {
    ///                  "description": "Primary free-form textual description of a location",
    ///                  "examples": [
    ///                      "SPS Commerce",
    ///                      "The White House"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "AddressAlternateName": {
    ///                  "description": "Additional free-form description of a location",
    ///                  "examples": [
    ///                      "ATTN: Marketing"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "AddressAlternateName2": {
    ///                  "description": "Additional free-form description of a location",
    ///                  "examples": [
    ///                      "ATTN: John Doe"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "Address1": {
    ///                  "description": "Address information",
    ///                  "examples": [
    ///                      "1600 Pennsylvania Ave NW",
    ///                      "333 South 7th Street"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "Address2": {
    ///                  "description": "Address information",
    ///                  "examples": [
    ///                      "ATTN: The President",
    ///                      "Suite 1000"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "Address3": {
    ///                  "description": "Address information",
    ///                  "examples": [
    ///                      "333 South Seventh Street Tower"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "Address4": {
    ///                  "description": "Address information",
    ///                  "examples": [
    ///                      "10th Floor"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "City": {
    ///                  "description": "Free-form text for city name",
    ///                  "examples": [
    ///                      "Minneapolis",
    ///                      "Washington"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "State": {
    ///                  "description": "Code[Standard State/Province] as defined by appropriate government agency",
    ///                  "examples": [
    ///                      "DC",
    ///                      "MN"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "PostalCode": {
    ///                  "description": "International postal zone excluding punctuation and blanks[Zip Code for United States]",
    ///                  "examples": [
    ///                      "20500",
    ///                      "55402"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "Country": {
    ///                  "description": "Human readable description identifying the country",
    ///                  "examples": [
    ///                      "US",
    ///                      "USA"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "LocationID": {
    ///                  "description": "Provides further description to the address information. This can be either text or an ID",
    ///                  "examples": [
    ///                      "555555",
    ///                      "East Location, next to interstate"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "CountrySubDivision": {
    ///                  "type": "string"
    ///              },
    ///              "AddressTaxIdNumber": {
    ///                  "description": "Unique number assigned by the relevant tax authority to identify a party for use in relation to Value Added Tax[VAT]",
    ///                  "examples": [
    ///                      "999999"
    ///                  ],
    ///                  "type": "string"
    ///              },
    ///              "AddressTaxExemptNumber": {
    ///                  "type": "string"
    ///              },
    ///              "References": {
    ///                  "type": "array",
    ///                  "items": {
    ///                      "type": "object",
    ///                      "additionalProperties": false,
    ///                      "required": [],
    ///                      "properties": {
    ///                          "ReferenceQual": {
    ///                              "description": "Code specifying the type of data in the ReferenceID/ReferenceDescription",
    ///                              "type": "string"
    ///                          },
    ///                          "ReferenceID": {
    ///                              "type": "string"
    ///                          },
    ///                          "Description": {
    ///                              "description": "Free-form textual description to clarify the related data elements and their content",
    ///                              "examples": [
    ///                                  "New products only. Do not reuse packaging"
    ///                              ],
    ///                              "type": "string"
    ///                          },
    ///                          "Date": {
    ///                              "type": "string",
    ///                              "format": "date"
    ///                          },
    ///                          "Time": {
    ///                              "description": "All standard XML formats are accepted.",
    ///                              "examples": [
    ///                                  "16:13:03-05:00"
    ///                              ],
    ///                              "type": "string",
    ///                              "format": "time"
    ///                          },
    ///                          "ReferenceIDs": {
    ///                              "type": "array",
    ///                              "items": {
    ///                                  "type": "object",
    ///                                  "additionalProperties": false,
    ///                                  "required": [],
    ///                                  "properties": {
    ///                                      "ReferenceQual": {
    ///                                          "description": "Code specifying the type of data in the ReferenceID/ReferenceDescription",
    ///                                          "type": "string"
    ///                                      },
    ///                                      "ReferenceID": {
    ///                                          "type": "string"
    ///                                      }
    ///                                  }
    ///                              }
    ///                          }
    ///                      }
    ///                  }
    ///              },
    ///              "Contacts": {
    ///                  "type": "array",
    ///                  "items": {
    ///                      "type": "object",
    ///                      "additionalProperties": false,
    ///                      "required": [],
    ///                      "properties": {
    ///                          "ContactTypeCode": {
    ///                              "description": "Code identifying a type of contact",
    ///                              "type": "string"
    ///                          },
    ///                          "ContactName": {
    ///                              "description": "Free-form name",
    ///                              "examples": [
    ///                                  "SPS Commerce"
    ///                              ],
    ///                              "type": "string"
    ///                          },
    ///                          "PrimaryPhone": {
    ///                              "description": "Phone number of contact listed",
    ///                              "examples": [
    ///                                  "866-245-8100"
    ///                              ],
    ///                              "type": "string"
    ///                          },
    ///                          "PrimaryFax": {
    ///                              "description": "Fax number of contact listed",
    ///                              "examples": [
    ///                                  "612-435-9401"
    ///                              ],
    ///                              "type": "string"
    ///                          },
    ///                          "PrimaryEmail": {
    ///                              "description": "E-mail address for contact listed",
    ///                              "examples": [
    ///                                  "info@spscommerce.com"
    ///                              ],
    ///                              "type": "string"
    ///                          },
    ///                          "AdditionalContactDetails": {
    ///                              "type": "array",
    ///                              "items": {
    ///                                  "type": "object",
    ///                                  "description": "This group should be used if the associated normalized fields already contain information.",
    ///                                  "additionalProperties": false,
    ///                                  "required": [],
    ///                                  "properties": {
    ///                                      "ContactQual": {
    ///                                          "type": "string"
    ///                                      },
    ///                                      "ContactID": {
    ///                                          "type": "string"
    ///                                      }
    ///                                  }
    ///                              }
    ///                          },
    ///                          "ContactReference": {
    ///                              "description": "Additional field to clarify a contact",
    ///                              "examples": [
    ///                                  "ext: 451"
    ///                              ],
    ///                              "type": "string"
    ///                          }
    ///                      }
    ///                  }
    ///              },
    ///              "Dates": {
    ///                  "type": "array",
    ///                  "items": {
    ///                      "type": "object",
    ///                      "additionalProperties": false,
    ///                      "required": [],
    ///                      "properties": {
    ///                          "DateTimeQualifier": {
    ///                              "description": "Code specifying the type of date",
    ///                              "type": "string"
    ///                          },
    ///                          "Date": {
    ///                              "type": "string",
    ///                              "format": "date"
    ///                          },
    ///                          "Time": {
    ///                              "description": "All standard XML formats are accepted.",
    ///                              "examples": [
    ///                                  "16:13:03-05:00"
    ///                              ],
    ///                              "type": "string",
    ///                              "format": "time"
    ///                          },
    ///                          "DateTimePeriod": {
    ///                              "type": "string"
    ///                          }
    ///                      }
    ///                  }
    ///              }
    ///          }
    ///      }
    ///  },
    /// </summary>

    ///<example>
    ///"Address" : [ {
    ///   "AddressTypeCode" : "ST",
    ///   "LocationCodeQualifier" : "92",
    ///   "AddressLocationNumber" : "0575"
    /// }, {
    ///   "AddressTypeCode" : "SF",
    ///   "AddressName" : "Juniper 08 LLC"
    /// } ],
    /// </example>
    public class BaseAddressModel : ABaseHasRequiredObject
    {
        public BaseAddressModel()
        {

        }
        public BaseAddressModel(string addTypeCode, string locationCodeQualifier)
        {
            SIAddressTypeCode = AddressTypeCode.GetToupleByItem(addTypeCode) ?? 41;
            SILocationCodeQualifier = LocationCodeQualifier.GetToupleByItem(locationCodeQualifier) ?? 9;
        }
        ///<summary>
        ///AddressTypeCode: Code identifying an organizational entity, a physical location, property, or an individual
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> AddressTypeCode { get; } = new List<Tuple<string, string>>()
        {
                new Tuple<string, string>("88","Approver"),
                new Tuple<string, string>("9C","Country of Destination"),
                new Tuple<string, string>("AG","Agent"),
                new Tuple<string, string>("BE","Beneficiary"),
                new Tuple<string, string>("BK","Bank"),
                new Tuple<string, string>("BO","Broker"),
                new Tuple<string, string>("BOWN","Brand Owner"),
                new Tuple<string, string>("BT","Bill to Party"),
                new Tuple<string, string>("BY","Buying Party"),
                new Tuple<string, string>("CB","Customs Broker"),
                new Tuple<string, string>("CN","Consignee"),
                new Tuple<string, string>("CQ","Corporate Office"),
                new Tuple<string, string>("CS","Consolidator"),
                new Tuple<string, string>("CT","Country of Origin"),
                new Tuple<string, string>("DA","Delivery Address"),
                new Tuple<string, string>("DE","Depositor"),
                new Tuple<string, string>("DS","Distributor"),
                new Tuple<string, string>("DV","Division"),
                new Tuple<string, string>("ESIID","Electric Service Identifier ID"),
                new Tuple<string, string>("FR","Message From"),
                new Tuple<string, string>("FW","Forwarder"),
                new Tuple<string, string>("IA","Install Address"),
                new Tuple<string, string>("MF","Manufacturer of Goods"),
                new Tuple<string, string>("N1","Notify Party"),
                new Tuple<string, string>("NES","New Store"),
                new Tuple<string, string>("OB","Ordered By"),
                new Tuple<string, string>("PATI","Patient"),
                new Tuple<string, string>("PF","Party to Receive Freight Bill"),
                new Tuple<string, string>("PLCO","Place of Consumption"),
                new Tuple<string, string>("POAR","Port Of Arrival"),
                new Tuple<string, string>("PODI","Port of Discharge"),
                new Tuple<string, string>("POEN","Port of Entry"),
                new Tuple<string, string>("POOR","Port Of Origin"),
                new Tuple<string, string>("PR","Payer"),
                new Tuple<string, string>("PW","Pickup Address"),
                new Tuple<string, string>("RAMP","Repair and Maintenance Provider"),
                new Tuple<string, string>("RI","Remit To"),
                new Tuple<string, string>("RL","Reporting Location"),
                new Tuple<string, string>("RT","Return Address"),
                new Tuple<string, string>("SF","Ship From"),
                new Tuple<string, string>("SO","Sold To"),
                new Tuple<string, string>("ST","Ship To"),
                new Tuple<string, string>("TO","Message To"),
                new Tuple<string, string>("TP","Transportation Provider"),
                new Tuple<string, string>("TS","Transshipment Location"),
                new Tuple<string, string>("VN","Vendor"),
                new Tuple<string, string>("WH","Warehouse"),
                new Tuple<string, string>("Z7","Mark for Party"),
        };
        private int siAddressTypeCode;
        public int SIAddressTypeCode
        {
            get => siAddressTypeCode;
            set => SetProperty(ref siAddressTypeCode, value);
        }
        public string? SelectedAddressTypeCode => AddressTypeCode[siAddressTypeCode].Item1;
        private string sAddressTypeCode;
        public string SAddressTypeCode
        {
            get { return sAddressTypeCode; }
            set
            {
                sAddressTypeCode = value;

                if (sAddressTypeCode != null)
                {
                    SIAddressTypeCode = AddressTypeCode.GetToupleByItem(value)??41;
                }
            }
        }

        ///<summary>
        ///LocationCodeQualifier: Code identifying the structure or format of the related location number[s]
        /// </summary>
        [JsonIgnore]
        public List<Tuple<string, string>> LocationCodeQualifier { get; } = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("1","Duns Number"),
            new Tuple<string, string>("10","Department of Defense Activity Address Code"),
            new Tuple<string, string>("11","Drug Enforcement Administration Number"),
            new Tuple<string, string>("15","Standard Address Number[SAN]"),
            new Tuple<string, string>("21","Health Industry Number"),
            new Tuple<string, string>("33","Commercial and Government Entity"),
            new Tuple<string, string>("6","Plant Code"),
            new Tuple<string, string>("9","Duns Plus 4 Number"),
            new Tuple<string, string>("91","Seller Location Number"),
            new Tuple<string, string>("92","Buyer Location Number"),
            new Tuple<string, string>("A1","Approver ID"),
            new Tuple<string, string>("BE","Common Language Location Identifier [CLLI]"),
            new Tuple<string, string>("D","Census Schedule D"),
            new Tuple<string, string>("K","Census Schedule K"),
            new Tuple<string, string>("TPL","Third Party Location Number"),
            new Tuple<string, string>("UL","Global Location Number[GLN]"),
        };
        private int siLocationCodeQualifier;
        public int SILocationCodeQualifier
        {
            get => siLocationCodeQualifier;
            set => SetProperty(ref siLocationCodeQualifier, value);
        }
        public string? SelectedLocationCodeQualifier =>  LocationCodeQualifier[siLocationCodeQualifier].Item1;
        private string sLocationCodeQualifier;
        public string SLocationCodeQualifier
        {
            get { return sLocationCodeQualifier; }
            set 
            { 
                sLocationCodeQualifier = value;
                if (sLocationCodeQualifier != null)
                {
                    SILocationCodeQualifier = LocationCodeQualifier.GetToupleByItem(value)??9;
                }
            }
        }

        [JsonIgnore]
        public ObservableCollection<string> AddressLocationNumbersList { get; set; } = new ObservableCollection<string>();

        /// <summary>
        /// AddressLocationNumber: Unique value assigned to identify a location
        /// </summary>
        private string? addressLocationNumber;
        [Required(ErrorMessage = "Address Location Number Is Required", AllowEmptyStrings = false)]
        public string? AddressLocationNumber
        {
            get
            {
                if (int.TryParse(addressLocationNumber, out _))
                    return addressLocationNumber?.AddInFrontTill("0", 4);
                else
                    return addressLocationNumber;
            }
            set
            {
                if(value != null)
                SetProperty(ref addressLocationNumber, value);
            }
        }

        /// <summary>
        /// AddressLocationNumber: Unique value assigned to identify a location
        /// </summary>
        //private string addressName = string.Empty;
        //public string AddressName
        //{
        //    get => addressName;
        //    set => SetProperty(ref addressName, value);
        //}

        /// <summary>
        /// DCAddressLocationNumber: Unique value assigned to identify a location
        /// </summary>
        private string? dcAddressLocationNumber;
        public string? DCAddressLocationNumber
        {
            get
            {
                if (int.TryParse(dcAddressLocationNumber, out _))
                    return dcAddressLocationNumber?.AddInFrontTill("0", 4);
                else
                    return dcAddressLocationNumber;
            }
            set => SetProperty(ref dcAddressLocationNumber, value);
        }
        private string? dc;
        public string? DC
        {
            get => dc;
            set => SetProperty(ref dc, value);
        }

        private AddressModel? addressModel;
        public AddressModel? AddressModel
        {
            get => addressModel;
            set => SetProperty(ref addressModel, value);
        }

    }
}