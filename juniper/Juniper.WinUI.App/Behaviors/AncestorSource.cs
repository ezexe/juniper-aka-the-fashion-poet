



namespace Juniper.WinUI.App.Behaviors
{
    public static class AncestorSource
    {
        public static readonly DependencyProperty StatusTypeProperty =
            DependencyProperty.RegisterAttached(
                "StatusType",
                typeof(bool),
                typeof(AncestorSource),
                new PropertyMetadata(false));

        public static void SetStatusType(FrameworkElement element, bool value) =>
            element.SetValue(StatusTypeProperty, value);

        public static bool GetStatusType(FrameworkElement element) =>
            (bool)element.GetValue(StatusTypeProperty);

        public static readonly DependencyProperty AncestorTypeProperty =
            DependencyProperty.RegisterAttached(
                "AncestorType",
                typeof(Type),
                typeof(AncestorSource),
                new PropertyMetadata(default(Type), OnAncestorTypeChanged)
        );

        public static void SetAncestorType(FrameworkElement element, Type value) =>
            element.SetValue(AncestorTypeProperty, value);

        public static Type GetAncestorType(FrameworkElement element) =>
            (Type)element.GetValue(AncestorTypeProperty);

        private static void OnAncestorTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FrameworkElement target = (FrameworkElement)d;
            if (target.IsLoaded)
                SetDataContext(target);
            else
                target.Loaded += OnTargetLoaded;
        }

        private static void OnTargetLoaded(object sender, RoutedEventArgs e)
        {
            FrameworkElement target = (FrameworkElement)sender;
            target.Loaded -= OnTargetLoaded;
            SetDataContext(target);
        }

        private static void SetDataContext(FrameworkElement target)
        {
            Type ancestorType = GetAncestorType(target);
            if (ancestorType != null)
                if (!GetStatusType(target))
                {
                    var p = FindParent(target, ancestorType);
                    if (((Page)p).DataContext is IHaveIncrementals ihn)
                    {
                        if (target is TextBox tb)
                        {
                            tb.IsReadOnly = ihn.Status == DocumentStatus.Sent;
                        }
                        else if (target is Control cb)
                        {
                            cb.IsEnabled = ihn.Status != DocumentStatus.Sent;
                        }
                        
                    }
                }
                else
                    target.DataContext = FindParent(target, ancestorType);
        }

        private static object FindParent(DependencyObject dependencyObject, Type ancestorType)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(dependencyObject);
            if (parent == null)
                return null;

            if (ancestorType.IsAssignableFrom(parent.GetType()))
                return parent;

            return FindParent(parent, ancestorType);
        }
    }
}
