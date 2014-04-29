// CREATED BY: Nathan Townsend
// CREATED DATE: 4/29/2014
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
        public static int Create(UserDO DO)
        {
            SqlParameter _Name = new SqlParameter("Name", SqlDbType.VarChar);
            SqlParameter _Email = new SqlParameter("Email", SqlDbType.VarChar);
            SqlParameter _Phone = new SqlParameter("Phone", SqlDbType.VarChar);
            SqlParameter _Login = new SqlParameter("Login", SqlDbType.VarChar);
            SqlParameter _PasswordHash = new SqlParameter("PasswordHash", SqlDbType.VarChar);
            SqlParameter _Created = new SqlParameter("Created", SqlDbType.DateTime);
            SqlParameter _LastAccessed = new SqlParameter("LastAccessed", SqlDbType.DateTime);
            
            _Name.Value = DO.Name;
            _Email.Value = DO.Email;
            _Phone.Value = DO.Phone;
            _Login.Value = DO.Login;
            _PasswordHash.Value = DO.PasswordHash;
            _Created.Value = DO.Created;
            _LastAccessed.Value = DO.LastAccessed;
            
            SqlParameter[] _params = new SqlParameter[] {
                _Name,
                _Email,
                _Phone,
                _Login,
                _PasswordHash,
                _Created,
                _LastAccessed
            };

            return DataCommon.ExecuteScalar("[dbo].[User_Insert]", _params, "dbo");
            
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
            SqlParameter _Login = new SqlParameter("Login", SqlDbType.VarChar);
            SqlParameter _PasswordHash = new SqlParameter("PasswordHash", SqlDbType.VarChar);
            SqlParameter _Created = new SqlParameter("Created", SqlDbType.DateTime);
            SqlParameter _LastAccessed = new SqlParameter("LastAccessed", SqlDbType.DateTime);
            
            _UserId.Value = DO.UserId;
            _Name.Value = DO.Name;
            _Email.Value = DO.Email;
            _Phone.Value = DO.Phone;
            _Login.Value = DO.Login;
            _PasswordHash.Value = DO.PasswordHash;
            _Created.Value = DO.Created;
            _LastAccessed.Value = DO.LastAccessed;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _Name,
                _Email,
                _Phone,
                _Login,
                _PasswordHash,
                _Created,
                _LastAccessed
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
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.Email = sr.GetString(sr.GetOrdinal("Email"));
                obj.Phone = sr.GetString(sr.GetOrdinal("Phone"));
                obj.Login = sr.GetString(sr.GetOrdinal("Login"));
                obj.PasswordHash = sr.GetString(sr.GetOrdinal("PasswordHash"));
                obj.Created = sr.GetDateTime(sr.GetOrdinal("Created"));
                obj.LastAccessed = sr.GetDateTime(sr.GetOrdinal("LastAccessed"));
                


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
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.Email = sr.GetString(sr.GetOrdinal("Email"));
                obj.Phone = sr.GetString(sr.GetOrdinal("Phone"));
                obj.Login = sr.GetString(sr.GetOrdinal("Login"));
                obj.PasswordHash = sr.GetString(sr.GetOrdinal("PasswordHash"));
                obj.Created = sr.GetDateTime(sr.GetOrdinal("Created"));
                obj.LastAccessed = sr.GetDateTime(sr.GetOrdinal("LastAccessed"));
                

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
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.Email = sr.GetString(sr.GetOrdinal("Email"));
                obj.Phone = sr.GetString(sr.GetOrdinal("Phone"));
                obj.Login = sr.GetString(sr.GetOrdinal("Login"));
                obj.PasswordHash = sr.GetString(sr.GetOrdinal("PasswordHash"));
                obj.Created = sr.GetDateTime(sr.GetOrdinal("Created"));
                obj.LastAccessed = sr.GetDateTime(sr.GetOrdinal("LastAccessed"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }

/// <summary>
        /// Selects User records by User_Login
        /// </summary>
        public static UserDO[] GetByUser_Login(String Login)
        {

            SqlParameter _Login = new SqlParameter("Login", SqlDbType.VarChar);
			
            _Login.Value = Login;
			
            SqlParameter[] _params = new SqlParameter[] {
                _Login
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[User_GetByUser_Login]", _params, "dbo");

            List<UserDO> objs = new List<UserDO>();
			
            while(sr.Read())
            {
                UserDO obj = new UserDO();
				
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.Email = sr.GetString(sr.GetOrdinal("Email"));
                obj.Phone = sr.GetString(sr.GetOrdinal("Phone"));
                obj.Login = sr.GetString(sr.GetOrdinal("Login"));
                obj.PasswordHash = sr.GetString(sr.GetOrdinal("PasswordHash"));
                obj.Created = sr.GetDateTime(sr.GetOrdinal("Created"));
                obj.LastAccessed = sr.GetDateTime(sr.GetOrdinal("LastAccessed"));
                

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