namespace Juniper.Core.Util
{
    //public class RestSharpUtil
    //{
    //    public static async Task<RestSharp.IRestResponse> PostRequest(string urlPath, byte[] bytes)
    //    {
    //        var client = new RestSharp.RestClient("https://api.spscommerce.com/transactions/v5/" + $"{urlPath}");
    //        client.Timeout = -1;
    //        var request = new RestSharp.RestRequest(RestSharp.Method.POST);
    //        request.AddHeader("Content-Type", "application/octet-stream");

    //        var token = await MainViewModel.Current.SettingsViewModel.GetLoadAccessToken();
    //        request.AddHeader("Authorization", "Bearer " + token);

    //        request.AddParameter(new RestSharp.Parameter("file", bytes, "application/octet-stream", RestSharp.ParameterType.RequestBody));

    //        return await client.ExecuteAsync(request);
    //    }

    //    public static async Task<RestSharp.IRestResponse> DeleteRequest(string urlPath)
    //    {
    //        var client = new RestSharp.RestClient("https://api.spscommerce.com/transactions/v5/data" + $"{urlPath}");
    //        client.Timeout = -1;

    //        var token = await MainViewModel.Current.SettingsViewModel.GetLoadAccessToken();

    //        var request = new RestSharp.RestRequest(RestSharp.Method.DELETE);
    //        request.AddHeader("Authorization", "Bearer " + token);

    //        return await client.ExecuteAsync(request);
    //    }
    //}
}
