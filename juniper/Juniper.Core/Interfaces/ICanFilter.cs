namespace Juniper.Core.Interfaces
{
    public interface ICanFilter
    {
        public ObservableCollection<DateTimeOffset> DocumentDates { get; set; }
        public DateTimeOffset SelectedDocumentDates { get; set; }

        List<IHaveIncrementals> SearchFor(string query, DocumentType dt);      
        void Filter(IEnumerable<IHaveIncrementals> filtered);
    }
}
