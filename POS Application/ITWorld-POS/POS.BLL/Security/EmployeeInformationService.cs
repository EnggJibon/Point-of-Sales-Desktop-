using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IEmployeeInformationService : IBaseService<EmployeeInformationModel, EmployeeInformation>
    {
        List<EmployeeInformationModel> GetAllEmployeeInformation();
    }

    public class EmployeeInformationService : BaseService<EmployeeInformationModel, EmployeeInformation>, IEmployeeInformationService
    {
        private readonly IEmployeeInformationRepository _employeeInformationRepository;

        public EmployeeInformationService(IEmployeeInformationRepository employeeInformationRepository)
            : base(employeeInformationRepository)
        {
            _employeeInformationRepository = employeeInformationRepository;
        }

        public List<EmployeeInformationModel> GetAllEmployeeInformation()
        {
            var employeeList = _employeeInformationRepository.GetAllEmployeeInformation();
            return Mapper.Map<List<EmployeeInformationModel>>(employeeList);
        }
    }
}
