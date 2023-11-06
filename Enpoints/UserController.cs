using Microsoft.AspNetCore.Mvc;
using voicevista_back.Enpoints.Models;
using voicevista_back.Services.Interfaces;

namespace voicevista_back.Enpoints
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("/register")]
        public async Task<IActionResult> Index([FromBody] CreateRequestUser createRequestUser)
        {
            await _userService.UserRegister(createRequestUser);
            return Ok("Upsert done");
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Index([FromBody] LoginRequestUser loginRequestUser)
        {
            var userLogin = await _userService.UserLogin(loginRequestUser);
            return Ok(userLogin);
        }

        [HttpPost]
        [Route("/find")]
        public async Task<IActionResult> Index([FromBody] string email)
        {
            var userLogin = await _userService.FindUser(email);
            return Ok(userLogin);
        }
    }
}
