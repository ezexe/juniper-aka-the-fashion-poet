namespace Juniper.WinUI.App.DependencyObjects
{
    public class DateFilterDependancyObject : DependencyObject
    {
        public static readonly DependencyProperty ActionButtonCommandParamProperty = DependencyProperty.Register("ActionButtonCommandParam",
            typeof(string),
            typeof(DateFilterDependancyObject), new PropertyMetadata(null));
        public string ActionButtonCommandParam
        {
            get { return (string)GetValue(ActionButtonCommandParamProperty); }
            set { SetValue(ActionButtonCommandParamProperty, value); }
        }
        public static readonly DependencyProperty ActionButtonContentProperty = DependencyProperty.Register("ActionButtonContent",
          typeof(object),
          typeof(DateFilterDependancyObject), new PropertyMetadata(null));
        public object ActionButtonContent
        {
            get { return GetValue(ActionButtonContentProperty); }
            set { SetValue(ActionButtonContentProperty, value); }
        }

        public static readonly DependencyProperty FilterBtnVisibilityProperty = DependencyProperty.Register("FilterBtnVisibility",
        typeof(Visibility),
        typeof(DateFilterDependancyObject), new PropertyMetadata(Visibility.Visible));
        public Visibility FilterBtnVisibility
        {
            get { return (Visibility)GetValue(FilterBtnVisibilityProperty); }
            set { SetValue(FilterBtnVisibilityProperty, value); }
        }
    }
}
