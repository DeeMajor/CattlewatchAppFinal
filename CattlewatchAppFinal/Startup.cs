using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CattlewatchAppFinal.Startup))]
namespace CattlewatchAppFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
