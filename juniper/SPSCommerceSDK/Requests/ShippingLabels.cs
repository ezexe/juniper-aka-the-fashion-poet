namespace SPSCommerceSDK.Requests;

public class ShippingLabelRequest
{
    public Header Header { get; set; }
    public List<Pack> Pack { get; set; }

    //public async Task<byte[]> ExecuteAsync(string url, string? token)
    //{
    //    //var httpRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
    //    //httpRequest.Method = "POST";

    //    //httpRequest.ContentType = "application/json";
    //    //httpRequest.Headers.Add("Authorization", "Bearer " + token);

    //    //var data = JsonSerializer.Serialize(this);

    //    //using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
    //    //{
    //    //    streamWriter.Write(data);
    //    //}

    //    //var httpResponse = (System.Net.HttpWebResponse)httpRequest.GetResponse();
    //    //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
    //    //{
    //    //    var result = streamReader.ReadToEnd();
    //    //}

    //    var client = new RestClient(url);
    //    client.Timeout = -1;
    //    var request = new RestRequest(Method.GET);
    //    //request.AddHeader("Content-Type", "application/json");
    //    request.AddHeader("Authorization", "Bearer " + token);
    //    //request.AddParameter("application/json", JsonSerializer.Serialize(this), RestSharp.ParameterType.RequestBody);
    //    IRestResponse response = await client.ExecuteAsync(request);

    //    if (!response.IsSuccessful)
    //    {
    //        throw new Exception(response.Content, response.ErrorException);
    //    }
    //    else
    //    {
    //        return response.RawBytes;
    //    }
    //}
}

public class Header
{
    public string? PurchaseOrderNumber { get; set; }
    public List<Address> Address { get; set; }
}

public class Address
{
    public string AddressTypeCode { get; set; }
    public string AddressLocationNumber { get; set; }
    public string LocationCodeQualifier { get; set; }
    public string AddressName { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}

public class Pack
{
    public List<Item> Item { get; set; }
    public string ShippingSerialID { get; set; }
}

public class Item
{
    public string LineSequenceNumber { get; set; }
    public string BuyerPartNumber { get; set; }
    public List<Productoritemdescription> ProductOrItemDescription { get; set; }
    public List<Priceinformation> PriceInformation { get; set; }
}

public class Productoritemdescription
{
    public string ProductCharacteristicCode { get; set; }
    public string ProductDescription { get; set; }
}

public class Priceinformation
{
    public string? PriceTypeIDCode { get; set; }
    public double? UnitPrice { get; set; }
}

