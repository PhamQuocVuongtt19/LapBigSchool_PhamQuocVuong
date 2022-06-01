using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LapBigSchool_PhamQuocVuong.Startup))]
namespace LapBigSchool_PhamQuocVuong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
