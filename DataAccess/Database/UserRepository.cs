using voicevista_back.DataAccess.Database.Interfaces;
using voicevista_back.DataAccess.Database.Models;
using voicevista_back.Enpoints.Models;

namespace voicevista_back.DataAccess.Database
{
    public class UserRepository : IUserRepository
    {
        private static List<UserDto> _users = new();

        public bool Create(UserDto user)
        {
            if (user == null)
            {
                return false;
            }

            _users.Add(user);

            return true;
        }

        public bool Find(string email)
        {
            if (_users.Any(user => user.Email == email))
            {
                return true;
            }

            return false;
        }

        public bool Challenge(string email, string password)
        {
            if (_users.Any(user => user.Email == email && user.Password == password))
            {
                return true;
            }

            return false;
        }
    }
}
