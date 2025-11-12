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
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Juniper.WinUI.App.Controls
{
    public sealed partial class DateFilterUserControl : UserControl
    {
        public DateFilterDependancyObject DateFilterPropertys
        {
            get { return (DateFilterDependancyObject)GetValue(DateFilterPropertysProperty); }
            set { SetValue(DateFilterPropertysProperty, value); }
        }
        public static readonly DependencyProperty DateFilterPropertysProperty =
            DependencyProperty.Register(
                name: nameof(DateFilterPropertys),
                propertyType: typeof(DateFilterDependancyObject),
                ownerType: typeof(DateFilterUserControl),
                typeMetadata: new PropertyMetadata(null));

        public BaseViewModel ViewModel => (BaseViewModel)DataContext;
        public ICanFilter ICanFilter => (ICanFilter)DataContext;

        public DateFilterUserControl()
        {
            this.InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DateFilterPropertys is not null && DateFilterPropertys.FilterBtnVisibility == Visibility.Collapsed)
            {
                ViewModel.OnCommandActivated(DateFilterPropertys.ActionButtonCommandParam);
            }
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if(sender is MenuFlyoutItem btn)
            {
                if(btn.Name == "ASNDate")
                {
                    ViewModel.OnCommandActivated(DateFilterPropertys.ActionButtonCommandParam);
                }
                else
                {
                    ViewModel.OnCommandActivated(btn.Name);
                }
            }
        }

        private async void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (ActualDate.Visibility == Visibility.Visible && ActualDate.IsChecked == true)
            //{
            //    await ViewModel.OnCommandActivated(ActualDate.Name);
            //}
            //else
            //{
            //    await ViewModel.RaiseOnCommandActivated(DateFilterPropertys.ActionButtonCommandParam);
            //}

            //if (e.ClickedItem is DateTimeOffset dt)
            //    tbSelectDate.Text = dt.ToString("MM-dd-yyyy");
        }
    }
}
