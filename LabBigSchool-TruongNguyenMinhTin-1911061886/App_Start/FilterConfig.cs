using System.Web;
using System.Web.Mvc;

namespace LabBigSchool_TruongNguyenMinhTin_1911061886
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
