using System.Web;
using System.Web.Mvc;

namespace Lab3_KIST_.net_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
