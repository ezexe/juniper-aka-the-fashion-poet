namespace Juniper.WinUI.App.Common
{
    public class SymbolLoader
    {
        public static string GetSource(DependencyObject obj)
        {
            return (string)obj.GetValue(SourceProperty);
        }

        public static void SetSource(DependencyObject obj, string value)
        {
            obj.SetValue(SourceProperty, value);
        }

        // Using a DependencyProperty as the backing store for Path.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.RegisterAttached("Source", typeof(string), typeof(SymbolLoader), new PropertyMetadata(string.Empty, OnPropertyChanged));

        private async static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is SymbolIcon image)
            {
                var item = await ControlInfoDataSource.Instance.GetItemAsync(e.NewValue?.ToString());
                if (item?.ImageSymbol != null)
                {
                    image.Symbol = item.ImageSymbol;
                }
            }
        }
    }
}