using Windows.Storage.Streams;
//using Windows.Data.Pdf;
using Windows.System;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Printing;
using CommunityToolkit.WinUI.Helpers;
using Windows.Graphics.Printing;
using Windows.UI.Popups;
using System.Diagnostics;
using Windows.Storage.Pickers;
using Windows.Storage.AccessCache;
using System.Net.NetworkInformation;
using Adobe.PDFServicesSDK.auth;
using Adobe.PDFServicesSDK.pdfops;
using Adobe.PDFServicesSDK.io;

namespace Juniper.WinUI.App.Services;

public class FilesService : IFilesService
{
    /// <inheritdoc/>
    public string InstallationPath => Package.Current.InstalledLocation.Path;

    public string ErrorsFolder => "ErrorsLogs";
    public string SettingsFolder => "Settings";
    public string SavedPurchaseOrdersFolder => "SavedPurchaseOrders";
    public string ArchivedPurchaseOrdersFolder => "ArchivedPurchaseOrders";
    public string SavedShipmentsFolder => "SavedShipments";
    public string SavedInvoiceFolder => "SavedInvoices";
    public string SentInvoiceFolder => "SentInvoices";
    public string SentShipmentsFolder => "SentShipments";

    // Get the app's local folder.
    StorageFolder storageFolder = ApplicationData.Current.LocalFolder;

    /// <inheritdoc/>
    public async Task<Stream> OpenForReadAsync(string path)
    {
        StorageFile file = await StorageFile.GetFileFromPathAsync(path);

        return await file.OpenStreamForReadAsync();
    }
    public async Task<string?> ReadToStringValueAsync(string path)
    {
        if(!File.Exists(path))
        {
            MainViewModel.Current.DisplayInfobarMessage("Error", $"Cannot Find File {path}", InfoSeverity.Error);
            return null;
        }
        using var stream = await OpenForReadAsync(path);
        using var reader = new StreamReader(stream);
        var text = await reader.ReadToEndAsync();
        reader.Close();
        stream.Close();

        return text;
    }
    public async Task<Tuple<string, T>> ReadToValueAsynTuple<T>(string path)
    {
        if (!File.Exists(path))
        {
            path = Path.Combine(storageFolder.Path, path);
            if (!File.Exists(path))
                return default;
        }

        var text = await ReadToStringValueAsync(path);
        if (typeof(T) == typeof(string))
            return new Tuple<string, T>(path, (T)(object)text);
        else
            return new Tuple<string, T>(path, JsonSerializer.Deserialize<T>(text));
    }
    public async Task<T> ReadToValueAsync<T>(string path)
    {
        if (!File.Exists(path))
        {
            path = Path.Combine(storageFolder.Path, path);
            if (!File.Exists(path))
                return default;
        }

        var text = await ReadToStringValueAsync(path);
        if (typeof(T) == typeof(string))
            return (T)(object)text;
        else
            return JsonSerializer.Deserialize<T>(text);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="folder"></param>
    /// <param name="exclue"></param>
    /// <returns>filepath T</returns>
    public async Task<List<Tuple<string, T>>>  ReadValuesAsync<T>(string folder, params string[] exclue)
    {
        var returned = new List<Tuple<string, T>>();
        var fullPath = folder.ToFullDirectory();
        if (!Directory.Exists(fullPath) || Directory.GetFiles(fullPath).Length == 0)
        {
                return returned;
        }

        MainViewModel.Current.DisplayInfobarMessage("Loading From...", fullPath, InfoSeverity.Informational);

        ParallelOptions parallelOptions = new()
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount,
            CancellationToken = CancellationToken.None,

        };
        // int i = 1;
        await Parallel.ForEachAsync(Directory.EnumerateFiles(fullPath, "*.*")
            .Where(f => Path.GetExtension(f) == ".json" && !exclue.Any(rf => f == rf || Path.GetFileName(f) == Path.GetFileName(rf))).ToArray(),
            parallelOptions, async (file, token) =>
            {
                var val = await ReadToValueAsynTuple<T>(file);

                lock (returned)
                {
                    returned.Add(new Tuple<string, T>(val.Item1, val.Item2));
                }
            });
        return returned;
    }

