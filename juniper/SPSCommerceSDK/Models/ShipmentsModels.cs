namespace SPSCommerceSDK.Models.Shipments;

public class Shipment
{
    [JsonPropertyName("ContainerLevel")]
    public List<ContainerLevel>? ContainerLevel { get; set; }

    [JsonPropertyName("Header")]
    public Header? Header { get; set; }

    [JsonPropertyName("ItemLevel")]
    public List<ItemLevel>? ItemLevel { get; set; }

    /// <summary>
    /// Contains internal SPS information
    /// </summary>
    [JsonPropertyName("Meta")]
    public Meta? Meta { get; set; }

    [JsonPropertyName("OrderLevel")]
    public List<OrderLevelElement>? OrderLevel { get; set; }

    [JsonPropertyName("PackLevel")]
    public List<PackLevel>? PackLevel { get; set; }

    [JsonPropertyName("Summary")]
    public Summary? Summary { get; set; }
}

public class PackLevel
{
    [JsonPropertyName("Address")]
    public List<IndecentAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<TentacledCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<TentacledChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Dates")]
    public List<FriskyDate>? Dates { get; set; }

    [JsonPropertyName("ItemLevel")]
    public List<ItemLevel>? ItemLevel { get; set; }

    [JsonPropertyName("MarksAndNumbersCollection")]
    public List<PurpleMarksAndNumbersCollection>? MarksAndNumbersCollection { get; set; }

    [JsonPropertyName("Notes")]
    public List<StickyNote>? Notes { get; set; }

    [JsonPropertyName("Pack")]
    public PurplePack? Pack { get; set; }

    [JsonPropertyName("Packaging")]
    public List<PurplePackaging>? Packaging { get; set; }

    [JsonPropertyName("PackLevel")]
    public List<PackLevel>? PackLevelPackLevel { get; set; }

    [JsonPropertyName("PalletInformation")]
    public List<PurplePalletInformation>? PalletInformation { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<PurplePhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("References")]
    public List<IndecentReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<PurpleRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("Taxes")]
    public List<StickyTax>? Taxes { get; set; }
}

public class OrderLevel
{
    [JsonPropertyName("Address")]
    public List<StickyAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<FluffyCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<FluffyChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<FluffyCommodity>? Commodity { get; set; }

    [JsonPropertyName("ContainerLevel")]
    public List<ContainerLevel>? ContainerLevel { get; set; }

    [JsonPropertyName("Dates")]
    public List<AmbitiousDate>? Dates { get; set; }

    [JsonPropertyName("ItemLevel")]
    public List<ItemLevel>? ItemLevel { get; set; }

    [JsonPropertyName("Notes")]
    public List<TentacledNote>? Notes { get; set; }

    [JsonPropertyName("OrderHeader")]
    public PurpleOrderHeader? OrderHeader { get; set; }

    [JsonPropertyName("PackLevel")]
    public List<PackLevel>? PackLevel { get; set; }

    [JsonPropertyName("QuantityAndWeight")]
    public List<PurpleQuantityAndWeight>? QuantityAndWeight { get; set; }

    [JsonPropertyName("References")]
    public List<HilariousReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<FluffyRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("Taxes")]
    public List<IndigoTax>? Taxes { get; set; }
}

public class ItemLevel
{
    [JsonPropertyName("Address")]
    public List<FluffyAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<PurpleCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("CarrierSpecialHandlingDetail")]
    public List<PurpleCarrierSpecialHandlingDetail>? CarrierSpecialHandlingDetail { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<PurpleChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<PurpleCommodity>? Commodity { get; set; }

    [JsonPropertyName("Dates")]
    public List<IndigoDate>? Dates { get; set; }

    [JsonPropertyName("ItemLoadInfo")]
    public List<PurpleItemLoadInfo>? ItemLoadInfo { get; set; }

    [JsonPropertyName("MasterItemAttribute")]
    public List<PurpleMasterItemAttribute>? MasterItemAttribute { get; set; }

    [JsonPropertyName("Measurements")]
    public List<FluffyMeasurement>? Measurements { get; set; }

    [JsonPropertyName("Notes")]
    public List<FluffyNote>? Notes { get; set; }

    [JsonPropertyName("OrderLevel")]
    public List<OrderLevel>? OrderLevel { get; set; }

    [JsonPropertyName("PackLevel")]
    public List<PackLevel>? PackLevel { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<FluffyPhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<PurplePriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<PurpleProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("References")]
    public List<AmbitiousReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<TentacledRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("ShipmentLine")]
    public PurpleShipmentLine? ShipmentLine { get; set; }

    [JsonPropertyName("Subline")]
    public List<PurpleSubline>? Subline { get; set; }

    [JsonPropertyName("Taxes")]
    public List<IndecentTax>? Taxes { get; set; }
}

public class ContainerLevel
{
    [JsonPropertyName("Address")]
    public List<ContainerLevelAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<ContainerLevelCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("Container")]
    public Container? Container { get; set; }

    [JsonPropertyName("Dates")]
    public List<ContainerLevelDate>? Dates { get; set; }

    [JsonPropertyName("ItemLevel")]
    public List<ItemLevel>? ItemLevel { get; set; }

    [JsonPropertyName("Notes")]
    public List<ContainerLevelNote>? Notes { get; set; }

    [JsonPropertyName("OrderLevel")]
    public List<OrderLevel>? OrderLevel { get; set; }

    [JsonPropertyName("PackLevel")]
    public List<PackLevel>? PackLevel { get; set; }

    [JsonPropertyName("QuantityAndWeight")]
    public List<ContainerLevelQuantityAndWeight>? QuantityAndWeight { get; set; }

    [JsonPropertyName("References")]
    public List<ContainerLevelReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<ContainerLevelRegulatoryCompliance>? RegulatoryCompliances { get; set; }
}

public class IndecentAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<StickyContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<CunningDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<IndigoReference>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class StickyContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<StickyAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

public class StickyAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class CunningDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class IndigoReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<IndigoReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class IndigoReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class TentacledCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<HilariousAddress>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<StickySealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<StickyServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class HilariousAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<MagentaDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class MagentaDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class StickySealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class StickyServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class TentacledChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<TentacledTax>? Taxes { get; set; }
}

public class TentacledTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class FriskyDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class PurpleMarksAndNumbersCollection
{
    /// <summary>
    /// Carton or Label ID indicating the shipment or parts of shipment
    /// </summary>
    [JsonPropertyName("MarksAndNumbers1")]
    public string? MarksAndNumbers1 { get; set; }

    /// <summary>
    /// Code specifying the application or source of MarksAndNumbers
    /// </summary>
    [JsonPropertyName("MarksAndNumbersQualifier1")]
    public string? MarksAndNumbersQualifier1 { get; set; }
}

public class StickyNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class PurplePack
{
    /// <summary>
    /// Carrier-Assigned Package ID indicating the shipment or parts of shipment
    /// </summary>
    [JsonPropertyName("CarrierPackageID")]
    public string? CarrierPackageId { get; set; }

    /// <summary>
    /// Indicator that defines the level the label information is provided or a carton reference
    /// number
    /// </summary>
    [JsonPropertyName("PackLevelType")]
    public string? PackLevelType { get; set; }

    /// <summary>
    /// Serial Shipping Container Code[SSCC] and Application Identifier[00] indicates the
    /// shipment or parts of shipment. This field includes both the SSCC[18 digits] and the
    /// Application Identifier[2 digits], which should be 20 digits in length
    /// </summary>
    [JsonPropertyName("ShippingSerialID")]
    public string? ShippingSerialId { get; set; }
}

public class PurplePackaging
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code specifying the marking, packaging, loading, and related characteristics being
    /// described
    /// </summary>
    [JsonPropertyName("PackagingCharacteristicCode")]
    public string? PackagingCharacteristicCode { get; set; }

    [JsonPropertyName("PackagingDescription")]
    public string? PackagingDescription { get; set; }

    [JsonPropertyName("PackagingDescriptionCode")]
    public string? PackagingDescriptionCode { get; set; }

    /// <summary>
    /// Code identifying loading or unloading a shipment
    /// </summary>
    [JsonPropertyName("UnitLoadOptionCode")]
    public string? UnitLoadOptionCode { get; set; }
}

public class PurplePalletInformation
{
    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    [JsonPropertyName("Height")]
    public double? Height { get; set; }

    [JsonPropertyName("Length")]
    public double? Length { get; set; }

    /// <summary>
    /// The number of units per horizontal layer on the pallet
    /// </summary>
    [JsonPropertyName("PalletBlocks")]
    public long? PalletBlocks { get; set; }

    /// <summary>
    /// Code specifying pallet exchange instructions
    /// </summary>
    [JsonPropertyName("PalletExchangeCode")]
    public string? PalletExchangeCode { get; set; }

    /// <summary>
    /// Code to identify the pallet hierarchical level
    /// </summary>
    [JsonPropertyName("PalletQualifier")]
    public string? PalletQualifier { get; set; }

    /// <summary>
    /// Code identifying the style of the pallet
    /// </summary>
    [JsonPropertyName("PalletStructureCode")]
    public string? PalletStructureCode { get; set; }

    /// <summary>
    /// The number of vertical layers on the pallet
    /// </summary>
    [JsonPropertyName("PalletTiers")]
    public long? PalletTiers { get; set; }

    /// <summary>
    /// Code indicating the type of material of the pallet
    /// </summary>
    [JsonPropertyName("PalletTypeCode")]
    public string? PalletTypeCode { get; set; }

    /// <summary>
    /// The number of units inside the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletValue")]
    public long? PalletValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletVolume")]
    public double? PalletVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PalletVolume is being measured by
    /// </summary>
    [JsonPropertyName("PalletVolumeUOM")]
    public string? PalletVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletWeight")]
    public double? PalletWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PalletWeight is being measured by
    /// </summary>
    [JsonPropertyName("PalletWeightUOM")]
    public string? PalletWeightUom { get; set; }

    [JsonPropertyName("UnitWeight")]
    public double? UnitWeight { get; set; }

    [JsonPropertyName("UnitWeightUOM")]
    public string? UnitWeightUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pallet when not loaded
    /// </summary>
    [JsonPropertyName("UnloadedHeight")]
    public double? UnloadedHeight { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the UnloadedHeight
    /// </summary>
    [JsonPropertyName("UnloadedHeightUOM")]
    public string? UnloadedHeightUom { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("Width")]
    public double? Width { get; set; }
}

public class PurplePhysicalDetail
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pack, as defined by the PackQualifer, when the pack is in
    /// the upright position
    /// </summary>
    [JsonPropertyName("PackHeight")]
    public double? PackHeight { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// The larger horizontal dimension of your pack, as defined by the PackQualifer, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackLength")]
    public double? PackLength { get; set; }

    /// <summary>
    /// Code to identify the pack hierarchical level
    /// </summary>
    [JsonPropertyName("PackQualifier")]
    public string? PackQualifier { get; set; }

    /// <summary>
    /// Measurable size of the sellable unit
    /// </summary>
    [JsonPropertyName("PackSize")]
    public double? PackSize { get; set; }

    /// <summary>
    /// Unit of measure for the PackSize
    /// </summary>
    [JsonPropertyName("PackUOM")]
    public string? PackUom { get; set; }

    /// <summary>
    /// The number of units inside the PackQualifier
    /// </summary>
    [JsonPropertyName("PackValue")]
    public long? PackValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PackQualifier or
    /// PalletQualifier
    /// </summary>
    [JsonPropertyName("PackVolume")]
    public double? PackVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackVolume is being measured by
    /// </summary>
    [JsonPropertyName("PackVolumeUOM")]
    public string? PackVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PackQualifier or PalletQualifier
    /// </summary>
    [JsonPropertyName("PackWeight")]
    public double? PackWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackWeight is being measured by
    /// </summary>
    [JsonPropertyName("PackWeightUOM")]
    public string? PackWeightUom { get; set; }

    /// <summary>
    /// The smaller horizontal dimension of your pack, as defined by the PackQualifier, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackWidth")]
    public double? PackWidth { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }
}

public class IndecentReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<IndecentReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class IndecentReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class PurpleRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class StickyTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class StickyAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<TentacledContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<IndecentDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<StickyReference>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class TentacledContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<TentacledAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class TentacledAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class IndecentDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class StickyReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<StickyReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class StickyReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class FluffyCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<IndigoAddress>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<TentacledSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<TentacledServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class IndigoAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<HilariousDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class HilariousDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class TentacledSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class TentacledServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class FluffyChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<FluffyTax>? Taxes { get; set; }
}

public class FluffyTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class FluffyCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class AmbitiousDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class TentacledNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class PurpleOrderHeader
{
    /// <summary>
    /// End consumer's account number
    /// </summary>
    [JsonPropertyName("CustomerAccountNumber")]
    public string? CustomerAccountNumber { get; set; }

    /// <summary>
    /// End consumer's order number
    /// </summary>
    [JsonPropertyName("CustomerOrderNumber")]
    public string? CustomerOrderNumber { get; set; }

    [JsonPropertyName("DeliveryDate")]
    public DateTimeOffset? DeliveryDate { get; set; }

    [JsonPropertyName("DeliveryTime")]
    public DateTimeOffset? DeliveryTime { get; set; }

    /// <summary>
    /// Name or number identifying an area wherein merchandise is categorized within a store
    /// </summary>
    [JsonPropertyName("Department")]
    public string? Department { get; set; }

    /// <summary>
    /// Free form text to describe the name or number identifying an area wherein merchandise is
    /// categorized within a store
    /// </summary>
    [JsonPropertyName("DepartmentDescription")]
    public string? DepartmentDescription { get; set; }

