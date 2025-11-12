

namespace SPSCommerceSDK.Models.Invoices;
public class Invoice
{
    [JsonPropertyName("Header")]
    public Header? Header { get; set; }

    [JsonPropertyName("LineItem")]
    public List<LineItem>? LineItem { get; set; }

    /// <summary>
    /// Contains internal SPS information
    /// </summary>
    [JsonPropertyName("Meta")]
    public Meta? Meta { get; set; }

    [JsonPropertyName("Summary")]
    public Summary? Summary { get; set; }
}

public class Header
{
    [JsonPropertyName("Address")]
    public List<HeaderAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<HeaderCarrierInformation>? CarrierInformation { get; set; }

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

    [JsonPropertyName("InvoiceHeader")]
    public InvoiceHeader? InvoiceHeader { get; set; }

    [JsonPropertyName("Notes")]
    public List<HeaderNote>? Notes { get; set; }

    [JsonPropertyName("PaymentTerms")]
    public List<PaymentTerm>? PaymentTerms { get; set; }

    [JsonPropertyName("QuantityTotals")]
    public List<QuantityTotal>? QuantityTotals { get; set; }

    [JsonPropertyName("References")]
    public List<HeaderReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<HeaderRegulatoryCompliance>? RegulatoryCompliances { get; set; }

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
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
}

public class PurpleReference
{
    [JsonPropertyName("Date")]
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
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

public class HeaderCarrierInformation
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

    [JsonPropertyName("TransitTimeQualifier")]
    public string? TransitTimeQualifier { get; set; }
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
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
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
    public DateTimeOffset? Time { get; set; }
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

public class InvoiceHeader
{
    /// <summary>
    /// Code indicating the type of action
    /// </summary>
    [JsonPropertyName("ActionCode")]
    public string? ActionCode { get; set; }

    [JsonPropertyName("AdditionalPOTypeCodes")]
    public List<AdditionalPoTypeCode>? AdditionalPoTypeCodes { get; set; }

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
    public string? InvoiceDate { get; set; }

    /// <summary>
    /// Unique identifier assigned by the billing party
    /// </summary>
    [JsonPropertyName("InvoiceNumber")]
    public string? InvoiceNumber { get; set; }

    [JsonPropertyName("InvoiceTime")]
    public DateTimeOffset? InvoiceTime { get; set; }

    /// <summary>
    /// Code that identifies the type of Invoice
    /// </summary>
    [JsonPropertyName("InvoiceTypeCode")]
    public string? InvoiceTypeCode { get; set; }

    /// <summary>
    /// Project number assigned to a standard reorder purchase order
    /// </summary>
    [JsonPropertyName("JobNumber")]
    public string? JobNumber { get; set; }

    /// <summary>
    /// Code designating the language used in text. ISO 639 language code
    /// </summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// Code indicating the specific details regarding the ordering document
    /// </summary>
    [JsonPropertyName("PrimaryPOTypeCode")]
    public string? PrimaryPoTypeCode { get; set; }

    /// <summary>
    /// Free form text to describe the specific details regarding the ordering document
    /// </summary>
    [JsonPropertyName("PrimaryPOTypeDescription")]
    public string? PrimaryPoTypeDescription { get; set; }

    /// <summary>
    /// Date the purchase order was created
    /// </summary>
    [JsonPropertyName("PurchaseOrderDate")]
    public string? PurchaseOrderDate { get; set; }

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
    /// Sellers Alpha ISO Currency Code[http://www.iso.org/iso/home/standards/currency_codes.htm]
    /// </summary>
    [JsonPropertyName("SellersCurrency")]
    public string? SellersCurrency { get; set; }

    /// <summary>
    /// Date shipment will leave the ship from location
    /// </summary>
    [JsonPropertyName("ShipDate")]
    public string? ShipDate { get; set; }

    [JsonPropertyName("ShipDeliveryDate")]
    public DateTimeOffset? ShipDeliveryDate { get; set; }

    [JsonPropertyName("ShipDeliveryTime")]
    public DateTimeOffset? ShipDeliveryTime { get; set; }

    [JsonPropertyName("ShipTime")]
    public DateTimeOffset? ShipTime { get; set; }

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

