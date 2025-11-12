namespace Juniper.Core.Interfaces;
public abstract class BaseViewModel : ObservableObject
{                                           
    private bool isLoading;       
    private bool isModified;
    private bool isActionEnabled = true;   

    public bool IsActionsEnabled
    {
        get => isActionEnabled;
        set => SetProperty(ref isActionEnabled, value);
    }
    public bool IsLoading
    {
        get => isLoading;
        set => SetProperty(ref isLoading, value);
    }
    public bool IsModified
    {
        get => isModified;
        set => SetProperty(ref isModified, value);
    }

    public IAsyncRelayCommand<string> OnCommand { get; }

    public ObservableCollection<DocumentTagsTable> DocumentTags { get; set; } = new();

    public BaseViewModel()
    {
        OnCommand = new AsyncRelayCommand<string>(RaiseOnCommandActivated);
    }

    public abstract Task OnCommandActivated(string? commandParam);

    public virtual Task RaiseOnCommandActivated(string? v)
    {
        try
        {
            switch (v)
            {
                case "CommandSetTags":
                    break;

                case "CommandAddTags":
                    TagsLibrary.Current.AddTags();
                    break;

                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            MainViewModel.Current.LoggerUtil.AddException(ex, v ?? "commandParam-Null");
        } 

        return OnCommandActivated(v);
    }

    public void RaisePropertyChanged(string v)
    {
        OnPropertyChanged(v);
    }
}
