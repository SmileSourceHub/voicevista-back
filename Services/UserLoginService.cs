using voicevista_back.DataAccess.Database.Interfaces;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Interfaces;

namespace voicevista_back.Services
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IUserRepository _userRepository;

        public UserLoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool UserLogin(LoginRequestUser loginRequestUser)
        {
            if (_userRepository.Challenge(loginRequestUser.Email, loginRequestUser.Password))
            {
                return true;
            }

            return false;
        }

    }
}
