using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Generic_Repostory_Unit_Of_Work.Startup))]
namespace Generic_Repostory_Unit_Of_Work
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
