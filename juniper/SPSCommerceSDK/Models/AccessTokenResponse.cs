namespace SPSCommerceSDK.Models
{
    public class AccessTokenResponse
    {
        [JsonPropertyName("access_token")]
        public string access_token { get; set; }

        [JsonPropertyName("token_type")]
        public string token_type { get; set; }

        [JsonPropertyName("expires_in")]
        public int expires_in { get; set; }

        public DateTime ExpiresAt { get; set; }
    }

}