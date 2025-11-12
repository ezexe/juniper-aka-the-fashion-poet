namespace Juniper.WinUI.App.Converters
{
    internal class InverseBoolConverter : IValueConverter
    {

        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;
            return ((bool)value == false) ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}