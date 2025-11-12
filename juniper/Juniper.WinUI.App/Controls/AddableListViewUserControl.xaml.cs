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
    public sealed partial class AddableListViewUserControl : UserControl
    {
        public static readonly DependencyProperty OnCommandPropery = DependencyProperty.Register(nameof(OnCommand),
typeof(ICommand),
typeof(AddableListViewUserControl),
new PropertyMetadata(null));
        public ICommand OnCommand
        {
            get { return (ICommand)GetValue(OnCommandPropery); }
            set { SetValue(OnCommandPropery, value); }
        }

        public static readonly DependencyProperty ActionButtonCommandParamProperty = DependencyProperty.Register("ActionButtonCommandParam", typeof(string),
          typeof(AddableListViewUserControl), new PropertyMetadata(null));
        public string ActionButtonCommandParam
        {
            get { return (string)GetValue(ActionButtonCommandParamProperty); }
            set { SetValue(ActionButtonCommandParamProperty, value); }
        }
        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(object),
    typeof(AddableListViewUserControl), new PropertyMetadata(null));
        public object ItemsSource
        {
            get { return GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate),
            typeof(AddableListViewUserControl), new PropertyMetadata(null));
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }
        public AddableListViewUserControl()
        {
            this.InitializeComponent();
        }

        public event Action<object> DeleteRequested;
        public BaseHasRemoveablesViewModel ViewModel => (BaseHasRemoveablesViewModel)DataContext;
        private void RemoveableItemUserControl_RemoveClicked(RemoveableItemUserControl sender, RemoveClickedEventArgs args)
        {
            if (DeleteRequested != null)
                DeleteRequested(args.DataContext);
            else
            {
                if (ItemsSource is IList a)
                {
                    a.Remove(args.DataContext);
                }
            }
        }
    }
}
