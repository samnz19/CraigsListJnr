using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CraigsListJnr.Startup))]
namespace CraigsListJnr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
