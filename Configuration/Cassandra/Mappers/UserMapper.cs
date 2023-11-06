using Cassandra.Mapping;
using voicevista_back.DataAccess.Database;
using voicevista_back.DataAccess.Database.Models;

namespace voicevista_back.Configuration.Cassandra.Mappers
{
    public static class UserMapper
    {
        public static Map<UserDto> GetMap()
        {
            return new Map<UserDto>()
                .TableName(UserRepository._tableName)
                .PartitionKey("UserId", "Email");
        }
    }
}
