using System.Web;
using System.Web.Mvc;

namespace Vidlys
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute()); //applying the authorize action globally
            filters.Add(new RequireHttpsAttribute()); //the app will only be opened by https channel
        }
    }
}
