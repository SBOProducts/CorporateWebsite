using SBO.BLL.BusinessObjects;
using SBO.BLL.Utilities;
using SBO.DAL.DAL.dbo;
using SBO.DAL.DO.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBO.BLL
{
    public class AccountBLL
    {
        /// <summary>
        /// Creates a new user object with no properties set
        /// </summary>
        /// <param name="UserId"></param>
        public static void CreateUser(int UserId)
        {
            UserDO data = new UserDO() { UserId = UserId };
            User.Create(data);
        }


        /// <summary>
        /// Gets a user object by id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static UserBO GetUser(int UserId)
        {
            UserDO data = User.GetByPK(UserId).FirstOrDefault();
            return new UserBO(data);
        }




    }
}
