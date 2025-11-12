namespace Juniper.WinUI.App.Converters
{
    internal class DocumentStatusToEnabledConverter : IValueConverter
    {

        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;

            if (parameter is string s)
            {
                if (s == "readonly")
                    return (DocumentStatus)value == DocumentStatus.Sent;
                else if (s == "visibility")
                    return (DocumentStatus)value == DocumentStatus.Sent ? Visibility.Collapsed : Visibility.Visible;
                else if(s == "StatusVisual")
                    return (DocumentStatus)value == DocumentStatus.New ? Visibility.Visible : Visibility.Collapsed;

                return false;
            }
            else
            {
                return ((DocumentStatus)value == DocumentStatus.Sent) ? false : true;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}