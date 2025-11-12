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
    public sealed partial class TeachingTipButtonUserControl : UserControl
    {
        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(object), 
            typeof(TeachingTipButtonUserControl),
            new PropertyMetadata(null));
        public object ItemsSource
        {
            get { return GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), 
            typeof(TeachingTipButtonUserControl),
            new PropertyMetadata(null));
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public static readonly DependencyProperty GroupHeaderTemplateProperty = DependencyProperty.Register("GroupHeaderTemplate", typeof(DataTemplate),
            typeof(TeachingTipButtonUserControl),
            new PropertyMetadata(null));
        public DataTemplate GroupHeaderTemplate
        {
            get { return (DataTemplate)GetValue(GroupHeaderTemplateProperty); }
            set { SetValue(GroupHeaderTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemSymbolProperty = DependencyProperty.Register(
            "ItemSymbol", 
            typeof(Symbol),
            typeof(TeachingTipButtonUserControl),
            new PropertyMetadata(null));
        public Symbol ItemSymbol
        {
            get { return (Symbol)GetValue(ItemSymbolProperty); }
            set { SetValue(ItemSymbolProperty, value); }
        }

        public static readonly DependencyProperty ItemTextProperty = DependencyProperty.Register(
           "ItemText",
           typeof(string),
           typeof(TeachingTipButtonUserControl),
           new PropertyMetadata(null));
        public string ItemText
        {
            get { return (string)GetValue(ItemTextProperty); }
            set { SetValue(ItemTextProperty, value); }
        }
        public TeachingTipButtonUserControl()
        {
            this.InitializeComponent();
        }
    }
}
