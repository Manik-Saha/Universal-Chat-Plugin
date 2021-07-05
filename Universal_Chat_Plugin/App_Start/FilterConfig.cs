using System.Web;
using System.Web.Mvc;

namespace Universal_Chat_Plugin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
