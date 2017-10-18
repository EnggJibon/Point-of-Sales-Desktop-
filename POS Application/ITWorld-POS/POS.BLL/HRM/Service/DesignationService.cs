using POS.BLL.HRM.Domain;
using POS.DAL.HRM;
using POS.DAL.HRM.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.HRM.Service
{
    public partial interface IDesignationService : IBaseService<DesignationModel, Designation>
    {
    }

    public class DesignationService : BaseService<DesignationModel, Designation>, IDesignationService
    {
        private readonly IDesignationRepository _designationRepository;

        public DesignationService(IDesignationRepository designationRepository)
            : base(designationRepository)
        {
            _designationRepository = designationRepository;
        }
    }
}
