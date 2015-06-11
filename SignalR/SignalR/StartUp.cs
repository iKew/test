using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(SignalR.StartUp))]
namespace SignalR
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app) { 
            app.MapSignalR();
        }
    }
}