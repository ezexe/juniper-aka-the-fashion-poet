namespace Juniper.Core.Services;

//public interface ISPSCommerceService
//{
//    [Get("/transactions/v5/data/{directoryPath}")]
//    Task<FilterTransactiosnResponses> GetTransactionsByDirPathAsync(string directoryPath);

//    [Get("/transactions/v5/data/{path}")]
//    Task<string> GetTransactionAsync(string path);

//    [Multipart]
//    [Headers("Content-Type: application/octet-stream")]
//    [Post("/transactions/v5/{path}")]
//    Task<string> PostTransactionAsync(string path, StreamPart stream);

//    [Headers("Content-Type: application/json")]
//    [Post("/transactions/v5/{path}")]
//    Task<string> PostTransactionBodyAsync(string path,[Body]string json);

//    /// <summary>
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?newest=true"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?offset=5"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?offset=5&limit=5"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?name=SPS Commerce Shipping Label - 1"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?name__EQ=SPS Commerce Shipping Label - 1"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?ownerName=SPS Commerce"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?ownerName__EQ=SPS Commerce"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?ownerID=123451927301720471274"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?ownerID__EQ=123451927301720471274"
//    /// curl -XGET "https://api.spscommerce.com/label/v1/?canRender=true"
//    /// </summary>
//    /// <returns></returns>
//    [Headers("Content-Type: application/json")]
//    [Post("/label/v1/{id}/pdf/batches/")]
//    Task<string> GetShippingLabelsAsync(string id, [Body(buffered:false, serializationMethod: BodySerializationMethod.Serialized)] ShipingLabelAll labels);

//    [Get("/label/v1/")]
//    Task<string> GetAllShippingLabelsAsync();
//    /// <summary>
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?newest=true"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?offset=5"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?offset=5&limit=5"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?name=SPS Commerce Packing Slip - 1"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?name__EQ=SPS Commerce Packing Slip - 1"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?ownerName=SPS Commerce"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?ownerName__EQ=SPS Commerce"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?ownerID=123451927301720471274"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?ownerID__EQ=123451927301720471274"
//    /// curl -XGET "https://api.spscommerce.com/packing-slip/v1/?canRender=true"
//    /// </summary>
//    [Get("/packing-slip/v1/")]
//    Task<string> GetPackingSlipsAsync([AliasAs("ownerID")] string ownerID);
//}