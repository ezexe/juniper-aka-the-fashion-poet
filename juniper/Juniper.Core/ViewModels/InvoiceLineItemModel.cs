namespace Juniper.Core.ViewModels
{
    public class InvoiceLineItemModel : BaseHasRemoveablesViewModel
    {
        public InvoiceLineModel InvoiceLine { get; set; }

        public ObservableCollection<BaseChargesAllowances> ChargesAllowances { get; set; } = new ObservableCollection<BaseChargesAllowances>();
        public ObservableCollection<BaseProductOrItemDescriptionModel> ProductOrItemDescription { get; set; } = new ObservableCollection<BaseProductOrItemDescriptionModel>();


        public InvoiceLineItemModel(FieldsBase invoiceFields)
        {
            InvoiceLine = new InvoiceLineModel(invoiceFields);
        }
        [JsonConstructor]
        public InvoiceLineItemModel()
        {
            InvoiceLine = new InvoiceLineModel();
            CanAddRemoveables = true;
        }

        //public override void RemoveableRequested(Type type, object dataContext)
        //{
        //    if (dataContext is BaseChargesAllowances bca)
        //    {
        //        ChargesAllowances.Remove(bca);
        //    }
        //}

        public override async Task<Exception?> OnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {
                    case "CommandAddChargesAllowances":
                        ChargesAllowances.Add(new BaseChargesAllowances());
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "commandParam-Null");
                return await Task.FromResult(ex);
            }
            return null;
        }
    }
}
