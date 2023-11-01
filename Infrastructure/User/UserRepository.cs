using voicevista_back.Application.User;

namespace voicevista_back.Infrastructure.User
{
    public class UserRepository : IUserRepository
    {
        public static List<Domain.User> _users = new List<Domain.User>();

        public bool Create(Domain.User user)
        {
            if (user == null)
            {
                return false;
            }

            _users.Add(user);

            return true;
        }

        public bool Find(CreateRequestUser createRequestUser)
        {
            if (_users.Any(user => user.Email == createRequestUser.Email))
            {
                return true;
            }

            return false;
        }

        public bool FindUserAndPassword(LoginRequestUser loginRequestUser)
        {
            if (_users.Any(user => user.Email == loginRequestUser.Email && user.Password == loginRequestUser.Password))
            {
                return true;
            }

            return false;
        }
    }
}
