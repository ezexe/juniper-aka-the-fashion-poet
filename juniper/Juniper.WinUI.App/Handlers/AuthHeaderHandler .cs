namespace Juniper.WinUI.App.Handlers
{
    internal class AuthHeaderHandler : DelegatingHandler
    {
        //private readonly IAuthTokenStore authTokenStore;

        public AuthHeaderHandler()
        {
            //this.authTokenStore = authTokenStore ?? throw new ArgumentNullException(nameof(authTokenStore));

            InnerHandler = new HttpClientHandler();
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //var token = await authTokenStore.GetToken();
            var token = await MainViewModel.Current.SettingsViewModel.GetLoadAccessToken();

            //potentially refresh token here if it has expired etc.

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}