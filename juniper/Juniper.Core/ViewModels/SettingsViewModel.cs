using System.Runtime.CompilerServices;

namespace Juniper.Core.ViewModels;
public class ReadAddressLines
{
    public string FilePath { get; set; }
    public string[] Lines { get; set; }
}

public class SettingsViewModel : BaseHasRemoveablesViewModel
{
    public static SettingsViewModel Current { get; private set; }
    public static bool StateofSandbox { get; set; }

    public static readonly string OneDriveProjectDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive - The Fashion Poet LLC", "Shared Documents", "New Project");
    public static readonly string[] NewLineSplitter = new string[] { "\r\n", "\r", "\n" };

    private readonly string defaultAppId = "C5inPyyq2KiGfsqiLIJP6Xutz2m90sj9";
    private readonly string defaultAppSecret = "H10vOHY-5jxD69_khe13iQQ8IbWhAt49B91Tn-GdYf389vUbtnpqtqI2kCnwrX7W";

    /// <summary>
    /// Gets the <see cref="ISettingsService"/> instance to use.
    /// </summary>
    private readonly ISettingsService SettingsService = Ioc.Default.GetRequiredService<ISettingsService>();
    private readonly IFilesService FilesService = Ioc.Default.GetRequiredService<IFilesService>();

    public const string BaseCarrierInformationFileName = "BaseCarrierInformation.json";
    public string BaseCarrierInformationFilePath => Path.Combine(FilesService.SettingsFolder, BaseCarrierInformationFileName);

    public const string UpcJsonFileName = "ReadUPCList_v3.json";
    public string UpcJsonFilePath => Path.Combine(FilesService.SettingsFolder, UpcJsonFileName);


    public bool IsLoggedIn { get; set; }
    private AccessTokenResponse? accessTokenResponse;
    public AccessTokenResponse? LatestAccessTokenResponse
    {
        get => accessTokenResponse;
        set => SetProperty(ref accessTokenResponse, value);
    }


    #region Ships From Address
    private string sfAddressName;
    [Setting(SettingStorageKeys.SFAddressName)]
    public string SFAddressName
    {
        get => sfAddressName;
        set
        {
            if (sfAddressName != value)
            {
                SetProperty(ref sfAddressName, value);
                
            }
        }
    }
    private AddressModel prevLoadedshipFromSettings;
    private AddressModel shipFromSettings;
    public AddressModel ShipFromSettings
    {
        get => shipFromSettings;
        set => SetProperty(ref shipFromSettings, value);
    }
    #endregion

    #region Last Used Document Numbers
    private int lastUsedASNMasterBOLNumber;
    [Setting(SettingStorageKeys.LastUsedASNMasterBOLNumber)]
    [MyDynamoDB(nameof(LastUsedASNMasterBOLNumber))]
    public int LastUsedASNMasterBOLNumber
    {
        get => lastUsedASNMasterBOLNumber;
        set
        {
            if (lastUsedASNMasterBOLNumber != value)
            {
                SetProperty(ref lastUsedASNMasterBOLNumber, value);
                SaveLastUsedNumbersInline();
            }
        }
    }

    private int lastUsedASNBOLNumber;
    [Setting(SettingStorageKeys.LastUsedASNBOLNumber)]
    [MyDynamoDB(nameof(LastUsedASNBOLNumber))]
    public int LastUsedASNBOLNumber
    {
        get => lastUsedASNBOLNumber;
        set
        {
            if (lastUsedASNBOLNumber != value)
            {
                SetProperty(ref lastUsedASNBOLNumber, value);
                SaveLastUsedNumbersInline();
            }
        }
    }

    private int lastUsedASNNumber;
    [Setting(SettingStorageKeys.LastUsedASNNumber)]
    [MyDynamoDB(nameof(LastUsedASNNumber))]
    public int LastUsedASNNumber
    {
        get => lastUsedASNNumber;
        set
        {
            if (lastUsedASNNumber != value)
            {
                SetProperty(ref lastUsedASNNumber, value);
                SaveLastUsedNumbersInline();
            }
        }
    }

    private int lastUsedInvoiceNumber;
    [Setting(SettingStorageKeys.LastUsedInvoiceNumber)]
    [MyDynamoDB(nameof(LastUsedInvoiceNumber))]
    public int LastUsedInvoiceNumber
    {
        get => lastUsedInvoiceNumber;
        set
        {
            if (lastUsedInvoiceNumber != value)
            {
                SetProperty(ref lastUsedInvoiceNumber, value);
                SaveLastUsedNumbersInline();
            }
        }
    }


