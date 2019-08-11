using System.Web;
using System.Web.Mvc;

namespace Token_Based_Owin_Athuentication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
