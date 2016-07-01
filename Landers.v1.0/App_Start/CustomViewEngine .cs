using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Landers.v1
{
    public class CustomViewEngine : RazorViewEngine 
    {
        public CustomViewEngine()
        {
            var viewLocations = new[] {  
            "~/Areas/AmericanHomeShield/views/shared/{0}.cshtml",
            "~/Areas/TruGreen/views/shared/{0}.cshtml",
            "~/Areas/TruGreen/views/shared/desktop/{0}.cshtml",
            "~/Views/{1}/{0}.cshtml",  
            "~/Views/Shared/{0}.cshtml",  
            //"~/Views/Shared/{0}.ascx",  
            //"~/AnotherPath/Views/{0}.ascx"
            // etc
        };

            this.PartialViewLocationFormats = viewLocations;
            this.ViewLocationFormats = viewLocations;
        }

    }
}