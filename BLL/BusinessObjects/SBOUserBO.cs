using SBO.DAL.DO.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBO.BLL.BusinessObjects
{
    public class SBOUserBO
    {
        internal SBOUserBO(UserDO UserDO)
        {
            UserId = UserDO.UserId;
        }

        public Int32 UserId { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Login { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastAccessed { get; set; }
    }
}