    /// <summary>
    /// Number assigned by buyer that uniquely identifies the vendor
    /// </summary>
    [JsonPropertyName("Vendor")]
    public string? Vendor { get; set; }
}

/// <summary>
/// This group should be used if the associated normalized fields already contain information.
/// </summary>
public class AdditionalPoTypeCode
{
    /// <summary>
    /// Code indicating additional details regarding the ordering document
    /// </summary>
    [JsonPropertyName("POTypeCode")]
    public string? PoTypeCode { get; set; }

    /// <summary>
    /// Free form text to describe the additional details regarding the ordering document
    /// </summary>
    [JsonPropertyName("POTypeDescription")]
    public string? PoTypeDescription { get; set; }
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

public class PaymentTerm
{
    /// <summary>
    /// Monetary amount upon which the terms discount amount is calculated
    /// </summary>
    [JsonPropertyName("AmountSubjectToDiscount")]
    public double? AmountSubjectToDiscount { get; set; }

    /// <summary>
    /// Amount due if all discount terms are met
    /// </summary>
    [JsonPropertyName("DiscountAmountDue")]
    public double? DiscountAmountDue { get; set; }

    /// <summary>
    /// Indicates that this is the percentage applied to a base amount used to determine a late
    /// payment charge
    /// </summary>
    [JsonPropertyName("LatePaymentChargePercent")]
    public double? LatePaymentChargePercent { get; set; }

    /// <summary>
    /// Indication of the instrument of payment
    /// </summary>
    [JsonPropertyName("PaymentMethodCode")]
    public string? PaymentMethodCode { get; set; }

    /// <summary>
    /// Used to communicate the data of the PaymentMethodCode
    /// </summary>
    [JsonPropertyName("PaymentMethodID")]
    public string? PaymentMethodId { get; set; }

    /// <summary>
    /// Percentages should be represented as real numbers[0% through 100% should be normalized to
    /// 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("PercentOfInvoicePayable")]
    public double? PercentOfInvoicePayable { get; set; }

    /// <summary>
    /// Code identifying the beginning of the terms period
    /// </summary>
    [JsonPropertyName("TermsBasisDateCode")]
    public string? TermsBasisDateCode { get; set; }

    /// <summary>
    /// The monetary amount which the payment is due if terms may have been deferred
    /// </summary>
    [JsonPropertyName("TermsDeferredAmountDue")]
    public double? TermsDeferredAmountDue { get; set; }

    /// <summary>
    /// Date by which the payment is due if terms have been deferred
    /// </summary>
    [JsonPropertyName("TermsDeferredDueDate")]
    public DateTimeOffset? TermsDeferredDueDate { get; set; }

    /// <summary>
    /// A free-form description to clarify the terms
    /// </summary>
    [JsonPropertyName("TermsDescription")]
    public string? TermsDescription { get; set; }

    /// <summary>
    /// Discount amount available to the purchaser if an invoice is paid on or before the
    /// TermsDiscountDate
    /// </summary>
    [JsonPropertyName("TermsDiscountAmount")]
    public double? TermsDiscountAmount { get; set; }

    /// <summary>
    /// Date by which payment or invoice must be received in order to receive the discount noted
    /// </summary>
    [JsonPropertyName("TermsDiscountDate")]
    public DateTimeOffset? TermsDiscountDate { get; set; }

    /// <summary>
    /// Number of days by which payment or invoice must be received in order to receive the
    /// discount noted
    /// </summary>
    [JsonPropertyName("TermsDiscountDueDays")]
    public long? TermsDiscountDueDays { get; set; }

    /// <summary>
    /// Terms discount percentage available to the purchaser if an invoice is paid on or before
    /// the TermsDiscountDate. Percentages should be represented as real numbers[0% through 100%
    /// should be normalized to 0.0 through 100.00]
    /// </summary>
    [JsonPropertyName("TermsDiscountPercentage")]
    public double? TermsDiscountPercentage { get; set; }

    /// <summary>
    /// Code identifying the method to be used for payment in conjunction with due date
    /// </summary>
    [JsonPropertyName("TermsDueDateQual")]
    public string? TermsDueDateQual { get; set; }

    /// <summary>
    /// Numeric value for day of month
    /// </summary>
    [JsonPropertyName("TermsDueDay")]
    public long? TermsDueDay { get; set; }

