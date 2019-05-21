using Contracts.DTO;
using Contracts.Interface.Service;
using DataAccessContracts.Interface.DataAccess;
using Exceptions.BusinessExceptions;
using Exceptions.DataAccessExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AuthService : IAuthService
    {
        IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public UserDTO FindUser(string userName, string password)
        {
            var user = _authRepository.FindUser(userName, password);

            if (user == null)
                throw new WrongLoginOrPasswordException();

            return user.ToUserDTO();
        }
    }
}
