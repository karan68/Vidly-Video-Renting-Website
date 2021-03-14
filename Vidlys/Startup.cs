using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlys.Startup))]
namespace Vidlys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
            ConfigureAuth(app);
        }
    }
}
