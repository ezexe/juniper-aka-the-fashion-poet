using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juniper.WinUI.App.Behaviors
{
    public class DocumentStatusService : DependencyObject
    {
        public static readonly DependencyProperty StatusProperty =
        DependencyProperty.RegisterAttached(
          "Status",
          typeof(string),
          typeof(DocumentStatusService),
          new PropertyMetadata("New")
        );


        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }



        public static void SetStatus(UIElement element, string value)
        {
            element.SetValue(StatusProperty, value);
        }
        public static string GetStatus(UIElement element)
        {
            return (string)element.GetValue(StatusProperty);
        }
    }
}