    /// <summary>
    /// Date by which total invoice amount is due[discount not applicable]
    /// </summary>
    [JsonPropertyName("TermsNetDueDate")]
    public string? TermsNetDueDate { get; set; }

    /// <summary>
    /// Number of days until total invoice amount is due[discount not applicable]
    /// </summary>
    [JsonPropertyName("TermsNetDueDays")]
    public long? TermsNetDueDays { get; set; }

    /// <summary>
    /// Date from which payment terms are calculated
    /// </summary>
    [JsonPropertyName("TermsStartDate")]
    public DateTimeOffset? TermsStartDate { get; set; }

    /// <summary>
    /// Code relating the TermsBasisDateCode to a date, time, or period
    /// </summary>
    [JsonPropertyName("TermsTimeRelationCode")]
    public string? TermsTimeRelationCode { get; set; }

    /// <summary>
    /// Code identifying type of payment terms
    /// </summary>
    [JsonPropertyName("TermsType")]
    public string? TermsType { get; set; }
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
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
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

public class LineItem
{
    [JsonPropertyName("Address")]
    public List<LineItemAddress>? Address { get; set; }

    [JsonPropertyName("CarrierInformation")]
    public List<LineItemCarrierInformation>? CarrierInformation { get; set; }

    [JsonPropertyName("ChargesAllowances")]
    public List<LineItemChargesAllowance>? ChargesAllowances { get; set; }

    [JsonPropertyName("Commodity")]
    public List<LineItemCommodity>? Commodity { get; set; }

    [JsonPropertyName("Dates")]
    public List<LineItemDate>? Dates { get; set; }

    [JsonPropertyName("InvoiceLine")]
    public InvoiceLine? InvoiceLine { get; set; }

    [JsonPropertyName("MasterItemAttribute")]
    public List<MasterItemAttribute>? MasterItemAttribute { get; set; }

    [JsonPropertyName("Measurements")]
    public List<LineItemMeasurement>? Measurements { get; set; }

    [JsonPropertyName("Notes")]
    public List<LineItemNote>? Notes { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<LineItemPhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<LineItemPriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<LineItemProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("QuantitiesSchedulesLocations")]
    public List<QuantitiesSchedulesLocation>? QuantitiesSchedulesLocations { get; set; }

    [JsonPropertyName("References")]
    public List<LineItemReference>? References { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<LineItemRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("Subline")]
    public List<Subline>? Subline { get; set; }

    [JsonPropertyName("Taxes")]
    public List<LineItemTax>? Taxes { get; set; }
}

public class LineItemAddress
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

public class TentacledDate
{
    [JsonPropertyName("Date")]
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
}

public class FluffyReference
{
    [JsonPropertyName("Date")]
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
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

public class LineItemCarrierInformation
{
    [JsonPropertyName("Address")]
    public List<FluffyAddress>? Address { get; set; }

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

    [JsonPropertyName("TransitTimeQualifier")]
    public string? TransitTimeQualifier { get; set; }
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
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
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

public class LineItemChargesAllowance
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

public class LineItemCommodity
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

public class LineItemDate
{
    [JsonPropertyName("Date")]
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
}

public class InvoiceLine
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
    /// A flag to indicate if cash discount is applicable to the item
    /// </summary>
    [JsonPropertyName("CashDiscount")]
    public string? CashDiscount { get; set; }

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
    /// Quantity Ordered * Price
    /// </summary>
    [JsonPropertyName("ExtendedItemTotal")]
    public double? ExtendedItemTotal { get; set; }

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
    /// Quantity being billed
    /// </summary>
    [JsonPropertyName("InvoiceQty")]
    public double? InvoiceQty { get; set; }

    /// <summary>
    /// Unit of measure used in relation with the InvoiceQty
    /// </summary>
    [JsonPropertyName("InvoiceQtyUOM")]
    public string? InvoiceQtyUom { get; set; }

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
    public InvoiceLineNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

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
    public List<InvoiceLineProductId>? ProductId { get; set; }

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

    /// <summary>
    /// Code indicating the quantity of an order, shipment, or the disposition of any difference
    /// between the quantity ordered and quantity shipped for a line item
    /// </summary>
    [JsonPropertyName("QtyLeftToReceiveStatus")]
    public string? QtyLeftToReceiveStatus { get; set; }

