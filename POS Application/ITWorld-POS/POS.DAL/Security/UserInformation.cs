//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DAL.Security
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInformation
    {
        public UserInformation()
        {
            this.AdditionalOperationPermissions = new HashSet<AdditionalOperationPermission>();
            this.AdditionalScreenPermissions = new HashSet<AdditionalScreenPermission>();
        }
    
        public long Id { get; set; }
        public long UserTypeId { get; set; }
        public long EmployeeId { get; set; }
        public Nullable<long> RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> PasswordAgeLimit { get; set; }
        public bool IsPasswordChanged { get; set; }
        public bool IsLocked { get; set; }
        public Nullable<System.DateTime> LastPasswordChangedDate { get; set; }
        public Nullable<System.DateTime> LastLockedDate { get; set; }
        public Nullable<int> WrongPasswordTryLimit { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
    
        public virtual ICollection<AdditionalOperationPermission> AdditionalOperationPermissions { get; set; }
        public virtual ICollection<AdditionalScreenPermission> AdditionalScreenPermissions { get; set; }
        public virtual Role Role { get; set; }
        public virtual UserType UserType { get; set; }
    }
}