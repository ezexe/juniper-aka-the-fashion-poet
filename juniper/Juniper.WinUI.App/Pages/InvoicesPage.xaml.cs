using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Juniper.WinUI.App.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InvoicesPage : FilterablePageBase
    {
        public InvoicesViewModel ViewModel => (InvoicesViewModel)DataContext;
        public override SemanticZoomBaseUserControl Szoom => sz;

        public InvoicesPage()
        {
            this.InitializeComponent();

            DataContext = App.Current.Services.GetService<InvoicesViewModel>(); 
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await InvoicesViewModel.SendSelectedInvoices(ViewModel, sz.SelectedItems);
        }
        private async void MFIPaid_Click(object sender, RoutedEventArgs e)
        {
            await InvoicesViewModel.MarkSelectedPaid(sz.SelectedItems, (sender as MenuFlyoutItem).Name == MFIPaid.Name);
        }

        public override void EnsureTitleObject(ControlInfoDataGroup g)
        {
            NavigationRootPage.Current.EnsureNavigationSelection(ControlInfoDataSource.Instance.Groups.IndexOf(g), sz.HeaderText, sz.HeaderContent);
        }

    }
}
