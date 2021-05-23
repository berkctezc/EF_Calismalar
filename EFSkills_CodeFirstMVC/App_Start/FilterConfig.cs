using System.Web;
using System.Web.Mvc;

namespace EFSkills_CodeFirstMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
