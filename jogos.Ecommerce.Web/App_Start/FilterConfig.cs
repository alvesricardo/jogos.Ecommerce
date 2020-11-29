using jogos.Ecommerce.Web.Filtros;
using System.Web;
using System.Web.Mvc;

namespace jogos.Ecommerce.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogActionFilter());
        }
    }
}
