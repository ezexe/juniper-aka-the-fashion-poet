namespace Juniper.Core.AWS.DynamoDB.Tables
{
    [DynamoDBTable("PurchaseOrders")]
    public class PurchaseOrderTable
    {
        [DynamoDBHashKey]// Partition key.
        public string TradingPartner { get; set; }

        [DynamoDBRangeKey] 
        public string PONumber { get; set; }

        public string JsonFilePath { get; set; }
        public string S3KeyName { get; set; }
    }
}
