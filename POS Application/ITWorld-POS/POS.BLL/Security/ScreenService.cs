using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IScreenService : IBaseService<ScreenModel, Screen>
    {
        //List<SelectListItem> GetScreenTypeList();

        List<ScreenModel> GetScreenList(long? id, long? moduleId);
    }

    public class ScreenService : BaseService<ScreenModel, Screen>, IScreenService
    {
        private readonly IScreenRepository _screenRepository;

        public ScreenService(IScreenRepository screenRepository)
            : base(screenRepository)
        {
            _screenRepository = screenRepository;
        }

        //public List<SelectListItem> GetScreenTypeList()
        //{
        //    return new List<SelectListItem>
        //    {
        //        new SelectListItem
        //        {
        //            Text = "Screen",
        //            Value = "S"
        //        },
        //        new SelectListItem
        //        {
        //            Text = "Report",
        //            Value = "R"
        //        }
        //    };
        //}

        public List<ScreenModel> GetScreenList(long? id, long? moduleId)
        {
            var screenList = _screenRepository.GetScreens(id, moduleId);
            return Mapper.Map<List<ScreenModel>>(screenList);
        }

    }
}
