using System.Web.Mvc;

namespace Landers.v1.Areas.TruGreen
{
    public class TruGreenAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TruGreen";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "TruGreen_default",
            //    "TruGreen/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}