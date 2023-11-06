namespace voicevista_back.DataAccess.Database.Models
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
    }
}