    private readonly SemaphoreSlim lastusedinlinelock = new SemaphoreSlim(1, 1);
    private async void SaveLastUsedNumbersInline([CallerMemberName] string? propertyname = null)
    {
        await lastusedinlinelock.WaitAsync();

        try
        {
            await DynamoLoadNSave(true);
        }
        catch (Exception ex)
        {
            MainViewModel.Current.LoggerUtil.AddException(ex, "SaveLastUsedNumbersInline");
        }
        finally
        {
            lastusedinlinelock.Release();
        }
    }
    #endregion

    #region AppId and Secret
    private string appId;
    [Setting(SettingStorageKeys.AppId)]
    public string AppId
    {
        get => appId;
        set
        {
            if (appId != value)
            {
                SetProperty(ref appId, value);
                
            }
        }
    }

    private string appSecret;
    [Setting(SettingStorageKeys.AppSecret)]
    public string AppSecret
    {
        get => appSecret;
        set
        {
            if (appSecret != value)
            {
                SetProperty(ref appSecret, value);
                
            }
        }
    }
    #endregion

    #region Base Settings Fields
    private string savedDataFilePath;
    [Setting(SettingStorageKeys.SavedDataFilePath)]
    public string SavedDataFilePath
    {
        get => savedDataFilePath;
        set
        {
            if (savedDataFilePath != value)
            {
                SetProperty(ref savedDataFilePath, value);

            }
        }
    }
    private string upcsFilePath;
    [Setting(SettingStorageKeys.UPCsFilePath)]
    public string UPCsFilePath
    {
        get => upcsFilePath;
        set
        {
            if (upcsFilePath != value)
            {
                SetProperty(ref upcsFilePath, value);

            }
        }
    }

    private string bolTemplateFilePath;
    [Setting(SettingStorageKeys.BolTemplateFilePath)]
    public string BolTemplateFilePath
    {
        get => bolTemplateFilePath;
        set
        {
            if (bolTemplateFilePath != value)
            {
                SetProperty(ref bolTemplateFilePath, value);

            }
        }
    }
    private string gs1CompanyPrefix;
    [MyDynamoDB(nameof(Gs1CompanyPrefix))]
    public string Gs1CompanyPrefix
    {
        get => gs1CompanyPrefix;
        set
        {
            if (gs1CompanyPrefix != value)
            {
                SetProperty(ref gs1CompanyPrefix, value);
                
            }
        }
    }

    private string fOBTitlePassageLocation;
    [MyDynamoDB(nameof(FOBTitlePassageLocation))]
    public string FOBTitlePassageLocation
    {
        get => fOBTitlePassageLocation;
        set
        {
            if (fOBTitlePassageLocation != value)
            {
                SetProperty(ref fOBTitlePassageLocation, value);
                
            }
        }
    }

    //private string bloomingdalesPartnerID;
    //[Setting(SettingStorageKeys.BloomingdalesPartnerID)]
    //public string BloomingdalesPartnerID
    //{
    //    get => bloomingdalesPartnerID;
    //    set
    //    {
    //        if (bloomingdalesPartnerID != value)
    //        {
    //            SetProperty(ref bloomingdalesPartnerID, value);
                
    //        }
    //    }
    //}

    //private string bloomingdalesOutletPartnerID;
    //[Setting(SettingStorageKeys.BloomingdalesOutletPartnerID)]
    //public string BloomingdalesOutletPartnerID
    //{
    //    get => bloomingdalesOutletPartnerID;
    //    set
    //    {
    //        if (bloomingdalesOutletPartnerID != value)
    //        {
    //            SetProperty(ref bloomingdalesOutletPartnerID, value);
                
    //        }
    //    }
    //}

    //private string sacksPartnerID;
    //[Setting(SettingStorageKeys.SacksPartnerID)]
    //public string SacksPartnerID
    //{
    //    get => sacksPartnerID;
    //    set
    //    {
    //        if (sacksPartnerID != value)
    //        {
    //            SetProperty(ref sacksPartnerID, value);
                
    //        }
    //    }
    //}

    //private string nordstromPartnerID;
    //[Setting(SettingStorageKeys.NordstromPartnerID)]
    //public string NordstromPartnerID
    //{
    //    get => nordstromPartnerID;
    //    set
    //    {
    //        if (nordstromPartnerID != value)
    //        {
    //            SetProperty(ref nordstromPartnerID, value);
                
    //        }
    //    }
    //}

