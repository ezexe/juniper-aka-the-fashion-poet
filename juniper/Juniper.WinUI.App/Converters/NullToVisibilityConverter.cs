namespace Juniper.WinUI.App.Converters
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public Visibility NullValue { get; set; } = Visibility.Collapsed;
        public Visibility NonNullValue { get; set; } = Visibility.Visible;

        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;
            if(value is string sv)
            {
                return (sv.IsNullEmptyOrWhiteSpace()) ? NullValue : NonNullValue;
            }
            return (value == null) ? NullValue : NonNullValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}