using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using SalesPortal.Client.Security;

namespace SalesPortal.Client.Providers
{
    public class SalesPortalClientProvider
    {
        private readonly IAccessTokenProvider _accessTokenProvider;
        private readonly AccessTokenProviderOptions _options;

        public SalesPortalClientProvider(IAccessTokenProvider accessTokenProvider, AccessTokenProviderOptions options)
        {
            _accessTokenProvider = accessTokenProvider;
            _options = options;
        }

        public SalesPortalClient Client
        {
            get
            {
                var authProvider = new BaseBearerTokenAuthenticationProvider(_accessTokenProvider);
                var adapter = new HttpClientRequestAdapter(authProvider);
                adapter.BaseUrl = $"https://{_options.BaseUrl}/".Replace("https://https://", "https://");
                return new SalesPortalClient(adapter);
            }
        }
    }
}


