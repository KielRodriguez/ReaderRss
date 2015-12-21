using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReaderRss.Startup))]
namespace ReaderRss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
