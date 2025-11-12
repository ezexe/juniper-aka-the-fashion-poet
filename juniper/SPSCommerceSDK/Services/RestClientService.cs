namespace SPSCommerceSDK.Services
{
    //public static class RestClientService
    //{
    //    public static async Task<IRestResponse> CreateRestRequest(string url, Method method, string? token, object? jsonO)
    //    {
    //        var client = new RestClient(url)
    //        {
    //            Timeout = -1,
    //        };
    //        var request = new RestRequest(method)
    //        {
    //        };
    //        if (method == Method.POST)
    //        {
    //            request.RequestFormat = DataFormat.Json;
    //            request.AddHeader("Content-Type", "application/json");
    //            if (jsonO != null)
    //            {
    //                var json = JsonSerializer.Serialize(jsonO, new JsonSerializerOptions(JsonSerializerDefaults.General)
    //                {
    //                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    //                });
    //                request.AddParameter("application/json", json, ParameterType.RequestBody);
    //            }
    //        }

    //        request.AddHeader("Authorization", "Bearer " + token);

    //        return await client.ExecuteAsync(request);
    //    }
    //}
}
