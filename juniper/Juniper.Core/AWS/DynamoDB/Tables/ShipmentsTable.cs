namespace Juniper.Core.AWS.DynamoDB.Tables
{
    [DynamoDBTable("Shipments")]
    public class ShipmentsTable
    {
        [DynamoDBHashKey]// Partition key.
        public string PONumber { get; set; }

        [DynamoDBRangeKey]
        public string ASNNumber { get; set; }
        public string BOLNumber { get; set; }
        public string ShipDate { get; set; }
        public string S3KeyName { get; set; }
        public string? S3LabelsPath { get; set; }

        [DynamoDBProperty(typeof(InternalASNSettingsConverter))]
        public InternalASNSettings? Settings { get; set; }
    }
}
