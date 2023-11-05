using voicevista_back.Enpoints.Models;

namespace voicevista_back.Services.Interfaces
{
    public interface IUserRegisterService
    {
        bool UserRegister(CreateRequestUser createRequestUser);
    }
}
