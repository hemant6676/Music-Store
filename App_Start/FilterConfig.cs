using System.Web;
using System.Web.Mvc;

namespace MVC_Music_Store_class_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
