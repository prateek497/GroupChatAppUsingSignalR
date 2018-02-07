using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ChatApplicationUsingSignalR.Startup))]

namespace ChatApplicationUsingSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
