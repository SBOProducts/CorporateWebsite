using SBO.DAL.DO.dbo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBO.BLL.BusinessObjects
{
    /// <summary>
    /// A specialized website business object that contains the roles of a user
    /// </summary>
    public class UserWebsiteBO : WebsiteBO
    {

        public UserWebsiteBO(WebsiteBO Website, string Roles, int UserId)
        {
            this.BusinessTypeId = Website.BusinessTypeId;
            this.Created = Website.Created;
            this.Description = Website.Description;
            this.SiteName = Website.SiteName;
            this.Type = Website.Type;
            this.WebsiteId = Website.WebsiteId;

            
            this.Roles = Roles;
            this.UserId = UserId;
        }

        public UserWebsiteBO()
        {
            // TODO: Complete member initialization
        }

        

        /// <summary>
        /// The user's roles
        /// </summary>
        public string Roles { get; set; }


        /// <summary>
        /// The user Id
        /// </summary>
        public int UserId { get; set; }
    }


    /// <summary>
    /// Provides information about a website
    /// </summary>
    public class WebsiteBO
    {
        /// <summary>
        /// Create an empty instance
        /// </summary>
        public WebsiteBO()
        {

        }


        /// <summary>
        /// Creates a new instance from data objects
        /// </summary>
        /// <param name="BusinessType"></param>
        /// <param name="Website"></param>
        internal WebsiteBO(BusinessTypeBO BusinessType, SiteDO Website)
        {
            this.Created = Website.CreatedDate;
            this.WebsiteId = Website.SiteId;
            this.SiteName = Website.SiteName;

            this.BusinessTypeId = BusinessType.BusinessTypeId;
            this.Type = BusinessType.BusinessType;
            this.Description = BusinessType.Description;
        }


        /// <summary>
        /// Gets the business type data object
        /// </summary>
        /// <returns></returns>
        internal BusinessTypeDO GetBusinessTypeDataObject()
        {
            return new BusinessTypeDO()
            {
                BusinessTypeId = BusinessTypeId,
                Title = Type,
                Description = Description
            };
        }

        /// <summary>
        /// Gets the site data object
        /// </summary>
        /// <returns></returns>
        internal SiteDO GetSiteDataObject()
        {
            return new SiteDO()
            {
                BusinessTypeId = BusinessTypeId,
                CreatedDate = Created,
                SiteId = WebsiteId,
                SiteName = SiteName
            };
        }


        #region Site Properties

        /// <summary>
        /// When the website was created
        /// </summary>
        public DateTime Created { get; set;}

        /// <summary>
        /// The name of the website used to identify the tenant
        /// </summary>
        [Required]
        [RegularExpression(@"([A-Za-z0-9\-]+)", ErrorMessage="Only letters, numbers, and dashes are allowed (no spaces or symbols)")]
        public string SiteName {get;set;}

        /// <summary>
        /// The unique id of the website
        /// </summary>
        public int WebsiteId { get; set; }

        #endregion


        #region Business Type properties

        /// <summary>
        /// The business type id
        /// </summary>
        public int BusinessTypeId { get; set; }

        /// <summary>
        /// The type of website line of business
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The description of the type of website line of business
        /// </summary>
        public string Description { get; set; }

        #endregion


    }


    /// <summary>
    /// A business type line of business
    /// </summary>
    public class BusinessTypeBO
    {
        public BusinessTypeBO()
        {

        }

        internal BusinessTypeBO(BusinessTypeDO BusinessType)
        {
            this.BusinessTypeId = BusinessType.BusinessTypeId;
            this.BusinessType = BusinessType.Title;
            this.Description = BusinessType.Description;
        }

        internal BusinessTypeDO GetBusinessTypeDataObject()
        {
            return new BusinessTypeDO()
            {
                BusinessTypeId = BusinessTypeId,
                Description = Description,
                Title = BusinessType
            };
        }


        public int BusinessTypeId { get; set; }

        public string BusinessType { get; set; }

        public string Description { get; set; }
    }

}
