using voicevista_back.DataAccess.Database.Interfaces;
using voicevista_back.DataAccess.Database.Mappings;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Interfaces;
using voicevista_back.Services.Models;

namespace voicevista_back.Services
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
            var user = createRequestUser.ToDomain();

            if (_userRepository.Find(user.Email))
            {
                return false;
            }

            _userRepository.Create(user.ToDto());
            return true;
        }
    }
}
