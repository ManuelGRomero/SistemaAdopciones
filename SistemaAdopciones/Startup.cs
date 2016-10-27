using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaAdopciones.Startup))]
namespace SistemaAdopciones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
