using SPSCommerceSDK.Models.Invoices;

namespace Juniper.Core.ViewModels
{
    public class ReadInvoicesFile
    {
        public string Filename { get; set; }
        public Invoice Invoice { get; set; }
    }
    public class InvoicesViewModel: ABaseMainPageViewModel
    {
        public static InvoicesViewModel Current { get; private set; }

        public List<InvoicesTable> InvoicesTable { get; set; }
        public List<ReadInvoicesFile> ReadInvoices { get; set; } = new List<ReadInvoicesFile>();

        public ObservableCollection<Invoice> Invoices { get; } = new ObservableCollection<Invoice>();
        public ObservableCollection<InvoiceViewModel> InvoiceViewModels { get; } = new ObservableCollection<InvoiceViewModel>();
        public override IEnumerable<IHaveIncrementals> IncViewModels => InvoiceViewModels.Cast<IHaveIncrementals>();

        private string failedInvoices;
        public string FailedInvoices
        {
            get { return failedInvoices; }
            set { SetProperty(ref failedInvoices, value); }
        }


        public InvoicesViewModel()
        {
            Current = this;
        }
        public async Task Init(bool clear)
        {
            if (clear)
            {
                ClearList();
            }

            await LoadLocalInvoices(MainViewModel.Current.FilesService.SentInvoiceFolder);
           // await LoadLocalInvoices(MainViewModel.Current.SettingsViewModel.SentInvoicesFilePath);
           
            InvoiceViewModels.OrderByIncrementals();
        }

        public void ClearList()
        {
            foreach (var p in TradingPartners)
            {
                p.InvoiceViewModels.Clear();
            }

            Invoices.Clear();
            InvoiceViewModels.Clear();
        }
        public async Task LoadLocalInvoices(string sentInvoicesFilePath)
        {
            foreach (var item in await MainViewModel.Current.FilesService.ReadValuesAsync<Invoice>(sentInvoicesFilePath, (from rs in ReadInvoices select rs.Filename).ToArray()))
            {
                if (!InvoiceDupes(item.Item2,item.Item1))
                {
                    if (item.Item2.Header?.InvoiceHeader?.InvoiceNumber == null || item.Item2.Header.InvoiceHeader.PurchaseOrderNumber == null)
                        continue;

                    ReadInvoices.Add(new ReadInvoicesFile
                    {
                        Filename = item.Item1,
                        Invoice = item.Item2,
                    });

                    Invoices.Add(item.Item2);
                }
                else
                {
                    Debug.WriteLine(item.Item1);
                }
            }
        }

        private bool InvoiceDupes(Invoice inv, string file)
        {
            return
                ReadInvoices.Any(ri=> (ri.Invoice != null && ri.Invoice.Header?.InvoiceHeader?.InvoiceNumber == inv.Header?.InvoiceHeader?.InvoiceNumber)
                || (Path.GetFileName(ri.Filename) == Path.GetFileName(file))) ||
                Invoices.Any(s =>
                     s.Header?.InvoiceHeader?.InvoiceNumber == inv.Header?.InvoiceHeader?.InvoiceNumber
                     && s.Header?.InvoiceHeader?.BillOfLadingNumber == inv.Header?.InvoiceHeader?.BillOfLadingNumber
                     && s.Header?.InvoiceHeader?.PurchaseOrderNumber == inv.Header?.InvoiceHeader?.PurchaseOrderNumber);
        }

        public override async Task<Exception?> OnCommandActivated(string? commandParam)
        {
            try
            {
                switch (commandParam)
                {
                    case "CommandReSendFailed":
                        await ReSendFailed();
                        break;

                    case "CommandExportCSVDataByDate":
                        await ExportCSVDataByDate();
                        break;

                    default:
                        return commandParam != null ? await base.RaiseOnCommandActivated(commandParam) : null;
                            

                }
            }
            catch (Exception ex)
            {
                MainViewModel.Current.LoggerUtil.AddException(ex, commandParam ?? "param null");
                return ex;
            }

            return null;
        }

        private async Task ReSendFailed()
        {
            if (!FailedInvoices.IsNullEmptyOrWhiteSpace())
            {
                var sentInvoices = 0;
                var errs = new List<Exception>();
                var lines = FailedInvoices.Split(SettingsViewModel.NewLineSplitter, StringSplitOptions.RemoveEmptyEntries);
                foreach (var l in lines)
                {
                    var line = l.Trim();
                    if (line.Contains(' '))
                        line = line.Remove(0, line.LastIndexOf(' '));
                    line = line.Trim();
                    var iv = InvoiceViewModels.FirstOrDefault(i => i.InvoiceHeader.InvoiceNumber == line);
                    if (iv != null)
                    {
                        var err = await iv.OnCommandActivated("CommandSend");
                        if (err != null)
                            errs.Add(err);
                        else
                        {
                            sentInvoices++;
                            await Task.Delay(250);
                        }
                    }
                }


                if (errs.Count > 0)
                    MainViewModel.Current.DisplayInfobarMessage("Errors", $"There was {errs.Count}, in Sending invoices to check log for more details.", InfoSeverity.Error);
                else
                    MainViewModel.Current.DisplayInfobarMessage("Done", $"Done ReSending invoices to a total of {sentInvoices} Invoices", InfoSeverity.Success);
            }
        }
        private async Task ExportCSVDataByDate()
        {
            await MainViewModel.Current.ExcelUtil.ExportInvoice(InvoiceViewModels.GetByDate(SelectedDocumentDates).ToArray());
        }

        public override void OrderBy()
        {
            InvoiceViewModels.OrderByIncrementals();
        }

        internal void AddToAllInvoicesList(InvoiceViewModel ivm)
        {
            ivm.asnvm.povm.TradingPartner.AddInvoice(ivm);

            if (!InvoiceViewModels.Contains(ivm))
                InvoiceViewModels.Add(ivm);

            DocumentDates.AddUnique(ivm.Date);
        }
        internal void RemoveFromAllInvoicesList(InvoiceViewModel ivm)
        {
            MainViewModel.Current.SettingsViewModel.LastUsedInvoiceNumber = SettingsViewModel.SetLastIdNumber(ivm, InvoiceViewModels.ToList<IHaveIncrementals>(), false);

            ivm.asnvm.povm.TradingPartner.RemoveInvoice(ivm);

            if (InvoiceViewModels.Contains(ivm))
                InvoiceViewModels.Remove(ivm);

            DocumentDates.RemoveUnique(InvoiceViewModels, ivm.Date);
        }

        public static async Task MarkSelectedPaid(IList<object> selectedItems, bool paid)
        {
            foreach (var o in selectedItems)
            {
                if (o is InvoiceViewModel ivm)
                {
                    await ivm.LoadS3Data();

                    ivm.InternalINVSettings.IsPaid = paid;
                    await ivm.SaveSettings();
                }
            }
        }

        public static async Task SendSelectedInvoices(BaseViewModel vm, IList<object> selectedItems)
        {
            vm.IsActionsEnabled = false;

            var errs = new List<Exception>();
            foreach (var o in selectedItems)
            {
                if (o is InvoiceViewModel ivm)
                {
                    await ivm.LoadS3Data();

                    var ex = await ivm.OnCommandActivated("CommandSend");
                    if (ex != null)
                    {
                        errs.Add(ex);
                    }
                }
            }

            vm.IsActionsEnabled = true;

            if (errs.Count > 0)
                MainViewModel.Current.DisplayInfobarMessage("Errors", $"There was {errs.Count}, in Sending invoices check log for more details.", InfoSeverity.Error);
        }
    }
}