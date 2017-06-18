using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstadisticaFutbol.Startup))]
namespace EstadisticaFutbol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
