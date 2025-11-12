namespace SPSCommerceSDK.Models;

public class ShipingLabels
{
    public Header Header { get; set; }
    public Pallet[] Pallet { get; set; }
    public Pack1[] Pack { get; set; }
}

public class Header
{
    public string PurchaseOrderNumber { get; set; }
    public string BillOfLadingNumber { get; set; }
    public Address[] Address { get; set; }
    public Carrierinformation[] CarrierInformation { get; set; }
    public string CarrierProNumber { get; set; }
    public string ShipDate { get; set; }
    public Date[] Dates { get; set; }
    public string Department { get; set; }
    public Reference1[] References { get; set; }
    public string TradingPartnerId { get; set; }
    public string Vendor { get; set; }
    public string ShipmentIdentification { get; set; }
    public Quantitytotal[] QuantityTotals { get; set; }
    public string CustomerOrderNumber { get; set; }
    public string Division { get; set; }
    public Note[] Notes { get; set; }
    public string PurchaseOrderDate { get; set; }
    public string AppointmentNumber { get; set; }
    public string DepartmentDescription { get; set; }
    public string CustomerAccountNumber { get; set; }
    public Contact1[] Contacts { get; set; }
    public Fobrelatedinstruction[] FOBRelatedInstruction { get; set; }
}

public class Address
{
    public string AddressTypeCode { get; set; }
    public string AddressName { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public Contact[] Contacts { get; set; }
    public string LocationCodeQualifier { get; set; }
    public string AddressLocationNumber { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int PackWeight { get; set; }
    public string AddressAlternateName { get; set; }
    public string AddressAlternateName2 { get; set; }
    public string Address3 { get; set; }
    public string Address4 { get; set; }
    public Reference[] References { get; set; }
}

public class Contact
{
    public string ContactTypeCode { get; set; }
    public string PrimaryPhone { get; set; }
    public string PrimaryEmail { get; set; }
    public string ContactName { get; set; }
}

public class Reference
{
    public string ReferenceQual { get; set; }
    public string ReferenceID { get; set; }
    public string Description { get; set; }
}

public class Carrierinformation
{
    public string CarrierRouting { get; set; }
    public string CarrierAlphaCode { get; set; }
    public string CarrierTransMethodCode { get; set; }
}

public class Date
{
    public string DateTimeQualifier { get; set; }

    [JsonPropertyName("Date")]
    public string Date_ { get; set; }
}

public class Reference1
{
    public string ReferenceQual { get; set; }
    public string ReferenceID { get; set; }
    public string Description { get; set; }
}

public class Quantitytotal
{
    public string QuantityTotalsQualifier { get; set; }
    public string WeightQualifier { get; set; }
    public int Weight { get; set; }
    public string WeightUOM { get; set; }
    public string QuantityUOM { get; set; }
    public int Volume { get; set; }
    public long Quantity { get; set; }
}

public class Note
{
    public string NoteCode { get; set; }

    [JsonPropertyName("Note")]
    public string Note_ { get; set; }
}

public class Contact1
{
    public string ContactTypeCode { get; set; }
    public string ContactName { get; set; }
}

public class Fobrelatedinstruction
{
    public string FOBLocationQualifier { get; set; }
    public string FOBLocationDescription { get; set; }
}

public class Pallet
{
    public Pack[] Pack { get; set; }
}

public class Pack
{
    public string ShippingSerialID { get; set; }
    public Reference2[] References { get; set; }
    public Address1[] Address { get; set; }
    public Item[] Item { get; set; }
    public Physicaldetail1[] PhysicalDetails { get; set; }
    public Marksandnumberscollection[] MarksAndNumbersCollection { get; set; }
    public Note2[] Notes { get; set; }
    public string CarrierPackageID { get; set; }
}

public class Reference2
{
    public string ReferenceQual { get; set; }
}

public class Address1
{
    public string AddressTypeCode { get; set; }
    public string LocationCodeQualifier { get; set; }
    public string AddressLocationNumber { get; set; }
    public string AddressName { get; set; }

    [JsonPropertyName("Address1")]
    public string Address_1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Address4 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}

public class Item
{
    public string BuyerPartNumber { get; set; }
    public string VendorPartNumber { get; set; }
    public int ShipQty { get; set; }
    public string ConsumerPriceType { get; set; }
    public string ConsumerPackageCode { get; set; }
    public Productoritemdescription[] ProductOrItemDescription { get; set; }
    public Date1[] Dates { get; set; }
    public string GTIN { get; set; }
    public Reference3[] References { get; set; }
    public string ProductSizeDescription { get; set; }
    public string ProductColorDescription { get; set; }
    public Subline[] Subline { get; set; }
    public Productid ProductID { get; set; }
    public string ProductMaterialCode { get; set; }
    public string ProductMaterialDescription { get; set; }
    public string EAN { get; set; }
    public string UPCCaseCode { get; set; }
    public string InternationalStandardBookNumber { get; set; }
    public string Department { get; set; }
    public string DepartmentDescription { get; set; }
    public Note1[] Notes { get; set; }
    public Physicaldetail[] PhysicalDetails { get; set; }
    public string ProductSizeCode { get; set; }
    public string ProductColorCode { get; set; }
    public string Class { get; set; }
}

public class Productid
{
    public string PartNumberQual { get; set; }
    public string PartNumber { get; set; }
}

public class Productoritemdescription
{
    public string ProductCharacteristicCode { get; set; }
    public string ProductDescription { get; set; }
    public string ProductDescriptionCode { get; set; }
}

public class Date1
{
    public string DateTimeQualifier { get; set; }
    public string Date { get; set; }
}

public class Reference3
{
    public string ReferenceQual { get; set; }
    public string ReferenceID { get; set; }
}

public class Subline
{
    public string VendorPartNumber { get; set; }
    public string ProductSizeDescription { get; set; }
    public string ProductColorDescription { get; set; }
    public long QtyPer { get; set; }
    public Productoritemdescription1[] ProductOrItemDescription { get; set; }
}

public class Productoritemdescription1
{
    public string ProductCharacteristicCode { get; set; }
    public string ProductDescription { get; set; }
}

public class Note1
{
    public string NoteCode { get; set; }
    public string Note { get; set; }
}

public class Physicaldetail
{
    public string PackQualifier { get; set; }
    public long PackValue { get; set; }
    public string PackUOM { get; set; }
    public string PackWeightUOM { get; set; }
    public int PackWeight { get; set; }
}

public class Physicaldetail1
{
    public string PackQualifier { get; set; }
    public int PackWeight { get; set; }
    public string Description { get; set; }
}

public class Marksandnumberscollection
{
    public string MarksAndNumbersQualifier1 { get; set; }
    public string MarksAndNumbers1 { get; set; }
}

public class Note2
{
    public string NoteCode { get; set; }
    public string Note { get; set; }
}

public class Pack1
{
    public string PackLevelType { get; set; }
    public string ShippingSerialID { get; set; }
    public Address2 Address { get; set; }
    public Pack2[] Pack { get; set; }
    public Physicaldetail4[] PhysicalDetails { get; set; }
    public Reference5[] References { get; set; }
    public Marksandnumberscollection2[] MarksAndNumbersCollection { get; set; }
    public string CarrierPackageID { get; set; }
    public Note4[] Notes { get; set; }
}

public class Address2
{
    public string AddressTypeCode { get; set; }
    public string LocationCodeQualifier { get; set; }
    public string AddressLocationNumber { get; set; }
    public string AddressName { get; set; }
    public string Address1 { get; set; }

    [JsonPropertyName("Address2")]
    public string Address_2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}

public class Pack2
{
    public Item1[] Item { get; set; }
    public string PackLevelType { get; set; }
    public Physicaldetail3[] PhysicalDetails { get; set; }
    public Marksandnumberscollection1[] MarksAndNumbersCollection { get; set; }
    public string ShippingSerialID { get; set; }
    public Palletinformation[] PalletInformation { get; set; }
    public Address3[] Address { get; set; }
}

public class Item1
{
    public string BuyerPartNumber { get; set; }
    public string ConsumerPackageCode { get; set; }
    public int ShipQty { get; set; }
    public string VendorPartNumber { get; set; }
    public Productoritemdescription2[] ProductOrItemDescription { get; set; }
    public Reference4[] References { get; set; }
    public string GTIN { get; set; }
    public Date2[] Dates { get; set; }
    public string ShipQtyUOM { get; set; }
    public Physicaldetail2[] PhysicalDetails { get; set; }
    public Note3[] Notes { get; set; }
    public string UPCCaseCode { get; set; }
    public string ProductSizeDescription { get; set; }
    public string ProductColorDescription { get; set; }
    public string LineSequenceNumber { get; set; }
    public string EAN { get; set; }
    public string ProductSizeCode { get; set; }
    public string ProductColorCode { get; set; }
    public int OrderQty { get; set; }
    public string ProductMaterialDescription { get; set; }
    public string Class { get; set; }
    public string ProductMaterialCode { get; set; }
    public string Department { get; set; }
    public string DepartmentDescription { get; set; }
}

public class Productoritemdescription2
{
    public string ProductCharacteristicCode { get; set; }
    public string ProductDescription { get; set; }
    public string ProductDescriptionCode { get; set; }
}

public class Reference4
{
    public string ReferenceQual { get; set; }
    public string ReferenceID { get; set; }
}

public class Date2
{
    public string DateTimeQualifier { get; set; }
    public string Date { get; set; }
}

public class Physicaldetail2
{
    public string PackQualifier { get; set; }
    public long PackValue { get; set; }
    public string PackUOM { get; set; }
    public string PackWeightUOM { get; set; }
    public int PackWeight { get; set; }
}

public class Note3
{
    public string NoteCode { get; set; }
    public string Note { get; set; }
}

public class Physicaldetail3
{
    public string PackQualifier { get; set; }
    public long PackWeight { get; set; }
    public string PackWeightUOM { get; set; }
}

public class Marksandnumberscollection1
{
    public string MarksAndNumbersQualifier1 { get; set; }
    public string MarksAndNumbers1 { get; set; }
}

public class Palletinformation
{
    public string PalletQualifier { get; set; }
    public int PalletValue { get; set; }
}

public class Address3
{
    public string AddressTypeCode { get; set; }
    public string Country { get; set; }
}

public class Physicaldetail4
{
    public string PackQualifier { get; set; }
    public int PackValue { get; set; }
    public string PackUOM { get; set; }
    public string PackWeightUOM { get; set; }
    public int PackWeight { get; set; }
}

public class Reference5
{
    public string ReferenceQual { get; set; }
    public string ReferenceID { get; set; }
}

public class Marksandnumberscollection2
{
    public string MarksAndNumbersQualifier1 { get; set; }
    public string MarksAndNumbers1 { get; set; }
}

public class Note4
{
    public string NoteCode { get; set; }
    public string Note { get; set; }
}
