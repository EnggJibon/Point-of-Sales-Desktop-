using System;
using POS.UTILS.Infrastructure;

namespace POS.BLL.Security.Domain
{
    public class UserInformationModel : BaseDomainModel<UserInformationModel>
    {
        public long UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public long? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public long? DesignationId { get; set; }
        public string DesignationName { get; set; }
        public long? RoleId { get; set; }
        public string RoleName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? PasswordAgeLimit { get; set; }
        public bool IsPasswordChanged { get; set; }
        public bool IsLocked { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public DateTime? LastLockedDate { get; set; }
        public int? WrongPasswordTryLimit { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
