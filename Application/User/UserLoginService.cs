using voicevista_back.Infrastructure.User;

namespace voicevista_back.Application.User
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
            if (_userRepository.FindUserAndPassword(loginRequestUser))
            {
                return true;
            }

            return false;
        }

    }
}
