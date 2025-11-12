namespace Juniper.Core.Interfaces
{
    public abstract class BaseHasCanSendViewModel : BaseHasRemoveablesViewModel
    {
        public readonly IFilesService FilesService = Ioc.Default.GetRequiredService<IFilesService>();

        private DocumentStatus status = DocumentStatus.New;
        private IHaveInternalSettings internalSettings;
        
        public string JsonFilePath { get; set; }//=> Path.Combine(FilesService.GetLocalFolder(), SendFileSaveDirectory, SaveFileName);
        public string SavedJsonFilePath { get; set; }//=> Path.Combine(FilesService.GetLocalFolder(), SendFileSaveDirectory, SaveFileName);
        public bool FromDynamo { get; set; }
        public bool FromDynamoLoaded { get; set; }
        public bool FromDynamoHasS3Files { get; set; }
        //public string FromDynamoJsonFilePath { get; set; }

        public abstract PurchaseOrderViewModel PurchaseOrder { get; }
        public abstract string S3KeyName { get; }
        public abstract string S3DirName { get; }
        public abstract string TradingPartnerId { get; }
        public abstract string SendFileName { get; }
        public abstract string SendFileSaveDirectory { get; }
        public abstract string SaveFileName { get; }
        public abstract string SaveFileDirectory { get; }

        public abstract void DocumentStatusChanged();
        public abstract void RemoveFromVMItemsList();
        public abstract object GetSendObject();
        public abstract object GetImplementorObject();
        public abstract object GetInternalSettingsObject();
        public abstract void SetForceEnabled();
        public abstract Task GetSetDBTableRow();
        internal abstract Task<bool> LoadFromS3(string json);

        public async Task StartSaveToAws(DocumentStatus storage)
        {
            bool s3 = !(storage == DocumentStatus.SavedSettings);
            //sent default
            var s3Dir = S3DirName;
            switch (storage)
            {
                case DocumentStatus.New:
                    break;
                case DocumentStatus.Saved:
                    s3Dir = S3BucketService.SaveBucketName + S3DirName;
                    break;
                case DocumentStatus.Deleted:
                    break;
                case DocumentStatus.InProgress:
                    break;
                case DocumentStatus.SavedSettings:
                    break;
                default:
                    break;
            }
            if (s3)
            {
                await S3BucketService.Current.UploadFileAsync(JsonFilePath, s3Dir, S3KeyName);
                if(GetImplementorObject() is ASNViewModel asn)
                {
                    await asn.PutIntoSSCCTable();
                }
            }

            await GetSetDBTableRow();
        }
        public DocumentStatus Status
        {
            get => status;
            set
            {
                status = value;
                SetProperty(ref status, value);
                ForceEnabled = CanAddRemoveables = value != DocumentStatus.Sent;
                SetForceEnabled();
                DocumentStatusChanged();
            }
        }

        public BaseHasCanSendViewModel() : base()
        {

        }

        //Instantiate a Singleton of the Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        static readonly SemaphoreSlim semaphoreSlim = new(1, 1);

        public override async Task<Exception?> RaiseOnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {
                    case "CommandCheckForError":
                        if (!CheckForError())
                            MainViewModel.Current.DisplayInfobarMessage("Error Check", $"Looks Good", InfoSeverity.Success);
                        return null;

                    case "CommandDelete":
                        await DeleteSaved();
                        return null;

                    case "CommandSave":
                        await Save(true);
                        MainViewModel.Current.DisplayInfobarMessage("Saved", $"Saved to {SaveFileDirectory}", InfoSeverity.Success);
                        return null;

                    case "CommandSend":
                        await CommandSend(false);
                        return null;

                    case "CommandForceEnabled":
                        CanAddRemoveables = ForceEnabled = !ForceEnabled;
                        DocumentStatusChanged();
                        SetForceEnabled();
                        break;

                    case "CommandSaveSettings":
                        await SaveSettings();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
                return ex;
            }

            await OnCommandActivated(commandParam);

            return null;
        }
        public async Task CommandSend(bool throwOnCheck)
        {
            if (await SendToSPSCommerce(throwOnCheck))
            {
                Status = DocumentStatus.Sent;
                MainViewModel.Current.DisplayInfobarMessage("Sent", $"{SaveFileName} Successfully Sent", InfoSeverity.Success);

                //JsonFilePath = Path.Combine(FilesService.GetLocalStorageFolder(), SendFileSaveDirectory, SaveFileName);
                await StartSaveToAws(DocumentStatus.Sent);
            }
        }
        public bool CheckForError()
        {
            ValidationErrors.Clear();

            AddValidationError(GetImplementorObject());

            RecursiveGetProps<ABaseHasRequiredObject>(GetImplementorObject());

            return ValidationErrors.Count > 0;
        }
        public async Task<bool> SendToSPSCommerce(bool throwOnCheck)
        {
            if (CheckForError())
            {
                if (throwOnCheck)
                    throw new Exception("Check For Error's found errors");
                else
                    return false;
            }

            //await Save(false);

            //what you send
            var jsonObj = GetSendObject();

            //how you send
            var jsonTxt = jsonObj.Serialize(JsonSerializerDefaults.Web);
            var file = await FilesService.WriteAsyncGetBytes(SendFileSaveDirectory, SaveFileName, jsonTxt);
            JsonFilePath = file.Item2;
            //where its sent
            //var urlPath = SettingsViewModel.GetLiveUrlPath(TradingPartnerId, SendFileName);
            RestResponse response = await RestClientService.Current.PostRequest(SendFileName, file.Item1);
            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                if (throwOnCheck)
                    throw new Exception(response.Content, response.ErrorException);
                else
                {
                    MainViewModel.Current.DisplayInfobarMessage("Not Sent", $"{response.Content} - {response.ErrorException}", InfoSeverity.Error);
                    return false;
                }
            }
        }
        public async Task Save(bool fromCommand)
        {
            await FilesService.WriteAsync(SaveFileDirectory, SaveFileName, GetImplementorObject());

            if (fromCommand && Status == DocumentStatus.Sent)
            {
                //JsonFilePath = Path.Combine(FilesService.GetLocalStorageFolder(), SendFileSaveDirectory, SaveFileName);
                JsonFilePath = await FilesService.WriteAsync(SendFileSaveDirectory, SaveFileName, GetSendObject());
                await StartSaveToAws(DocumentStatus.Sent);
            }
            else
            {
                if (Status != DocumentStatus.Sent)
                    Status = DocumentStatus.Saved;

                SavedJsonFilePath = await FilesService.WriteAsync(SaveFileDirectory, SaveFileName, GetSendObject());
                await StartSaveToAws(DocumentStatus.Saved);
            }
        }
        public async Task SaveSettings()
        {
           // var o = GetInternalSettingsObject();
           // await FilesService.WriteAsync(SaveSettingsDirectory, SaveSettingsFileName, o);

            await GetSetDBTableRow();
        }
        public async Task DeleteSaved()
        {
            await FilesService.DeleteItem(SaveFileDirectory, SaveFileName);
            await FilesService.DeleteItem(SendFileSaveDirectory, SaveFileName);

            RemoveFromVMItemsList();
        }
        /// <summary>
        /// loads the asn data and calls LoadFromS3(json)
        /// </summary>
        /// <returns></returns>
        public async Task LoadS3Data()
        {
            await semaphoreSlim.WaitAsync();
            try
            {
                if (FromDynamo && !FromDynamoLoaded)
                {
                    var json = await S3BucketService.Current.ReadObjectDataAsync(S3DirName, S3KeyName);

                    FromDynamoHasS3Files = json != string.Empty;

                    if (FromDynamoHasS3Files)
                        FromDynamoLoaded = await LoadFromS3(json);
                    else
                        throw new IndexOutOfRangeException("FromDynamoHasS3Files false");
                }
            }
            finally
            {
                semaphoreSlim.Release();
            }
        }
    }
}
