using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICurrentAccount.Services;

namespace WebAPICurrentAccount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInterface _userInterface;

        public UserController(IUserInterface userInterface) {

            _userInterface = userInterface;

        }

        [HttpGet]
        public async Task<IActionResult> SearchUser()
        {

            var user = await _userInterface.SearchUser();

            if (user.Situação == false)
            {
                return NotFound(user);
            }

            return Ok(user);
        }
    }
}
