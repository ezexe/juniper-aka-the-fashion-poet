namespace Juniper.WinUI.App.Converters
{
    public class StyleCodeToDescriptionConverter : IValueConverter
    {
        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;

            var li = MainViewModel.Current.ExcelUtil.LastReadUPCList.FirstOrDefault(u => u.GTIN == (string)value);
            if (li is not null)
            {
                if (parameter is string pmv)
                {
                    if (pmv == "Product")
                        return li.Product;
                    else if (pmv == "ColorDescription")
                        return li.ColorDescripton;
                    else if (pmv == "Description")
                        return li.ProductDescription;
                    else if (pmv == "Size")
                        return li.ShortSizeDescription;
                    else if (pmv == "All")
                        return $"{li.Product} {li.ProductDescription} {li.ColorDescripton} {li.ShortSizeDescription}";
                }
                else
                    return $"{li.Product} {li.SizeDescription}";
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}