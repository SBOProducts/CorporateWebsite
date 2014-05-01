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
    public class UserBO
    {
        internal UserBO(UserDO UserDO)
        {
            this.UserId = UserDO.UserId;
            this.Name = UserDO.Name;
            this.Email = UserDO.Email;
            this.Phone = UserDO.Phone;
        }

        /// <summary>
        /// The user id in the database
        /// </summary>
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

    }
}
