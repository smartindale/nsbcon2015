using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Slate.Web.Startup))]

namespace Slate.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GlobalHost.DependencyResolver.UseSqlServer("data source=.;initial catalog=signalR;integrated security=SSPI;");
            app.MapSignalR();

        }
    }
}
