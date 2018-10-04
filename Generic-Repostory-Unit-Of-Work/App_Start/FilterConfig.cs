using System.Web;
using System.Web.Mvc;

namespace Generic_Repostory_Unit_Of_Work
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
