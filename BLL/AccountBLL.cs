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
        public static SBOUserBO CreateNewRegistration(RegisterBO Registration){
            
            // create the new data object
            UserDO data = new UserDO()
            {
                Created = DateTime.Now,
                Email = Registration.Email,
                LastAccessed = DateTime.Now,
                Login = Registration.Login,
                Name = Registration.Name,
                PasswordHash = PasswordHash.CreateHash(Registration.Password),
                Phone = Registration.Phone
            };

            // add to database
            data.UserId = User.Create(data);
            
            // build the business object
            SBOUserBO user = new SBOUserBO(data);

            return user;

        }

    }
}
