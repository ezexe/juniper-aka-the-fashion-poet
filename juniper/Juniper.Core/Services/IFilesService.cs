namespace Juniper.Core.Services;
public interface IFilesService
{
    /// <summary>
    /// Gets the path of the installation directory.
    /// </summary>
    string InstallationPath { get; }

    string ErrorsFolder { get; }
    string SettingsFolder { get; }
    string SavedPurchaseOrdersFolder { get; }
    string ArchivedPurchaseOrdersFolder { get; }
    string SavedShipmentsFolder { get; }
    string SavedInvoiceFolder { get; }
    string SentInvoiceFolder { get; }
    string SentShipmentsFolder { get; }

    /// <summary>
    /// Gets a readonly <see cref="Stream"/> for a file at a specified path.
    /// </summary>
    /// <param name="path">The path of the file to retrieve.</param>
    /// <returns>The <see cref="Stream"/> for the specified file.</returns>
    Task<Stream> OpenForReadAsync(string path);
    Task<string?> ReadToStringValueAsync(string path);
    Task<T?> ReadToValueAsync<T>(string path);
    Task<Tuple<string, T>> ReadToValueAsynTuple<T>(string path);
    Task<List<Tuple<string, T>>> ReadValuesAsync<T>(string folder,params string[] exclue);
   // Task<List<Tuple<string,T>>> ReadValuesWithFnameAsync<T>(string folder, params string[] exclue);

    Task DeleteItem(string folder, string filename);

    Task<string> WriteAsync<T>(string folder, string fileName, T value, bool rethrow = false); 
    Task<Stream> WriteAsync(string folder, string fileName, string value);
    Task<Tuple<byte[],string>> WriteAsyncGetBytes(string folder, string fileName, string value);
    string GetAssetsFolder();
    string GetLocalFolder();
    /// <summary>
    /// storageFolder.Path
    /// </summary>
    /// <returns>storageFolder.Path</returns>
    string GetLocalStorageFolder();
    Task SetStorageFolderAsync(string directory);
    Task OpenDirectory(string directory);
    Task OpenPrindPrivewFor(ObservableCollection<PDFRenderModel> renderlist, string directory, string mainFile);
    Task<Tuple<string, ObservableCollection<PDFRenderModel>>> CombinePDF(string directory, string allpdfkey, string[] files);

    Task<string> SelectDirectory();
}
