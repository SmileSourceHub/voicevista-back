using voicevista_back.Application.User;

namespace voicevista_back.Infrastructure.User
{
    public interface IUserRepository
    {
        bool Create(Domain.User user);

        bool Find(CreateRequestUser createRequestUser);

        bool FindUserAndPassword(LoginRequestUser loginRequestUser);
    }
}
