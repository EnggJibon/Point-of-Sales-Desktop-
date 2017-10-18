using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IScreenOperationService : IBaseService<ScreenOperationModel, ScreenOperation>
    {
        List<ScreenOperationModel> GetScreenOperationDetailsList(long? id, long? screenId);
    }

    public class ScreenOperationService : BaseService<ScreenOperationModel, ScreenOperation>, IScreenOperationService
    {
        private readonly IScreenOperationRepository _screenOperationRepository;

        public ScreenOperationService(IScreenOperationRepository screenOperationRepository)
            : base(screenOperationRepository)
        {
            _screenOperationRepository = screenOperationRepository;
        }

        public List<ScreenOperationModel> GetScreenOperationDetailsList(long? id, long? screenId)
        {
            var screenOperationDetailsList = _screenOperationRepository.GetScreenOperationDetails(id, screenId);
            return Mapper.Map<List<ScreenOperationModel>>(screenOperationDetailsList);
        }
    }
}
