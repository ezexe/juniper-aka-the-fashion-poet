using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System;
using Refit;
using Juniper.Core.Services;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System.Threading;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Juniper.Core.ViewModels;

namespace SPSSDKJuniperAppTests
{
    [TestClass]
    public class SPSAPICallsTests
    {
        public static ISPSCommerceService SPSCommerceService { get; set; }
        public static MainViewModel ViewModel { get; set; }

        public SPSAPICallsTests()
        {
            //SPSCommerceService = RestService.For<ISPSCommerceService>(new HttpClient(new AuthHeaderHandler())
            //{
            //    BaseAddress = new Uri("https://api.spscommerce.com")
            //});

        }
    }

    //internal class AuthHeaderHandler : DelegatingHandler
    //{
    //    //private readonly IAuthTokenStore authTokenStore;

    //    public AuthHeaderHandler()
    //    {
    //        //this.authTokenStore = authTokenStore ?? throw new ArgumentNullException(nameof(authTokenStore));

    //        InnerHandler = new HttpClientHandler();
    //    }

    //    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    //    {
    //        var vm = (MainViewModel)SPSAPICallsTests.Services.GetService(typeof(MainViewModel));
    //        var token = await vm.GetorResetAccessToken();

    //        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

    //        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    //    }
    //}
}