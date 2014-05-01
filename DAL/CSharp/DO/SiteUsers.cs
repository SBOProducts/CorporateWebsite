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
    /// Encapsulates a row of data in the SiteUsers table
    /// </summary>
    public partial class SiteUsersDO
    {

        public virtual Int32 UserId {get; set;}
        public virtual Int32 SiteId {get; set;}
        public virtual DateTime Added {get; set;}
        public virtual String Roles {get; set;}

    }
}