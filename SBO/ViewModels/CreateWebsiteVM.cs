using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBO.ViewModels
{
    public class CreateWebsiteVM
    {
        /// <summary>
        /// The unique name of the site
        /// </summary>
        [Required]
        [RegularExpression(@"([A-Za-z0-9\-]+)", ErrorMessage = "Only letters, numbers, and dashes are allowed (no spaces or symbols)")]
        public string SiteName { get; set; }


        public IEnumerable<SelectListItem> Layouts
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>();

                return items;
            }
        }
    }
}