﻿using Owin;
using SelfHost.Config;
using Thinktecture.IdentityServer.Core.Configuration;

namespace SelfHost
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var options = new IdentityServerOptions
            {
                IssuerUri = "https://idsrv3.com",
                SiteName = "Thinktecture IdentityServer v3 - beta3 (EntityFramework)",
                
                SigningCertificate = Certificate.Get(),
                Factory = Factory.Configure("IdSvr3Config"),
                CorsPolicy = CorsPolicy.AllowAll
            };

            appBuilder.UseIdentityServer(options);
        }
    }
}