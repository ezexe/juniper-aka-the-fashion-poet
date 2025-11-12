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

namespace Juniper.WinUI.App.Controls
{
    public sealed partial class HasIncrementalsListUserControl : UserControl
    {
        public static readonly DependencyProperty TitleHeaderProperty = DependencyProperty.Register(
            "TitleHeader",
            typeof(string),
            typeof(HasIncrementalsListUserControl),
            new PropertyMetadata(null));
        public string TitleHeader
        {
            get { return (string)GetValue(TitleHeaderProperty); }
            set { SetValue(TitleHeaderProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
            "ItemsSource",
            typeof(object),
            typeof(HasIncrementalsListUserControl),
            new PropertyMetadata(null));
        public object ItemsSource
        {
            get { return GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemsSourceProperty = DependencyProperty.Register(
           "SelectedItemsSource",
           typeof(object),
           typeof(HasIncrementalsListUserControl),
           new PropertyMetadata(null));
        public object SelectedItemsSource
        {
            get { return GetValue(SelectedItemsSourceProperty); }
            set { SetValue(SelectedItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty OptionsProperty = DependencyProperty.Register("Options", typeof(object), typeof(HasIncrementalsListUserControl), new PropertyMetadata(null));
        public object Options
        {
            get { return GetValue(OptionsProperty); }
            set { SetValue(OptionsProperty, value); }
        }


        public HasIncrementalsListUserControl()
        {
            this.InitializeComponent();
        }

        public IHaveIncrementals IHaveIncremental => (IHaveIncrementals)DataContext;
        public ListView LvIncItems => lvIncItems;
        public IList<object> SelectedItems => lvIncItems.SelectedItems;
        public object SelectedItem 
        { 
            get => lvIncItems.SelectedItem; 
            set => lvIncItems.SelectedItem = value; 
        }
        public bool SelectionModeIsOn => ToggleSwitch2.IsChecked == true;
        

        private void ToggleSwitch2_Toggled(object sender, RoutedEventArgs e)
        {
            if (ToggleSwitch2.IsChecked == true)
            {
                lvIncItems.SelectionMode = ListViewSelectionMode.Multiple;
            }
            else
            {
                lvIncItems.SelectionMode = ListViewSelectionMode.Single;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            lvIncItems.SelectAll();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (lvIncItems.Items.Count > 0)
                lvIncItems.DeselectRange(new ItemIndexRange(0, (uint)lvIncItems.Items.Count));
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            if (SelectedItems.Count == lvIncItems.Items.Count)
                saCheckBox.IsChecked = true;// ? false : true;
        }

        private void lvIncItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvIncItems.SelectionMode == ListViewSelectionMode.Multiple)
            {
                if (SelectedItems.Count == 0)
                    saCheckBox.IsChecked = false;
                else if(lvIncItems.Items.Count > SelectedItems.Count)
                    saCheckBox.IsChecked=null;
                else if (lvIncItems.Items.Count == SelectedItems.Count)
                    saCheckBox.IsChecked = true;
            }
        }

        private void ToggleSwitch2_Click(object sender, RoutedEventArgs e)
        {
            if (ToggleSwitch2.IsChecked == true)
            {
                lvIncItems.SelectionMode = ListViewSelectionMode.Multiple;
            }
            else
            {
                lvIncItems.SelectionMode = ListViewSelectionMode.Single;
            }
        }
    }
}
