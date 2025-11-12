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
    public sealed partial class PurchaseOrderPage : Page
    {
        private static readonly SemaphoreSlim semaphoreSlim = new(1, 1);
        private static readonly SemaphoreSlim semaphoreSlimToggle = new(1, 1);
        private object trvSelected;

        public PurchaseOrderViewModel ViewModel => (PurchaseOrderViewModel)DataContext;
        public object TreeViewSelectedItem
        {
            get => trvSelected;
            set
            {
                if (value != null && value != trvSelected)
                {
                    trvSelected = value;
                    NavigateToSelected();
                }
            }
        }


        public PurchaseOrderPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is ASNViewModel asnvm)
            {
                DataContext = asnvm.povm;
                //ViewModel.OnNavigateToRequested = ViewModel_OnNavigateToRequested;

                ViewModel.SelectedASNViewModel = asnvm;

                TreeViewSelectedItem = asnvm;

                //await NaveToASN();
            }
            else if (e.Parameter is InvoiceViewModel ivm)
            {
                DataContext = ivm.asnvm.povm;
                //ViewModel.OnNavigateToRequested = ViewModel_OnNavigateToRequested;

                ViewModel.SelectedASNViewModel = ivm.asnvm;
                ViewModel.SelectedInvoiceViewModel = ivm;

                TreeViewSelectedItem = ivm;

                // HILInvoices.SelectedItem = ivm;
                // HILInvoices.LvIncItems.ScrollIntoView(HILInvoices.SelectedItem);
                //await NaveToIVM();
            }
            else
            {
                DataContext = e.Parameter;

                TreeViewSelectedItem = ViewModel.SelectedASNViewModel;

                //ViewModel.OnNavigateToRequested = ViewModel_OnNavigateToRequested;
                //await NaveToASN();
            }

            //if(TrvDocuments.SelectedItem == null) 
            //    CBshipments.Visibility = Visibility.Visible;
            ViewModel.PropertyChanged -= ViewModel_PropertyChanged;
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
           if(e.PropertyName == "SelectedASNViewModel" && ViewModel.SelectedASNViewModel != null)
            {
                TreeViewSelectedItem = ViewModel.SelectedASNViewModel;
            }
        }

        private async void NavigateToSelected()
        {
            await semaphoreSlim.WaitAsync();
            try
            {
                if (contentFrame.Visibility != Visibility.Visible)
                    contentFrame.Visibility = Visibility.Visible;

                if (TreeViewSelectedItem is ASNViewModel asn)
                {
                    await asn.LoadS3Data();

                    ViewModel.SelectedASNViewModel = asn;

                    //CBinvoices.Visibility = Visibility.Collapsed;
                    //CBshipments.Visibility = Visibility.Visible;

                    //NavigationRootPage.Current.NavigationHelper.OnTryGoBack = null;
                    contentFrame.Navigate(typeof(ASNPage), ViewModel.SelectedASNViewModel);
                }
                else if (TreeViewSelectedItem is InvoiceViewModel ivm)
                {
                    await ivm.LoadS3Data();

                    ViewModel.SelectedASNViewModel = ivm.asnvm;
                    ViewModel.SelectedInvoiceViewModel = ivm;

                    //CBshipments.Visibility = Visibility.Collapsed;
                    //CBinvoices.Visibility = Visibility.Visible;

                    //NavigationRootPage.Current.NavigationHelper.OnTryGoBack = ContentFrameOnTryGoBack;
                    contentFrame.Navigate(typeof(InvoicePage), ViewModel.SelectedInvoiceViewModel);
                }
            }
            catch(IndexOutOfRangeException ioex)
            {
                contentFrame.Visibility = Visibility.Collapsed;
                MainViewModel.Current.LoggerUtil.AddException(ioex, $"{ioex.Message}");
            }
            finally
            {
                await SeteSelectedTrvItem();

                semaphoreSlim.Release();
            }
        }
        private async void ToggleSwitch2_Click(object sender, RoutedEventArgs e)
        {
            if (ToggleSwitch2.IsChecked == true)
            {
                CBshipments.Visibility = Visibility.Visible;
                TrvDocuments.SelectionMode = TreeViewSelectionMode.Multiple;
            }
            else
            {
                CBshipments.Visibility = Visibility.Collapsed;
                TrvDocuments.SelectionMode = TreeViewSelectionMode.Single;
                await semaphoreSlimToggle.WaitAsync();
                try
                {
                    await SeteSelectedTrvItem();
                }
                finally
                {
                    semaphoreSlimToggle.Release();
                }
            }
        }

        private async Task SeteSelectedTrvItem()
        {
            while (!TrvDocuments.IsLoaded)
                await Task.Delay(500);

            if (TrvDocuments.SelectedItem != TreeViewSelectedItem)
                TrvDocuments.SelectedItem = TreeViewSelectedItem;

            if (TrvDocuments.ContainerFromItem(TrvDocuments.SelectedItem) is TreeViewItem trvitem)
            {
                trvitem.IsSelected = true;
                trvitem.StartBringIntoView();
            }
            else if (TrvDocuments.ContainerFromItem(ViewModel.SelectedASNViewModel) is TreeViewItem trvitemAsn)
            {
                trvitemAsn.IsExpanded = true;
                trvitemAsn.StartBringIntoView();

                
                if (TrvDocuments.NodeFromContainer(trvitemAsn) is TreeViewNode trvNode)
                {
                    trvNode.IsExpanded = true;
                    do
                    {
                        TrvDocuments.SelectedNode = trvNode.Children.FirstOrDefault(c => c.Content == TrvDocuments.SelectedItem);
                        if(TrvDocuments.SelectedNode == null)
                            await Task.Delay(500);
                    } while (TrvDocuments.SelectedNode == null);

                    if(ViewModel.ASNCollection.Count > ViewModel.ASNCollection.IndexOf(ViewModel.SelectedASNViewModel) + 1)
                    {
                        if (TrvDocuments.ContainerFromItem(ViewModel.ASNCollection[ViewModel.ASNCollection.IndexOf(ViewModel.SelectedASNViewModel) + 1]) is TreeViewItem trvitemAsn2)
                            trvitemAsn2.StartBringIntoView();
                    }
                    //if (TrvDocuments.ContainerFromItem(TrvDocuments.SelectedItem) is TreeViewItem trvitemInv)
                    //{
                    //    trvitemInv.StartBringIntoView();
                    //}
                    //else
                    //{
                    //    TrvDocuments.StartBringIntoView(new BringIntoViewOptions() { HorizontalAlignmentRatio = 0.9 });
                    //}

                    //var childInv = trvitem3.Children.First(c=>c.Content == ViewModel.SelectedInvoiceViewModel);
                    //TrvDocuments.SelectedItem = ViewModel.SelectedInvoiceViewModel;
                }
            }
            else
            {
                await Task.Delay(500);
                await SeteSelectedTrvItem();
            }
        }

        private async void AsnMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            await ShipmentsViewModel.SendSelectedShipments(TrvDocuments.SelectedItems);
        }

        private async void InvMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            await InvoicesViewModel.SendSelectedInvoices(ViewModel, TrvDocuments.SelectedItems);
        }

        private async void AbbPackingListSingle_Click(object sender, RoutedEventArgs e)
        {
            await ShipmentsViewModel.CreatePackingListFoeSelected(TrvDocuments.SelectedItems,true);
        }

        private async void AbbPackingList_Click(object sender, RoutedEventArgs e)
        {
            //await ShipmentsViewModel.CreatePackingListFoeSelected(HILShipments.SelectedItems);
            await ShipmentsViewModel.CreatePackingListFoeSelected(TrvDocuments.SelectedItems,false);
        }

        private async void AbbLabels_Click(object sender, RoutedEventArgs e)
        {
            //await ShipmentsViewModel.CreateLabelsForSelected(HILShipments.SelectedItems);
            await ShipmentsViewModel.CreateLabelsForSelected(TrvDocuments.SelectedItems);
        }
    }

    public class DocumentItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ShipmentTemplate { get; set; }
        public DataTemplate InvoiceTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is ASNViewModel) return ShipmentTemplate;

            return InvoiceTemplate;
        }
    }
}
