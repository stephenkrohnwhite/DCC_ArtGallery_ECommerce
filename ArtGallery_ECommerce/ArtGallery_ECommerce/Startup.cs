using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtGallery_ECommerce.Startup))]
namespace ArtGallery_ECommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
