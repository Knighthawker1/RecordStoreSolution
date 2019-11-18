using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecordStoreProject.Startup))]
namespace RecordStoreProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
