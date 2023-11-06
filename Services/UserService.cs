using voicevista_back.DataAccess.Database.Interfaces;
using voicevista_back.DataAccess.Database.Mappings;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Interfaces;
using voicevista_back.Services.Models;

namespace voicevista_back.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task UserRegister(CreateRequestUser createRequestUser)
        {
            var user = createRequestUser.ToDomain();

            await _userRepository.Upsert(user.ToDto());
        }

        public async Task<bool> UserLogin(LoginRequestUser loginRequestUser)
        {
            if (await _userRepository.Challenge(loginRequestUser.Email, loginRequestUser.Password))
            {
                return true;
            }

            return false;
        }

        public async Task<User> FindUser(string email)
        {
            return await _userRepository.Find(email);
        }
    }
}
