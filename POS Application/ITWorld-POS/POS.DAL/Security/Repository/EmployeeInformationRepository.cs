using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IEmployeeInformationRepository : IBaseRepository<EmployeeInformation>
    {
        List<USP_GetAllEmployeeInformation_Result> GetAllEmployeeInformation();
    }

    public class EmployeeInformationRepository : BaseRepository<EmployeeInformation, POS_Security>, IEmployeeInformationRepository
    {
        private readonly POS_Security _dbContextSecurity;

        public EmployeeInformationRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextSecurity = new POS_Security();
        }

        public List<USP_GetAllEmployeeInformation_Result> GetAllEmployeeInformation()
        {
            var query = new StringBuilder();
            query.Append("EXEC [Security].[USP_GetAllEmployeeInformation] ");

            return _dbContextSecurity.Database.SqlQuery<USP_GetAllEmployeeInformation_Result>(query.ToString()).ToList();
        }
    }
}
