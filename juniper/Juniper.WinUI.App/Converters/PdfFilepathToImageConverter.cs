using Microsoft.UI.Xaml.Media.Imaging;
using Windows.Data.Pdf;
using Windows.Storage.Streams;

namespace Juniper.WinUI.App.Converters
{
    internal class PdfFilepathToImageConverter : IValueConverter
    {
        object prevValue;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            prevValue = value;

            var pdfDocument =   PdfDocument.LoadFromFileAsync(StorageFile.GetFileFromPathAsync((string)value).GetResults()).GetResults();

                var stream = new InMemoryRandomAccessStream();

                using PdfPage page = pdfDocument.GetPage(0);
                page.RenderToStreamAsync(stream).GetResults();

                BitmapImage src = new();
                //Output.Source = src;
                src.SetSourceAsync(stream).GetResults();

                return src;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return prevValue;
        }
    }
}