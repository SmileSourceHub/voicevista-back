using voicevista_back.DataAccess.Database.Models;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Models;

namespace voicevista_back.DataAccess.Database.Mappings

{
    public static class UserMapping
    {
        public static User ToDomain(this CreateRequestUser createRequestUser)
        {
            return new()
            {
                UserId = Random.Shared.Next(),
                Username = createRequestUser.Username,
                Password = createRequestUser.Password,
                Email = createRequestUser.Email,
            };
        }

        public static UserDto ToDto(this User user)
        {
            return new()
            {
                UserId = Random.Shared.Next(),
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
            };
        }
    }
}
