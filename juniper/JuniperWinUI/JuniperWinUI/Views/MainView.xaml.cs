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

namespace JuniperWinUI.Views
{
    public sealed partial class MainView : Page
    {
        private readonly IReadOnlyCollection<SampleEntry> NavigationItems;

        private readonly Type settingsView = typeof(SettingsView);

        public MainViewModel ViewModel => (MainViewModel)DataContext;

        public MainView()
        {
            this.InitializeComponent();

            this.DataContext = App.Current.Services.GetService<MainViewModel>();
        }

        private void NavigationView_OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                NavigationFrame.Navigate(settingsView);
            }
            else
            {

            }
        }

        private void NavigationView_OnBackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
        }

        private void NavigationFrame_OnNavigated(object sender, NavigationEventArgs e)
        {
            NavigationView.IsBackEnabled = ((Frame)sender).BackStackDepth > 0;
        }

        internal void WindowActivated(MainWindow mainWindow)
        {
            // Set the custom title bar to act as a draggable region
            //mainWindow.SetTitleBar(AppTitleBar);
        }
    }

    /// <summary>
    /// A simple model for tracking sample pages associated with buttons.
    /// </summary>
    public sealed class SampleEntry
    {
        public SampleEntry(NavigationViewItem viewItem, Type pageType, string? name = null, string? tags = null)
        {
            Item = viewItem;
            PageType = pageType;
            Name = name;
            Tags = tags;
        }

        /// <summary>
        /// The navigation item for the current entry.
        /// </summary>
        public NavigationViewItem Item { get; }

        /// <summary>
        /// The associated page type for the current entry.
        /// </summary>
        public Type PageType { get; }

        /// <summary>
        /// Gets the name of the current entry.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// Gets the tag for the current entry, if any.
        /// </summary>
        public string? Tags { get; }
    }
}
