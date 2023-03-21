using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenDinhHoang_BigSchool.Startup))]
namespace NguyenDinhHoang_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
