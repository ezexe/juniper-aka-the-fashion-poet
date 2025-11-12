namespace Juniper.WinUI.App.Services
{
    public class FieldsService : IFieldsService
    {
        public Task Initialization { get; private set; }

        public FieldsBase ShipmentsFields { get; private set; }
        public FieldsBase InvoiceFields { get; private set; }

        public FieldsService()
        {
            Initialization = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            InvoiceFields = await GetJsonAsync("InvoiceFields.json");
            ShipmentsFields = await GetJsonAsync("fields.json");
        }

        private async Task<FieldsBase> GetJsonAsync(string fileName)
        {
            var path = Path.Combine(Package.Current.InstalledLocation.Path, "Assets", "Fields", fileName);

            StorageFile file = await StorageFile.GetFileFromPathAsync(path);
            using var stream = await file.OpenStreamForReadAsync();
            return await JsonSerializer.DeserializeAsync<FieldsBase>(stream);
        }
    }
}