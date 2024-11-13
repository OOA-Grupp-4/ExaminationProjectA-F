using ExaminationProjectA_F.Business.Services;
using ExaminationProjectA_F.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationProjectA_F.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost]

        public async Task<IActionResult> Create(UserRegistrationForm form)
        {
            if (!ModelState.IsValid)
                return BadRequest(400);

            var result = await _userService.CreateUserAsync(form);
            if (result != null)
            {
                return Ok(result);
            }

            return Problem();
        }
    }
}
