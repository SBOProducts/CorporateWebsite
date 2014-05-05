// CREATED BY: Nathan Townsend
// CREATED DATE: 5/5/2014
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
    /// Provides data access methods for the SiteUsers database table
    /// </summary>
    /// <remarks>
    public partial class SiteUsers
    {
        
        /// <summary>
        /// Creates a new SiteUsers record
        /// </summary>
        public static void Create(SiteUsersDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            SqlParameter _SiteId = new SqlParameter("SiteId", SqlDbType.Int);
            SqlParameter _Added = new SqlParameter("Added", SqlDbType.DateTime);
            SqlParameter _Roles = new SqlParameter("Roles", SqlDbType.VarChar);
            
            _UserId.Value = DO.UserId;
            _SiteId.Value = DO.SiteId;
            _Added.Value = DO.Added;
            _Roles.Value = DO.Roles;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _SiteId,
                _Added,
                _Roles
            };

            DataCommon.ExecuteNonQuery("[dbo].[SiteUsers_Insert]", _params, "dbo");
            
        }


        /// <summary>
        /// Updates a SiteUsers record and returns the number of records affected
        /// </summary>
        public static int Update(SiteUsersDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            SqlParameter _SiteId = new SqlParameter("SiteId", SqlDbType.Int);
            SqlParameter _Added = new SqlParameter("Added", SqlDbType.DateTime);
            SqlParameter _Roles = new SqlParameter("Roles", SqlDbType.VarChar);
            
            _UserId.Value = DO.UserId;
            _SiteId.Value = DO.SiteId;
            _Added.Value = DO.Added;
            _Roles.Value = DO.Roles;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _SiteId,
                _Added,
                _Roles
            };

            return DataCommon.ExecuteScalar("[dbo].[SiteUsers_Update]", _params, "dbo");
        }


        /// <summary>
        /// Deletes a SiteUsers record
        /// </summary>
        public static int Delete(SiteUsersDO DO)
        {
            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            SqlParameter _SiteId = new SqlParameter("SiteId", SqlDbType.Int);
            
            _UserId.Value = DO.UserId;
            _SiteId.Value = DO.SiteId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _SiteId
            };

            return DataCommon.ExecuteScalar("[dbo].[SiteUsers_Delete]", _params, "dbo");
        }


        /// <summary>
        /// Gets all SiteUsers records
        /// </summary>
        public static SiteUsersDO[] GetAll()
        {
            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[SiteUsers_GetAll]", new SqlParameter[] { }, "dbo");
            
            List<SiteUsersDO> objs = new List<SiteUsersDO>();
            
            while(sr.Read()){

                SiteUsersDO obj = new SiteUsersDO();
                
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.Added = sr.GetDateTime(sr.GetOrdinal("Added"));
                obj.Roles = sr.GetString(sr.GetOrdinal("Roles"));
                


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects SiteUsers records by PK
        /// </summary>
        public static SiteUsersDO[] GetByPK(Int32 UserId,
 Int32 SiteId)
        {

            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
            SqlParameter _SiteId = new SqlParameter("SiteId", SqlDbType.Int);
			
            _UserId.Value = UserId;
            _SiteId.Value = SiteId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _UserId,
                _SiteId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[SiteUsers_GetByPK]", _params, "dbo");

            List<SiteUsersDO> objs = new List<SiteUsersDO>();
			
            while(sr.Read())
            {
                SiteUsersDO obj = new SiteUsersDO();
				
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.Added = sr.GetDateTime(sr.GetOrdinal("Added"));
                obj.Roles = sr.GetString(sr.GetOrdinal("Roles"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }

/// <summary>
        /// Selects SiteUsers records by SiteUsers_Site
        /// </summary>
        public static SiteUsersDO[] GetBySiteUsers_Site(Int32 SiteId)
        {

            SqlParameter _SiteId = new SqlParameter("SiteId", SqlDbType.Int);
			
            _SiteId.Value = SiteId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _SiteId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[SiteUsers_GetBySiteUsers_Site]", _params, "dbo");

            List<SiteUsersDO> objs = new List<SiteUsersDO>();
			
            while(sr.Read())
            {
                SiteUsersDO obj = new SiteUsersDO();
				
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.Added = sr.GetDateTime(sr.GetOrdinal("Added"));
                obj.Roles = sr.GetString(sr.GetOrdinal("Roles"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }

/// <summary>
        /// Selects SiteUsers records by SiteUsers_User
        /// </summary>
        public static SiteUsersDO[] GetBySiteUsers_User(Int32 UserId)
        {

            SqlParameter _UserId = new SqlParameter("UserId", SqlDbType.Int);
			
            _UserId.Value = UserId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _UserId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[SiteUsers_GetBySiteUsers_User]", _params, "dbo");

            List<SiteUsersDO> objs = new List<SiteUsersDO>();
			
            while(sr.Read())
            {
                SiteUsersDO obj = new SiteUsersDO();
				
                obj.UserId = sr.GetInt32(sr.GetOrdinal("UserId"));
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.Added = sr.GetDateTime(sr.GetOrdinal("Added"));
                obj.Roles = sr.GetString(sr.GetOrdinal("Roles"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the SiteUsers Table
        /// </summary>
        public static void Truncate()
        {
            DataCommon.TruncateTable("dbo", "SiteUsers");
        }

    }
}