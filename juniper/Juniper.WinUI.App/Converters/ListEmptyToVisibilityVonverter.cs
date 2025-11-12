namespace Juniper.WinUI.App.Converters
{
    internal class ListEmptyToVisibilityVonverter : IValueConverter
    {
        public Visibility NullValue { get; set; } = Visibility.Collapsed;
        public Visibility NonNullValue { get; set; } = Visibility.Visible;

        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;

            var a = value as System.Collections.IList;
            if (a != null)
                return (a.Count == 0) ? NullValue : NonNullValue;

            return NullValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}