namespace Juniper.Core.AWS.DynamoDB.Tables
{
    [DynamoDBTable("TradingPartners")]
    public class TradingPartnersTable
    {
        [DynamoDBHashKey] // Partition key.
        public string TradingPartnerName { get; set; }

        public string TradingPartnerId { get; set; }
        public string DefaultCarrier { get; set; }

        [DynamoDBProperty(typeof(BaseAddressModelConverter))]
        public List<BaseAddressModel> Addresses { get; set; }
    }
}
