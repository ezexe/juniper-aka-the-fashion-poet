namespace Juniper.Core.AWS.DynamoDB.Tables
{
    internal class SettingsTableValueConverter : IPropertyConverter
    {
        public DynamoDBEntry ToEntry(object value)
        {
            List<string>? bookDimensions = value as List<string>;
            if (bookDimensions == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            string data = "";// string.Format($"{bookDimensions.Length} x {bookDimensions.Height} x {bookDimensions.Thickness}");

            DynamoDBEntry entry = new Primitive
            {
                Value = data,
            };
            return entry;
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            Primitive? primitive = entry as Primitive;
            if (primitive == null || !(primitive.Value is string) || string.IsNullOrEmpty((string)primitive.Value))
            {
                throw new ArgumentOutOfRangeException();
            }

            string[] data = ((string)primitive.Value).Split(new[] { " x " }, StringSplitOptions.None);
            if (data.Length != 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            //DimensionType complexData = new DimensionType
            //{
            //    Length = Convert.ToDecimal(data[0]),
            //    Height = Convert.ToDecimal(data[1]),
            //    Thickness = Convert.ToDecimal(data[2]),
            //};

            return data;
        }
    }
}
