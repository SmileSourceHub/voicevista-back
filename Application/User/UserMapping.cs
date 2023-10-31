namespace voicevista_back.Application.User
{
    public static class UserMapping
    {
        public static Domain.User ToDomain(this CreateRequestUser createRequestUser)
        {
            return new()
            {
                UserId = Random.Shared.Next(),
                Username = createRequestUser.Username,
                Password = createRequestUser.Password,
                Email = createRequestUser.Email,
            };
        }
    }
}
