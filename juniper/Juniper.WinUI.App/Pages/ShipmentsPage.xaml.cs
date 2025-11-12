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
    public sealed partial class ShipmentsPage : FilterablePageBase
    {
        public ShipmentsViewModel ViewModel => (ShipmentsViewModel)DataContext;

        public override SemanticZoomBaseUserControl Szoom => sz;
        public ShipmentsPage()
        {
            this.InitializeComponent();

            DataContext = App.Current.Services.GetService<ShipmentsViewModel>();
            ViewModel.OnInvoicePreviewReady += ViewModel_OnInvoicePreviewReady;
        }

        public override void EnsureTitleObject(ControlInfoDataGroup g)
        {
            NavigationRootPage.Current.EnsureNavigationSelection(ControlInfoDataSource.Instance.Groups.IndexOf(g), sz.HeaderText, sz.HeaderContent);
        }

        private async void ViewModel_OnInvoicePreviewReady()
        {
            var p = new SendMultiInvoicePreviewPage();
            p.DataContext = ViewModel;
            //p.CVS.Source = ViewModel.PreviewASNInvoicesData;

            ContentDialog dialog = new();
            dialog.Title = "Preview";
            dialog.PrimaryButtonText = "Send";
            //dialog.SecondaryButtonText = "Open Directory";
            dialog.CloseButtonText = "Close";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.Content = p;
            dialog.XamlRoot = App.AppCurrent.MainWindow.Content.XamlRoot;

            var result = await dialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                await ViewModel.SendInvoicesToSelected(sz.SelectedItems, false);
            }
            else
            {
                foreach (var tp in ViewModel.PreviewASNInvoicesData)
                {
                    ShipmentsViewModel.RemovePreviewINV(tp.InvoiceViewModels.ToArray());
                    tp.ASNShipments.Clear();
                    tp.PurchaseOrders.Clear();
                    tp.InvoiceViewModels.Clear();
                }
                ViewModel.PreviewASNInvoicesData.Clear();
            }
        }

        private async void ABBMasterBol_Click(object sender, RoutedEventArgs e)
        {
            ABBMasterBol.IsEnabled = false;
            await ShipmentsViewModel.CreateMasterBolFor(sz.SelectedItems);
            ABBMasterBol.IsEnabled = true;
        }

        private async void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            await ViewModel.SendInvoicesToSelected(sz.SelectedItems, true);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            btnsetActualShipDateFlyout.Hide();
             await ViewModel.SetSelectedActualShipDate(sz.SelectedItems);
        }
    }
}
