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
    public sealed partial class RemoveableItemUserControl : UserControl
    {
        public static readonly DependencyProperty ItemContentProperty = DependencyProperty.Register("ItemContent", typeof(object), typeof(RemoveableItemUserControl), new PropertyMetadata(null));
        public object ItemContent
        {
            get { return GetValue(ItemContentProperty); }
            set { SetValue(ItemContentProperty, value); }
        }
        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate),
    typeof(RemoveableItemUserControl), new PropertyMetadata(null));
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public event TypedEventHandler<RemoveableItemUserControl, RemoveClickedEventArgs> RemoveClicked;

        public ICommand Command { get; set; }

        public RemoveableItemUserControl()
        {
            this.InitializeComponent();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            //var parent = VisualTreeHelper.GetParent(e.OriginalSource as AppBarButton);

            //var item = VisualTreeHelper.GetParent(parent);
            //while(item.GetType() != typeof(GridViewItem))
            //{
            //    item = VisualTreeHelper.GetParent(item);
            //}

            //var grdv = VisualTreeHelper.GetParent(item);
            //while (grdv.GetType() != typeof(GridView))
            //{
            //    grdv = VisualTreeHelper.GetParent(grdv);
            //}

            //(grdv as GridView).Items.Remove(item);

            var apb = ((Button)e.OriginalSource);
            RemoveClicked?.Invoke(this, new RemoveClickedEventArgs() 
            {
                type = apb.DataContext.GetType(),
                DataContext = apb.DataContext
            });
        }

        private void uc_Loaded(object sender, RoutedEventArgs e)
        {
            var deleteCommand = new StandardUICommand(StandardUICommandKind.Delete);
            deleteCommand.ExecuteRequested += DeleteCommand_ExecuteRequested;

            Command = deleteCommand;
        }

        private void ListViewSwipeContainer_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (HeaderContentDisplay.IsEnabled && 
                (e.Pointer.PointerDeviceType == Microsoft.UI.Input.PointerDeviceType.Mouse || e.Pointer.PointerDeviceType == Microsoft.UI.Input.PointerDeviceType.Pen))
            {
                VisualStateManager.GoToState(sender as Control, "HoverButtonsShown", true);
            }
        }

        private void ListViewSwipeContainer_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (HeaderContentDisplay.IsEnabled)
            VisualStateManager.GoToState(sender as Control, "HoverButtonsHidden", true);
        }

        private void DeleteCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs args)
        {
            RemoveClicked?.Invoke(this, new RemoveClickedEventArgs()
            {
                type = HoverButton.DataContext.GetType(),
                DataContext = HoverButton.DataContext
            });
        }
    }

    public class RemoveClickedEventArgs
    {
        public Type type { get; set; }
        public object DataContext { get; set; }
    }
}
