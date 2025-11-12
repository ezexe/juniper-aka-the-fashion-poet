namespace Juniper.WinUI.App.Converters
{
    internal class NullToPlaceholderTextConverter : IValueConverter
    {

        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;

            if (value is DateTimeOffset dt && dt.Date == DateTime.MinValue.Date)
                return parameter;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}
