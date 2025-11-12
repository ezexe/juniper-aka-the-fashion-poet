namespace Juniper.Core.AWS.DynamoDB.Tables
{
    public class InternalASNSettingsConverter : IPropertyConverter
    {
        public DynamoDBEntry ToEntry(object value)
        {
            if (value is not InternalASNSettings settings)
            {
                throw new ArgumentOutOfRangeException("value is not InternalASNSettings");
            }

            string data = settings.Serialize();// string.Format($"{bookDimensions.Length} x {bookDimensions.Height} x {bookDimensions.Thickness}");

            DynamoDBEntry entry = new Primitive
            {
                Value = data,
            };
            return entry;
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            Primitive? primitive = entry as Primitive;
            if (primitive == null || primitive.Value is not string || string.IsNullOrEmpty((string)primitive.Value) ||
                ((string)primitive.Value).Deserialize<InternalASNSettings>() is not InternalASNSettings settings)
            {
                throw new ArgumentOutOfRangeException();
            }

            return settings;
        }
    }
}
