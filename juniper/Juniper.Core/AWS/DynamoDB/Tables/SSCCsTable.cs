namespace Juniper.Core.AWS.DynamoDB.Tables;

[DynamoDBTable("SSCCs")]
public class SSCCsTable
{
    [DynamoDBHashKey]// Partition key.
    public string ASNId { get; set; }

    [DynamoDBRangeKey]
    public string SSCC { get; set; }

    public string? StoreId { get; set; }
    public List<string> UPCs { get; set; }
}

