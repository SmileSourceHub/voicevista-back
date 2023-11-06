using voicevista_back.DataAccess.Database.Models;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Models;

namespace voicevista_back.DataAccess.Database.Interfaces
{
    public interface IUserRepository
    {
        Task Upsert(UserDto user);

        Task<User> Find(string email);

        Task<bool> Challenge(string email, string password);
    }
}
