
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

namespace Juniper.WinUI.App
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private DispatcherQueueTimer _dismissTimer;

        public new readonly DispatcherQueue DispatcherQueue = DispatcherQueue.GetForCurrentThread();

        public MainViewModel ViewModel => App.Current.Services.GetService<MainViewModel>(); 
        public MainWindow()
        {
            this.InitializeComponent();

            _dismissTimer = DispatcherQueue.CreateTimer();
            _dismissTimer.Tick += DismissTimer_Tick;

            ViewModel.Initialized += ViewModel_Initialized;
            ViewModel.OnDisplayInfoBarRequest += ViewModel_OnDisplayInfoBarRequest;
        }

        private void DismissTimer_Tick(DispatcherQueueTimer sender, object args)
        {
            NavigationRootPage.Current.CloseInfoBar();
        }

        private void ViewModel_OnDisplayInfoBarRequest(string title, string message, InfoSeverity severity)
        {
            DispatcherQueue.TryEnqueue(() =>
            {
                if(_dismissTimer.IsRunning)
                    _dismissTimer.Stop();

                NavigationRootPage.Current.DisplayInfoBarRequest(title, message, severity);

                if (severity == InfoSeverity.Success)
                {
                    _dismissTimer.Interval = TimeSpan.FromMilliseconds(3000);
                    _dismissTimer.Start();
                }
            });
        }

        private void ViewModel_Initialized(bool loggedIn)
        {
            Frame rootFrame = GetRootFrame();

            NavigationRootPage.Current.mainProgressRing.IsActive = false;

            rootFrame.Navigate(loggedIn ? typeof(OrdersPage) : typeof(SettingsPage));
        }

        private Frame GetRootFrame()
        {
            Frame rootFrame;
            if (!(Content is NavigationRootPage rootPage))
            {
                rootPage = new NavigationRootPage();
                rootFrame = (Frame)rootPage.FindName("rootFrame");
                if (rootFrame == null)
                {
                    throw new Exception("Root frame not found");
                }
                //SuspensionManager.RegisterFrame(rootFrame, "AppFrame");
                rootFrame.Language = Windows.Globalization.ApplicationLanguages.Languages[0];
                rootFrame.NavigationFailed += OnNavigationFailed;

                Content = rootPage;
            }
            else
            {
                rootFrame = (Frame)rootPage.FindName("rootFrame");
            }

            return rootFrame;
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }
    }
}