    public async Task<StorageFile> OpenForWright(string folder, string fileName)
    {
        // Create a new subfolder in the current folder.
        // Raise an exception if the folder already exists.
        StorageFolder newFolder = Directory.Exists(folder) ? await StorageFolder.GetFolderFromPathAsync(folder) : 
            await storageFolder.CreateFolderAsync(folder, CreationCollisionOption.OpenIfExists);

        StorageFile file = 
            await newFolder.CreateFileAsync(fileName.EndsWith(".json")? fileName : fileName + ".json", CreationCollisionOption.ReplaceExisting);

        return file;

    }
    public async Task<string> WriteAsync<T>(string folder, string fileName, T value, bool rethrow = false)
    {
        try
        {
            var file = await OpenForWright(folder, fileName);
            //while(file.Attributes.HasFlag(Windows.Storage.FileAttributes.))
            using (var fileStream = await file.OpenStreamForWriteAsync())
            {
                await JsonSerializer.SerializeAsync<T>(fileStream, value, new JsonSerializerOptions(JsonSerializerDefaults.General)
                {
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                });
            }
            return file.Path;
        }
        catch (Exception e)
        {
            if(rethrow)
                MainViewModel.Current.DisplayInfobarMessage("Error", $"Error in WriteAsync {e.Message}", InfoSeverity.Error);
            else
                MainViewModel.Current.LoggerUtil.AddException(e, $"WriteAsync");
        }

        return null;
    }
    public async Task<Stream> WriteAsync(string folder, string fileName, string value)
    {
        var file = await OpenForWright(folder, fileName);
        using (var fileStream = await file.OpenStreamForWriteAsync())
        {
            await fileStream.WriteAsync(Encoding.UTF8.GetBytes(value));
        }

        return await file.OpenStreamForReadAsync();
    }
    public async Task<Tuple<byte[], string>> WriteAsyncGetBytes(string folder, string fileName, string value)
    {
        byte[] bytes;
        var file = await OpenForWright(folder, fileName);

        using (var fileStream = await file.OpenStreamForWriteAsync())
            await fileStream.WriteAsync(Encoding.UTF8.GetBytes(value));

        using (Stream stream = await file.OpenStreamForReadAsync())
        {
            long numBytes = stream.Length;
            using var br = new BinaryReader(stream);
            bytes = br.ReadBytes((int)numBytes);
        }

        return new Tuple<byte[], string>(bytes,file.Path);
    }

    public async Task DeleteItem(string folder, string filename)
    {
        if(!File.Exists(Path.Combine(storageFolder.Path, folder, filename)))
            return;

        var file = await storageFolder.GetFileAsync(Path.Combine(folder, filename));
        await file.DeleteAsync(StorageDeleteOption.Default);
    }

    public string GetAssetsFolder()
    {
        var installationPath = Package.Current.InstalledLocation.Path;
        return Path.Combine(installationPath, "Assets");
    }
    public string GetLocalFolder()
    {
        return ApplicationData.Current.LocalFolder.Path;
    }
    /// <summary>
    /// storageFolder.Path
    /// </summary>
    /// <returns></returns>
    public string GetLocalStorageFolder()
    {
        return storageFolder.Path;
    }


    public async Task SetStorageFolderAsync(string directory)
    {
        storageFolder = await StorageFolder.GetFolderFromPathAsync(directory);
    }

