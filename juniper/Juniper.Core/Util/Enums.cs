namespace Juniper.Core.Util
{
    public enum DocumentStatus
    {
        New,
        Saved,
        SavedSettings,
        Sent,
        Deleted,
        InProgress,
    }
    public enum DocumentType
    {
        ASN856,
        PO850,
        IN810,
        BOL,
    }
    public enum SettingStorageKeys
    {
        AppId,
        AppSecret,
        SFAddressName,
        Gs1CompanyPrefix,
        FOBTitlePassageLocation,
        SacksPartnerID,
        NordstromPartnerID,
        BloomingdalesPartnerID,
        BloomingdalesOutletPartnerID,
        SavedDataFilePath,
        UPCsFilePath,
        BloomingDalesOutletStoreToDCFilePath,
        BloomingDalesStoreToDCFilePath,
        SentShipmentsFilePath,
        LoacalPurchaseOrdersFilePath,
        SaksStoreToDCFilePath,
        BolTemplateFilePath,
        LastUsedASNNumber,
        LastUsedInvoiceNumber,
        LastUsedASNBOLNumber,
        SentInvoicesFilePath,
        LastUsedASNMasterBOLNumber,
        NordstromStoreAddressFilePath,
        NordstromCanadaPartnerID,
        NordCanadaFilePath,
    }
    public enum InfoSeverity
    {
        Error,
        Warning,
        Success,
        Informational,
    }
}