    //private string nordstromCanadatPartnerID;
    //[Setting(SettingStorageKeys.NordstromCanadaPartnerID)]
    //public string NordstromCANPartnerID
    //{
    //    get => nordstromCanadatPartnerID;
    //    set
    //    {
    //        if (nordstromCanadatPartnerID != value)
    //        {
    //            SetProperty(ref nordstromCanadatPartnerID, value);
                
    //        }
    //    }
    //}
    #endregion

    #region Default Carrier Information
    private List<BaseCarrierInformationModel> prevBaseCarrierInformation = new List<BaseCarrierInformationModel>();
    [MinimumCount(1)]
    public ObservableCollection<BaseCarrierInformationModel> BaseCarrierInformation { get; } = new ObservableCollection<BaseCarrierInformationModel>();
    public async Task GetBaseCarrierInformationModel()
    {
        BaseCarrierInformation.Clear();

        prevBaseCarrierInformation = await FilesService.ReadToValueAsync<List<BaseCarrierInformationModel>>(BaseCarrierInformationFilePath) ?? new List<BaseCarrierInformationModel>();
        if (prevBaseCarrierInformation.Count > 0)
            foreach (var bci in prevBaseCarrierInformation)
            {
                BaseCarrierInformation.Add(bci);
            }
        else
        {
            BaseCarrierInformation.Add(GetNewBaseCarrierInformationModel("Default"));
            prevBaseCarrierInformation.Add(GetNewBaseCarrierInformationModel("Default"));
        }
    }
    #endregion

