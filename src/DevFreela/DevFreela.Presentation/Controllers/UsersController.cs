using DevFreela.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Presentation.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] CreateUserModel createUser)
        {
            return CreatedAtAction(nameof(GetById), new { id= 1 }, createUser);
        }

        [HttpPost]
        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