    /// <summary>
    /// Different entities belonging to the same parent company
    /// </summary>
    [JsonPropertyName("Division")]
    public string? Division { get; set; }

    /// <summary>
    /// ERP generated internal date for each incoming order
    /// </summary>
    [JsonPropertyName("InternalOrderDate")]
    public DateTimeOffset? InternalOrderDate { get; set; }

    /// <summary>
    /// ERP generated number assigned as unique identifier for each incoming order
    /// </summary>
    [JsonPropertyName("InternalOrderNumber")]
    public string? InternalOrderNumber { get; set; }

    /// <summary>
    /// Date Invoice was created
    /// </summary>
    [JsonPropertyName("InvoiceDate")]
    public DateTimeOffset? InvoiceDate { get; set; }

    /// <summary>
    /// Unique identifier assigned by the billing party
    /// </summary>
    [JsonPropertyName("InvoiceNumber")]
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// Project number assigned to a standard reorder purchase order
    /// </summary>
    [JsonPropertyName("JobNumber")]
    public string? JobNumber { get; set; }

    /// <summary>
    /// Date the purchase order was created
    /// </summary>
    [JsonPropertyName("PurchaseOrderDate")]
    public DateTimeOffset? PurchaseOrderDate { get; set; }

    /// <summary>
    /// Identifying number for the purchase order assigned by the buying organization
    /// </summary>
    [JsonPropertyName("PurchaseOrderNumber")]
    public string? PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Identifying number for the purchase order relating back to the original blanket order
    /// </summary>
    [JsonPropertyName("ReleaseNumber")]
    public string? ReleaseNumber { get; set; }

    /// <summary>
    /// Number assigned by buyer that uniquely identifies the vendor
    /// </summary>
    [JsonPropertyName("Vendor")]
    public string? Vendor { get; set; }
}

/// <summary>
/// This group contains the quantity of your PackingMedium and other related values such as
/// weight and volume
/// </summary>
public class PurpleQuantityAndWeight
{
    [JsonPropertyName("LadingDescription")]
    public string? LadingDescription { get; set; }

    /// <summary>
    /// Number of units/pieces of the lading commodity
    /// </summary>
    [JsonPropertyName("LadingQuantity")]
    public long? LadingQuantity { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// Code specifying pallet exchange instructions
    /// </summary>
    [JsonPropertyName("PalletExchangeCode")]
    public string? PalletExchangeCode { get; set; }

    [JsonPropertyName("Volume")]
    public double? Volume { get; set; }

    [JsonPropertyName("VolumeUOM")]
    public string? VolumeUom { get; set; }

    [JsonPropertyName("Weight")]
    public double? Weight { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("WeightUOM")]
    public string? WeightUom { get; set; }
}

public class HilariousReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<HilariousReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class HilariousReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class FluffyRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class IndigoTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class FluffyAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<FluffyContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<TentacledDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<FluffyReference>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class FluffyContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<FluffyAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class FluffyAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class TentacledDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FluffyReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<FluffyReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FluffyReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class PurpleCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<TentacledAddress>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<FluffySealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<FluffyServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class TentacledAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<StickyDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class StickyDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FluffySealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class FluffyServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class PurpleCarrierSpecialHandlingDetail
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("HazardousMaterialClass")]
    public string? HazardousMaterialClass { get; set; }

    [JsonPropertyName("HazardousMaterialCode")]
    public string? HazardousMaterialCode { get; set; }

    /// <summary>
    /// Code specifying special transportation handling instructions
    /// </summary>
    [JsonPropertyName("SpecialHandlingCode")]
    public string? SpecialHandlingCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class PurpleChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<PurpleTax>? Taxes { get; set; }
}

public class PurpleTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class PurpleCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class IndigoDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class PurpleItemLoadInfo
{
    [JsonPropertyName("ItemLoad")]
    public PurpleItemLoad? ItemLoad { get; set; }

    [JsonPropertyName("Notes")]
    public List<PurpleNote>? Notes { get; set; }

    [JsonPropertyName("References")]
    public List<TentacledReference>? References { get; set; }
}

public class PurpleItemLoad
{
    [JsonPropertyName("LoadSize")]
    public double? LoadSize { get; set; }

    [JsonPropertyName("LoadSizeUOM")]
    public string? LoadSizeUom { get; set; }

    [JsonPropertyName("NumberOfLoads")]
    public long? NumberOfLoads { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    [JsonPropertyName("UnitsShipped")]
    public double? UnitsShipped { get; set; }
}

public class PurpleNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class TentacledReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<TentacledReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class TentacledReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// This group is to link item attributes that are talking about the same part of the item.
/// Only once per MasterItemAttribute can a specific ItemAttributeQualifier be used
/// </summary>
public class PurpleMasterItemAttribute
{
    [JsonPropertyName("ItemAttribute")]
    public List<PurpleItemAttribute>? ItemAttribute { get; set; }
}

/// <summary>
/// This group describes a part of an item
/// </summary>
public class PurpleItemAttribute
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code identifying the part of an item being described.
    /// </summary>
    [JsonPropertyName("ItemAttributeQualifier")]
    public string? ItemAttributeQualifier { get; set; }

    [JsonPropertyName("Measurements")]
    public List<PurpleMeasurement>? Measurements { get; set; }

    /// <summary>
    /// Numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("Value")]
    public double? Value { get; set; }

