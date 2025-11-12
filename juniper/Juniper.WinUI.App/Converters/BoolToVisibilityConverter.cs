namespace Juniper.WinUI.App.Converters
{
    internal class BoolToVisibilityConverter : IValueConverter
    {
        public Visibility NullValue { get; set; } = Visibility.Collapsed;
        public Visibility NonNullValue { get; set; } = Visibility.Visible;

        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;
            return ((bool)value == false) ? NullValue : NonNullValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}