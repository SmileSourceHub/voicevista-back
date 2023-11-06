using Cassandra;
using Cassandra.Mapping;
using voicevista_back.DataAccess.Database.Interfaces;
using voicevista_back.DataAccess.Database.Mappings;
using voicevista_back.DataAccess.Database.Models;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Models;

namespace voicevista_back.DataAccess.Database
{
    public class UserRepository : IUserRepository
    {
        private readonly Cassandra.ISession _client;
        public readonly static string _tableName = "users";
        private readonly string _keySpaceName;

        public UserRepository(IConfiguration configuration)
        {
            _keySpaceName = configuration["CassandraConfig:KeySpaceName"];
            var cluster = Cluster.Builder()
                     .AddContactPoints(configuration["CassandraConfig:HostName"])
                     .Build();

            // Connect to the nodes using a keyspace
            _client = cluster.Connect(_keySpaceName);
        }

        public async Task Upsert(UserDto user)
        {
            user.UserId = Guid.NewGuid();
            var mapper = new Mapper(_client);
            await mapper.UpdateAsync(user, );
        }

        public async Task<User> Find(string email)
        {
            var mapper = new Mapper(_client);
            UserDto? user;
            try
            {
                user = await mapper.SingleOrDefaultAsync<UserDto>("WHERE Email = ?", email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching user", ex);
            }

            return user?.ToDomain();
        }

        public async Task<bool> Challenge(string email, string password)
        {
            var mapper = new Mapper(_client);
            UserDto user;
            try
            {
                user = await mapper.SingleOrDefaultAsync<UserDto>("WHERE Email = ? AND Pwd = ?", email, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while challenging user", ex);
            }

            return user == null ? false : true;
        }
    }
}
