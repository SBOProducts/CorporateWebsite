using SBO.BLL.BusinessObjects;
using SBO.BLL.Utilities;
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
    public class AccountBLL
    {

        #region User Profile

        /// <summary>
        /// Creates a new user 
        /// </summary>
        /// <param name="UserName">The user name used to login</param>
        /// <param name="Password">The password used to login</param>
        /// <returns>The user id of the new user</returns>
        public static int CreateUserProfile(string UserName, string Password)
        {
            // create the membership record
            WebSecurity.CreateUserAndAccount(UserName, Password);

            // login the user and take to profile page
            WebSecurity.Login(UserName, Password);

            // add the user record to the database
            int UserId = WebSecurity.GetUserId(UserName);
            UserDO data = new UserDO() { UserId = UserId };
            User.Create(data);

            return UserId;
        }


        /// <summary>
        /// Gets a user profile by their id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static UserProfileBO GetUserProfile(int UserId)
        {
            UserDO data = User.GetByPK(UserId).FirstOrDefault();
            return new UserProfileBO(data);
        }

        /// <summary>
        /// Gets a user profile by their login name
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public static UserProfileBO GetUserProfile(string UserName)
        {
            int id = WebSecurity.GetUserId(UserName);
            return GetUserProfile(id);
        }


        /// <summary>
        /// Updates a user's profile info
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        public static UserProfileBO UpdateUserProfile(UserProfileBO profile)
        {
            profile.UserId = WebSecurity.CurrentUserId;
            User.Update(profile.GetDataObject());
            return profile;
        }

        #endregion
    }
}
