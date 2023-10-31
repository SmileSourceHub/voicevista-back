namespace voicevista_back.Application.User
{
    public interface IUserRegisterService
    {
        bool UserRegister(CreateRequestUser createRequestUser);
    }
}
