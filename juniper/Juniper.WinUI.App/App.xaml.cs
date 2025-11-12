using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Juniper.WinUI.App
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        public const string TitlePurchaseOrdersPage = "Orders";
        public const string TitleShipmentsPage = "Shipments";
        public const string TitleInvoicesPage = "Invoices";

        //Application.Current.Resources
        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        public static App AppCurrent;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; private set; }

        public MainWindow MainWindow { get; private set; }

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            AppCurrent = this;

            this.InitializeComponent();
        }
        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
#if DEBUG
            string[] arguments = Environment.GetCommandLineArgs();
            //SettingsViewModel.StateofElie = System.Diagnostics.Debugger.IsAttached && arguments.Length == 2 && arguments[1] == "iselie";
            SettingsViewModel.StateofSandbox = System.Diagnostics.Debugger.IsAttached && arguments.Length == 2 && arguments[1] == "sandbox";
#endif
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Register services
            Services = new ServiceCollection()
                .AddSingleton<IFilesService, FilesService>().AddSingleton<ISettingsService, SettingsService>().AddSingleton<IFieldsService, FieldsService>()
                .AddSingleton<MainViewModel>()
                .AddSingleton<SettingsViewModel>().AddSingleton<OrdersViewModel>().AddSingleton<ShipmentsViewModel>().AddSingleton<InvoicesViewModel>()
                .AddSingleton<LoggerUtil>().AddSingleton<ExcelInteropUtil>().AddSingleton<WordInteropUtil>()
                .AddSingleton<RestClientService>().AddSingleton<DynamoService>().AddSingleton<S3BucketService>()
                .AddSingleton<TagsLibrary>()
                .BuildServiceProvider();
            Ioc.Default.ConfigureServices(Services);


            MainWindow = new MainWindow();
            MainWindow.Title = Package.Current.DisplayName;
            MainWindow.Activate();
        }

        public static TEnum GetEnum<TEnum>(string text) where TEnum : struct
        {
            if (!typeof(TEnum).GetTypeInfo().IsEnum)
            {
                throw new InvalidOperationException("Generic parameter 'TEnum' must be an enum.");
            }
            return (TEnum)System.Enum.Parse(typeof(TEnum), text);
        }
    }
}
