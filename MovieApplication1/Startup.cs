using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieApplication1.Startup))]
namespace MovieApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
