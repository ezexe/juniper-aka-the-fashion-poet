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
    public sealed partial class AddableButtonUserControl : Button
    {
        public static readonly DependencyProperty ActionButtonCommandParamProperty = DependencyProperty.Register(nameof(ActionButtonCommandParam),
         typeof(string),
         typeof(AddableButtonUserControl), 
         new PropertyMetadata(null));
        public string ActionButtonCommandParam
        {
            get { return (string)GetValue(ActionButtonCommandParamProperty); }
            set { SetValue(ActionButtonCommandParamProperty, value); }
        }

        public static readonly DependencyProperty OnCommandPropery = DependencyProperty.Register(nameof(OnCommand),
         typeof(ICommand),
         typeof(AddableButtonUserControl),
         new PropertyMetadata(null));
        public ICommand OnCommand
        {
            get { return (ICommand)GetValue(OnCommandPropery); }
            set { SetValue(OnCommandPropery, value); }
        }

        public static readonly DependencyProperty ButtonVisibilityProperty = DependencyProperty.Register(nameof(ButtonVisibility),
         typeof(Visibility),
         typeof(AddableButtonUserControl),
         new PropertyMetadata(null));
        public Visibility ButtonVisibility
        {
            get { return (Visibility)GetValue(ButtonVisibilityProperty); }
            set { SetValue(ButtonVisibilityProperty, value); }
        }

        public AddableButtonUserControl()
        {
            this.InitializeComponent();
        }
    }
}
