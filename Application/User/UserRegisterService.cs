namespace voicevista_back.Application.User
{
    public class UserRegisterService : IUserRegisterService
    {
        private static List<Domain.User> _users = new List<Domain.User>();
        public bool UserRegister(CreateRequestUser createRequestUser)
        {
            if (_users.Any(user => user.Username == createRequestUser.Username))
            {
                return false;
            }

            _users.Add(createRequestUser.ToDomain());
            return true;
        }
    }
}
