using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigSchool_TruongNguyenMinhTin_1911061886.Startup))]
namespace LabBigSchool_TruongNguyenMinhTin_1911061886
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
