using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpComingGibs.Startup))]
namespace UpComingGibs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
