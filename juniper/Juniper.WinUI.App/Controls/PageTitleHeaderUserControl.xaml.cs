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
    public sealed partial class PageTitleHeaderUserControl : UserControl
    {
        public static readonly DependencyProperty HeaderTextProperty = DependencyProperty.Register(nameof(HeaderText),
            typeof(string),
       typeof(PageTitleHeaderUserControl),
       new PropertyMetadata(null));
        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        public static readonly DependencyProperty HeaderContentProperty = DependencyProperty.Register(nameof(HeaderContent),
            typeof(object),
            typeof(PageTitleHeaderUserControl),
            new PropertyMetadata(null));
        public object HeaderContent
        {
            get { return GetValue(HeaderContentProperty); }
            set { SetValue(HeaderContentProperty, value); }
        }

        public static readonly DependencyProperty HeaderOptionsContentProperty = DependencyProperty.Register(nameof(HeaderOptionsContent),
            typeof(object),
            typeof(PageTitleHeaderUserControl),
            new PropertyMetadata(null));
        public object HeaderOptionsContent
        {
            get { return GetValue(HeaderOptionsContentProperty); }
            set { SetValue(HeaderOptionsContentProperty, value); }
        }
        public PageTitleHeaderUserControl()
        {
            this.InitializeComponent();
        }
    }
}
