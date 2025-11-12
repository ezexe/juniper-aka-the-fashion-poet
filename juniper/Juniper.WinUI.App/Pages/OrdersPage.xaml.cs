using Microsoft.UI.Composition;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Hosting;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Juniper.WinUI.App.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersPage : FilterablePageBase
    {
        public OrdersViewModel ViewModel => (OrdersViewModel)DataContext;

        public override SemanticZoomBaseUserControl Szoom => sz;

        public OrdersPage()
        {
            this.InitializeComponent();

            DataContext = App.Current.Services.GetService<OrdersViewModel>();
        }

        public override void EnsureTitleObject(ControlInfoDataGroup g)
        {
            NavigationRootPage.Current.EnsureNavigationSelection(ControlInfoDataSource.Instance.Groups.IndexOf(g),sz.HeaderText, sz.HeaderContent);
        }
    }
}
