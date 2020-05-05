using System.Web;
using System.Web.Mvc;

namespace aulla004_ConsomeCalculadora
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
