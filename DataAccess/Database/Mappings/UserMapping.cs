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
                UserId = Guid.Empty,
                Username = createRequestUser.Username,
                Password = createRequestUser.Password,
                Email = createRequestUser.Email,
            };
        }

        public static UserDto ToDto(this User user)
        {
            return new()
            {
                UserId = user.UserId,
                Username = user.Username,
                Pwd = user.Password,
                Email = user.Email,
            };
        }

        public static User ToDomain(this UserDto userDto)
        {
            return new()
            {
                UserId = userDto.UserId,
                Username = userDto.Username,
                Password = userDto.Pwd,
                Email = userDto.Email,
            };
        }
    }
}