    #region Quantity And Weight
    private BaseQuantityAndWeightModel baseQuantityAndWeightModel;
    public BaseQuantityAndWeightModel QuantityAndWeightModel
    {
        get => baseQuantityAndWeightModel;
        set => SetProperty(ref baseQuantityAndWeightModel, value);
    }
    public async Task<BaseQuantityAndWeightModel> GetBaseQuantityAndWeightModel()
    {
        var settings = await SettingsService.GetValueAsync<BaseQuantityAndWeightModel>();
        if (settings is null)
        {
            settings = new BaseQuantityAndWeightModel();
            settings.PackingMedium = "CTN";
            settings.WeightQualifier = "G";
            settings.WeightUOM = "LB";
            settings.PackingMaterial = "25";
            settings.Weight = 3.2;

        }
        return settings;
    }
    #endregion
    public SettingsViewModel()
    {
        Current = this;
    }
    public async Task Init()
    {
        foreach (var sa in GetSettingAttributes())
            await GetSavedAsync(sa.StorageKey);

        await GetLoadAccessToken();
        await DynamoLoadNSave(false);

        QuantityAndWeightModel = await GetBaseQuantityAndWeightModel();

        var text = UPCsFilePath.EndsWith(".xlsx") ?
            await MainViewModel.Current.ExcelUtil.GetFileText(UPCsFilePath, "UPC") :
            await MainViewModel.Current.ExcelUtil.GetCsvFileText(UPCsFilePath);

    }
    public async Task<string?> GetLoadAccessToken()
    {
        IsLoggedIn = false;

        LatestAccessTokenResponse = await SettingsService.GetValueAsync<AccessTokenResponse>();
        if (LatestAccessTokenResponse is not null)
        {
            if (LatestAccessTokenResponse.ExpiresAt > DateTime.Now)
            {
                IsLoggedIn = true;
            }
            else
            {
                try
                {
                    LatestAccessTokenResponse = await RestClientService.Current.GetAccessTokenRequestAsync(new AccessTokenRequest()
                    {
                        Client_id = AppId,
                        client_secret = AppSecret
                    });

                    SettingsService.SetValue(nameof(AccessTokenResponse), JsonSerializer.Serialize(LatestAccessTokenResponse));
                }
                catch (Exception ex)
                {
                    LatestAccessTokenResponse = null;
                    MainViewModel.Current.LoggerUtil.AddException(ex, "GetLoadAccessToken");
                }
            }
        }

        return LatestAccessTokenResponse?.access_token;
    }
    private async Task DynamoLoadNSave(bool save)
    {
        var tSettings = await DynamoService.Current.GetAllItemsAsync<SettingsTable>();
        if (tSettings != null)
        {
            var dbProps = GetDynamoDBAttributes();
            foreach (var s in tSettings)
            {
                if (dbProps.FirstOrDefault(p => p.SettingId == s.SettingId) is MyDynamoDBAttribute sa)
                {
                    var prop = typeof(SettingsViewModel).GetProperties().FirstOrDefault(p => p.Name == sa.SettingId);
                    if (prop != null)
                    {
                        if (save)
                            s.SettingValue = prop.GetValue(this)?.ToString();
                        else
                            prop.SetValue(this, prop.PropertyType == typeof(int) ? Convert.ToInt32(s.SettingValue) : s.SettingValue);
                    }
                }
                else
                {
                    if (s.SettingId == "BaseCarrierInformation")
                    {
                        if (s.SettingValueList == null)
                            s.SettingValueList = new();

                        if (save)
                        {
                            s.SettingValueList.Clear();
                            foreach (var ci in BaseCarrierInformation)
                            {
                                s.SettingValueList.Add(ci.Serialize());
                            }
                        }
                        else
                        {
                            foreach (var json in s.SettingValueList)
                            {
                                if (json.Deserialize<BaseCarrierInformationModel>() is BaseCarrierInformationModel cim && 
                                    !BaseCarrierInformation.Contains(cim) && 
                                    !BaseCarrierInformation.Any(bci=>bci.Title == cim.Title))
                                    BaseCarrierInformation.Add(cim);
                            }
                        }
                    }
                }

                if (save)
                    await DynamoService.Current.Store(s);
            }
        }
    }
    public async Task<string> GetSavedAsync(SettingStorageKeys key, bool set = true)
    {
        var ret = await SettingsService.GetStringValueAsync(key.ToString());
        string? actualRet;
        switch (key)
        {
            case SettingStorageKeys.AppId:
                actualRet = ret ?? defaultAppId;
                if (set)
                    AppId = actualRet;
                break;
            case SettingStorageKeys.AppSecret:
                actualRet = ret ?? defaultAppSecret;
                if (set)
                    AppSecret = actualRet;
                break;
            case SettingStorageKeys.SFAddressName:
                actualRet = ret ?? "Juniper 08 LLC";
                if (set)
                {
                    SFAddressName = actualRet;
                    LoadShipFromSettings();
                }
                break;
            case SettingStorageKeys.UPCsFilePath:
                actualRet = ret ?? Path.Combine(FilesService.GetAssetsFolder(), "UPC's.xlsx - UPC.csv");
                if (set)
                    UPCsFilePath = actualRet;
                break;
            case SettingStorageKeys.BolTemplateFilePath:
                actualRet = ret ?? Path.Combine(OneDriveProjectDir, "Templates"); //@"C:\Users\elimd\OneDrive - The Fashion Poet LLC\Templates\BOL.docx";C:\Users\elimd\OneDrive - The Fashion Poet LLC\Documents\New Project
                if (set)
                    BolTemplateFilePath = actualRet;
                break;
            case SettingStorageKeys.SavedDataFilePath:
                if (Debugger.IsAttached && StateofSandbox)
                {
                    actualRet = @"C:\tmp\LocalState";
                    if (!Directory.Exists(actualRet))
                        Directory.CreateDirectory(actualRet);
                }
                else
                    actualRet = ret ?? FilesService.GetLocalFolder();

                if (set)
                {
                    SavedDataFilePath = actualRet;
                    await FilesService.SetStorageFolderAsync(SavedDataFilePath);
                }
                break;
            default:
                actualRet = ret;
                break;
        }

        return actualRet.Trim();
    }
    private void LoadShipFromSettings()
    {
        prevLoadedshipFromSettings = LoadAddressSettings();
        ShipFromSettings =  LoadAddressSettings();
    }
    private AddressModel LoadAddressSettings()
    {
        //var settings = await SettingsService.GetValueAsync<AddressModel>(SFAddressName);
        //return settings ?? new AddressModel()
        //{
        //    Address = "4014 1ST AVE",
        //    Address2 = "BLDG 26 STE 601",
        //    City = "BROOKLYN",
        //    State = "NY",
        //    Zip = "11232",
        //    PhoneNumber = "9292612641",
        //    Name = SFAddressName,
        //};
        return new AddressModel()
        {
            Address = "4014 1ST AVE",
            Address2 = "BLDG 26 STE 601",
            City = "BROOKLYN",
            State = "NY",
            Zip = "11232",
            PhoneNumber = "9292612641",
            Name = SFAddressName,
        };
    }
    public override async Task<Exception?> OnCommandActivated(string? commandParam)
    {
        if (commandParam == null) return null;
        try
        {
            switch (commandParam)
            {
                case "CommandSaveSettings":
                    await SaveProps();
                    await SaveShipFromSettings();
                    //await SaveBaseCarriers();
                    //await SaveFilepaths();
                    await DynamoLoadNSave(true);
                    await TagsLibrary.Current.Save();

                    IsModified = false;
                    MainViewModel.Current.DisplayInfobarMessage("Setting Saved", $"Settings have been successfully saved.", InfoSeverity.Success);
                    break;

                case "CommandGetToken":
                    await GetLoadAccessToken();
                    if (LatestAccessTokenResponse is not null)
                        MainViewModel.Current.DisplayInfobarMessage("Access Token", $"Access token loaded Expires At: {LatestAccessTokenResponse.ExpiresAt}", InfoSeverity.Success);
                    break;

                case "CommandAddCarrierInformation":
                    BaseCarrierInformation.Add(GetNewBaseCarrierInformationModel("Carrier-" + (BaseCarrierInformation.Count + 1)));
                    IsModified = true;
                    break;

                default:
                    break;
            }
        }
        catch(Exception ex)
        {
            MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
            return ex;
        }

        return null;
    }
    private async Task SaveProps()
    {
        foreach (var sa in GetSettingAttributes())
        {
            await SettingsService.SetValueAsync(sa.Name, Convert.ToString(typeof(SettingsViewModel).GetProperty(sa.Name)?.GetValue(this)));
        }
    }
    private async Task SaveShipFromSettings()
    {
        await SettingsService.SetValueAsync(SFAddressName, JsonSerializer.Serialize(ShipFromSettings));
        prevLoadedshipFromSettings = LoadAddressSettings();
    }
    private static BaseCarrierInformationModel GetNewBaseCarrierInformationModel(string title)
    {
        var settings = new BaseCarrierInformationModel(MainViewModel.Current.FieldsService.ShipmentsFields);
        settings.Title = title;
        settings.CarrierAlphaCode = "DYN";
        settings.CarrierRouting = "DYNAMIC GROUND";
        settings.CarrierTransMethodCode = "M";
        settings.StatusCode = "CL";
        return settings;
    }

