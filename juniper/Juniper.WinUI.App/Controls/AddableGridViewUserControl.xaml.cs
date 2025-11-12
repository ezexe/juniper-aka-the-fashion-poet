
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Juniper.WinUI.App.Controls
{
    public sealed partial class AddableGridViewUserControl : UserControl
    {
        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(object), 
            typeof(AddableGridViewUserControl), new PropertyMetadata(null));
        public object ItemsSource
        {
            get { return GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate),
            typeof(AddableGridViewUserControl),new PropertyMetadata(null));
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public static readonly DependencyProperty OnCommandPropery = DependencyProperty.Register(nameof(OnCommand),
 typeof(ICommand),
 typeof(AddableGridViewUserControl),
 new PropertyMetadata(null));
        public ICommand OnCommand
        {
            get { return (ICommand)GetValue(OnCommandPropery); }
            set { SetValue(OnCommandPropery, value); }
        }

        public static readonly DependencyProperty ActionButtonCommandParamProperty = DependencyProperty.Register("ActionButtonCommandParam", typeof(string),
          typeof(AddableGridViewUserControl), new PropertyMetadata(null));
        public string ActionButtonCommandParam
        {
            get { return (string)GetValue(ActionButtonCommandParamProperty); }
            set { SetValue(ActionButtonCommandParamProperty, value); }
        }
        public static readonly DependencyProperty HeaderVisibilityProperty = DependencyProperty.Register("HeaderVisibility", typeof(Visibility),
            typeof(AddableGridViewUserControl), new PropertyMetadata(Visibility.Visible));
        public Visibility HeaderVisibility
        {
            get { return (Visibility)GetValue(HeaderVisibilityProperty); }
            set { SetValue(HeaderVisibilityProperty, value); }
        }

        public static readonly DependencyProperty GridviewVisibilityProperty = DependencyProperty.Register(nameof(GridviewVisibility),
            typeof(Visibility),
            typeof(AddableGridViewUserControl),
            new PropertyMetadata(Visibility.Visible));
        public Visibility GridviewVisibility
        {
            get { return (Visibility)GetValue(GridviewVisibilityProperty); }
            set { SetValue(GridviewVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ListviewVisibilityProperty = DependencyProperty.Register(nameof(ListviewVisibility),
    typeof(Visibility),
    typeof(AddableGridViewUserControl),
    new PropertyMetadata(Visibility.Collapsed));
        public Visibility ListviewVisibility
        {
            get { return (Visibility)GetValue(ListviewVisibilityProperty); }
            set 
            {
                if (value == Visibility.Visible)
                    GridviewVisibility = Visibility.Collapsed;

                SetValue(ListviewVisibilityProperty, value);
            }
        }

        public static readonly DependencyProperty ItemContentProperty = DependencyProperty.Register("ItemContent", typeof(object),
            typeof(AddableGridViewUserControl), new PropertyMetadata(null));
        public object ItemContent
        {
            get { return GetValue(ItemContentProperty); }
            set { SetValue(ItemContentProperty, value); }
        }
        public AddableGridViewUserControl()
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
               // ViewModel.RemoveableRequested(args.type, args.DataContext);
        }

        private void ButtonRoot_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.OnCommandActivated(ActionButtonCommandParam);
        }
    }
}
