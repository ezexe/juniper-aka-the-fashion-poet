namespace SPSCommerceSDK.Models.ShipingLabel
{
    public class ShipingLabelAll
    {
        public Header Header { get; set; }
        public List<Pack> Pack { get; set; }
        public List<Pallet>? Pallet { get; set; }
    }
    #region responses

    public class Validationerror
    {
        public string path { get; set; }
        public string message { get; set; }
        public string validator { get; set; }
        public object validatorValue { get; set; }
    }

    public class Rootobject2
    {
        public string batchId { get; set; }
        public string status { get; set; }
        public string ownerName { get; set; }
        public string responseType { get; set; }
        public string resultURL { get; set; }
        public string failureDescription { get; set; }
        public Validationerror[] validationErrors { get; set; }
    }

    public class Rootobject1
    {
        public string batchId { get; set; }
        public string statusURL { get; set; }
    }
    #endregion

    public class Header
    {
        public List<Address> Address { get; set; }
        public string BillOfLadingNumber { get; set; }
        public List<Carrierinformation> CarrierInformation { get; set; }
        public string? CarrierProNumber { get; set; }
        public string? Department { get; set; }
        public string? Vendor { get; set; }
        public string? PurchaseOrderNumber { get; set; }
        public List<Reference> References { get; set; }
    }

    public class Address
    {
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? AddressLocationNumber { get; set; }
        public string? AddressName { get; set; }
        public string? AddressTypeCode { get; set; }
        public string? City { get; set; }
        public string? LocationCodeQualifier { get; set; }
        public string? PostalCode { get; set; }
        public string? State { get; set; }
    }

    public class Carrierinformation
    {
        public string? CarrierAlphaCode { get; set; }
        public string? CarrierRouting { get; set; }
    }

    public class Reference
    {
        public string? Description { get; set; }
        public string? ReferenceID { get; set; }
        public string ReferenceQual { get; set; }
    }

    public class Pallet
    {
        public Pack[] Pack { get; set; }
    }

    public class Pack
    {
        public List<Address> Address { get; set; }
        public List<Item> Item { get; set; }
        public string ShippingSerialID { get; set; }
    }

    public class Item
    {
        public Productid[]? ProductID { get; set; }
        public string? BuyerPartNumber { get; set; }
        public string? VendorPartNumber { get; set; }
        public string? ConsumerPackageCode { get; set; }
        public string? ProductColorDescription { get; set; }
        public string? ProductSizeDescription { get; set; }
        public string? ProductMaterialDescription { get; set; }
        public string? ProductMaterialCode { get; set; }
        public string? ProductSizeCode { get; set; }
        public string? ProductColorCode { get; set; }
        public double ShipQty { get; set; }
    }

    public class Productid
    {
        public string PartNumber { get; set; }
        public string PartNumberQual { get; set; }
    }

}
