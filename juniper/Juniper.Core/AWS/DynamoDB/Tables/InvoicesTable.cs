namespace Juniper.Core.AWS.DynamoDB.Tables
{
    [DynamoDBTable("Invoices")]
    public class InvoicesTable
    {
        [DynamoDBHashKey]// Partition key.
        public string ASNNumber { get; set; }
        [DynamoDBRangeKey]
        public string INVNumber { get; set; }

        public string BOLNumber { get; set; }
        public string PONumber { get; set; }
        public string INVDate { get; set; }
        public string S3KeyName { get; set; }
        public List<string> BYAddressIds { get; set; } = new List<string>();

        [DynamoDBProperty(typeof(InternalINVSettingsConverter))]
        public InternalINVSettings? Settings { get; set; }
    }
}