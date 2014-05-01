// CREATED BY: Nathan Townsend
// CREATED DATE: 5/1/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using SBO.DAL.DAL;
using SBO.DAL.DO.dbo;

namespace SBO.DAL.DAL.dbo
{
    /// <summary>
    /// Provides data access methods for the User database table
    /// </summary>
    /// <remarks>
    public partial class User
    {
        
        /// <summary>
        /// Creates a new User record
        /// </summary>
        public static void Create(UserDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            SqlParameter _Name = new SqlParameter("Name", SqlDbType.VarChar);
            SqlParameter _Email = new SqlParameter("Email", SqlDbType.VarChar);
            SqlParameter _Phone = new SqlParameter("Phone", SqlDbType.VarChar);
            
            _UserId.Value = DO.UserId;
            _Name.Value = DO.Name;
            _Email.Value = DO.Email;
            _Phone.Value = DO.Phone;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _Name,
                _Email,
                _Phone
            };

            DataCommon.ExecuteNonQuery("[dbo].[User_Insert]", _params, "dbo");
            
        }


        /// <summary>
        /// Updates a User record and returns the number of records affected
        /// </summary>
        public static int Update(UserDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            SqlParameter _Name = new SqlParameter("Name", SqlDbType.VarChar);
            SqlParameter _Email = new SqlParameter("Email", SqlDbType.VarChar);
            SqlParameter _Phone = new SqlParameter("Phone", SqlDbType.VarChar);
            
            _UserId.Value = DO.UserId;
            _Name.Value = DO.Name;
            _Email.Value = DO.Email;
            _Phone.Value = DO.Phone;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _Name,
                _Email,
                _Phone
            };

            return DataCommon.ExecuteScalar("[dbo].[User_Update]", _params, "dbo");
        }


        /// <summary>
        /// Deletes a User record
        /// </summary>
        public static int Delete(UserDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            
            _UserId.Value = DO.UserId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId
            };

            return DataCommon.ExecuteScalar("[dbo].[User_Delete]", _params, "dbo");
        }


        /// <summary>
        /// Gets all User records
        /// </summary>
        public static UserDO[] GetAll()
        {
            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[User_GetAll]", new SqlParameter[] { }, "dbo");
            
            List<UserDO> objs = new List<UserDO>();
            
            while(sr.Read()){

                UserDO obj = new UserDO();
                
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                if (sr.IsDBNull(sr.GetOrdinal("Name"))) { obj.Name = null; } else { obj.Name = sr.GetString(sr.GetOrdinal("Name")); }
                if (sr.IsDBNull(sr.GetOrdinal("Email"))) { obj.Email = null; } else { obj.Email = sr.GetString(sr.GetOrdinal("Email")); }
                if (sr.IsDBNull(sr.GetOrdinal("Phone"))) { obj.Phone = null; } else { obj.Phone = sr.GetString(sr.GetOrdinal("Phone")); }


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects User records by PK
        /// </summary>
        public static UserDO[] GetByPK(Int32 UserId)
        {

            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
			
            _UserId.Value = UserId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _UserId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[User_GetByPK]", _params, "dbo");

            List<UserDO> objs = new List<UserDO>();
			
            while(sr.Read())
            {
                UserDO obj = new UserDO();
				
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                if (sr.IsDBNull(sr.GetOrdinal("Name"))) { obj.Name = null; } else { obj.Name = sr.GetString(sr.GetOrdinal("Name")); }
                if (sr.IsDBNull(sr.GetOrdinal("Email"))) { obj.Email = null; } else { obj.Email = sr.GetString(sr.GetOrdinal("Email")); }
                if (sr.IsDBNull(sr.GetOrdinal("Phone"))) { obj.Phone = null; } else { obj.Phone = sr.GetString(sr.GetOrdinal("Phone")); }

                objs.Add(obj);
            }

            return objs.ToArray();
        }

/// <summary>
        /// Selects User records by User_Email
        /// </summary>
        public static UserDO[] GetByUser_Email(String Email)
        {

            SqlParameter _Email = new SqlParameter("Email", SqlDbType.VarChar);
			
            _Email.Value = Email;
			
            SqlParameter[] _params = new SqlParameter[] {
                _Email
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[User_GetByUser_Email]", _params, "dbo");

            List<UserDO> objs = new List<UserDO>();
			
            while(sr.Read())
            {
                UserDO obj = new UserDO();
				
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                if (sr.IsDBNull(sr.GetOrdinal("Name"))) { obj.Name = null; } else { obj.Name = sr.GetString(sr.GetOrdinal("Name")); }
                if (sr.IsDBNull(sr.GetOrdinal("Email"))) { obj.Email = null; } else { obj.Email = sr.GetString(sr.GetOrdinal("Email")); }
                if (sr.IsDBNull(sr.GetOrdinal("Phone"))) { obj.Phone = null; } else { obj.Phone = sr.GetString(sr.GetOrdinal("Phone")); }

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the User Table
        /// </summary>
        public static void Truncate()
        {
            DataCommon.TruncateTable("dbo", "User");
        }

    }
}