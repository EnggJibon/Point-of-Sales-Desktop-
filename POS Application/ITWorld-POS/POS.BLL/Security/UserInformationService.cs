using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IUserInformationService : IBaseService<UserInformationModel, UserInformation>
    {
        List<UserInformationModel> GetAllUserInformation();
        List<UserInformationModel> GetAllUsers();
        UserInformationModel GetUserDetails(long? id, string username);
        UserInformationModel GetUser(long employeeId);
        long CreateUser(UserInformationModel userInformation);
        void UpdateUser(UserInformationModel userInformation);
        void ChangePassword(UserInformationModel userInformation);
    }

    public class UserInformationService : BaseService<UserInformationModel, UserInformation>, IUserInformationService
    {
        private readonly IUserInformationRepository _userInformationRepository;

        public UserInformationService(IUserInformationRepository userInformationRepository)
            : base(userInformationRepository)
        {
            _userInformationRepository = userInformationRepository;
        }

        public List<UserInformationModel> GetAllUserInformation()
        {
            var users = _userInformationRepository.GetAllUserInformation();
            return Mapper.Map<List<UserInformationModel>>(users);
        }

        public List<UserInformationModel> GetAllUsers()
        {
            var users = _userInformationRepository.GetAllUsers();
            return Mapper.Map<List<UserInformationModel>>(users);
        }

        public UserInformationModel GetUserDetails(long? id, string username)
        {
            var user = _userInformationRepository.GetUserDetails(id, username);
            return Mapper.Map<UserInformationModel>(user);
        }

        public UserInformationModel GetUser(long employeeId)
        {
            var user = _userInformationRepository.GetUser(employeeId);
            return Mapper.Map<UserInformationModel>(user);
        }

        public long CreateUser(UserInformationModel userInformation)
        {
            userInformation.Password = Authenticator.GetHashPassword(userInformation.Password);
            return Insert(userInformation);
        }

        public void UpdateUser(UserInformationModel userInformation)
        {
            _userInformationRepository.UpdateUser(Mapper.Map<UserInformation>(userInformation));
        }

        public void ChangePassword(UserInformationModel userInformation)
        {
            var userFromDatabase = GetById(userInformation.Id);

            if (Authenticator.ValidatePassword(userInformation.OldPassword, userFromDatabase.Password))
            {
                userFromDatabase.Password = Authenticator.GetHashPassword(userInformation.NewPassword);
                userFromDatabase.IsPasswordChanged = true;
                _userInformationRepository.UpdateUserPassword(Mapper.Map<UserInformation>(userFromDatabase));
            }
        }
    }
}
