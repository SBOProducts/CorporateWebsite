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
    /// Used for the user registration process
    /// </summary>
    public class UserProfileBO
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public UserProfileBO()
        {

        }


        /// <summary>
        /// Create the business object from a data object
        /// </summary>
        /// <param name="UserDO"></param>
        internal UserProfileBO(UserDO UserDO)
        {
            this.UserId = UserDO.UserId;
            this.Name = UserDO.Name;
            this.Email = UserDO.Email;
            this.Phone = UserDO.Phone;
        }

        /// <summary>
        /// Gets a data object from the business object
        /// </summary>
        /// <returns></returns>
        internal UserDO GetDataObject()
        {
            return new UserDO()
            {
                Email = this.Email,
                Name = this.Name,
                Phone = this.Phone,
                UserId = this.UserId
            };
        }


        /// <summary>
        /// The user id in the database
        /// </summary>
        public int UserId { get; set; }


        /// <summary>
        /// The user's full name
        /// </summary>
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        
        /// <summary>
        /// The user's email address
        /// </summary>
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        /// <summary>
        /// The user's phone number
        /// </summary>
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


    }
}