    /// <summary>
    /// The unit of measure of the numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("ValueUOM")]
    public string? ValueUom { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class PurpleMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class FluffyMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class FluffyNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class FluffyPhysicalDetail
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pack, as defined by the PackQualifer, when the pack is in
    /// the upright position
    /// </summary>
    [JsonPropertyName("PackHeight")]
    public double? PackHeight { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// The larger horizontal dimension of your pack, as defined by the PackQualifer, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackLength")]
    public double? PackLength { get; set; }

    /// <summary>
    /// Code to identify the pack hierarchical level
    /// </summary>
    [JsonPropertyName("PackQualifier")]
    public string? PackQualifier { get; set; }

    /// <summary>
    /// Measurable size of the sellable unit
    /// </summary>
    [JsonPropertyName("PackSize")]
    public double? PackSize { get; set; }

    /// <summary>
    /// Unit of measure for the PackSize
    /// </summary>
    [JsonPropertyName("PackUOM")]
    public string? PackUom { get; set; }

    /// <summary>
    /// The number of units inside the PackQualifier
    /// </summary>
    [JsonPropertyName("PackValue")]
    public long? PackValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PackQualifier or
    /// PalletQualifier
    /// </summary>
    [JsonPropertyName("PackVolume")]
    public double? PackVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackVolume is being measured by
    /// </summary>
    [JsonPropertyName("PackVolumeUOM")]
    public string? PackVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PackQualifier or PalletQualifier
    /// </summary>
    [JsonPropertyName("PackWeight")]
    public double? PackWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackWeight is being measured by
    /// </summary>
    [JsonPropertyName("PackWeightUOM")]
    public string? PackWeightUom { get; set; }

    /// <summary>
    /// The smaller horizontal dimension of your pack, as defined by the PackQualifier, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackWidth")]
    public double? PackWidth { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }
}

public class PurplePriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class PurpleProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class AmbitiousReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<AmbitiousReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class AmbitiousReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class TentacledRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class PurpleShipmentLine
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Retailer's classification/grouping of products
    /// </summary>
    [JsonPropertyName("Class")]
    public string? Class { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// Quantity that has been shipped to date against a specific order or forecast
    /// </summary>
    [JsonPropertyName("CumulativeQty")]
    public double? CumulativeQty { get; set; }

    /// <summary>
    /// Name or number identifying an area wherein merchandise is categorized within a store
    /// </summary>
    [JsonPropertyName("Department")]
    public string? Department { get; set; }

    /// <summary>
    /// Free form text to describe the name or number identifying an area wherein merchandise is
    /// categorized within a store
    /// </summary>
    [JsonPropertyName("DepartmentDescription")]
    public string? DepartmentDescription { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// Code defining the vendor's status of the item
    /// </summary>
    [JsonPropertyName("ItemStatusCode")]
    public string? ItemStatusCode { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public PurpleNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Most up-to-date quantity
    /// </summary>
    [JsonPropertyName("OrderQty")]
    public double? OrderQty { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the OrderQty
    /// </summary>
    [JsonPropertyName("OrderQtyUOM")]
    public string? OrderQtyUom { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<PurpleProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Quantity of an order, shipment, or the disposition of any difference between the quantity
    /// ordered and quantity shipped for a line item
    /// </summary>
    [JsonPropertyName("QtyLeftToReceive")]
    public double? QtyLeftToReceive { get; set; }

    [JsonPropertyName("SellerDateCode")]
    public string? SellerDateCode { get; set; }

    /// <summary>
    /// Date shipment will leave the ship from location
    /// </summary>
    [JsonPropertyName("ShipDate")]
    public DateTimeOffset? ShipDate { get; set; }

    /// <summary>
    /// Quantity that has already or is scheduled to be shipped/delivered
    /// </summary>
    [JsonPropertyName("ShipQty")]
    public double? ShipQty { get; set; }

    /// <summary>
    /// Unit of measure used with the ShipQty
    /// </summary>
    [JsonPropertyName("ShipQtyUOM")]
    public string? ShipQtyUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class PurpleNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class PurpleProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class PurpleSubline
{
    [JsonPropertyName("Commodity")]
    public List<TentacledCommodity>? Commodity { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<FluffyPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<FluffyProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<StickyRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("SublineItemDetail")]
    public PurpleSublineItemDetail? SublineItemDetail { get; set; }
}

public class TentacledCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class FluffyPriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class FluffyProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class StickyRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class PurpleSublineItemDetail
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public FluffyNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<FluffyProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Component quantity within the pre-pack
    /// </summary>
    [JsonPropertyName("QtyPer")]
    public double? QtyPer { get; set; }

    /// <summary>
    /// Unit of measure pertaining to the QtyPer
    /// </summary>
    [JsonPropertyName("QtyPerUOM")]
    public string? QtyPerUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class FluffyNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class FluffyProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class IndecentTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class ContainerLevelAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<PurpleContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<PurpleDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<PurpleReference>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class PurpleContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<PurpleAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class PurpleAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class PurpleDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class PurpleReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<PurpleReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class PurpleReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class ContainerLevelCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<PurpleAddress>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<PurpleSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<PurpleServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class PurpleAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<FluffyDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class FluffyDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class PurpleSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class PurpleServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class Container
{
    /// <summary>
    /// A shipper assigned number that outlines the ownership, terms of carriage and is a receipt
    /// of goods
    /// </summary>
    [JsonPropertyName("BillOfLadingNumber")]
    public string? BillOfLadingNumber { get; set; }

    /// <summary>
    /// Reference number assigned by the carrier
    /// </summary>
    [JsonPropertyName("CarrierProNumber")]
    public string? CarrierProNumber { get; set; }
}

public class ContainerLevelDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ContainerLevelNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

/// <summary>
/// This group contains the quantity of your PackingMedium and other related values such as
/// weight and volume
/// </summary>
public class ContainerLevelQuantityAndWeight
{
    [JsonPropertyName("LadingDescription")]
    public string? LadingDescription { get; set; }

    /// <summary>
    /// Number of units/pieces of the lading commodity
    /// </summary>
    [JsonPropertyName("LadingQuantity")]
    public long? LadingQuantity { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// Code specifying pallet exchange instructions
    /// </summary>
    [JsonPropertyName("PalletExchangeCode")]
    public string? PalletExchangeCode { get; set; }

    [JsonPropertyName("Volume")]
    public double? Volume { get; set; }

    [JsonPropertyName("VolumeUOM")]
    public string? VolumeUom { get; set; }

    [JsonPropertyName("Weight")]
    public double? Weight { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("WeightUOM")]
    public string? WeightUom { get; set; }
}

public class ContainerLevelReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<CunningReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class CunningReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class ContainerLevelRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class Header
{
    [JsonPropertyName("Address")]
    public List<HeaderAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<HeaderCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("CarrierSpecialHandlingDetail")]
    public List<HeaderCarrierSpecialHandlingDetail>? CarrierSpecialHandlingDetail { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<HeaderChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<HeaderCommodity>? Commodity { get; set; }

    [JsonPropertyName("Contacts")]
    public List<HeaderContact>? Contacts { get; set; }

    [JsonPropertyName("Dates")]
    public List<HeaderDate>? Dates { get; set; }

    [JsonPropertyName("FOBRelatedInstruction")]
    public List<FobRelatedInstruction>? FobRelatedInstruction { get; set; }

    [JsonPropertyName("Notes")]
    public List<HeaderNote>? Notes { get; set; }

    [JsonPropertyName("QuantityAndWeight")]
    public List<HeaderQuantityAndWeight>? QuantityAndWeight { get; set; }

    [JsonPropertyName("QuantityTotals")]
    public List<QuantityTotal>? QuantityTotals { get; set; }

    [JsonPropertyName("References")]
    public List<HeaderReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<HeaderRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("ShipmentHeader")]
    public ShipmentHeader? ShipmentHeader { get; set; }

    [JsonPropertyName("Taxes")]
    public List<HeaderTax>? Taxes { get; set; }
}

public class HeaderAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<IndigoContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<MischievousDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<CunningReference>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class IndigoContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<IndigoAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class IndigoAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class MischievousDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class CunningReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<MagentaReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class MagentaReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class HeaderCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<AmbitiousAddress>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<IndigoSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<IndigoServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class AmbitiousAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<BraggadociousDate>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class BraggadociousDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class IndigoSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class IndigoServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class HeaderCarrierSpecialHandlingDetail
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("HazardousMaterialClass")]
    public string? HazardousMaterialClass { get; set; }

    [JsonPropertyName("HazardousMaterialCode")]
    public string? HazardousMaterialCode { get; set; }

    /// <summary>
    /// Code specifying special transportation handling instructions
    /// </summary>
    [JsonPropertyName("SpecialHandlingCode")]
    public string? SpecialHandlingCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class HeaderChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<HilariousTax>? Taxes { get; set; }
}

public class HilariousTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class HeaderCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class HeaderContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<IndecentAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class IndecentAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class HeaderDate
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FobRelatedInstruction
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Free-form textual description of the location at which ownership of goods is transferred
    /// </summary>
    [JsonPropertyName("FOBLocationDescription")]
    public string? FobLocationDescription { get; set; }

    /// <summary>
    /// Code identifying the party or location responsible for organizing and paying for
    /// transportation
    /// </summary>
    [JsonPropertyName("FOBLocationQualifier")]
    public string? FobLocationQualifier { get; set; }

    /// <summary>
    /// Code identifying payment terms for transportation charges
    /// </summary>
    [JsonPropertyName("FOBPayCode")]
    public string? FobPayCode { get; set; }

    /// <summary>
    /// Code describing the location of ownership of the goods changes
    /// </summary>
    [JsonPropertyName("FOBTitlePassageCode")]
    public string? FobTitlePassageCode { get; set; }

    /// <summary>
    /// Location of ownership of the goods
    /// </summary>
    [JsonPropertyName("FOBTitlePassageLocation")]
    public string? FobTitlePassageLocation { get; set; }

    /// <summary>
    /// Code specifying which party should bear the burden for risk of damage occurring to goods
    /// after the sale but before delivery
    /// </summary>
    [JsonPropertyName("RiskOfLossCode")]
    public string? RiskOfLossCode { get; set; }

    /// <summary>
    /// Code that defines to the recipient what types of fees are associated with the movement of
    /// goods. By default, if you do not send the TransportationTermsType, you are using the
    /// standard codes from the Incoterms website
    /// [http://www.iccwbo.org/products-and-services/trade-facilitation/]
    /// </summary>
    [JsonPropertyName("TransportationTerms")]
    public string? TransportationTerms { get; set; }

    /// <summary>
    /// Code identifying the source of the transportation terms
    /// </summary>
    [JsonPropertyName("TransportationTermsType")]
    public string? TransportationTermsType { get; set; }
}

public class HeaderNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

/// <summary>
/// This group contains the quantity of your PackingMedium and other related values such as
/// weight and volume
/// </summary>
public class HeaderQuantityAndWeight
{
    [JsonPropertyName("LadingDescription")]
    public string? LadingDescription { get; set; }

    /// <summary>
    /// Number of units/pieces of the lading commodity
    /// </summary>
    [JsonPropertyName("LadingQuantity")]
    public long? LadingQuantity { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// Code specifying pallet exchange instructions
    /// </summary>
    [JsonPropertyName("PalletExchangeCode")]
    public string? PalletExchangeCode { get; set; }

    [JsonPropertyName("Volume")]
    public double? Volume { get; set; }

    [JsonPropertyName("VolumeUOM")]
    public string? VolumeUom { get; set; }

    [JsonPropertyName("Weight")]
    public double? Weight { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("WeightUOM")]
    public string? WeightUom { get; set; }
}

/// <summary>
/// This group is used to communicate quantities for all line items
/// </summary>
public class QuantityTotal
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Qualifier used to define the related total amounts
    /// </summary>
    [JsonPropertyName("QuantityTotalsQualifier")]
    public string? QuantityTotalsQualifier { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("Volume")]
    public double? Volume { get; set; }

    [JsonPropertyName("VolumeUOM")]
    public string? VolumeUom { get; set; }

    [JsonPropertyName("Weight")]
    public double? Weight { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("WeightUOM")]
    public string? WeightUom { get; set; }
}

public class HeaderReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<FriskyReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FriskyReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class HeaderRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class ShipmentHeader
{
    /// <summary>
    /// Number assigned by the buying or logistics organization approving the delivery, routing,
    /// or pickup of the shipment. This is not the tracking number
    /// </summary>
    [JsonPropertyName("AppointmentNumber")]
    public string? AppointmentNumber { get; set; }

    /// <summary>
    /// Code is the reflection of the structure of the document
    /// </summary>
    [JsonPropertyName("ASNStructureCode")]
    public string? AsnStructureCode { get; set; }

    /// <summary>
    /// A shipper assigned number that outlines the ownership, terms of carriage and is a receipt
    /// of goods
    /// </summary>
    [JsonPropertyName("BillOfLadingNumber")]
    public string? BillOfLadingNumber { get; set; }

    /// <summary>
    /// Buyers Alpha ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("BuyersCurrency")]
    public string? BuyersCurrency { get; set; }

    /// <summary>
    /// Reference number assigned by the carrier
    /// </summary>
    [JsonPropertyName("CarrierProNumber")]
    public string? CarrierProNumber { get; set; }

    [JsonPropertyName("CurrentScheduledDeliveryDate")]
    public string? CurrentScheduledDeliveryDate { get; set; }

    [JsonPropertyName("CurrentScheduledDeliveryTime")]
    public string? CurrentScheduledDeliveryTime { get; set; }

    [JsonPropertyName("CurrentScheduledShipDate")]
    public string? CurrentScheduledShipDate { get; set; }

    [JsonPropertyName("CurrentScheduledShipTime")]
    public string? CurrentScheduledShipTime { get; set; }

    /// <summary>
    /// Used to communicate the revision number of the current document
    /// </summary>
    [JsonPropertyName("DocumentRevision")]
    public string? DocumentRevision { get; set; }

    /// <summary>
    /// Used to communicate the version number of the current document
    /// </summary>
    [JsonPropertyName("DocumentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>
    /// The rate to be applied to convert one currency to another
    /// </summary>
    [JsonPropertyName("ExchangeRate")]
    public double? ExchangeRate { get; set; }

    [JsonPropertyName("PickupNumber")]
    public string? PickupNumber { get; set; }

    [JsonPropertyName("RequestedPickupDate")]
    public string? RequestedPickupDate { get; set; }

    [JsonPropertyName("RequestedPickupTime")]
    public string? RequestedPickupTime { get; set; }

    [JsonPropertyName("ScheduledShipDate")]
    public string? ScheduledShipDate { get; set; }

    [JsonPropertyName("ScheduledShipTime")]
    public string? ScheduledShipTime { get; set; }

    /// <summary>
    /// Sellers Alpha ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("SellersCurrency")]
    public string? SellersCurrency { get; set; }

    /// <summary>
    /// Date shipment will leave the ship from location
    /// </summary>
    [JsonPropertyName("ShipDate")]
    public string? ShipDate { get; set; }

    /// <summary>
    /// Identification number assigned to the shipment by the shipper that uniquely identifies
    /// the shipment from origin to ultimate destination and is not subject to modification
    /// </summary>
    [JsonPropertyName("ShipmentIdentification")]
    public string? ShipmentIdentification { get; set; }

    /// <summary>
    /// Time the shipment left the ship from location. [All standard XML formats are accepted.]
    /// </summary>
    [JsonPropertyName("ShipmentTime")]
    public string? ShipmentTime { get; set; }

    /// <summary>
    /// Date the document was created
    /// </summary>
    [JsonPropertyName("ShipNoticeDate")]
    public string? ShipNoticeDate { get; set; }

    /// <summary>
    /// Time the document was created. [All standard XML formats are accepted]
    /// </summary>
    [JsonPropertyName("ShipNoticeTime")]
    public string? ShipNoticeTime { get; set; }

    [JsonPropertyName("StatusReasonCode")]
    public string? StatusReasonCode { get; set; }

    /// <summary>
    /// Unique internal identifier defined by SPS Commerce which identifies the relationship
    /// </summary>
    [JsonPropertyName("TradingPartnerId")]
    public string? TradingPartnerId { get; set; }

    /// <summary>
    /// Code identifying purpose or function of the transmission
    /// </summary>
    [JsonPropertyName("TsetPurposeCode")]
    public string? TsetPurposeCode { get; set; }

    [JsonPropertyName("TsetTypeCode")]
    public string? TsetTypeCode { get; set; }
}

public class HeaderTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

/// <summary>
/// Contains internal SPS information
/// </summary>
public class Meta
{
    [JsonPropertyName("BatchID")]
    public string? BatchId { get; set; }

    [JsonPropertyName("BatchPart")]
    public string? BatchPart { get; set; }

    [JsonPropertyName("BatchTotal")]
    public long? BatchTotal { get; set; }

    [JsonPropertyName("Comments")]
    public string? Comments { get; set; }

    [JsonPropertyName("DocumentControlIdentifier")]
    public string? DocumentControlIdentifier { get; set; }

    [JsonPropertyName("DocumentControlNumber")]
    public string? DocumentControlNumber { get; set; }

    [JsonPropertyName("GroupControlIdentifier")]
    public string? GroupControlIdentifier { get; set; }

    [JsonPropertyName("GroupControlNumber")]
    public string? GroupControlNumber { get; set; }

    [JsonPropertyName("GroupReceiverID")]
    public string? GroupReceiverId { get; set; }

    [JsonPropertyName("GroupSenderID")]
    public string? GroupSenderId { get; set; }

    [JsonPropertyName("InterchangeControlNumber")]
    public string? InterchangeControlNumber { get; set; }

    [JsonPropertyName("InterchangeReceiverID")]
    public string? InterchangeReceiverId { get; set; }

    [JsonPropertyName("InterchangeSenderID")]
    public string? InterchangeSenderId { get; set; }

    [JsonPropertyName("IsDropShip")]
    public bool? IsDropShip { get; set; }

    [JsonPropertyName("OrderManagement")]
    public string? OrderManagement { get; set; }

    [JsonPropertyName("ReceiverCompanyName")]
    public string? ReceiverCompanyName { get; set; }

    [JsonPropertyName("ReceiverUniqueID")]
    public string? ReceiverUniqueId { get; set; }

    [JsonPropertyName("SenderCompanyName")]
    public string? SenderCompanyName { get; set; }

    [JsonPropertyName("SenderUniqueID")]
    public string? SenderUniqueId { get; set; }

    [JsonPropertyName("Validation")]
    public string? Validation { get; set; }

    /// <summary>
    /// XML Version number
    /// </summary>
    [JsonPropertyName("Version")]
    public string? Version { get; set; }
}

public class OrderLevelElement
{
    [JsonPropertyName("Address")]
    public List<CunningAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<StickyCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<StickyChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<StickyCommodity>? Commodity { get; set; }

    [JsonPropertyName("ContainerLevel")]
    public List<ContainerLevel>? ContainerLevel { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date3>? Dates { get; set; }

    [JsonPropertyName("ItemLevel")]
    public List<OrderLevelItemLevel>? ItemLevel { get; set; }

    [JsonPropertyName("Notes")]
    public List<HilariousNote>? Notes { get; set; }

    [JsonPropertyName("OrderHeader")]
    public FluffyOrderHeader? OrderHeader { get; set; }

    [JsonPropertyName("PackLevel")]
    public List<OrderLevelPackLevel>? PackLevel { get; set; }

    [JsonPropertyName("QuantityAndWeight")]
    public List<FluffyQuantityAndWeight>? QuantityAndWeight { get; set; }

    [JsonPropertyName("References")]
    public List<Reference11>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<BraggadociousRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("Taxes")]
    public List<Tax6>? Taxes { get; set; }
}

public class CunningAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<IndecentContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date1>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<MagentaReference>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class IndecentContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<HilariousAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class HilariousAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class Date1
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class MagentaReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<MischievousReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class MischievousReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class StickyCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<MagentaAddress>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<IndecentSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<IndecentServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class MagentaAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date2>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class Date2
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class IndecentSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class IndecentServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class StickyChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<AmbitiousTax>? Taxes { get; set; }
}

public class AmbitiousTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class StickyCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class Date3
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class OrderLevelItemLevel
{
    [JsonPropertyName("Address")]
    public List<FriskyAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<IndigoCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("CarrierSpecialHandlingDetail")]
    public List<FluffyCarrierSpecialHandlingDetail>? CarrierSpecialHandlingDetail { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<IndigoChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<IndigoCommodity>? Commodity { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date6>? Dates { get; set; }

    [JsonPropertyName("ItemLoadInfo")]
    public List<FluffyItemLoadInfo>? ItemLoadInfo { get; set; }

    [JsonPropertyName("MasterItemAttribute")]
    public List<FluffyMasterItemAttribute>? MasterItemAttribute { get; set; }

    [JsonPropertyName("Measurements")]
    public List<StickyMeasurement>? Measurements { get; set; }

    [JsonPropertyName("Notes")]
    public List<IndecentNote>? Notes { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<TentacledPhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<TentacledPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<TentacledProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("References")]
    public List<BraggadociousReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<IndigoRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("ShipmentLine")]
    public FluffyShipmentLine? ShipmentLine { get; set; }

    [JsonPropertyName("Subline")]
    public List<FluffySubline>? Subline { get; set; }

    [JsonPropertyName("Taxes")]
    public List<MagentaTax>? Taxes { get; set; }
}

public class FriskyAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<HilariousContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date4>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<FriskyReference>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class HilariousContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<AmbitiousAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class AmbitiousAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class Date4
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FriskyReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<BraggadociousReferenceId>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class BraggadociousReferenceId
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class IndigoCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<MischievousAddress>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<HilariousSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<HilariousServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class MischievousAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date5>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class Date5
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class HilariousSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class HilariousServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class FluffyCarrierSpecialHandlingDetail
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("HazardousMaterialClass")]
    public string? HazardousMaterialClass { get; set; }

    [JsonPropertyName("HazardousMaterialCode")]
    public string? HazardousMaterialCode { get; set; }

    /// <summary>
    /// Code specifying special transportation handling instructions
    /// </summary>
    [JsonPropertyName("SpecialHandlingCode")]
    public string? SpecialHandlingCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class IndigoChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<CunningTax>? Taxes { get; set; }
}

public class CunningTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class IndigoCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class Date6
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FluffyItemLoadInfo
{
    [JsonPropertyName("ItemLoad")]
    public FluffyItemLoad? ItemLoad { get; set; }

    [JsonPropertyName("Notes")]
    public List<IndigoNote>? Notes { get; set; }

    [JsonPropertyName("References")]
    public List<MischievousReference>? References { get; set; }
}

public class FluffyItemLoad
{
    [JsonPropertyName("LoadSize")]
    public double? LoadSize { get; set; }

    [JsonPropertyName("LoadSizeUOM")]
    public string? LoadSizeUom { get; set; }

    [JsonPropertyName("NumberOfLoads")]
    public long? NumberOfLoads { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    [JsonPropertyName("UnitsShipped")]
    public double? UnitsShipped { get; set; }
}

public class IndigoNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class MischievousReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId1>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId1
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// This group is to link item attributes that are talking about the same part of the item.
/// Only once per MasterItemAttribute can a specific ItemAttributeQualifier be used
/// </summary>
public class FluffyMasterItemAttribute
{
    [JsonPropertyName("ItemAttribute")]
    public List<FluffyItemAttribute>? ItemAttribute { get; set; }
}

/// <summary>
/// This group describes a part of an item
/// </summary>
public class FluffyItemAttribute
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code identifying the part of an item being described.
    /// </summary>
    [JsonPropertyName("ItemAttributeQualifier")]
    public string? ItemAttributeQualifier { get; set; }

    [JsonPropertyName("Measurements")]
    public List<TentacledMeasurement>? Measurements { get; set; }

    /// <summary>
    /// Numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("Value")]
    public double? Value { get; set; }

    /// <summary>
    /// The unit of measure of the numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("ValueUOM")]
    public string? ValueUom { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class TentacledMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class StickyMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class IndecentNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class TentacledPhysicalDetail
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pack, as defined by the PackQualifer, when the pack is in
    /// the upright position
    /// </summary>
    [JsonPropertyName("PackHeight")]
    public double? PackHeight { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// The larger horizontal dimension of your pack, as defined by the PackQualifer, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackLength")]
    public double? PackLength { get; set; }

    /// <summary>
    /// Code to identify the pack hierarchical level
    /// </summary>
    [JsonPropertyName("PackQualifier")]
    public string? PackQualifier { get; set; }

    /// <summary>
    /// Measurable size of the sellable unit
    /// </summary>
    [JsonPropertyName("PackSize")]
    public double? PackSize { get; set; }

    /// <summary>
    /// Unit of measure for the PackSize
    /// </summary>
    [JsonPropertyName("PackUOM")]
    public string? PackUom { get; set; }

    /// <summary>
    /// The number of units inside the PackQualifier
    /// </summary>
    [JsonPropertyName("PackValue")]
    public long? PackValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PackQualifier or
    /// PalletQualifier
    /// </summary>
    [JsonPropertyName("PackVolume")]
    public double? PackVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackVolume is being measured by
    /// </summary>
    [JsonPropertyName("PackVolumeUOM")]
    public string? PackVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PackQualifier or PalletQualifier
    /// </summary>
    [JsonPropertyName("PackWeight")]
    public double? PackWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackWeight is being measured by
    /// </summary>
    [JsonPropertyName("PackWeightUOM")]
    public string? PackWeightUom { get; set; }

    /// <summary>
    /// The smaller horizontal dimension of your pack, as defined by the PackQualifier, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackWidth")]
    public double? PackWidth { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }
}

public class TentacledPriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class TentacledProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class BraggadociousReference
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId2>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId2
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class IndigoRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class FluffyShipmentLine
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Retailer's classification/grouping of products
    /// </summary>
    [JsonPropertyName("Class")]
    public string? Class { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// Quantity that has been shipped to date against a specific order or forecast
    /// </summary>
    [JsonPropertyName("CumulativeQty")]
    public double? CumulativeQty { get; set; }

    /// <summary>
    /// Name or number identifying an area wherein merchandise is categorized within a store
    /// </summary>
    [JsonPropertyName("Department")]
    public string? Department { get; set; }

    /// <summary>
    /// Free form text to describe the name or number identifying an area wherein merchandise is
    /// categorized within a store
    /// </summary>
    [JsonPropertyName("DepartmentDescription")]
    public string? DepartmentDescription { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// Code defining the vendor's status of the item
    /// </summary>
    [JsonPropertyName("ItemStatusCode")]
    public string? ItemStatusCode { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public TentacledNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Most up-to-date quantity
    /// </summary>
    [JsonPropertyName("OrderQty")]
    public double? OrderQty { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the OrderQty
    /// </summary>
    [JsonPropertyName("OrderQtyUOM")]
    public string? OrderQtyUom { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<TentacledProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Quantity of an order, shipment, or the disposition of any difference between the quantity
    /// ordered and quantity shipped for a line item
    /// </summary>
    [JsonPropertyName("QtyLeftToReceive")]
    public double? QtyLeftToReceive { get; set; }

    [JsonPropertyName("SellerDateCode")]
    public string? SellerDateCode { get; set; }

    /// <summary>
    /// Date shipment will leave the ship from location
    /// </summary>
    [JsonPropertyName("ShipDate")]
    public DateTimeOffset? ShipDate { get; set; }

    /// <summary>
    /// Quantity that has already or is scheduled to be shipped/delivered
    /// </summary>
    [JsonPropertyName("ShipQty")]
    public double? ShipQty { get; set; }

    /// <summary>
    /// Unit of measure used with the ShipQty
    /// </summary>
    [JsonPropertyName("ShipQtyUOM")]
    public string? ShipQtyUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class TentacledNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class TentacledProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class FluffySubline
{
    [JsonPropertyName("Commodity")]
    public List<IndecentCommodity>? Commodity { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<StickyPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<StickyProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<IndecentRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("SublineItemDetail")]
    public FluffySublineItemDetail? SublineItemDetail { get; set; }
}

public class IndecentCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class StickyPriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class StickyProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class IndecentRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class FluffySublineItemDetail
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public StickyNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<StickyProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Component quantity within the pre-pack
    /// </summary>
    [JsonPropertyName("QtyPer")]
    public double? QtyPer { get; set; }

    /// <summary>
    /// Unit of measure pertaining to the QtyPer
    /// </summary>
    [JsonPropertyName("QtyPerUOM")]
    public string? QtyPerUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class StickyNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class StickyProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class MagentaTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class HilariousNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class FluffyOrderHeader
{
    /// <summary>
    /// End consumer's account number
    /// </summary>
    [JsonPropertyName("CustomerAccountNumber")]
    public string? CustomerAccountNumber { get; set; }

    /// <summary>
    /// End consumer's order number
    /// </summary>
    [JsonPropertyName("CustomerOrderNumber")]
    public string? CustomerOrderNumber { get; set; }

    [JsonPropertyName("DeliveryDate")]
    public DateTimeOffset? DeliveryDate { get; set; }

    [JsonPropertyName("DeliveryTime")]
    public DateTimeOffset? DeliveryTime { get; set; }

    /// <summary>
    /// Name or number identifying an area wherein merchandise is categorized within a store
    /// </summary>
    [JsonPropertyName("Department")]
    public string? Department { get; set; }

    /// <summary>
    /// Free form text to describe the name or number identifying an area wherein merchandise is
    /// categorized within a store
    /// </summary>
    [JsonPropertyName("DepartmentDescription")]
    public string? DepartmentDescription { get; set; }

    /// <summary>
    /// Identifying number for a warehouse shipping order assigned by the depositor
    /// </summary>
    [JsonPropertyName("DepositorOrderNumber")]
    public string? DepositorOrderNumber { get; set; }

    /// <summary>
    /// Different entities belonging to the same parent company
    /// </summary>
    [JsonPropertyName("Division")]
    public string? Division { get; set; }

    /// <summary>
    /// ERP generated internal date for each incoming order
    /// </summary>
    [JsonPropertyName("InternalOrderDate")]
    public DateTimeOffset? InternalOrderDate { get; set; }

    /// <summary>
    /// ERP generated number assigned as unique identifier for each incoming order
    /// </summary>
    [JsonPropertyName("InternalOrderNumber")]
    public string? InternalOrderNumber { get; set; }

    /// <summary>
    /// Date Invoice was created
    /// </summary>
    [JsonPropertyName("InvoiceDate")]
    public DateTimeOffset? InvoiceDate { get; set; }

    /// <summary>
    /// Unique identifier assigned by the billing party
    /// </summary>
    [JsonPropertyName("InvoiceNumber")]
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// Project number assigned to a standard reorder purchase order
    /// </summary>
    [JsonPropertyName("JobNumber")]
    public string? JobNumber { get; set; }

    /// <summary>
    /// Date the purchase order was created
    /// </summary>
    [JsonPropertyName("PurchaseOrderDate")]
    public DateTimeOffset? PurchaseOrderDate { get; set; }

    /// <summary>
    /// Identifying number for the purchase order assigned by the buying organization
    /// </summary>
    [JsonPropertyName("PurchaseOrderNumber")]
    public string? PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Identifying number for the purchase order relating back to the original blanket order
    /// </summary>
    [JsonPropertyName("ReleaseNumber")]
    public string? ReleaseNumber { get; set; }

    /// <summary>
    /// Number assigned by buyer that uniquely identifies the vendor
    /// </summary>
    [JsonPropertyName("Vendor")]
    public string? Vendor { get; set; }
}

public class OrderLevelPackLevel
{
    [JsonPropertyName("Address")]
    public List<BraggadociousAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<IndecentCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<IndecentChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date9>? Dates { get; set; }

    [JsonPropertyName("ItemLevel")]
    public List<PurpleItemLevel>? ItemLevel { get; set; }

    [JsonPropertyName("MarksAndNumbersCollection")]
    public List<FluffyMarksAndNumbersCollection>? MarksAndNumbersCollection { get; set; }

    [JsonPropertyName("Notes")]
    public List<MagentaNote>? Notes { get; set; }

    [JsonPropertyName("Pack")]
    public FluffyPack? Pack { get; set; }

    [JsonPropertyName("Packaging")]
    public List<TentacledPackaging>? Packaging { get; set; }

    [JsonPropertyName("PackLevel")]
    public List<PackLevelPackLevel>? PackLevel { get; set; }

    [JsonPropertyName("PalletInformation")]
    public List<TentacledPalletInformation>? PalletInformation { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<HilariousPhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("References")]
    public List<Reference10>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<MischievousRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("Taxes")]
    public List<Tax5>? Taxes { get; set; }
}

public class BraggadociousAddress
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<AmbitiousContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date7>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<Reference1>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class AmbitiousContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<CunningAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class CunningAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class Date7
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class Reference1
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId3>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId3
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class IndecentCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<Address1>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<AmbitiousSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<AmbitiousServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class Address1
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? AddressAddress1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date8>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class Date8
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class AmbitiousSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class AmbitiousServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class IndecentChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<FriskyTax>? Taxes { get; set; }
}

public class FriskyTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class Date9
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class PurpleItemLevel
{
    [JsonPropertyName("Address")]
    public List<Address2>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<HilariousCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("CarrierSpecialHandlingDetail")]
    public List<TentacledCarrierSpecialHandlingDetail>? CarrierSpecialHandlingDetail { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<HilariousChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<HilariousCommodity>? Commodity { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date12>? Dates { get; set; }

    [JsonPropertyName("ItemLoadInfo")]
    public List<TentacledItemLoadInfo>? ItemLoadInfo { get; set; }

    [JsonPropertyName("MasterItemAttribute")]
    public List<TentacledMasterItemAttribute>? MasterItemAttribute { get; set; }

    [JsonPropertyName("Measurements")]
    public List<IndecentMeasurement>? Measurements { get; set; }

    [JsonPropertyName("Notes")]
    public List<CunningNote>? Notes { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<StickyPhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<IndigoPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<IndigoProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("References")]
    public List<Reference4>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<HilariousRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("ShipmentLine")]
    public TentacledShipmentLine? ShipmentLine { get; set; }

    [JsonPropertyName("Subline")]
    public List<TentacledSubline>? Subline { get; set; }

    [JsonPropertyName("Taxes")]
    public List<BraggadociousTax>? Taxes { get; set; }
}

public class Address2
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? AddressAddress2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<CunningContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date10>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<Reference2>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class CunningContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<MagentaAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class MagentaAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class Date10
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class Reference2
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId4>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId4
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class HilariousCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<Address3>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<CunningSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<CunningServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class Address3
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? AddressAddress3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date11>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class Date11
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class CunningSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class CunningServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class TentacledCarrierSpecialHandlingDetail
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("HazardousMaterialClass")]
    public string? HazardousMaterialClass { get; set; }

    [JsonPropertyName("HazardousMaterialCode")]
    public string? HazardousMaterialCode { get; set; }

    /// <summary>
    /// Code specifying special transportation handling instructions
    /// </summary>
    [JsonPropertyName("SpecialHandlingCode")]
    public string? SpecialHandlingCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class HilariousChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<MischievousTax>? Taxes { get; set; }
}

public class MischievousTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class HilariousCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class Date12
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class TentacledItemLoadInfo
{
    [JsonPropertyName("ItemLoad")]
    public TentacledItemLoad? ItemLoad { get; set; }

    [JsonPropertyName("Notes")]
    public List<AmbitiousNote>? Notes { get; set; }

    [JsonPropertyName("References")]
    public List<Reference3>? References { get; set; }
}

public class TentacledItemLoad
{
    [JsonPropertyName("LoadSize")]
    public double? LoadSize { get; set; }

    [JsonPropertyName("LoadSizeUOM")]
    public string? LoadSizeUom { get; set; }

    [JsonPropertyName("NumberOfLoads")]
    public long? NumberOfLoads { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    [JsonPropertyName("UnitsShipped")]
    public double? UnitsShipped { get; set; }
}

public class AmbitiousNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class Reference3
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId5>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId5
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// This group is to link item attributes that are talking about the same part of the item.
/// Only once per MasterItemAttribute can a specific ItemAttributeQualifier be used
/// </summary>
public class TentacledMasterItemAttribute
{
    [JsonPropertyName("ItemAttribute")]
    public List<TentacledItemAttribute>? ItemAttribute { get; set; }
}

/// <summary>
/// This group describes a part of an item
/// </summary>
public class TentacledItemAttribute
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code identifying the part of an item being described.
    /// </summary>
    [JsonPropertyName("ItemAttributeQualifier")]
    public string? ItemAttributeQualifier { get; set; }

    [JsonPropertyName("Measurements")]
    public List<IndigoMeasurement>? Measurements { get; set; }

    /// <summary>
    /// Numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("Value")]
    public double? Value { get; set; }

    /// <summary>
    /// The unit of measure of the numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("ValueUOM")]
    public string? ValueUom { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class IndigoMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class IndecentMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class CunningNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class StickyPhysicalDetail
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pack, as defined by the PackQualifer, when the pack is in
    /// the upright position
    /// </summary>
    [JsonPropertyName("PackHeight")]
    public double? PackHeight { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// The larger horizontal dimension of your pack, as defined by the PackQualifer, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackLength")]
    public double? PackLength { get; set; }

    /// <summary>
    /// Code to identify the pack hierarchical level
    /// </summary>
    [JsonPropertyName("PackQualifier")]
    public string? PackQualifier { get; set; }

    /// <summary>
    /// Measurable size of the sellable unit
    /// </summary>
    [JsonPropertyName("PackSize")]
    public double? PackSize { get; set; }

    /// <summary>
    /// Unit of measure for the PackSize
    /// </summary>
    [JsonPropertyName("PackUOM")]
    public string? PackUom { get; set; }

    /// <summary>
    /// The number of units inside the PackQualifier
    /// </summary>
    [JsonPropertyName("PackValue")]
    public long? PackValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PackQualifier or
    /// PalletQualifier
    /// </summary>
    [JsonPropertyName("PackVolume")]
    public double? PackVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackVolume is being measured by
    /// </summary>
    [JsonPropertyName("PackVolumeUOM")]
    public string? PackVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PackQualifier or PalletQualifier
    /// </summary>
    [JsonPropertyName("PackWeight")]
    public double? PackWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackWeight is being measured by
    /// </summary>
    [JsonPropertyName("PackWeightUOM")]
    public string? PackWeightUom { get; set; }

    /// <summary>
    /// The smaller horizontal dimension of your pack, as defined by the PackQualifier, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackWidth")]
    public double? PackWidth { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }
}

public class IndigoPriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class IndigoProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class Reference4
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId6>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId6
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class HilariousRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class TentacledShipmentLine
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Retailer's classification/grouping of products
    /// </summary>
    [JsonPropertyName("Class")]
    public string? Class { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// Quantity that has been shipped to date against a specific order or forecast
    /// </summary>
    [JsonPropertyName("CumulativeQty")]
    public double? CumulativeQty { get; set; }

    /// <summary>
    /// Name or number identifying an area wherein merchandise is categorized within a store
    /// </summary>
    [JsonPropertyName("Department")]
    public string? Department { get; set; }

    /// <summary>
    /// Free form text to describe the name or number identifying an area wherein merchandise is
    /// categorized within a store
    /// </summary>
    [JsonPropertyName("DepartmentDescription")]
    public string? DepartmentDescription { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// Code defining the vendor's status of the item
    /// </summary>
    [JsonPropertyName("ItemStatusCode")]
    public string? ItemStatusCode { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public IndigoNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Most up-to-date quantity
    /// </summary>
    [JsonPropertyName("OrderQty")]
    public double? OrderQty { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the OrderQty
    /// </summary>
    [JsonPropertyName("OrderQtyUOM")]
    public string? OrderQtyUom { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<IndigoProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Quantity of an order, shipment, or the disposition of any difference between the quantity
    /// ordered and quantity shipped for a line item
    /// </summary>
    [JsonPropertyName("QtyLeftToReceive")]
    public double? QtyLeftToReceive { get; set; }

    [JsonPropertyName("SellerDateCode")]
    public string? SellerDateCode { get; set; }

    /// <summary>
    /// Date shipment will leave the ship from location
    /// </summary>
    [JsonPropertyName("ShipDate")]
    public DateTimeOffset? ShipDate { get; set; }

    /// <summary>
    /// Quantity that has already or is scheduled to be shipped/delivered
    /// </summary>
    [JsonPropertyName("ShipQty")]
    public double? ShipQty { get; set; }

    /// <summary>
    /// Unit of measure used with the ShipQty
    /// </summary>
    [JsonPropertyName("ShipQtyUOM")]
    public string? ShipQtyUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class IndigoNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class IndigoProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class TentacledSubline
{
    [JsonPropertyName("Commodity")]
    public List<AmbitiousCommodity>? Commodity { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<IndecentPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<IndecentProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<AmbitiousRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("SublineItemDetail")]
    public TentacledSublineItemDetail? SublineItemDetail { get; set; }
}

public class AmbitiousCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class IndecentPriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class IndecentProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class AmbitiousRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class TentacledSublineItemDetail
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public IndecentNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<IndecentProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Component quantity within the pre-pack
    /// </summary>
    [JsonPropertyName("QtyPer")]
    public double? QtyPer { get; set; }

    /// <summary>
    /// Unit of measure pertaining to the QtyPer
    /// </summary>
    [JsonPropertyName("QtyPerUOM")]
    public string? QtyPerUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class IndecentNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class IndecentProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class BraggadociousTax
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class FluffyMarksAndNumbersCollection
{
    /// <summary>
    /// Carton or Label ID indicating the shipment or parts of shipment
    /// </summary>
    [JsonPropertyName("MarksAndNumbers1")]
    public string? MarksAndNumbers1 { get; set; }

    /// <summary>
    /// Code specifying the application or source of MarksAndNumbers
    /// </summary>
    [JsonPropertyName("MarksAndNumbersQualifier1")]
    public string? MarksAndNumbersQualifier1 { get; set; }
}

public class MagentaNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class FluffyPack
{
    /// <summary>
    /// Carrier-Assigned Package ID indicating the shipment or parts of shipment
    /// </summary>
    [JsonPropertyName("CarrierPackageID")]
    public string? CarrierPackageId { get; set; }

    /// <summary>
    /// Indicator that defines the level the label information is provided or a carton reference
    /// number
    /// </summary>
    [JsonPropertyName("PackLevelType")]
    public string? PackLevelType { get; set; }

    /// <summary>
    /// Serial Shipping Container Code[SSCC] and Application Identifier[00] indicates the
    /// shipment or parts of shipment. This field includes both the SSCC[18 digits] and the
    /// Application Identifier[2 digits], which should be 20 digits in length
    /// </summary>
    [JsonPropertyName("ShippingSerialID")]
    public string? ShippingSerialId { get; set; }
}

public class PackLevelPackLevel
{
    [JsonPropertyName("Address")]
    public List<Address4>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<AmbitiousCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<AmbitiousChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date15>? Dates { get; set; }

    [JsonPropertyName("ItemLevel")]
    public List<FluffyItemLevel>? ItemLevel { get; set; }

    [JsonPropertyName("MarksAndNumbersCollection")]
    public List<TentacledMarksAndNumbersCollection>? MarksAndNumbersCollection { get; set; }

    [JsonPropertyName("Notes")]
    public List<BraggadociousNote>? Notes { get; set; }

    [JsonPropertyName("Pack")]
    public TentacledPack? Pack { get; set; }

    [JsonPropertyName("Packaging")]
    public List<FluffyPackaging>? Packaging { get; set; }

    [JsonPropertyName("PalletInformation")]
    public List<FluffyPalletInformation>? PalletInformation { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<IndecentPhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("References")]
    public List<Reference9>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<FriskyRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("Taxes")]
    public List<Tax4>? Taxes { get; set; }
}

public class Address4
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? AddressAddress4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<MagentaContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date13>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<Reference5>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class MagentaContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<FriskyAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class FriskyAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class Date13
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class Reference5
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId7>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId7
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class AmbitiousCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<Address5>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<MagentaSealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<MagentaServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class Address5
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date14>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class Date14
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class MagentaSealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class MagentaServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class AmbitiousChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<Tax1>? Taxes { get; set; }
}

public class Tax1
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class Date15
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FluffyItemLevel
{
    [JsonPropertyName("Address")]
    public List<Address6>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<CunningCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("CarrierSpecialHandlingDetail")]
    public List<StickyCarrierSpecialHandlingDetail>? CarrierSpecialHandlingDetail { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<CunningChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<CunningCommodity>? Commodity { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date18>? Dates { get; set; }

    [JsonPropertyName("ItemLoadInfo")]
    public List<StickyItemLoadInfo>? ItemLoadInfo { get; set; }

    [JsonPropertyName("MasterItemAttribute")]
    public List<StickyMasterItemAttribute>? MasterItemAttribute { get; set; }

    [JsonPropertyName("Measurements")]
    public List<AmbitiousMeasurement>? Measurements { get; set; }

    [JsonPropertyName("Notes")]
    public List<MischievousNote>? Notes { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<IndigoPhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<HilariousPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<HilariousProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("References")]
    public List<Reference8>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<CunningRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("ShipmentLine")]
    public StickyShipmentLine? ShipmentLine { get; set; }

    [JsonPropertyName("Subline")]
    public List<StickySubline>? Subline { get; set; }

    [JsonPropertyName("Taxes")]
    public List<Tax3>? Taxes { get; set; }
}

public class Address6
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    [JsonPropertyName("Contacts")]
    public List<FriskyContact>? Contacts { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date16>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("References")]
    public List<Reference6>? References { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class FriskyContact
{
    [JsonPropertyName("AdditionalContactDetails")]
    public List<MischievousAdditionalContactDetail>? AdditionalContactDetails { get; set; }

    /// <summary>
    /// Free-form name
    /// </summary>
    [JsonPropertyName("ContactName")]
    public string? ContactName { get; set; }

    /// <summary>
    /// Additional field to clarify a contact
    /// </summary>
    [JsonPropertyName("ContactReference")]
    public string? ContactReference { get; set; }

    /// <summary>
    /// Code identifying a type of contact
    /// </summary>
    [JsonPropertyName("ContactTypeCode")]
    public string? ContactTypeCode { get; set; }

    /// <summary>
    /// E-mail address for contact listed
    /// </summary>
    [JsonPropertyName("PrimaryEmail")]
    public string? PrimaryEmail { get; set; }

    /// <summary>
    /// Fax number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryFax")]
    public string? PrimaryFax { get; set; }

    /// <summary>
    /// Phone number of contact listed
    /// </summary>
    [JsonPropertyName("PrimaryPhone")]
    public string? PrimaryPhone { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class MischievousAdditionalContactDetail
{
    [JsonPropertyName("ContactID")]
    public string? ContactId { get; set; }

    [JsonPropertyName("ContactQual")]
    public string? ContactQual { get; set; }
}

public class Date16
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class Reference6
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId8>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId8
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

public class CunningCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<Address7>? Address { get; set; }

    /// <summary>
    /// Standard Carrier Alpha Code[SCAC] - 2 to 4 digit alphabetic code assigned by the National
    /// Motor Freight Traffic Association identifying transportation companies
    /// </summary>
    [JsonPropertyName("CarrierAlphaCode")]
    public string? CarrierAlphaCode { get; set; }

    /// <summary>
    /// Prefix or alphabetic part of an equipment unit's identifying number
    /// </summary>
    [JsonPropertyName("CarrierEquipmentInitial")]
    public string? CarrierEquipmentInitial { get; set; }

    /// <summary>
    /// Sequencing or serial part of an equipment unit's identifying number[Pure numeric form for
    /// equipment number is preferred]
    /// </summary>
    [JsonPropertyName("CarrierEquipmentNumber")]
    public string? CarrierEquipmentNumber { get; set; }

    /// <summary>
    /// Free-form description of the routing/requested routing for shipment or the originating
    /// carrier's identity
    /// </summary>
    [JsonPropertyName("CarrierRouting")]
    public string? CarrierRouting { get; set; }

    /// <summary>
    /// Code specifying the method or type of transportation for the shipment
    /// </summary>
    [JsonPropertyName("CarrierTransMethodCode")]
    public string? CarrierTransMethodCode { get; set; }

    /// <summary>
    /// Code identifying type of equipment used for shipment
    /// </summary>
    [JsonPropertyName("EquipmentDescriptionCode")]
    public string? EquipmentDescriptionCode { get; set; }

    [JsonPropertyName("EquipmentType")]
    public string? EquipmentType { get; set; }

    [JsonPropertyName("OwnershipCode")]
    public string? OwnershipCode { get; set; }

    [JsonPropertyName("RoutingSequenceCode")]
    public string? RoutingSequenceCode { get; set; }

    [JsonPropertyName("SealNumbers")]
    public List<FriskySealNumber>? SealNumbers { get; set; }

    [JsonPropertyName("ServiceLevelCodes")]
    public List<FriskyServiceLevelCode>? ServiceLevelCodes { get; set; }

    /// <summary>
    /// Code indicating the status of an order or shipment or the disposition of any difference
    /// between the quantity ordered and the quantity shipped for a line item or transaction
    /// </summary>
    [JsonPropertyName("StatusCode")]
    public string? StatusCode { get; set; }

    /// <summary>
    /// The point of origin and point of direction
    /// </summary>
    [JsonPropertyName("TransitDirectionCode")]
    public string? TransitDirectionCode { get; set; }

    [JsonPropertyName("TransitTime")]
    public double? TransitTime { get; set; }

    [JsonPropertyName("TransitTimeQual")]
    public string? TransitTimeQual { get; set; }
}

public class Address7
{
    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address1")]
    public string? Address1 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address3")]
    public string? Address3 { get; set; }

    /// <summary>
    /// Address information
    /// </summary>
    [JsonPropertyName("Address4")]
    public string? Address4 { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName")]
    public string? AddressAlternateName { get; set; }

    /// <summary>
    /// Additional free-form description of a location
    /// </summary>
    [JsonPropertyName("AddressAlternateName2")]
    public string? AddressAlternateName2 { get; set; }

    /// <summary>
    /// Unique value assigned to identify a location
    /// </summary>
    [JsonPropertyName("AddressLocationNumber")]
    public string? AddressLocationNumber { get; set; }

    /// <summary>
    /// Primary free-form textual description of a location
    /// </summary>
    [JsonPropertyName("AddressName")]
    public string? AddressName { get; set; }

    [JsonPropertyName("AddressTaxExemptNumber")]
    public string? AddressTaxExemptNumber { get; set; }

    /// <summary>
    /// Unique number assigned by the relevant tax authority to identify a party for use in
    /// relation to Value Added Tax[VAT]
    /// </summary>
    [JsonPropertyName("AddressTaxIdNumber")]
    public string? AddressTaxIdNumber { get; set; }

    /// <summary>
    /// Code identifying an organizational entity, a physical location, property, or an individual
    /// </summary>
    [JsonPropertyName("AddressTypeCode")]
    public string? AddressTypeCode { get; set; }

    /// <summary>
    /// Free-form text for city name
    /// </summary>
    [JsonPropertyName("City")]
    public string? City { get; set; }

    /// <summary>
    /// Human readable description identifying the country
    /// </summary>
    [JsonPropertyName("Country")]
    public string? Country { get; set; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; set; }

    [JsonPropertyName("Dates")]
    public List<Date17>? Dates { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Provides further description to the address information. This can be either text or an ID
    /// </summary>
    [JsonPropertyName("LocationID")]
    public string? LocationId { get; set; }

    /// <summary>
    /// International postal zone excluding punctuation and blanks[Zip Code for United States]
    /// </summary>
    [JsonPropertyName("PostalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Code[Standard State/Province] as defined by appropriate government agency
    /// </summary>
    [JsonPropertyName("State")]
    public string? State { get; set; }
}

public class Date17
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class FriskySealNumber
{
    /// <summary>
    /// Stamped lock that is on the container
    /// </summary>
    [JsonPropertyName("SealNumber")]
    public string? SealNumber { get; set; }

    /// <summary>
    /// Code indicating condition of door seal upon arrival
    /// </summary>
    [JsonPropertyName("SealStatusCode")]
    public string? SealStatusCode { get; set; }
}

public class FriskyServiceLevelCode
{
    /// <summary>
    /// Code indicating the level of transportation service or the billing service offered by the
    /// transportation carrier
    /// </summary>
    [JsonPropertyName("ServiceLevelCode")]
    public string? ServiceLevelCode { get; set; }
}

public class StickyCarrierSpecialHandlingDetail
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("HazardousMaterialClass")]
    public string? HazardousMaterialClass { get; set; }

    [JsonPropertyName("HazardousMaterialCode")]
    public string? HazardousMaterialCode { get; set; }

    /// <summary>
    /// Code specifying special transportation handling instructions
    /// </summary>
    [JsonPropertyName("SpecialHandlingCode")]
    public string? SpecialHandlingCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class CunningChargesAllowance
{
    /// <summary>
    /// Agency maintained code identifying the service, promotion, allowance, or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAgency")]
    public string? AllowChrgAgency { get; set; }

    /// <summary>
    /// Code identifying the agency assigning the code values
    /// </summary>
    [JsonPropertyName("AllowChrgAgencyCode")]
    public string? AllowChrgAgencyCode { get; set; }

    /// <summary>
    /// Amount of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgAmt")]
    public double? AllowChrgAmt { get; set; }

    /// <summary>
    /// Code describing the type of allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgCode")]
    public string? AllowChrgCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for an allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingCode")]
    public string? AllowChrgHandlingCode { get; set; }

    /// <summary>
    /// Free-form textual description of the allowance or charge
    /// </summary>
    [JsonPropertyName("AllowChrgHandlingDescription")]
    public string? AllowChrgHandlingDescription { get; set; }

    /// <summary>
    /// Code which indicates an allowance or charge for the service specified
    /// </summary>
    [JsonPropertyName("AllowChrgIndicator")]
    public string? AllowChrgIndicator { get; set; }

    /// <summary>
    /// Percentage of allowance or charge. Percentages should be represented as real numbers[0%
    /// through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("AllowChrgPercent")]
    public double? AllowChrgPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis an allowance or charge percent is calculated
    /// </summary>
    [JsonPropertyName("AllowChrgPercentQual")]
    public string? AllowChrgPercentQual { get; set; }

    /// <summary>
    /// Numeric value of quantity to which the allowance or charge applies[AllowChrgRate,
    /// AllowChrgQty, AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQty")]
    public double? AllowChrgQty { get; set; }

    [JsonPropertyName("AllowChrgQty2")]
    public double? AllowChrgQty2 { get; set; }

    /// <summary>
    /// The unit of measure used in relation with AllowChrgQty[AllowChrgRate, AllowChrgQty,
    /// AllowChrgQtyUOM fields should all be sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgQtyUOM")]
    public string? AllowChrgQtyUom { get; set; }

    /// <summary>
    /// Value expressed in monetary currency that applies to the given quantity [i.e. The rate is
    /// $5.00 off one dozen]. [AllowChrgRate, AllowChrgQty, AllowChrgQtyUOM fields should all be
    /// sent in conjunction with each other]
    /// </summary>
    [JsonPropertyName("AllowChrgRate")]
    public double? AllowChrgRate { get; set; }

    /// <summary>
    /// Used to indicate at what point a value should be used in calculations where orders of
    /// operations matter [i.e. 1 would indicate that the related value should be taken first].
    /// </summary>
    [JsonPropertyName("CalculationSequence")]
    public long? CalculationSequence { get; set; }

    [JsonPropertyName("ExceptionNumber")]
    public string? ExceptionNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("OptionNumber")]
    public string? OptionNumber { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    [JsonPropertyName("ReferenceIdentification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("Taxes")]
    public List<Tax2>? Taxes { get; set; }
}

public class Tax2
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class CunningCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class Date18
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    [JsonPropertyName("DateTimePeriod")]
    public string? DateTimePeriod { get; set; }

    /// <summary>
    /// Code specifying the type of date
    /// </summary>
    [JsonPropertyName("DateTimeQualifier")]
    public string? DateTimeQualifier { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class StickyItemLoadInfo
{
    [JsonPropertyName("ItemLoad")]
    public StickyItemLoad? ItemLoad { get; set; }

    [JsonPropertyName("Notes")]
    public List<FriskyNote>? Notes { get; set; }

    [JsonPropertyName("References")]
    public List<Reference7>? References { get; set; }
}

public class StickyItemLoad
{
    [JsonPropertyName("LoadSize")]
    public double? LoadSize { get; set; }

    [JsonPropertyName("LoadSizeUOM")]
    public string? LoadSizeUom { get; set; }

    [JsonPropertyName("NumberOfLoads")]
    public long? NumberOfLoads { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    [JsonPropertyName("UnitsShipped")]
    public double? UnitsShipped { get; set; }
}

public class FriskyNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class Reference7
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId9>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId9
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// This group is to link item attributes that are talking about the same part of the item.
/// Only once per MasterItemAttribute can a specific ItemAttributeQualifier be used
/// </summary>
public class StickyMasterItemAttribute
{
    [JsonPropertyName("ItemAttribute")]
    public List<StickyItemAttribute>? ItemAttribute { get; set; }
}

/// <summary>
/// This group describes a part of an item
/// </summary>
public class StickyItemAttribute
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code identifying the part of an item being described.
    /// </summary>
    [JsonPropertyName("ItemAttributeQualifier")]
    public string? ItemAttributeQualifier { get; set; }

    [JsonPropertyName("Measurements")]
    public List<HilariousMeasurement>? Measurements { get; set; }

    /// <summary>
    /// Numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("Value")]
    public double? Value { get; set; }

    /// <summary>
    /// The unit of measure of the numeric value of the ItemAttributeQualifier
    /// </summary>
    [JsonPropertyName("ValueUOM")]
    public string? ValueUom { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class HilariousMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class AmbitiousMeasurement
{
    [JsonPropertyName("CompositeUOM")]
    public string? CompositeUom { get; set; }

    [JsonPropertyName("IndustryCode")]
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Code indicating a code from a specific industry code list
    /// </summary>
    [JsonPropertyName("IndustryCodeQualifier")]
    public string? IndustryCodeQualifier { get; set; }

    [JsonPropertyName("MeasurementAttributeCode")]
    public string? MeasurementAttributeCode { get; set; }

    /// <summary>
    /// Code identifying a specific product to which a measurement applies
    /// </summary>
    [JsonPropertyName("MeasurementQualifier")]
    public string? MeasurementQualifier { get; set; }

    [JsonPropertyName("MeasurementRefIDCode")]
    public string? MeasurementRefIdCode { get; set; }

    /// <summary>
    /// Code used to qualify or further define a measurement value
    /// </summary>
    [JsonPropertyName("MeasurementSignificanceCode")]
    public string? MeasurementSignificanceCode { get; set; }

    [JsonPropertyName("MeasurementValue")]
    public double? MeasurementValue { get; set; }

    [JsonPropertyName("RangeMaximum")]
    public double? RangeMaximum { get; set; }

    [JsonPropertyName("RangeMinimum")]
    public double? RangeMinimum { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }
}

public class MischievousNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class IndigoPhysicalDetail
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pack, as defined by the PackQualifer, when the pack is in
    /// the upright position
    /// </summary>
    [JsonPropertyName("PackHeight")]
    public double? PackHeight { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// The larger horizontal dimension of your pack, as defined by the PackQualifer, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackLength")]
    public double? PackLength { get; set; }

    /// <summary>
    /// Code to identify the pack hierarchical level
    /// </summary>
    [JsonPropertyName("PackQualifier")]
    public string? PackQualifier { get; set; }

    /// <summary>
    /// Measurable size of the sellable unit
    /// </summary>
    [JsonPropertyName("PackSize")]
    public double? PackSize { get; set; }

    /// <summary>
    /// Unit of measure for the PackSize
    /// </summary>
    [JsonPropertyName("PackUOM")]
    public string? PackUom { get; set; }

    /// <summary>
    /// The number of units inside the PackQualifier
    /// </summary>
    [JsonPropertyName("PackValue")]
    public long? PackValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PackQualifier or
    /// PalletQualifier
    /// </summary>
    [JsonPropertyName("PackVolume")]
    public double? PackVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackVolume is being measured by
    /// </summary>
    [JsonPropertyName("PackVolumeUOM")]
    public string? PackVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PackQualifier or PalletQualifier
    /// </summary>
    [JsonPropertyName("PackWeight")]
    public double? PackWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackWeight is being measured by
    /// </summary>
    [JsonPropertyName("PackWeightUOM")]
    public string? PackWeightUom { get; set; }

    /// <summary>
    /// The smaller horizontal dimension of your pack, as defined by the PackQualifier, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackWidth")]
    public double? PackWidth { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }
}

public class HilariousPriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class HilariousProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class Reference8
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId10>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId10
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class CunningRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class StickyShipmentLine
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Retailer's classification/grouping of products
    /// </summary>
    [JsonPropertyName("Class")]
    public string? Class { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// Quantity that has been shipped to date against a specific order or forecast
    /// </summary>
    [JsonPropertyName("CumulativeQty")]
    public double? CumulativeQty { get; set; }

    /// <summary>
    /// Name or number identifying an area wherein merchandise is categorized within a store
    /// </summary>
    [JsonPropertyName("Department")]
    public string? Department { get; set; }

    /// <summary>
    /// Free form text to describe the name or number identifying an area wherein merchandise is
    /// categorized within a store
    /// </summary>
    [JsonPropertyName("DepartmentDescription")]
    public string? DepartmentDescription { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// Code defining the vendor's status of the item
    /// </summary>
    [JsonPropertyName("ItemStatusCode")]
    public string? ItemStatusCode { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public HilariousNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Most up-to-date quantity
    /// </summary>
    [JsonPropertyName("OrderQty")]
    public double? OrderQty { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the OrderQty
    /// </summary>
    [JsonPropertyName("OrderQtyUOM")]
    public string? OrderQtyUom { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<HilariousProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Quantity of an order, shipment, or the disposition of any difference between the quantity
    /// ordered and quantity shipped for a line item
    /// </summary>
    [JsonPropertyName("QtyLeftToReceive")]
    public double? QtyLeftToReceive { get; set; }

    [JsonPropertyName("SellerDateCode")]
    public string? SellerDateCode { get; set; }

    /// <summary>
    /// Date shipment will leave the ship from location
    /// </summary>
    [JsonPropertyName("ShipDate")]
    public DateTimeOffset? ShipDate { get; set; }

    /// <summary>
    /// Quantity that has already or is scheduled to be shipped/delivered
    /// </summary>
    [JsonPropertyName("ShipQty")]
    public double? ShipQty { get; set; }

    /// <summary>
    /// Unit of measure used with the ShipQty
    /// </summary>
    [JsonPropertyName("ShipQtyUOM")]
    public string? ShipQtyUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class HilariousNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class HilariousProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class StickySubline
{
    [JsonPropertyName("Commodity")]
    public List<MagentaCommodity>? Commodity { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<AmbitiousPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<AmbitiousProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<MagentaRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("SublineItemDetail")]
    public StickySublineItemDetail? SublineItemDetail { get; set; }
}

public class MagentaCommodity
{
    /// <summary>
    /// Code describing a commodity or group of commodities
    /// </summary>
    [JsonPropertyName("CommodityCode")]
    public string? CommodityCode { get; set; }

    /// <summary>
    /// Code identifying the commodity coding system used for Commodity Code
    /// </summary>
    [JsonPropertyName("CommodityCodeQualifier")]
    public string? CommodityCodeQualifier { get; set; }
}

public class AmbitiousPriceInformation
{
    [JsonPropertyName("ChangeReasonCode")]
    public string? ChangeReasonCode { get; set; }

    /// <summary>
    /// Self defined categories used to indicate who is authorized to view or use the related
    /// price information contained in the PriceInformation or PricingType group
    /// </summary>
    [JsonPropertyName("ClassOfTradeCode")]
    public string? ClassOfTradeCode { get; set; }

    [JsonPropertyName("ConditionValue")]
    public string? ConditionValue { get; set; }

    /// <summary>
    /// ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("Currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("EffectiveDate")]
    public DateTimeOffset? EffectiveDate { get; set; }

    /// <summary>
    /// Quantity of units for a given price [i.e. 3 for $10.00].
    /// </summary>
    [JsonPropertyName("MultiplePriceQuantity")]
    public double? MultiplePriceQuantity { get; set; }

    /// <summary>
    /// Value to be used as a multiplier to obtain a new price
    /// </summary>
    [JsonPropertyName("PriceMultiplier")]
    public double? PriceMultiplier { get; set; }

    /// <summary>
    /// Code indicating the type of price multiplier
    /// </summary>
    [JsonPropertyName("PriceMultiplierQual")]
    public string? PriceMultiplierQual { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PriceTypeIDCode")]
    public string? PriceTypeIdCode { get; set; }

    [JsonPropertyName("Quantity")]
    public double? Quantity { get; set; }

    [JsonPropertyName("QuantityUOM")]
    public string? QuantityUom { get; set; }

    [JsonPropertyName("RebateAmount")]
    public double? RebateAmount { get; set; }

    /// <summary>
    /// Price as defined by the PriceTypeIDCode
    /// </summary>
    [JsonPropertyName("UnitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("UnitPriceBasis")]
    public string? UnitPriceBasis { get; set; }

    /// <summary>
    /// Value to be used as a modifier to obtain a new UnitPriceBasis.
    /// </summary>
    [JsonPropertyName("UnitPriceBasisMultiplier")]
    public double? UnitPriceBasisMultiplier { get; set; }
}

public class AmbitiousProductOrItemDescription
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code defining/classifying the type of description being sent
    /// </summary>
    [JsonPropertyName("ProductCharacteristicCode")]
    public string? ProductCharacteristicCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product
    /// </summary>
    [JsonPropertyName("ProductDescription")]
    public string? ProductDescription { get; set; }

    [JsonPropertyName("ProductDescriptionCode")]
    public string? ProductDescriptionCode { get; set; }

    [JsonPropertyName("SourceSubqualifier")]
    public string? SourceSubqualifier { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class MagentaRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class StickySublineItemDetail
{
    /// <summary>
    /// ERP generated code to uniquely identify the item
    /// </summary>
    [JsonPropertyName("ApplicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// Buyer's primary product identifier
    /// </summary>
    [JsonPropertyName("BuyerPartNumber")]
    public string? BuyerPartNumber { get; set; }

    /// <summary>
    /// Consumer level or customer unit product identification number
    /// </summary>
    [JsonPropertyName("ConsumerPackageCode")]
    public string? ConsumerPackageCode { get; set; }

    /// <summary>
    /// International Article Number, aka European Article Number, which is the European
    /// equivalent of the United States UPC[Universal Product Code]
    /// </summary>
    [JsonPropertyName("EAN")]
    public string? Ean { get; set; }

    /// <summary>
    /// Global Trade Item Number which is an item identifier that encompasses all product
    /// identification numbers such as UPC, EAN, ITF, etc. and can be assigned at various packing
    /// levels
    /// </summary>
    [JsonPropertyName("GTIN")]
    public string? Gtin { get; set; }

    /// <summary>
    /// ISBN is a unique number assigned to every book before publication
    /// </summary>
    [JsonPropertyName("InternationalStandardBookNumber")]
    public string? InternationalStandardBookNumber { get; set; }

    /// <summary>
    /// For an initiated document, this is a unique number for the line item[s]. For a return
    /// transaction, this number should be the same as what was received from the source
    /// transaction.
    /// </summary>
    [JsonPropertyName("LineSequenceNumber")]
    public string? LineSequenceNumber { get; set; }

    /// <summary>
    /// National Drug Code or NDC is a unique, universal product identifier for drugs. Primarily
    /// used in the pharmaceutical industry
    /// </summary>
    [JsonPropertyName("NatlDrugCode")]
    public string? NatlDrugCode { get; set; }

    [JsonPropertyName("NRFStandardColorAndSize")]
    public AmbitiousNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned color code. NRF codes should go in the NRFStandardColorAndSize
    /// fields
    /// </summary>
    [JsonPropertyName("ProductColorCode")]
    public string? ProductColorCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product color
    /// </summary>
    [JsonPropertyName("ProductColorDescription")]
    public string? ProductColorDescription { get; set; }

    [JsonPropertyName("ProductID")]
    public List<AmbitiousProductId>? ProductId { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned fabric code/material code. NRF codes should go in the
    /// NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductMaterialCode")]
    public string? ProductMaterialCode { get; set; }

    /// <summary>
    /// Free-form textual description of the item's primary material/fabric
    /// </summary>
    [JsonPropertyName("ProductMaterialDescription")]
    public string? ProductMaterialDescription { get; set; }

    [JsonPropertyName("ProductProcessCode")]
    public string? ProductProcessCode { get; set; }

    [JsonPropertyName("ProductProcessDescription")]
    public string? ProductProcessDescription { get; set; }

    /// <summary>
    /// Vendor/Buyer assigned size code. NRF codes should go in the NRFStandardColorAndSize fields
    /// </summary>
    [JsonPropertyName("ProductSizeCode")]
    public string? ProductSizeCode { get; set; }

    /// <summary>
    /// Free-form textual description of the product size
    /// </summary>
    [JsonPropertyName("ProductSizeDescription")]
    public string? ProductSizeDescription { get; set; }

    /// <summary>
    /// Agreed upon price the buyer is paying for the line item
    /// </summary>
    [JsonPropertyName("PurchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Code specifying the type of unit price for an item
    /// </summary>
    [JsonPropertyName("PurchasePriceBasis")]
    public string? PurchasePriceBasis { get; set; }

    /// <summary>
    /// Code identifying the type of price
    /// </summary>
    [JsonPropertyName("PurchasePriceType")]
    public string? PurchasePriceType { get; set; }

    /// <summary>
    /// Component quantity within the pre-pack
    /// </summary>
    [JsonPropertyName("QtyPer")]
    public double? QtyPer { get; set; }

    /// <summary>
    /// Unit of measure pertaining to the QtyPer
    /// </summary>
    [JsonPropertyName("QtyPerUOM")]
    public string? QtyPerUom { get; set; }

    /// <summary>
    /// Package or case level product identification number
    /// </summary>
    [JsonPropertyName("UPCCaseCode")]
    public string? UpcCaseCode { get; set; }

    /// <summary>
    /// Vendor's primary product identifier
    /// </summary>
    [JsonPropertyName("VendorPartNumber")]
    public string? VendorPartNumber { get; set; }
}

public class AmbitiousNrfStandardColorAndSize
{
    /// <summary>
    /// A name describing a group of associated colors
    /// </summary>
    [JsonPropertyName("ColorCategoryName")]
    public string? ColorCategoryName { get; set; }

    /// <summary>
    /// Human readable text defining the color code
    /// </summary>
    [JsonPropertyName("ColorPrimaryDescription")]
    public string? ColorPrimaryDescription { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the color of the product
    /// </summary>
    [JsonPropertyName("NRFColorCode")]
    public string? NrfColorCode { get; set; }

    /// <summary>
    /// Standardized National Retail Federation Code describing the size of the product
    /// </summary>
    [JsonPropertyName("NRFSizeCode")]
    public string? NrfSizeCode { get; set; }

    /// <summary>
    /// A name describing a group of associated sizes
    /// </summary>
    [JsonPropertyName("SizeCategoryName")]
    public string? SizeCategoryName { get; set; }

    [JsonPropertyName("SizeHeading1")]
    public string? SizeHeading1 { get; set; }

    [JsonPropertyName("SizeHeading2")]
    public string? SizeHeading2 { get; set; }

    [JsonPropertyName("SizeHeading3")]
    public string? SizeHeading3 { get; set; }

    [JsonPropertyName("SizeHeading4")]
    public string? SizeHeading4 { get; set; }

    /// <summary>
    /// Human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizePrimaryDescription")]
    public string? SizePrimaryDescription { get; set; }

    /// <summary>
    /// Additional human readable text defining the size code
    /// </summary>
    [JsonPropertyName("SizeSecondaryDescription")]
    public string? SizeSecondaryDescription { get; set; }

    [JsonPropertyName("SizeTableName")]
    public string? SizeTableName { get; set; }
}

public class AmbitiousProductId
{
    /// <summary>
    /// Additional product identification numbers not defined in specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Qualifier describing the additional product identification numbers not defined in
    /// specific fields at the line level
    /// </summary>
    [JsonPropertyName("PartNumberQual")]
    public string? PartNumberQual { get; set; }
}

public class Tax3
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class TentacledMarksAndNumbersCollection
{
    /// <summary>
    /// Carton or Label ID indicating the shipment or parts of shipment
    /// </summary>
    [JsonPropertyName("MarksAndNumbers1")]
    public string? MarksAndNumbers1 { get; set; }

    /// <summary>
    /// Code specifying the application or source of MarksAndNumbers
    /// </summary>
    [JsonPropertyName("MarksAndNumbersQualifier1")]
    public string? MarksAndNumbersQualifier1 { get; set; }
}

public class BraggadociousNote
{
    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Free-form textual description of the note
    /// </summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>
    /// Code specifying the type of note
    /// </summary>
    [JsonPropertyName("NoteCode")]
    public string? NoteCode { get; set; }
}

public class TentacledPack
{
    /// <summary>
    /// Carrier-Assigned Package ID indicating the shipment or parts of shipment
    /// </summary>
    [JsonPropertyName("CarrierPackageID")]
    public string? CarrierPackageId { get; set; }

    /// <summary>
    /// Indicator that defines the level the label information is provided or a carton reference
    /// number
    /// </summary>
    [JsonPropertyName("PackLevelType")]
    public string? PackLevelType { get; set; }

    /// <summary>
    /// Serial Shipping Container Code[SSCC] and Application Identifier[00] indicates the
    /// shipment or parts of shipment. This field includes both the SSCC[18 digits] and the
    /// Application Identifier[2 digits], which should be 20 digits in length
    /// </summary>
    [JsonPropertyName("ShippingSerialID")]
    public string? ShippingSerialId { get; set; }
}

public class FluffyPackaging
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code specifying the marking, packaging, loading, and related characteristics being
    /// described
    /// </summary>
    [JsonPropertyName("PackagingCharacteristicCode")]
    public string? PackagingCharacteristicCode { get; set; }

    [JsonPropertyName("PackagingDescription")]
    public string? PackagingDescription { get; set; }

    [JsonPropertyName("PackagingDescriptionCode")]
    public string? PackagingDescriptionCode { get; set; }

    /// <summary>
    /// Code identifying loading or unloading a shipment
    /// </summary>
    [JsonPropertyName("UnitLoadOptionCode")]
    public string? UnitLoadOptionCode { get; set; }
}

public class FluffyPalletInformation
{
    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    [JsonPropertyName("Height")]
    public double? Height { get; set; }

    [JsonPropertyName("Length")]
    public double? Length { get; set; }

    /// <summary>
    /// The number of units per horizontal layer on the pallet
    /// </summary>
    [JsonPropertyName("PalletBlocks")]
    public long? PalletBlocks { get; set; }

    /// <summary>
    /// Code specifying pallet exchange instructions
    /// </summary>
    [JsonPropertyName("PalletExchangeCode")]
    public string? PalletExchangeCode { get; set; }

    /// <summary>
    /// Code to identify the pallet hierarchical level
    /// </summary>
    [JsonPropertyName("PalletQualifier")]
    public string? PalletQualifier { get; set; }

    /// <summary>
    /// Code identifying the style of the pallet
    /// </summary>
    [JsonPropertyName("PalletStructureCode")]
    public string? PalletStructureCode { get; set; }

    /// <summary>
    /// The number of vertical layers on the pallet
    /// </summary>
    [JsonPropertyName("PalletTiers")]
    public long? PalletTiers { get; set; }

    /// <summary>
    /// Code indicating the type of material of the pallet
    /// </summary>
    [JsonPropertyName("PalletTypeCode")]
    public string? PalletTypeCode { get; set; }

    /// <summary>
    /// The number of units inside the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletValue")]
    public long? PalletValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletVolume")]
    public double? PalletVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PalletVolume is being measured by
    /// </summary>
    [JsonPropertyName("PalletVolumeUOM")]
    public string? PalletVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletWeight")]
    public double? PalletWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PalletWeight is being measured by
    /// </summary>
    [JsonPropertyName("PalletWeightUOM")]
    public string? PalletWeightUom { get; set; }

    [JsonPropertyName("UnitWeight")]
    public double? UnitWeight { get; set; }

    [JsonPropertyName("UnitWeightUOM")]
    public string? UnitWeightUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pallet when not loaded
    /// </summary>
    [JsonPropertyName("UnloadedHeight")]
    public double? UnloadedHeight { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the UnloadedHeight
    /// </summary>
    [JsonPropertyName("UnloadedHeightUOM")]
    public string? UnloadedHeightUom { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("Width")]
    public double? Width { get; set; }
}

public class IndecentPhysicalDetail
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pack, as defined by the PackQualifer, when the pack is in
    /// the upright position
    /// </summary>
    [JsonPropertyName("PackHeight")]
    public double? PackHeight { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// The larger horizontal dimension of your pack, as defined by the PackQualifer, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackLength")]
    public double? PackLength { get; set; }

    /// <summary>
    /// Code to identify the pack hierarchical level
    /// </summary>
    [JsonPropertyName("PackQualifier")]
    public string? PackQualifier { get; set; }

    /// <summary>
    /// Measurable size of the sellable unit
    /// </summary>
    [JsonPropertyName("PackSize")]
    public double? PackSize { get; set; }

    /// <summary>
    /// Unit of measure for the PackSize
    /// </summary>
    [JsonPropertyName("PackUOM")]
    public string? PackUom { get; set; }

    /// <summary>
    /// The number of units inside the PackQualifier
    /// </summary>
    [JsonPropertyName("PackValue")]
    public long? PackValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PackQualifier or
    /// PalletQualifier
    /// </summary>
    [JsonPropertyName("PackVolume")]
    public double? PackVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackVolume is being measured by
    /// </summary>
    [JsonPropertyName("PackVolumeUOM")]
    public string? PackVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PackQualifier or PalletQualifier
    /// </summary>
    [JsonPropertyName("PackWeight")]
    public double? PackWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackWeight is being measured by
    /// </summary>
    [JsonPropertyName("PackWeightUOM")]
    public string? PackWeightUom { get; set; }

    /// <summary>
    /// The smaller horizontal dimension of your pack, as defined by the PackQualifier, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackWidth")]
    public double? PackWidth { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }
}

public class Reference9
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId11>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId11
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class FriskyRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class Tax4
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class TentacledPackaging
{
    [JsonPropertyName("AgencyQualifierCode")]
    public string? AgencyQualifierCode { get; set; }

    /// <summary>
    /// Code specifying the marking, packaging, loading, and related characteristics being
    /// described
    /// </summary>
    [JsonPropertyName("PackagingCharacteristicCode")]
    public string? PackagingCharacteristicCode { get; set; }

    [JsonPropertyName("PackagingDescription")]
    public string? PackagingDescription { get; set; }

    [JsonPropertyName("PackagingDescriptionCode")]
    public string? PackagingDescriptionCode { get; set; }

    /// <summary>
    /// Code identifying loading or unloading a shipment
    /// </summary>
    [JsonPropertyName("UnitLoadOptionCode")]
    public string? UnitLoadOptionCode { get; set; }
}

public class TentacledPalletInformation
{
    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    [JsonPropertyName("Height")]
    public double? Height { get; set; }

    [JsonPropertyName("Length")]
    public double? Length { get; set; }

    /// <summary>
    /// The number of units per horizontal layer on the pallet
    /// </summary>
    [JsonPropertyName("PalletBlocks")]
    public long? PalletBlocks { get; set; }

    /// <summary>
    /// Code specifying pallet exchange instructions
    /// </summary>
    [JsonPropertyName("PalletExchangeCode")]
    public string? PalletExchangeCode { get; set; }

    /// <summary>
    /// Code to identify the pallet hierarchical level
    /// </summary>
    [JsonPropertyName("PalletQualifier")]
    public string? PalletQualifier { get; set; }

    /// <summary>
    /// Code identifying the style of the pallet
    /// </summary>
    [JsonPropertyName("PalletStructureCode")]
    public string? PalletStructureCode { get; set; }

    /// <summary>
    /// The number of vertical layers on the pallet
    /// </summary>
    [JsonPropertyName("PalletTiers")]
    public long? PalletTiers { get; set; }

    /// <summary>
    /// Code indicating the type of material of the pallet
    /// </summary>
    [JsonPropertyName("PalletTypeCode")]
    public string? PalletTypeCode { get; set; }

    /// <summary>
    /// The number of units inside the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletValue")]
    public long? PalletValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletVolume")]
    public double? PalletVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PalletVolume is being measured by
    /// </summary>
    [JsonPropertyName("PalletVolumeUOM")]
    public string? PalletVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PalletQualifier
    /// </summary>
    [JsonPropertyName("PalletWeight")]
    public double? PalletWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PalletWeight is being measured by
    /// </summary>
    [JsonPropertyName("PalletWeightUOM")]
    public string? PalletWeightUom { get; set; }

    [JsonPropertyName("UnitWeight")]
    public double? UnitWeight { get; set; }

    [JsonPropertyName("UnitWeightUOM")]
    public string? UnitWeightUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pallet when not loaded
    /// </summary>
    [JsonPropertyName("UnloadedHeight")]
    public double? UnloadedHeight { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the UnloadedHeight
    /// </summary>
    [JsonPropertyName("UnloadedHeightUOM")]
    public string? UnloadedHeightUom { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("Width")]
    public double? Width { get; set; }
}

public class HilariousPhysicalDetail
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code specifying the units in which the length, width, or height is being measured by
    /// </summary>
    [JsonPropertyName("DimensionUOM")]
    public string? DimensionUom { get; set; }

    /// <summary>
    /// The vertical dimension of your pack, as defined by the PackQualifer, when the pack is in
    /// the upright position
    /// </summary>
    [JsonPropertyName("PackHeight")]
    public double? PackHeight { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// The larger horizontal dimension of your pack, as defined by the PackQualifer, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackLength")]
    public double? PackLength { get; set; }

    /// <summary>
    /// Code to identify the pack hierarchical level
    /// </summary>
    [JsonPropertyName("PackQualifier")]
    public string? PackQualifier { get; set; }

    /// <summary>
    /// Measurable size of the sellable unit
    /// </summary>
    [JsonPropertyName("PackSize")]
    public double? PackSize { get; set; }

    /// <summary>
    /// Unit of measure for the PackSize
    /// </summary>
    [JsonPropertyName("PackUOM")]
    public string? PackUom { get; set; }

    /// <summary>
    /// The number of units inside the PackQualifier
    /// </summary>
    [JsonPropertyName("PackValue")]
    public long? PackValue { get; set; }

    /// <summary>
    /// Numeric value of volume per unit of measure in reference to the PackQualifier or
    /// PalletQualifier
    /// </summary>
    [JsonPropertyName("PackVolume")]
    public double? PackVolume { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackVolume is being measured by
    /// </summary>
    [JsonPropertyName("PackVolumeUOM")]
    public string? PackVolumeUom { get; set; }

    /// <summary>
    /// Numeric value of total weight in reference to the PackQualifier or PalletQualifier
    /// </summary>
    [JsonPropertyName("PackWeight")]
    public double? PackWeight { get; set; }

    /// <summary>
    /// Code specifying the units in which the PackWeight is being measured by
    /// </summary>
    [JsonPropertyName("PackWeightUOM")]
    public string? PackWeightUom { get; set; }

    /// <summary>
    /// The smaller horizontal dimension of your pack, as defined by the PackQualifier, when the
    /// pack is in the upright position
    /// </summary>
    [JsonPropertyName("PackWidth")]
    public double? PackWidth { get; set; }

    [JsonPropertyName("SurfaceLayerPositionCode")]
    public string? SurfaceLayerPositionCode { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }
}

public class Reference10
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId12>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId12
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class MischievousRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class Tax5
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

/// <summary>
/// This group contains the quantity of your PackingMedium and other related values such as
/// weight and volume
/// </summary>
public class FluffyQuantityAndWeight
{
    [JsonPropertyName("LadingDescription")]
    public string? LadingDescription { get; set; }

    /// <summary>
    /// Number of units/pieces of the lading commodity
    /// </summary>
    [JsonPropertyName("LadingQuantity")]
    public long? LadingQuantity { get; set; }

    /// <summary>
    /// Code identifying the type of packaging material
    /// </summary>
    [JsonPropertyName("PackingMaterial")]
    public string? PackingMaterial { get; set; }

    /// <summary>
    /// Code identifying the type of packaging
    /// </summary>
    [JsonPropertyName("PackingMedium")]
    public string? PackingMedium { get; set; }

    /// <summary>
    /// Code specifying pallet exchange instructions
    /// </summary>
    [JsonPropertyName("PalletExchangeCode")]
    public string? PalletExchangeCode { get; set; }

    [JsonPropertyName("Volume")]
    public double? Volume { get; set; }

    [JsonPropertyName("VolumeUOM")]
    public string? VolumeUom { get; set; }

    [JsonPropertyName("Weight")]
    public double? Weight { get; set; }

    /// <summary>
    /// Code defining the type of weight
    /// </summary>
    [JsonPropertyName("WeightQualifier")]
    public string? WeightQualifier { get; set; }

    [JsonPropertyName("WeightUOM")]
    public string? WeightUom { get; set; }
}

public class Reference11
{
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("ReferenceIDs")]
    public List<ReferenceId13>? ReferenceIDs { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }

    /// <summary>
    /// All standard XML formats are accepted.
    /// </summary>
    [JsonPropertyName("Time")]
    public string? Time { get; set; }
}

public class ReferenceId13
{
    [JsonPropertyName("ReferenceID")]
    public string? ReferenceId { get; set; }

    /// <summary>
    /// Code specifying the type of data in the ReferenceID/ReferenceDescription
    /// </summary>
    [JsonPropertyName("ReferenceQual")]
    public string? ReferenceQual { get; set; }
}

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class BraggadociousRegulatoryCompliance
{
    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Used to indicate the organization responsible for validating or enforcing the
    /// RegulatoryComplianceQual when not otherwise specified by the RegulatoryComplianceQual
    /// </summary>
    [JsonPropertyName("RegulatoryAgency")]
    public string? RegulatoryAgency { get; set; }

    /// <summary>
    /// The ID relating to the RegulatoryComplianceQual, if applicable
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceID")]
    public string? RegulatoryComplianceId { get; set; }

    /// <summary>
    /// Code indicating the act or legislation
    /// </summary>
    [JsonPropertyName("RegulatoryComplianceQual")]
    public string? RegulatoryComplianceQual { get; set; }

    /// <summary>
    /// Code indicating a Yes or No condition or response
    /// </summary>
    [JsonPropertyName("YesOrNoResponse")]
    public string? YesOrNoResponse { get; set; }
}

public class Tax6
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    /// <summary>
    /// Free-form textual description to clarify the related data elements and their content
    /// </summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>
    /// Code represents the City, State, or Providence[tax authority] associated with the Tax
    /// group
    /// </summary>
    [JsonPropertyName("JurisdictionCode")]
    public string? JurisdictionCode { get; set; }

    /// <summary>
    /// Code identifying the source of the data used in the Tax JurisdictionCode
    /// </summary>
    [JsonPropertyName("JurisdictionQual")]
    public string? JurisdictionQual { get; set; }

    /// <summary>
    /// Monetary amount that is used when calculating a tax, allowance, or charge amount.
    /// </summary>
    [JsonPropertyName("PercentDollarBasis")]
    public double? PercentDollarBasis { get; set; }

    /// <summary>
    /// Code identifying whether the tax amount is included in the total transaction amount
    /// </summary>
    [JsonPropertyName("RelationshipCode")]
    public string? RelationshipCode { get; set; }

    /// <summary>
    /// The monetary amount applied
    /// </summary>
    [JsonPropertyName("TaxAmount")]
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Code indicating whether the header or item level data is exempt[or not exempt] for the
    /// tax and taxing authority indicated in JurisdictionCode
    /// </summary>
    [JsonPropertyName("TaxExemptCode")]
    public string? TaxExemptCode { get; set; }

    /// <summary>
    /// Code indicating method of handling for a tax
    /// </summary>
    [JsonPropertyName("TaxHandlingCode")]
    public string? TaxHandlingCode { get; set; }

    /// <summary>
    /// Number assigned to a purchaser[buyer, orderer] by a tax jurisdiction[state, country, etc]
    /// </summary>
    [JsonPropertyName("TaxID")]
    public string? TaxId { get; set; }

    /// <summary>
    /// The percentage that is applied to determine the tax amount. Percentages should be
    /// represented as real numbers[0% through 100% should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TaxPercent")]
    public double? TaxPercent { get; set; }

    /// <summary>
    /// Code indicating on what basis a tax percent is calculated
    /// </summary>
    [JsonPropertyName("TaxPercentQual")]
    public string? TaxPercentQual { get; set; }

    /// <summary>
    /// Identification of the type of duty, tax, or fee applicable to commodities or of tax
    /// applicable to services
    /// </summary>
    [JsonPropertyName("TaxTypeCode")]
    public string? TaxTypeCode { get; set; }
}

public class Summary
{
    /// <summary>
    /// Sum of the total number of line items in this document
    /// </summary>
    [JsonPropertyName("TotalLineItemNumber")]
    public long? TotalLineItemNumber { get; set; }

    [JsonPropertyName("TotalOrders")]
    public long? TotalOrders { get; set; }
}





