using Microsoft.AspNetCore.Mvc;

namespace voicevista_back.Application.User
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserRegisterService _userRegisterService;

        public UserRegisterController(IUserRegisterService userRegisterService)
        {
            _userRegisterService = userRegisterService;
        }

        [HttpPost]
        [Route("/")]
        public async Task<IActionResult> Index([FromBody] CreateRequestUser createRequestUser)
        {
            var userRegister = _userRegisterService.UserRegister(createRequestUser);
            return Ok(userRegister);
        }
    }
}
