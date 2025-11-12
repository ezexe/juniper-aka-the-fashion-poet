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
    public sealed partial class SettingsPage : Page
    {
        public SettingsViewModel ViewModel => (SettingsViewModel)DataContext;

        public SettingsPage()
        {
            this.InitializeComponent();

            DataContext = App.Current.Services.GetService<MainViewModel>().SettingsViewModel; // App.Current.MainWindow.ViewModel.SettingsViewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //NavigationRootPage.Current.HeaderContent = this.PageHeaderUserControl;
            //NavigationRootPage.Current.NavigationView.AlwaysShowHeader = true;

            NavigationRootPage.Current.EnsureNavigationSelection(-1, PageTitleHeader.HeaderText, PageTitleHeader);

            passworBoxWithRevealmode.Password = ViewModel.AppSecret;

            base.OnNavigatedTo(e);

        }

        private void passworBoxWithRevealmode_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ViewModel.AppSecret = passworBoxWithRevealmode.Password;
        }

        private void RemoveableItemUserControl_RemoveClicked(RemoveableItemUserControl sender, RemoveClickedEventArgs args)
        {
            ViewModel.RemoveableRequested(args.type, args.DataContext);
        }

        private void TBViewPass_Click(object sender, RoutedEventArgs e)
        {
            if(TBViewPass.IsChecked == true)
            {
                passworBoxWithRevealmode.PasswordRevealMode = PasswordRevealMode.Visible;
            }
            else
            {
                passworBoxWithRevealmode.PasswordRevealMode = PasswordRevealMode.Hidden;
            }
        }
    }
}
