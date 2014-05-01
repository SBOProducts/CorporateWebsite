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
    /// Provides data access methods for the BusinessType database table
    /// </summary>
    /// <remarks>
    public partial class BusinessType
    {
        
        /// <summary>
        /// Creates a new BusinessType record
        /// </summary>
        public static int Create(BusinessTypeDO DO)
        {
            SqlParameter _Title = new SqlParameter("Title", SqlDbType.VarChar);
            SqlParameter _Description = new SqlParameter("Description", SqlDbType.VarChar);
            
            _Title.Value = DO.Title;
            _Description.Value = DO.Description;
            
            SqlParameter[] _params = new SqlParameter[] {
                _Title,
                _Description
            };

            return DataCommon.ExecuteScalar("[dbo].[BusinessType_Insert]", _params, "dbo");
            
        }


        /// <summary>
        /// Updates a BusinessType record and returns the number of records affected
        /// </summary>
        public static int Update(BusinessTypeDO DO)
        {
            SqlParameter _BusinessTypeId = new SqlParameter("BusinessTypeId", SqlDbType.Int);
            SqlParameter _Title = new SqlParameter("Title", SqlDbType.VarChar);
            SqlParameter _Description = new SqlParameter("Description", SqlDbType.VarChar);
            
            _BusinessTypeId.Value = DO.BusinessTypeId;
            _Title.Value = DO.Title;
            _Description.Value = DO.Description;
            
            SqlParameter[] _params = new SqlParameter[] {
                _BusinessTypeId,
                _Title,
                _Description
            };

            return DataCommon.ExecuteScalar("[dbo].[BusinessType_Update]", _params, "dbo");
        }


        /// <summary>
        /// Deletes a BusinessType record
        /// </summary>
        public static int Delete(BusinessTypeDO DO)
        {
            SqlParameter _BusinessTypeId = new SqlParameter("BusinessTypeId", SqlDbType.Int);
            
            _BusinessTypeId.Value = DO.BusinessTypeId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _BusinessTypeId
            };

            return DataCommon.ExecuteScalar("[dbo].[BusinessType_Delete]", _params, "dbo");
        }


        /// <summary>
        /// Gets all BusinessType records
        /// </summary>
        public static BusinessTypeDO[] GetAll()
        {
            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[BusinessType_GetAll]", new SqlParameter[] { }, "dbo");
            
            List<BusinessTypeDO> objs = new List<BusinessTypeDO>();
            
            while(sr.Read()){

                BusinessTypeDO obj = new BusinessTypeDO();
                
                obj.BusinessTypeId = sr.GetInt32(sr.GetOrdinal("BusinessTypeId"));
                obj.Title = sr.GetString(sr.GetOrdinal("Title"));
                obj.Description = sr.GetString(sr.GetOrdinal("Description"));
                


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects BusinessType records by PK
        /// </summary>
        public static BusinessTypeDO[] GetByPK(Int32 BusinessTypeId)
        {

            SqlParameter _BusinessTypeId = new SqlParameter("BusinessTypeId", SqlDbType.Int);
			
            _BusinessTypeId.Value = BusinessTypeId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _BusinessTypeId
            };

            SafeReader sr = DataCommon.ExecuteSafeReader("[dbo].[BusinessType_GetByPK]", _params, "dbo");

            List<BusinessTypeDO> objs = new List<BusinessTypeDO>();
			
            while(sr.Read())
            {
                BusinessTypeDO obj = new BusinessTypeDO();
				
                obj.BusinessTypeId = sr.GetInt32(sr.GetOrdinal("BusinessTypeId"));
                obj.Title = sr.GetString(sr.GetOrdinal("Title"));
                obj.Description = sr.GetString(sr.GetOrdinal("Description"));
                

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the BusinessType Table
        /// </summary>
        public static void Truncate()
        {
            DataCommon.TruncateTable("dbo", "BusinessType");
        }

    }
}