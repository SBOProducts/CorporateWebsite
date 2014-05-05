using SBO.BLL.BusinessObjects;
using SBO.DAL.DAL.dbo;
using SBO.DAL.DO.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMatrix.WebData;

namespace SBO.BLL
{
    public class WebsiteBLL
    {
        /// <summary>
        /// Creates a new website 
        /// </summary>
        /// <param name="Website"></param>
        /// <returns></returns>
        public static UserWebsiteBO CreateWebsite(UserWebsiteBO Website)
        {
            // site names must be unique
            if (Site.GetByPK(Website.SiteName).Length > 0)
                throw new Exception("A site with that name already exists");


            // There's only one line of business currently
            BusinessTypeBO type = GetBusinessType(1);

            Website.UserId = WebSecurity.CurrentUserId;
            Website.Created = DateTime.Now;
            Website.Roles = SiteRoles.Owner;
            Website.BusinessTypeId = type.BusinessTypeId;
            Website.Description = type.Description;
            Website.Type = type.BusinessType;

            // create the website data record
            SiteDO site = Website.GetSiteDataObject();
            site.SiteId = Site.Create(site);
            Website.WebsiteId = site.SiteId;

            // make the user the owner of the new website
            SiteUsersDO xref = new SiteUsersDO() { Added = DateTime.Now, Roles = SiteRoles.Owner, SiteId = site.SiteId, UserId = Website.UserId };
            SiteUsers.Create(xref);

            return Website;
        }


        /// <summary>
        /// Gets all websites for a user
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static IEnumerable<UserWebsiteBO> GetUserWebsites(int UserId)
        {
            SiteUsersDO[] xrefs = SiteUsers.GetBySiteUsers_User(UserId);

            List<UserWebsiteBO> sites = new List<UserWebsiteBO>();

            foreach (SiteUsersDO xref in xrefs)
            {
                WebsiteBO website = GetWebsite(xref.SiteId);
                UserWebsiteBO userSite = new UserWebsiteBO(website, xref.Roles, UserId);
                sites.Add(userSite);
            }

            return sites;
        }


        /// <summary>
        /// Gets a website by Id
        /// </summary>
        /// <param name="WebsiteId"></param>
        /// <returns></returns>
        public static WebsiteBO GetWebsite(int WebsiteId)
        {
            SiteDO data = Site.GetBySite_SiteId(WebsiteId).FirstOrDefault();
            if (data == null)
                return null;

            return new WebsiteBO(GetBusinessType(data.BusinessTypeId), data);
            
        }


        #region Business Types


        /// <summary>
        /// Stores a static list of all business types from the database
        /// </summary>
        private static List<BusinessTypeBO> _businessTypes = null;


        /// <summary>
        /// Returns all business types
        /// </summary>
        /// <returns></returns>
        public static List<BusinessTypeBO> GetBusinessTypes(){
            if (_businessTypes == null)
            {
                _businessTypes = new List<BusinessTypeBO>();
                foreach (BusinessTypeDO type in BusinessType.GetAll())
                {
                    _businessTypes.Add(new BusinessTypeBO(type));
                }
            }

            return _businessTypes;
        }

        /// <summary>
        /// Gets a business type by id
        /// </summary>
        /// <param name="BusinessTypeId"></param>
        /// <returns></returns>
        public static BusinessTypeBO GetBusinessType(int BusinessTypeId)
        {
            return GetBusinessTypes().Where(t => t.BusinessTypeId == BusinessTypeId).FirstOrDefault();
        }

        #endregion
    }
}
