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
    /// Encapsulates a row of data in the BusinessType table
    /// </summary>
    public partial class BusinessTypeDO
    {

        public virtual Int32 BusinessTypeId {get; set;}
        public virtual String Title {get; set;}
        public virtual String Description {get; set;}

    }
}