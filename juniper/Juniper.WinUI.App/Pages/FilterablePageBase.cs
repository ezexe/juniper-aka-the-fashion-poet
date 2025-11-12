using Microsoft.UI.Xaml.Navigation;

namespace Juniper.WinUI.App.Pages
{
    public abstract class FilterablePageBase : Page
    {
        public abstract SemanticZoomBaseUserControl Szoom { get; }

        public abstract void EnsureTitleObject(ControlInfoDataGroup g);
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var t = GetType();
            if (ControlInfoDataSource.Instance.Groups.SingleOrDefault(g => g.UniqueId == t.Name) is ControlInfoDataGroup g)
            {
                EnsureTitleObject(g);
            }

            base.OnNavigatedTo(e);
        }

        public async void OnItemListViewItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is PurchaseOrderViewModel item)
            {
                MainViewModel.Current.OrdersViewModel.SelectedPO = item;
            }
            else if (e.ClickedItem is ASNViewModel i2)
            {
                MainViewModel.Current.OrdersViewModel.SelectedPO = i2.povm;
            }
            else if (e.ClickedItem is InvoiceViewModel i3)
            {
                MainViewModel.Current.OrdersViewModel.SelectedPO = i3.asnvm.povm;
            }

            NavigationRootPage.Current.RootFrame.Navigate(typeof(PurchaseOrderPage), e.ClickedItem);
        }

        public void CanFilterUserControl_OnBeforeFilterd()
        {
            Szoom?.SettZoomedView(true);
        }
    }
}
