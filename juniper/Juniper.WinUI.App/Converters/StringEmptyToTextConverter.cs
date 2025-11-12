namespace Juniper.WinUI.App.Converters
{
    internal class StringEmptyToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string s)
                return s.IsNullEmptyOrWhiteSpace() ? "" : System.Convert.ToString(parameter);

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}