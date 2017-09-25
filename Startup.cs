using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Music_Store_class_1.Startup))]
namespace MVC_Music_Store_class_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
