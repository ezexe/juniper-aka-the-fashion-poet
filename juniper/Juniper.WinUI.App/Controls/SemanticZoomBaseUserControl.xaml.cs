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
    public sealed partial class SemanticZoomBaseUserControl : UserControl
    {
        #region dp
        public static readonly DependencyProperty HeaderTextProperty = DependencyProperty.Register(nameof(HeaderText),
               typeof(string),
               typeof(SemanticZoomBaseUserControl),
               new PropertyMetadata(null));
        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        public static readonly DependencyProperty HeaderContentProperty = DependencyProperty.Register(nameof(HeaderContent), 
            typeof(object), 
            typeof(SemanticZoomBaseUserControl), 
            new PropertyMetadata(null));
        public object HeaderContent
        {
            get { return GetValue(HeaderContentProperty); }
            set { SetValue(HeaderContentProperty, value); }
        }

        public static readonly DependencyProperty HeaderOptionsContentProperty = DependencyProperty.Register(nameof(HeaderOptionsContent), 
            typeof(object), 
            typeof(SemanticZoomBaseUserControl), 
            new PropertyMetadata(null));
        public object HeaderOptionsContent
        {
            get { return GetValue(HeaderOptionsContentProperty); }
            set { SetValue(HeaderOptionsContentProperty, value); }
        }

        public static readonly DependencyProperty BodyOverlayOptionsContentProperty = DependencyProperty.Register(nameof(BodyOverlayOptionsContent),
    typeof(object),
    typeof(SemanticZoomBaseUserControl),
    new PropertyMetadata(null));
        public object BodyOverlayOptionsContent
        {
            get { return GetValue(BodyOverlayOptionsContentProperty); }
            set { SetValue(BodyOverlayOptionsContentProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource",
            typeof(object),
            typeof(SemanticZoomBaseUserControl), 
            new PropertyMetadata(null));
        public object ItemsSource
        {
            get { return GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", 
            typeof(DataTemplate),
            typeof(SemanticZoomBaseUserControl), 
            new PropertyMetadata(null));
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public static readonly DependencyProperty PropertyPathProperty = DependencyProperty.Register("PropertyPath",
            typeof(PropertyPath), 
            typeof(SemanticZoomBaseUserControl), 
            new PropertyMetadata(null));
        public PropertyPath PropertyPath
        {
            get { return (PropertyPath)GetValue(PropertyPathProperty); }
            set { SetValue(PropertyPathProperty, value); }
        }
        #endregion

        public event TypedEventHandler<object, ItemClickEventArgs> ItemListViewItemClick;

        public BaseViewModel ViewModel => (BaseViewModel)DataContext;
        public GridView GrvItems => gvItems;
        public ListView LvItems => lvItems;
        public IList<object> SelectedItems => wideSeZo.Visibility == Visibility.Visible ? gvItems.SelectedItems : lvItems.SelectedItems;

        public SemanticZoomBaseUserControl()
        {
            this.InitializeComponent();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ABBBullets.IsChecked == false)
                ItemListViewItemClick?.Invoke(sender, e);
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ABBBullets.IsChecked == false)
                ItemListViewItemClick?.Invoke(sender, e);
        }

        private void ABBBullets_Click(object sender, RoutedEventArgs e)
        {
            if (ABBBullets.IsChecked == true)
            {
                AbbTags.Visibility = Visibility.Visible;

                gvItems.SelectionMode = ListViewSelectionMode.Multiple;
                lvItems.SelectionMode = ListViewSelectionMode.Multiple;
            }
            else
            {
                AbbTags.Visibility = Visibility.Collapsed;

                gvItems.SelectionMode = ListViewSelectionMode.None;
                lvItems.SelectionMode = ListViewSelectionMode.None;
            }
        }

        public void SettZoomedView(bool zoomedInActive)
        {
            wideSeZo.IsZoomedInViewActive = zoomedInActive;
            narrowSeZo.IsZoomedInViewActive = zoomedInActive;
        }

        private async void SetDocumentTags_Click(object sender, RoutedEventArgs e)
        {
            await TagsLibrary.Current.SetDocumentTags(Gvtags.SelectedItems, SelectedItems);
        }

        private void CreateNewTags_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
