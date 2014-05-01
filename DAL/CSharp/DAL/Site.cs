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
    /// Provides data access methods for the Site database table
    /// </summary>
    /// <remarks>
    public partial class Site
    {
        
        /// <summary>
        /// Creates a new Site record
        /// </summary>
        public static int Create(SiteDO DO)
        {
            SqlParameter _SiteName = new SqlParameter("SiteName", SqlDbType.VarChar);
            SqlParameter _CreatedDate = new SqlParameter("CreatedDate", SqlDbType.DateTime);
            SqlParameter _BusinessTypeId = new SqlParameter("BusinessTypeId", SqlDbType.Int);
            
            _SiteName.Value = DO.SiteName;
            _CreatedDate.Value = DO.CreatedDate;
            _BusinessTypeId.Value = DO.BusinessTypeId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _SiteName,
                _CreatedDate,
                _BusinessTypeId
            };

            return DataCommon.ExecuteScalar("[dbo].[Site_Insert]", _params, "dbo");
            
        }


        /// <summary>
        /// Updates a Site record and returns the number of records affected
        /// </summary>
        public static int Update(SiteDO DO)
        {
            SqlParameter _SiteId = new SqlParameter("SiteId", SqlDbType.Int);
            SqlParameter _SiteName = new SqlParameter("SiteName", SqlDbType.VarChar);
            SqlParameter _CreatedDate = new SqlParameter("CreatedDate", SqlDbType.DateTime);
            SqlParameter _BusinessTypeId = new SqlParameter("BusinessTypeId", SqlDbType.Int);
            
            _SiteId.Value = DO.SiteId;
            _SiteName.Value = DO.SiteName;
            _CreatedDate.Value = DO.CreatedDate;
            _BusinessTypeId.Value = DO.BusinessTypeId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _SiteId,
                _SiteName,
                _CreatedDate,
                _BusinessTypeId
            };

            return DataCommon.ExecuteScalar("[dbo].[Site_Update]", _params, "dbo");
        }


        /// <summary>
        /// Deletes a Site record
        /// </summary>
        public static int Delete(SiteDO DO)
        {
            SqlParameter _SiteName = new SqlParameter("SiteName", SqlDbType.VarChar);
            
            _SiteName.Value = DO.SiteName;
            
            SqlParameter[] _params = new SqlParameter[] {
                _SiteName
            };

            return DataCommon.ExecuteScalar("[dbo].[Site_Delete]", _params, "dbo");
        }


        /// <summary>
        /// Gets all Site records
        /// </summary>
        public static SiteDO[] GetAll()
        {
            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Site_GetAll]", new SqlParameter[] { }, "dbo");
            
            List<SiteDO> objs = new List<SiteDO>();
            
            while(sr.Read()){

                SiteDO obj = new SiteDO();
                
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.SiteName = sr.GetString(sr.GetOrdinal("SiteName"));
                obj.CreatedDate = sr.GetDateTime(sr.GetOrdinal("CreatedDate"));
                obj.BusinessTypeId = sr.GetInt32(sr.GetOrdinal("BusinessTypeId"));
                


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects Site records by PK
        /// </summary>
        public static SiteDO[] GetByPK(String SiteName)
        {

            SqlParameter _SiteName = new SqlParameter("SiteName", SqlDbType.VarChar);
			
            _SiteName.Value = SiteName;
			
            SqlParameter[] _params = new SqlParameter[] {
                _SiteName
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Site_GetByPK]", _params, "dbo");

            List<SiteDO> objs = new List<SiteDO>();
			
            while(sr.Read())
            {
                SiteDO obj = new SiteDO();
				
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.SiteName = sr.GetString(sr.GetOrdinal("SiteName"));
                obj.CreatedDate = sr.GetDateTime(sr.GetOrdinal("CreatedDate"));
                obj.BusinessTypeId = sr.GetInt32(sr.GetOrdinal("BusinessTypeId"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }

/// <summary>
        /// Selects Site records by Site_BusinessTypeId
        /// </summary>
        public static SiteDO[] GetBySite_BusinessTypeId(Int32 BusinessTypeId)
        {

            SqlParameter _BusinessTypeId = new SqlParameter("BusinessTypeId", SqlDbType.Int);
			
            _BusinessTypeId.Value = BusinessTypeId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _BusinessTypeId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Site_GetBySite_BusinessTypeId]", _params, "dbo");

            List<SiteDO> objs = new List<SiteDO>();
			
            while(sr.Read())
            {
                SiteDO obj = new SiteDO();
				
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.SiteName = sr.GetString(sr.GetOrdinal("SiteName"));
                obj.CreatedDate = sr.GetDateTime(sr.GetOrdinal("CreatedDate"));
                obj.BusinessTypeId = sr.GetInt32(sr.GetOrdinal("BusinessTypeId"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }

/// <summary>
        /// Selects Site records by Site_SiteName
        /// </summary>
        public static SiteDO[] GetBySite_SiteName(String SiteName)
        {

            SqlParameter _SiteName = new SqlParameter("SiteName", SqlDbType.VarChar);
			
            _SiteName.Value = SiteName;
			
            SqlParameter[] _params = new SqlParameter[] {
                _SiteName
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[Site_GetBySite_SiteName]", _params, "dbo");

            List<SiteDO> objs = new List<SiteDO>();
			
            while(sr.Read())
            {
                SiteDO obj = new SiteDO();
				
                obj.SiteId = sr.GetInt32(sr.GetOrdinal("SiteId"));
                obj.SiteName = sr.GetString(sr.GetOrdinal("SiteName"));
                obj.CreatedDate = sr.GetDateTime(sr.GetOrdinal("CreatedDate"));
                obj.BusinessTypeId = sr.GetInt32(sr.GetOrdinal("BusinessTypeId"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the Site Table
        /// </summary>
        public static void Truncate()
        {
            DataCommon.TruncateTable("dbo", "Site");
        }

    }
}