namespace Juniper.WinUI.App.Converters
{
    public class StringFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var format = parameter as string;
            if (!string.IsNullOrEmpty(format))
                if(value is string s)
                {
                    var sp = s.Split('-');
                    return string.Format(format, new DateTime(System.Convert.ToInt32(sp[0]), System.Convert.ToInt32(sp[1]), System.Convert.ToInt32(sp[2])));
                }
                else
                    return string.Format(format, value);

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
