using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMusicStore.Startup))]
namespace MyMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
