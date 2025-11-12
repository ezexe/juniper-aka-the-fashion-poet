using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation;
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

namespace Juniper.WinUI.App.Navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationRootPage : Page
    {
        public static NavigationRootPage Current { get; private set; }

        public static readonly DependencyProperty HeaderTextProperty = DependencyProperty.Register(nameof(HeaderText),
            typeof(string),
            typeof(NavigationRootPage),
            new PropertyMetadata(null));
        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        public static readonly DependencyProperty HeaderContentProperty = DependencyProperty.Register(nameof(HeaderContent),
            typeof(object),
            typeof(NavigationRootPage),
            new PropertyMetadata(null));
        public object HeaderContent
        {
            get { return GetValue(HeaderContentProperty); }
            set { SetValue(HeaderContentProperty, value); }
        }

        private NavigationViewItem ordersMenuItem;
        private NavigationViewItem shipmentMenuItem;
        private NavigationViewItem invoiceMenuItem;

        public Frame RootFrame => rootFrame;
        public RootFrameNavigationHelper NavigationHelper
        {
            get;
        }
        public NavigationView NavigationView => NavigationViewControl;

        public PageHeaderUserControl PageHeader => UIHelper.GetDescendantsOfType<PageHeaderUserControl>(NavigationViewControl).FirstOrDefault();

        public bool IsFocusSupported => Convert.ToBoolean(new Windows.Devices.Input.KeyboardCapabilities().KeyboardPresent);

        public NavigationRootPage()
        {
            this.InitializeComponent();

            // Workaround for VisualState issue that should be fixed
            // by https://github.com/microsoft/microsoft-ui-xaml/pull/2271
            //NavigationViewControl.PaneDisplayMode = muxc.NavigationViewPaneDisplayMode.Left;

            NavigationHelper = new RootFrameNavigationHelper(rootFrame, NavigationViewControl);

            //SetDeviceFamily();
            AddNavigationMenuItems();

            Current = this;
           
        }
        public string GetAppTitleFromSystem()
        {
            App.AppCurrent.MainWindow.ExtendsContentIntoTitleBar = true;
            App.AppCurrent.MainWindow.SetTitleBar(AppTitleBar);
            return $"{Package.Current.DisplayName} {Package.Current.Id.Version.Major}.{Package.Current.Id.Version.Minor}.{Package.Current.Id.Version.Build}.{Package.Current.Id.Version.Revision}";
        }
        private void AddNavigationMenuItems()
        {
            var og = new ControlInfoDataGroup(typeof(OrdersPage).Name, "Orders", Symbol.Shop);
            ControlInfoDataSource.Instance.Groups.Add(og);
            ordersMenuItem = og.NavItem;
            NavigationViewControl.MenuItems.Add(ordersMenuItem);

            var sg = new ControlInfoDataGroup(typeof(ShipmentsPage).Name, "Shipments", Symbol.Map);
            ControlInfoDataSource.Instance.Groups.Add(sg);
            shipmentMenuItem = sg.NavItem;
            NavigationViewControl.MenuItems.Add(shipmentMenuItem);

            var ig = new ControlInfoDataGroup(typeof(InvoicesPage).Name, "Invoices", Symbol.Document);
            ControlInfoDataSource.Instance.Groups.Add(ig);
            invoiceMenuItem = ig.NavItem;
            NavigationViewControl.MenuItems.Add(invoiceMenuItem);
        }

        public void EnsureNavigationSelection(int index, string title, object headerContent)
        {
            HeaderText = title;
            HeaderContent = headerContent;
            EnsureNavigationSelection(index);
        }
        public void EnsureNavigationSelection(int index)
        {
            if (index >= 0 && NavigationView.MenuItems[index] is NavigationViewItem group)
            {
                NavigationView.SelectedItem = group;
                group.IsSelected = true;
            }
        }

        private void OnNavigationViewControlLoaded(object sender, RoutedEventArgs e)
        {
            // Delay necessary to ensure NavigationView visual state can match navigation
            //await Task.Delay(500);
            //this.NavigationViewLoaded?.Invoke();
        }
        private void OnNavigationViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            NavigationHelper.OnTryGoBack = null;
            
            if (args.IsSettingsInvoked)
            {
                if (rootFrame.CurrentSourcePageType != typeof(SettingsPage))
                {
                    rootFrame.Navigate(typeof(SettingsPage));
                }
            }
            else
            {
                var invokedItem = args.InvokedItemContainer;

                if (invokedItem == ordersMenuItem)
                {
                    rootFrame.Navigate(typeof(OrdersPage));
                }
                else if (invokedItem == shipmentMenuItem)
                {
                    rootFrame.Navigate(typeof(ShipmentsPage));
                }
                else if (invokedItem == invoiceMenuItem)
                {
                    rootFrame.Navigate(typeof(InvoicesPage));
                }
                else
                {
                    if (invokedItem.DataContext is ControlInfoDataGroup)
                    {
                        var itemId = ((ControlInfoDataGroup)invokedItem.DataContext).UniqueId;
                        //rootFrame.Navigate(typeof(SectionPage), itemId);
                    }
                    else if (invokedItem.DataContext is Data.ControlInfoDataItem)
                    {
                        var item = (Data.ControlInfoDataItem)invokedItem.DataContext;
                        //rootFrame.Navigate(typeof(ItemPage), item.UniqueId);
                    }
                }
            }
        }

        private async Task TryNavigate(string pageId)
        {
            var item = await ControlInfoDataSource.Instance.GetGroupAsync(pageId);

            if (item != null)
            {
                if (Type.GetType("Juniper.WinUI.App.Pages." + item.UniqueId) is { } pageType) 
                    rootFrame.Navigate(pageType);

                NavigationHelper.OnTryGoBack = null;
            }
           // rootFrame.Navigate(typeof(BaseItemPage), pageId);
        }

        internal void DisplayInfoBarRequest(string title, string message, InfoSeverity severity)
        {
            try
            {
                mainInfoBar.Title = title;
                mainInfoBar.Message = message;
                mainInfoBar.Severity = severity switch
                {
                    InfoSeverity.Error => InfoBarSeverity.Error,
                    InfoSeverity.Warning => InfoBarSeverity.Warning,
                    InfoSeverity.Success => InfoBarSeverity.Success,
                    InfoSeverity.Informational => InfoBarSeverity.Informational,
                    _ => InfoBarSeverity.Informational,
                };
                mainInfoBar.IsOpen = true;
            }
            catch { }
            //ElementSoundPlayer.Play(ElementSoundKind.Focus);
            //ElementSoundPlayer.Play(ElementSoundKind.Invoke);
            //ElementSoundPlayer.Play(ElementSoundKind.Show);
            //ElementSoundPlayer.Play(ElementSoundKind.Hide);
            //ElementSoundPlayer.Play(ElementSoundKind.MoveNext);
            //ElementSoundPlayer.Play(ElementSoundKind.MovePrevious);
            //ElementSoundPlayer.Play(ElementSoundKind.GoBack);
        }
        internal void CloseInfoBar()
        {
            try
            {
                if (mainInfoBar.IsOpen)
                    mainInfoBar.IsOpen = false;
            }
            catch { }
        }

        private void OnRootFrameNavigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void NavigationViewControl_PaneClosing(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewPaneClosingEventArgs args)
        {
            UpdateAppTitleMargin(sender);
        }
        private void NavigationViewControl_PaneOpened(Microsoft.UI.Xaml.Controls.NavigationView sender, object args)
        {
            UpdateAppTitleMargin(sender);
        }
        private void NavigationViewControl_DisplayModeChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewDisplayModeChangedEventArgs args)
        {
            Thickness currMargin = AppTitleBar.Margin;
            if (sender.DisplayMode == NavigationViewDisplayMode.Minimal)
            {
                AppTitleBar.Margin = new Thickness((sender.CompactPaneLength * 2), currMargin.Top, currMargin.Right, currMargin.Bottom);

            }
            else
            {
                AppTitleBar.Margin = new Thickness(sender.CompactPaneLength, currMargin.Top, currMargin.Right, currMargin.Bottom);
            }

            UpdateAppTitleMargin(sender);
            UpdateHeaderMargin(sender);

            UpdateAppTitleMargin(sender);
            UpdateHeaderMargin(sender);
        }
        private void UpdateAppTitleMargin(Microsoft.UI.Xaml.Controls.NavigationView sender)
        {
            const int smallLeftIndent = 6, largeLeftIndent = 6;

            if (Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7))
            {
                AppTitle.TranslationTransition = new Vector3Transition();

                if ((sender.DisplayMode == NavigationViewDisplayMode.Expanded && sender.IsPaneOpen) ||
                         sender.DisplayMode == NavigationViewDisplayMode.Minimal)
                {
                    AppTitle.Translation = new System.Numerics.Vector3(smallLeftIndent, 0, 0);
                }
                else
                {
                    AppTitle.Translation = new System.Numerics.Vector3(largeLeftIndent, 0, 0);
                }
            }
            else
            {
                Thickness currMargin = AppTitle.Margin;

                if ((sender.DisplayMode == NavigationViewDisplayMode.Expanded && sender.IsPaneOpen) ||
                         sender.DisplayMode == NavigationViewDisplayMode.Minimal)
                {
                    AppTitle.Margin = new Thickness(smallLeftIndent, currMargin.Top, currMargin.Right, currMargin.Bottom);
                }
                else
                {
                    AppTitle.Margin = new Thickness(largeLeftIndent, currMargin.Top, currMargin.Right, currMargin.Bottom);
                }
            }
        }
        private void UpdateHeaderMargin(NavigationView sender)
        {
            if (PageHeader != null)
            {
                if (sender.DisplayMode == NavigationViewDisplayMode.Minimal)
                {
                    Current.PageHeader.HeaderPadding = (Thickness)App.Current.Resources["PageHeaderMinimalPadding"];
                }
                else
                {
                    Current.PageHeader.HeaderPadding = (Thickness)App.Current.Resources["PageHeaderDefaultPadding"];
                }
            }
        }
    }
}
