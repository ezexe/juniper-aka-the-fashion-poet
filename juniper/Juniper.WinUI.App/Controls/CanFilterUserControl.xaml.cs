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
    public sealed partial class CanFilterUserControl : UserControl
    {
        public event Action OnBeforeFilterd;

        public static readonly DependencyProperty ASNFilterVisibilityProperty = DependencyProperty.Register("ASNFilterVisibility", 
                typeof(Visibility), 
                typeof(CanFilterUserControl), 
                new PropertyMetadata(Visibility.Visible));
        public Visibility ASNFilterVisibility
        {
            get { return (Visibility)GetValue(ASNFilterVisibilityProperty); }
            set { SetValue(ASNFilterVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ASNFilterBtnVisibilityProperty = DependencyProperty.Register("ASNFilterBtnVisibility",
            typeof(Visibility),
            typeof(CanFilterUserControl),
            new PropertyMetadata(Visibility.Collapsed));
        public Visibility ASNFilterBtnVisibility
        {
            get { return (Visibility)GetValue(ASNFilterBtnVisibilityProperty); }
            set { SetValue(ASNFilterBtnVisibilityProperty, value); }
        }

        public static readonly DependencyProperty BOLFilterVisibilityProperty =
            DependencyProperty.Register("BOLFilterVisibility",
            typeof(Visibility),
            typeof(CanFilterUserControl),
            new PropertyMetadata(Visibility.Visible));
        public Visibility BOLFilterVisibility
        {
            get { return (Visibility)GetValue(BOLFilterVisibilityProperty); }
            set { SetValue(BOLFilterVisibilityProperty, value); }
        }

        public static readonly DependencyProperty INVFilterVisibilityProperty =
            DependencyProperty.Register("INVFilterVisibility", 
                typeof(Visibility),
                typeof(CanFilterUserControl), 
                new PropertyMetadata(Visibility.Visible));
        public Visibility INVFilterVisibility
        {
            get { return (Visibility)GetValue(INVFilterVisibilityProperty); }
            set { SetValue(INVFilterVisibilityProperty, value); }
        }

        public DateFilterDependancyObject DateFilterPropertys
        {
            get { return (DateFilterDependancyObject)GetValue(DateFilterPropertysProperty); }
            set { SetValue(DateFilterPropertysProperty, value); }
        }
        public static readonly DependencyProperty DateFilterPropertysProperty =
            DependencyProperty.Register(
                name: nameof(DateFilterPropertys),
                propertyType: typeof(DateFilterDependancyObject),
                ownerType: typeof(CanFilterUserControl),
                typeMetadata: new PropertyMetadata(null));

        public CanFilterUserControl()
        {
            this.InitializeComponent();
        }

        public ICanFilter Icanfilter => (ICanFilter)DataContext;

        private void ASBall_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                var dt = MainViewModel.Current.GetDocumentTypeFromText(sender.Name);
                var invList =
                    (from s in
                        Icanfilter.SearchFor(sender.Text, dt)
                     select dt switch
                     {
                         DocumentType.PO850 => s.PoId,
                         DocumentType.ASN856 => s.ASNId,
                         DocumentType.IN810 => s.StringId,
                         DocumentType.BOL => Convert.ToString(s.Bol),
                         _ => s.StringId,
                     }).Distinct().ToList();


                var suggestions = invList;

                if (suggestions.Any())
                    sender.ItemsSource = suggestions;
                else
                    sender.ItemsSource = new string[] { "No results found" };
            }
        }
        private void ASBall_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            if (args.SelectedItem is string control)
            {
                sender.Text = control;
            }
        }
        private void ASBall_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            OnBeforeFilterd?.Invoke();

            var filtertext = args.ChosenSuggestion is string s ? s : args.QueryText ?? "";
            var dt = MainViewModel.Current.GetDocumentTypeFromText(sender.Name);

            Icanfilter.Filter(Icanfilter.SearchFor(filtertext, dt));
        }
    }
}
