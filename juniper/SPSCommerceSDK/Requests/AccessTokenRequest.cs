namespace SPSCommerceSDK.Requests
{
    /// <summary>
    /// {\n \t \"grant_type\": \"client_credentials\",\n \t \"client_id\": \"YOUR_APP_ID\",\n \t \"client_secret\": \"YOUR_APP_SECRET\", \n \t \"audience\": \"api://api.spscommerce.com/\"\n }
    /// </summary>
    public class AccessTokenRequest
    {
        [JsonPropertyName("grant_type")]
        public string Grant_type { get; set; } = "client_credentials";

        [JsonPropertyName("client_id")]
        public string Client_id { get; set; }

        [JsonPropertyName("client_secret")]
        public string client_secret { get; set; }

        [JsonPropertyName("audience")]
        public string audience { get; set; } = "api://api.spscommerce.com/";
    }
}