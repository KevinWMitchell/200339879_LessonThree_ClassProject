using System.Web;
using System.Web.Mvc;

namespace _200339879_LessonThree_ClassProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
