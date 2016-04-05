using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharePointDemo.Startup))]
namespace SharePointDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
