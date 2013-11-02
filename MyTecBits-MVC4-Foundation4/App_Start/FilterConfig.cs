using System.Web;
using System.Web.Mvc;

namespace MyTecBits_MVC4_Foundation4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}