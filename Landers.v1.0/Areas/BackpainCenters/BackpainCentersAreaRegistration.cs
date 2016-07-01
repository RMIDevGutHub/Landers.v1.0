using System.Web.Mvc;

namespace Landers.v1._0.Areas.BackpainCenters
{
    public class BackpainCentersAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BackpainCenters";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BackpainCenters_default",
                "BackpainCenters/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}