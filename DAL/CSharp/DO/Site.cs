// CREATED BY: Nathan Townsend
// CREATED DATE: 5/1/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.ComponentModel.DataAnnotations;

namespace SBO.DAL.DO.dbo
{
    /// <summary>
    /// Encapsulates a row of data in the Site table
    /// </summary>
    public partial class SiteDO
    {

        public virtual Int32 SiteId {get; set;}
        public virtual String SiteName {get; set;}
        public virtual DateTime CreatedDate {get; set;}
        public virtual Int32 BusinessTypeId {get; set;}

    }
}