using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.BrainRemainder.Startup))]
namespace MVC.BrainRemainder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
