using voicevista_back.DataAccess.Database.Models;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Models;

namespace voicevista_back.DataAccess.Database.Interfaces
{
    public interface IUserRepository
    {
        bool Create(UserDto user);

        bool Find(string email);

        bool Challenge(string email, string password);
    }
}
