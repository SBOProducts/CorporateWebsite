// CREATED BY: Nathan Townsend
// CREATED DATE: 4/29/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.ComponentModel.DataAnnotations;

namespace SBO.DAL.DO.dbo
{
    /// <summary>
    /// Encapsulates a row of data in the User table
    /// </summary>
    public partial class UserDO
    {

        public virtual Int32 UserId {get; set;}
        public virtual String Name {get; set;}
        public virtual String Email {get; set;}
        public virtual String Phone {get; set;}
        public virtual String Login {get; set;}
        public virtual String PasswordHash {get; set;}
        public virtual DateTime Created {get; set;}
        public virtual DateTime LastAccessed {get; set;}

    }
}