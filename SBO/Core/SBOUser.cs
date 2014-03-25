using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Routing;

namespace SBO.Core
{
    public class SBOUser
    {
        /// <summary>
        /// Gets the Customer Id from the current request route data if present, or else an empty string
        /// </summary>
        public static string CustomerId 
        {
            get
            {
                object value = HttpContext.Current.Request.RequestContext.RouteData.Values["customer"];
                return value == null ? "" : value.ToString();
            }
        }


    }
}