    /// <summary>
    /// Type of sale or service being provided. This field is typically used in Tradacoms.
    /// </summary>
    [JsonPropertyName("SaleOrService")]
    public string? SaleOrService { get; set; }

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

public class InvoiceLineNrfStandardColorAndSize
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

public class InvoiceLineProductId
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

/// <summary>
/// This group is to link item attributes that are talking about the same part of the item.
/// Only once per MasterItemAttribute can a specific ItemAttributeQualifier be used
/// </summary>
public class MasterItemAttribute
{
    [JsonPropertyName("ItemAttribute")]
    public List<ItemAttribute>? ItemAttribute { get; set; }
}

/// <summary>
/// This group describes a part of an item
/// </summary>
public class ItemAttribute
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
    public List<ItemAttributeMeasurement>? Measurements { get; set; }

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

public class ItemAttributeMeasurement
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

public class LineItemMeasurement
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

public class LineItemNote
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

public class LineItemPhysicalDetail
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

public class LineItemPriceInformation
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

public class LineItemProductOrItemDescription
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
/// Specialized quantities that may be defined by location and/or dates
/// </summary>
public class QuantitiesSchedulesLocation
{
    [JsonPropertyName("AssignedID")]
    public string? AssignedId { get; set; }

    [JsonPropertyName("Dates")]
    public List<QuantitiesSchedulesLocationDate>? Dates { get; set; }

    /// <summary>
    /// Code indicating the time range that applies to LeadTimePeriodInterval, LeadTimeQuantity,
    /// and LeadTimeDate
    /// </summary>
    [JsonPropertyName("LeadTimeCode")]
    public string? LeadTimeCode { get; set; }

    /// <summary>
    /// Date that indicates when a LeadTimeCode takes effect
    /// </summary>
    [JsonPropertyName("LeadTimeDate")]
    public DateTimeOffset? LeadTimeDate { get; set; }

    /// <summary>
    /// Code indicating the units of time that apply to the LeadTimeQuantity
    /// </summary>
    [JsonPropertyName("LeadTimePeriodInterval")]
    public string? LeadTimePeriodInterval { get; set; }

    /// <summary>
    /// The amount of time allowed to fulfill the primary function of the transaction
    /// </summary>
    [JsonPropertyName("LeadTimeQuantity")]
    public double? LeadTimeQuantity { get; set; }

    /// <summary>
    /// Code identifying the structure or format of the related location number[s]
    /// </summary>
    [JsonPropertyName("LocationCodeQualifier")]
    public string? LocationCodeQualifier { get; set; }

    /// <summary>
    /// Generic description to explain all the location quantities. i.e. Bin Number, Warehouse,
    /// Stockroom
    /// </summary>
    [JsonPropertyName("LocationDescription")]
    public string? LocationDescription { get; set; }

    [JsonPropertyName("LocationQuantity")]
    public List<LocationQuantity>? LocationQuantity { get; set; }

    /// <summary>
    /// Free-form text to further describe the QuantityQualifier
    /// </summary>
    [JsonPropertyName("QuantityDescription")]
    public string? QuantityDescription { get; set; }

    /// <summary>
    /// Qualifier used to define the type of quantity to follow
    /// </summary>
    [JsonPropertyName("QuantityQualifier")]
    public string? QuantityQualifier { get; set; }

    /// <summary>
    /// Numeric value of the total quantity
    /// </summary>
    [JsonPropertyName("TotalQty")]
    public double? TotalQty { get; set; }

    /// <summary>
    /// The unit of measure for the numeric value of the total quantity
    /// </summary>
    [JsonPropertyName("TotalQtyUOM")]
    public string? TotalQtyUom { get; set; }
}

public class QuantitiesSchedulesLocationDate
{
    [JsonPropertyName("Date")]
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
}

public class LocationQuantity
{
    /// <summary>
    /// For CrossDock, it's the marked for location. For MultiStore[could also be DC] ship-to
    /// location
    /// </summary>
    [JsonPropertyName("Location")]
    public string? Location { get; set; }

