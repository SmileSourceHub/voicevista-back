namespace voicevista_back.Application.User
{
    public interface IUserLoginService
    {
        bool UserLogin(LoginRequestUser loginRequestUser);
    }
}
