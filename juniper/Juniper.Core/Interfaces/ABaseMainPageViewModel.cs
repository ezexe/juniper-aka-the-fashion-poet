namespace Juniper.Core.Interfaces
{
    public abstract class ABaseMainPageViewModel : BaseViewModel, ICanFilter
    {
        public readonly IFilesService FilesService = Ioc.Default.GetRequiredService<IFilesService>();

        public abstract IEnumerable<IHaveIncrementals> IncViewModels { get; }

        public ObservableCollection<TradingPartnerModel> TradingPartners { get => MainViewModel.Current.TradingPartners; }

        public abstract void OrderBy();
        #region ICanFilter
        public ObservableCollection<DateTimeOffset> DocumentDates { get; set; } = new ObservableCollection<DateTimeOffset>();
        public DateTimeOffset SelectedDocumentDates { get; set; }
        public void Filter(IEnumerable<IHaveIncrementals> filtered)
        {
            filtered.RemovedRange(IncViewModels);
            filtered.AddBackRemoved();
        }
        public List<IHaveIncrementals> SearchFor(string query, DocumentType dt)
        {
            return IncViewModels.ToList().SearchForByIncrementals(query, dt);
        }
        #endregion

        public override async Task<Exception?> RaiseOnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {
                    case "CommandClearFilters":
                        IncViewModels.AddBackRemoved();
                        OrderBy();
                        TradingPartners.SortAll();
                        break;

                    case "CommandFilterByDate":
                        Filter(IncViewModels.GetByDate(SelectedDocumentDates));
                        break;

                    case "CommandAddTags":
                        await base.RaiseOnCommandActivated(commandParam);
                        break;

                    default:
                        if (commandParam != null)
                            await OnCommandActivated(commandParam);
                        break;
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
                return ex;
            }
            return null;
        }
    }
}
