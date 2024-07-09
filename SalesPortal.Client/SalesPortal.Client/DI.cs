using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions.Authentication;
using SalesPortal.Client.Providers;
using SalesPortal.Client.Security;
using System;
using System.Linq;

namespace SalesPortal.Client.DependencyInjection
{
    public static class DI
    {
        public static void AddSalesPortalClient(this IServiceCollection services, Action<AccessTokenProviderOptionsBuilder> builderAction, ServiceLifetime serviceLifetime = ServiceLifetime.Transient)
        {
            var builder = new AccessTokenProviderOptionsBuilder();
            if (builderAction != null)
            {
                builderAction(builder);
            }

            if (string.IsNullOrWhiteSpace(builder.Options.BaseUrl))
            {
                builder.UseBaseUrl("https://api.sales.createif-labs.de");
            }

            if (!builder.Options.AllowedHosts.Any())
            {
                builder.UseAllowedHosts(new string[] { "api.sales.createif-labs.de" });
            }

            services.AddSingleton(builder.Options);

            switch (serviceLifetime)
            {
                case ServiceLifetime.Singleton:
                    services.AddSingleton<IAccessTokenProvider, AccessTokenProvider>();
                    services.AddSingleton<SalesPortalClientProvider>();
                    break;
                case ServiceLifetime.Scoped:
                    services.AddScoped<IAccessTokenProvider, AccessTokenProvider>();
                    services.AddScoped<SalesPortalClientProvider>();
                    break;
                case ServiceLifetime.Transient:
                default:
                    services.AddTransient<IAccessTokenProvider, AccessTokenProvider>();
                    services.AddTransient<SalesPortalClientProvider>();
                    break;
            }

        }
    }
}
