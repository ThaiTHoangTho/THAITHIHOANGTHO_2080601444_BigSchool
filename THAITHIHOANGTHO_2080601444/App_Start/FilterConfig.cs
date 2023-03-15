using System.Web;
using System.Web.Mvc;

namespace THAITHIHOANGTHO_2080601444
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
