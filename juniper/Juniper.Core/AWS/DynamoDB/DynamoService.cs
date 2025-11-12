using Amazon.DynamoDBv2.Model;

namespace Juniper.Core.AWS.DynamoDB
{
    public class DynamoService
    {
        public static DynamoService Current { get; private set; }

        public DynamoDBContext DBContext { get; private set; }
        public AmazonDynamoDBClient DBClient { get; private set; }

        public DynamoService()
        {
            Current = this;

            // Uses AWS credential provider chain (environment variables, AWS credentials file, IAM role, etc.)
            DBClient = new AmazonDynamoDBClient(
                SettingsViewModel.StateofSandbox ? Amazon.RegionEndpoint.USEast2 : Amazon.RegionEndpoint.USEast1);

            DBContext = new DynamoDBContext(DBClient, new DynamoDBContextConfig
            {
                //Setting the Consistent property to true ensures that you'll always get the latest 
                ConsistentRead = true,
                SkipVersionCheck = true
            });
        }

        public async Task<List<T>?> GetAllItemsAsync<T>() where T : class
        {
            MainViewModel.Current.DisplayInfobarMessage("Loading...", typeof(T).Name);

            var batch = await DBContext.ScanAsync<T>(new List<ScanCondition>()).GetRemainingAsync();

            MainViewModel.Current.DisplayInfobarMessage("Loading Done", typeof(T).Name, InfoSeverity.Success);
            return batch;
        }

        public async Task<IEnumerable<T>> QuesryItemsAsync<T>(string key) 
        {
            MainViewModel.Current.DisplayInfobarMessage("Query...",$"{typeof(T).Name} - key: {key}");

            var reply = await DBContext.QueryAsync<T>(key).GetRemainingAsync();

            MainViewModel.Current.DisplayInfobarMessage("Query Done", $"{typeof(T).Name} - key: {key}", InfoSeverity.Success);
            return reply;
        }

        public async Task PutTableBatch<T>(List<T> tableList)
        {
            MainViewModel.Current.DisplayInfobarMessage("Writing...", $"{typeof(T).Name} - entries: {tableList.Count}");

            var bookBatch = DBContext.CreateBatchWrite<T>();
            bookBatch.AddPutItems(tableList);

            await bookBatch.ExecuteAsync();

            MainViewModel.Current.DisplayInfobarMessage("Writing Done", $"{typeof(T).Name} - entries: {tableList.Count}", InfoSeverity.Success);
        }

        public async Task<T?> Store<T>(T item)
        {
            MainViewModel.Current.DisplayInfobarMessage("Store...", $"{typeof(T).Name} - item: {item}");

            await DBContext.SaveAsync(item);

            MainViewModel.Current.DisplayInfobarMessage("Store Done", $"{typeof(T).Name} - item: {item}", InfoSeverity.Success);

            return await LoadAsync(item);
        }
        public async Task<T?> LoadAsync<T>(T item)
        {
            MainViewModel.Current.DisplayInfobarMessage("Loading...", $"{typeof(T).Name} - item: {item}");

            var i = await DBContext.LoadAsync<T>(item, new DynamoDBOperationConfig
            {
                ConsistentRead = true,
            });

            MainViewModel.Current.DisplayInfobarMessage("Loading Done", $"{typeof(T).Name} - item: {item}", InfoSeverity.Success);

            return i;
        }
            public async Task<bool> Delete<T>(T item)
        {
            MainViewModel.Current.DisplayInfobarMessage("Delete...", $"{typeof(T).Name} - item: {item}");

            await DBContext.DeleteAsync(item);

            if (await LoadAsync(item) is null)
            {
                MainViewModel.Current.DisplayInfobarMessage("Delete Done", $"{typeof(T).Name} - item: {item}", InfoSeverity.Success);
                return true;
            }

            return false;
        }

        public async Task<T> Update<T>(T newItem, string key, string range)
        {
            //    var request = new UpdateItemRequest
            //    {
            //        TableName = table,
            //        Key = new Dictionary<string, AttributeValue>()
            //{
            //  {
            //    keyName,
            //    new AttributeValue { S = key }
            //  },
            //  {
            //    rangeName,
            //    new AttributeValue { S = range }
            //  },
            //},
            //        ExpressionAttributeNames = new Dictionary<string, string>()
            //{
            //  { "#S", "Order_Status" },
            //},
            //        ExpressionAttributeValues = new Dictionary<string, AttributeValue>()
            //{
            //  {
            //    ":s",
            //    new AttributeValue { S = status }
            //  },
            //},
            //        ReturnValues = "UPDATED_NEW",
            //        UpdateExpression = "SET #S = :s",
            //    };

            // Retrieve the existing order.
            var orderRetrieved = await DBContext.LoadAsync<T>(key, range);

            // Trap any nulls.
            if (orderRetrieved is null)
            {
                throw new ArgumentException("The ID " + key + " did not identify");
            }

            // Update
            await DBContext.SaveAsync(newItem);

            return await DBContext.LoadAsync<T>(key, range, new DynamoDBOperationConfig
            {
                ConsistentRead = true,
            });
        }
    }
}
