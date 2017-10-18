using System;
using POS.UTILS.Infrastructure;

namespace POS.BLL.Security.Domain
{
    public class EmployeeInformationModel : BaseDomainModel<EmployeeInformationModel>
    {
        public string EmployeeCode { get; set; }
        public long DepartmentId { get; set; }
        public long DesignationId { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public string NationalId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
    }
}

