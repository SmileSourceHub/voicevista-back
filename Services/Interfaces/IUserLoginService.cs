using voicevista_back.Enpoints.Models;

namespace voicevista_back.Services.Interfaces
{
    public interface IUserLoginService
    {
        bool UserLogin(LoginRequestUser loginRequestUser);
    }
}