    public async Task OpenDirectory(string directory)
    {
        if (!Directory.Exists(directory)) 
            Directory.CreateDirectory(directory);

        await Launcher.LaunchFolderAsync(await StorageFolder.GetFolderFromPathAsync(directory));
    }   
    public async Task<string> SelectDirectory()
    {
        // Retrieve the window handle (HWND) of the current WinUI 3 window.
        //var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
        // Retrieve the window handle (HWND) of the current WinUI 3 window.
        var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(App.AppCurrent.MainWindow);

        Windows.Storage.Pickers.FolderPicker folderPicker = new();


        // Initialize the folder picker with the window handle (HWND).
        WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hWnd);

        folderPicker.FileTypeFilter.Add("*");
        StorageFolder folder = await folderPicker.PickSingleFolderAsync();
        if (folder != null)
        {
            // The StorageFolder has read/write access to all contents in the picked folder (including other sub-folder contents).
            // See the FileAccess sample for code that obtains a StorageFile from a StorageFolder to read and write.
            StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
            return folder.Path;
            //OutputTextBlock.Text = "Picked folder: " + folder.Name;

        }
        else
        {
            //OutputTextBlock.Text = "Operation cancelled.";
        }

        return null;
    }             
    public async Task OpenPrindPrivewFor(ObservableCollection<PDFRenderModel> renderlist, string directory, string mainfile)
    {
        var p = new PDFRenderingPage();
        p.ItemsListView.ItemsSource = renderlist;

        var result = await new ContentDialog()
        {
            Title = "Print Labels?",
            PrimaryButtonText = "Print",
            SecondaryButtonText = "Open Directory",
            CloseButtonText = "Close",
            DefaultButton = ContentDialogButton.Primary,
            Content = p,
            XamlRoot = App.AppCurrent.MainWindow.Content.XamlRoot,
            Width = 1280
        }.ShowAsync();

        if (result == ContentDialogResult.Secondary)
        {
            await OpenDirectory(directory);
        }
        else if (result == ContentDialogResult.Primary)
        {
            await Launcher.LaunchFileAsync(await StorageFile.GetFileFromPathAsync(mainfile));
        }
    }
    public async Task<Tuple<string, ObservableCollection<PDFRenderModel>>> CombinePDF(string directory, string allpdfkey, string[] files)
    {
        if (!allpdfkey.EndsWith("-"))
            allpdfkey += "-";

        var targetPath = Path.Combine(directory, $"00-{allpdfkey}All.pdf");

        if (File.Exists(targetPath))
            File.Delete(targetPath);

        ObservableCollection<PDFRenderModel> renderlist = new();

        // Initial setup, create credentials instance.
        Credentials credentials = Credentials.ServiceAccountCredentialsBuilder() 
                        .FromFile(@"C:\Users\elimd\OneDrive\Juniper\pdfservices-api-credentials.json")
                        .Build();

        //Create an ExecutionContext using credentials and create a new operation instance.
        Adobe.PDFServicesSDK.ExecutionContext executionContext = Adobe.PDFServicesSDK.ExecutionContext.Create(credentials);
        CombineFilesOperation combineFilesOperation = CombineFilesOperation.CreateNew();

        foreach (var file in files)
        {
            if (file == targetPath)
                continue;

            // Add operation input from source files.
            combineFilesOperation.AddInput(FileRef.CreateFromLocalFile(file));

            var pdfDocument = await Windows.Data.Pdf.PdfDocument.LoadFromFileAsync(await StorageFile.GetFileFromPathAsync(file));

            var stream = new InMemoryRandomAccessStream();
            for (uint i = 0; i < pdfDocument.PageCount; i++)
            {
                using Windows.Data.Pdf.PdfPage page = pdfDocument.GetPage(i);
                await page.RenderToStreamAsync(stream);

                BitmapImage src = new();
                await src.SetSourceAsync(stream);
                renderlist.Add(new() { PDFSrc = file, ImgSrc = src });
            }
        }

        // Execute the operation.
        FileRef result = combineFilesOperation.Execute(executionContext);

        // Save the result to the specified location.
        result.SaveAs(targetPath);

        return new(targetPath, renderlist);
    }
}