    public static IEnumerable<SettingAttribute> GetSettingAttributes()
    {
        var props = typeof(SettingsViewModel).GetProperties();
        foreach (var p in props)
        {
            var att = Attribute.GetCustomAttribute(p, typeof(SettingAttribute));
            if (att is SettingAttribute sa)
            {
                yield return sa;
            }
        }
    }
    public static IEnumerable<MyDynamoDBAttribute> GetDynamoDBAttributes()
    {
        var props = typeof(SettingsViewModel).GetProperties();
        foreach (var p in props)
        {
            var att = Attribute.GetCustomAttribute(p, typeof(MyDynamoDBAttribute));
            if (att is MyDynamoDBAttribute sa)
            {
                yield return sa;
            }
        }
    }

    public static string FCtoDCHardcod(string? fc)
    {
        return fc switch
        {
            "873" or "0873" => "0879",
            "881" or "0881" => "0562",
            _ => fc ?? "",
        };
    }

    internal static int SetLastIdNumber(IHaveIncrementals ivm, List<IHaveIncrementals> incl, bool isbol)
    {
        var curIdnum = isbol ? ivm.Bol : ivm.Id;

        var query = from iv in incl
                    where
                        iv.Status != DocumentStatus.Sent &&
                        ((!isbol && iv.Id > curIdnum) || (isbol && iv.Bol > curIdnum))
                    orderby isbol ? iv.Bol : iv.Id
                    select iv;

        var queryarr = from iv in incl
                       where
                        iv.Status == DocumentStatus.Sent
                       orderby isbol ? iv.Bol : iv.Id
                       select isbol ? iv.Bol : iv.Id;

        var arr = queryarr.ToArray();

        foreach (var i in query)
        {
            while (arr.Contains(curIdnum))
                curIdnum++;

            if (isbol)
                i.Bol = curIdnum;
            else
                i.Id = curIdnum;
            curIdnum++;
        }

        return curIdnum;
    }
    internal static int GetNextIdNumber(List<IHaveIncrementals> incl, int curIdnum, bool isbol)
    {
        var numblist = new List<int>();
        //var query = isbol ?
        //    from iv in incl
        //    orderby iv.Bol
        //    select iv.Bol
        //    :
        //    from iv in incl
        //    orderby iv.Id
        //    select iv.Id;
        foreach (var item in incl.OrderBy(o => isbol ? o.Bol : o.Id).ToArray())
        {
            if (isbol)
                numblist.Add(item.Bol);
            else
                numblist.Add(item.Id);
        }

        //var arr = query.ToArray();
        while (numblist.Contains(curIdnum))
            curIdnum++;

        return curIdnum;
    }
}