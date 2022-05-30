using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_BigSchool_TranThanhPhong.Startup))]
namespace Lab_BigSchool_TranThanhPhong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
