using Microsoft.AspNetCore.Mvc;

namespace voicevista_back.Application.User
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRegisterService _userRegisterService;
        private readonly IUserLoginService _userLoginService;

        public UserController(IUserRegisterService userRegisterService, IUserLoginService userLoginService)
        {
            _userRegisterService = userRegisterService;
            _userLoginService = userLoginService;   
        }

        [HttpPost]
        [Route("/register")]
        public async Task<IActionResult> Index([FromBody] CreateRequestUser createRequestUser)
        {
            var userRegister = _userRegisterService.UserRegister(createRequestUser);
            return Ok(userRegister);
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Index([FromBody] LoginRequestUser loginRequestUser)
        {
            var userLogin = _userLoginService.UserLogin(loginRequestUser);
            return Ok(userLogin);
        }
    }
}
