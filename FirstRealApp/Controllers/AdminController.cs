using FirstRealApp.Models;
using FirstRealApp.Models.DTO_models;
using FirstRealApp.Models.DTO_models.AdminDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FirstRealApp.Controllers
{

    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]


    public class AdminController : ControllerBase
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;


        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {


            _roleManager = roleManager;
            _userManager = userManager;
            _configuration = configuration;

        }

        [HttpPost]
        [Route("register-admin")]

        public IActionResult RegisterAdmin([FromBody] RegisterDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Registration parameters invalid.");
            }

            var userExists = _userManager.FindByNameAsync(model.Username).GetAwaiter().GetResult();

            if (userExists != null)
            {
                return BadRequest("User already exists");
            }

            ApplicationUser user = new()
            {

                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username,



            };

            var result = _userManager.CreateAsync(user, model.Password).GetAwaiter().GetResult();

            if (!result.Succeeded)
            {
                return BadRequest("user creation failed");
            }

            if (!_roleManager.RoleExistsAsync(UserRole.Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(UserRole.Admin)).GetAwaiter().GetResult();

            }



            if (_roleManager.RoleExistsAsync(UserRole.Admin).GetAwaiter().GetResult())
            {
                _userManager.AddToRoleAsync(user, UserRole.Admin).GetAwaiter().GetResult();
            }

            return Ok(result);


        }




        [HttpPost]
        [Route("create-role")]
        public IActionResult CreateRole([FromBody] CreateRoleDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityRole role = new IdentityRole
            {
                Name = model.RoleName
            };

            IdentityResult result = _roleManager.CreateAsync(role).GetAwaiter().GetResult();

            return Ok(result);

        }


        [HttpGet]
        [Route("allroles")]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return Ok(roles);
        }

        [HttpGet]
        [Route("list-users")]
        public IActionResult ListAllUsers()
        {
            var users = _userManager.Users;
            return Ok(users);
        }



    }
}