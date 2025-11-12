namespace Juniper.Core.Services
{
    public interface IFieldsService : IAsyncInitialization
    {
        FieldsBase ShipmentsFields { get; }
        FieldsBase InvoiceFields { get; }
    }
}