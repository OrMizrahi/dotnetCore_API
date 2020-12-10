using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using zigit.Data;
using zigit.Models;

namespace zigit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        private readonly IProjectRepo _projectRepo;

        public UserController(IUserRepo userRepo, IProjectRepo projectRepo)
        {
            _userRepo = userRepo;
            _projectRepo = projectRepo;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserCred userCred)
        {
            var token = _userRepo.Login(userCred.Email, userCred.Password);

            if (token == null)
                return Unauthorized("Wrong Credentials. check your password and email, and make sure you are registered.");

            return Ok(token);
        }

        [Authorize]
        [HttpGet("projects")]
        public ActionResult<Project> GetUserProject()
        {
            var currentUserEmail = User.FindFirstValue(ClaimTypes.Email);
            var currentUser = _userRepo.GetUserByEmail(currentUserEmail);
            if (currentUser == null)
                return null;
            
            return _projectRepo.GetProjectById(currentUser.ProjectId);
        }

        [HttpGet("notauthorized")]
        public IActionResult NotAuthorized()
        {
            return Unauthorized("You must Include a bearer token to access this endpoint. If token was provided, the token is not correct");
        }
    }
}