    /// <summary>
    /// Numeric value of quantity
    /// </summary>
    [JsonPropertyName("Qty")]
    public double? Qty { get; set; }
}

public class LineItemReference
{
    [JsonPropertyName("Date")]
    public DateTimeOffset? Date { get; set; }

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
    public DateTimeOffset? Time { get; set; }
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

/// <summary>
/// Indicates that the related item[s] are following the specified government or industry
/// rules regarding material, manufacturing process and or end product
/// </summary>
public class LineItemRegulatoryCompliance
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

public class Subline
{
    [JsonPropertyName("Commodity")]
    public List<SublineCommodity>? Commodity { get; set; }

    [JsonPropertyName("PhysicalDetails")]
    public List<SublinePhysicalDetail>? PhysicalDetails { get; set; }

    [JsonPropertyName("PriceInformation")]
    public List<SublinePriceInformation>? PriceInformation { get; set; }

    [JsonPropertyName("ProductOrItemDescription")]
    public List<SublineProductOrItemDescription>? ProductOrItemDescription { get; set; }

    [JsonPropertyName("RegulatoryCompliances")]
    public List<SublineRegulatoryCompliance>? RegulatoryCompliances { get; set; }

    [JsonPropertyName("SublineItemDetail")]
    public SublineItemDetail? SublineItemDetail { get; set; }
}

public class SublineCommodity
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

public class SublinePhysicalDetail
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

public class SublinePriceInformation
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

public class SublineProductOrItemDescription
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
public class SublineRegulatoryCompliance
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

public class SublineItemDetail
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
    public SublineItemDetailNrfStandardColorAndSize? NrfStandardColorAndSize { get; set; }

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
    public List<SublineItemDetailProductId>? ProductId { get; set; }

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

public class SublineItemDetailNrfStandardColorAndSize
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

public class SublineItemDetailProductId
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

public class LineItemTax
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

public class Summary
{
    /// <summary>
    /// Data element providing secure method for identifying authenticity of content. Value
    /// calculated by using CRC 16 algorithm
    /// </summary>
    [JsonPropertyName("IntegrityCheckValue")]
    public string? IntegrityCheckValue { get; set; }

    /// <summary>
    /// Total amount of transaction if paid by the terms date
    /// </summary>
    [JsonPropertyName("InvoiceAmtDueByTermsDate")]
    public double? InvoiceAmtDueByTermsDate { get; set; }

    /// <summary>
    /// Electronic identity. Calculation algorithm obtained from the Uniform Code Council
    /// </summary>
    [JsonPropertyName("SignatureIdentification")]
    public string? SignatureIdentification { get; set; }

    /// <summary>
    /// Free form text to describe the SignatureIdentification
    /// </summary>
    [JsonPropertyName("SignatureName")]
    public string? SignatureName { get; set; }

    [JsonPropertyName("TotalAllowancesAmount")]
    public double? TotalAllowancesAmount { get; set; }

    /// <summary>
    /// Total amount of the transaction. Sum of the item qty * price +/- the charges, allowances,
    /// and taxes, if sent
    /// </summary>
    [JsonPropertyName("TotalAmount")]
    public double? TotalAmount { get; set; }

    [JsonPropertyName("TotalCartonCount")]
    public double? TotalCartonCount { get; set; }

    /// <summary>
    /// Total amount of the charges
    /// </summary>
    [JsonPropertyName("TotalChargesAmount")]
    public double? TotalChargesAmount { get; set; }

    [JsonPropertyName("TotalFreightCharges")]
    public double? TotalFreightCharges { get; set; }

    /// <summary>
    /// Sum of the total number of line items in this document
    /// </summary>
    [JsonPropertyName("TotalLineItemNumber")]
    public long? TotalLineItemNumber { get; set; }

    [JsonPropertyName("TotalNonFreightCharges")]
    public double? TotalNonFreightCharges { get; set; }

    /// <summary>
    /// Total merchandise amount. Sum of price * quantity
    /// </summary>
    [JsonPropertyName("TotalSalesAmount")]
    public double? TotalSalesAmount { get; set; }

    /// <summary>
    /// Total tax and allowance/charges amount. This is the difference between TotalAmount and
    /// TotalSalesAmount
    /// </summary>
    [JsonPropertyName("TotalTaxesAndCharges")]
    public double? TotalTaxesAndCharges { get; set; }

    /// <summary>
    /// Total amount of the discount subtracted from the net
    /// </summary>
    [JsonPropertyName("TotalTermsDiscountAmount")]
    public double? TotalTermsDiscountAmount { get; set; }
}
