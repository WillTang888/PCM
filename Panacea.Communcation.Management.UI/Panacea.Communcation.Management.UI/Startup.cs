using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Panacea.Communcation.Management.UI.Startup))]
namespace Panacea.Communcation.Management.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
