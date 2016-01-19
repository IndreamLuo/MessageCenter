using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageCenter.Service.Web.Startup))]
namespace MessageCenter.Service.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
