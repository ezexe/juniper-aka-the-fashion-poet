namespace Juniper.Core.AWS.DynamoDB.Tables;

[DynamoDBTable("DocumentTags")]
public class DocumentTagsTable
{ 
    [DynamoDBHashKey]// Partition key.
    public string DocumentID { get; set; }         
    
    [DynamoDBRangeKey]
    public string TagName { get; set; } 
}

[DynamoDBTable("Tags")]
public class TagsTable
{
    [DynamoDBHashKey]// Partition key.
    public string TagName { get; set; }

    [DynamoDBRangeKey]
    public string TagValue { get; set; }
}

//tag
//TagName  = Status
//TagValue = New/Acknowledged/InProgress/Complete
//document tag
//DocumentID = poId/asnId/invId
//TagName    = tag.TagName