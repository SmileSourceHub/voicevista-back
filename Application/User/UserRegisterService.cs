using voicevista_back.Infrastructure.User;

namespace voicevista_back.Application.User
{
    public class UserRegisterService : IUserRegisterService
    {
        private readonly IUserRepository _userRepository;

        public UserRegisterService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool UserRegister(CreateRequestUser createRequestUser)
        {
            if (_userRepository.Find(createRequestUser))
            {
                return false;
            }

            _userRepository.Create(createRequestUser.ToDomain());
            return true;
        }
    }
}
