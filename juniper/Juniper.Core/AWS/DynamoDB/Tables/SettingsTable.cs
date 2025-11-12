namespace Juniper.Core.AWS.DynamoDB.Tables
{
    [DynamoDBTable("Settings")]
    public class SettingsTable
    {
        [DynamoDBHashKey]// Partition key.
        public string SettingId { get; set; }

        public string? SettingValue { get; set; }

        public List<string>? SettingValueList { get; set; }
    }
}
