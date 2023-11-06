using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Models;

namespace voicevista_back.Services.Interfaces
{
    public interface IUserService
    {
        Task UserRegister(CreateRequestUser createRequestUser);

        Task<bool> UserLogin(LoginRequestUser loginRequestUser);

        Task<User> FindUser(string email);
    }
}
