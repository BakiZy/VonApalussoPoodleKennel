using FirstRealApp.Models;
using FirstRealApp.Models.DTO_models;
using FirstRealApp.Models.DTO_models.AdminDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FirstRealApp.Controllers
{

    [Authorize(Roles ="Admin")]
    
    [ApiController]
    [Route("api/[controller]")]


    public class AdminController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        AppDbContext context;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {

 
            _roleManager = roleManager;
            _userManager = userManager;
            _configuration = configuration;

        }

        [AllowAnonymous]
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
                UserName = model.Username


            };

            var result = _userManager.CreateAsync(user, model.Password).GetAwaiter().GetResult();

            if (!result.Succeeded)
            {
                return BadRequest("user creation failed");
            }

            if (!_roleManager.RoleExistsAsync(UserRoles.Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

            }

            if (_roleManager.RoleExistsAsync(UserRoles.Admin).GetAwaiter().GetResult())
            {
                _userManager.AddToRoleAsync(user, UserRoles.Admin).GetAwaiter().GetResult();
            }

           

            return Ok(result);


        }

   

        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("allroles")]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return Ok(roles);
        }



        [Authorize(Roles = "Admin")]
        [HttpPut("{name}")]
        public IActionResult EditRole(string name, EditRoleDTO model)
        {

            var role = _roleManager.FindByNameAsync(name).GetAwaiter().GetResult();

            if (role.Id != model.Id)
            {
                BadRequest();
            }
            else
            {
                role.Name = model.RoleName;
                var result = _roleManager.UpdateAsync(role).GetAwaiter().GetResult();

                if (result.Succeeded)
                {
                    return Ok(result);
                }
            }

         

         
            return Ok(model);

        }


        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public IActionResult EditUsersInRole(string roleId)
        {




            var role = _roleManager.FindByIdAsync(roleId).GetAwaiter().GetResult();

            if (role == null)
            {
                return BadRequest();
            }

            var model = new List<UserRoleDTO>();

            foreach (var user in _userManager.Users)
            {
                var userRole = new UserRoleDTO
                {
                    UserId = user.Id,
                    UserName = user.UserName,

                };

                if (_userManager.IsInRoleAsync(user, role.Name).GetAwaiter().GetResult())
                {
                    userRole.IsSelected = true;
                }
                else
                {
                    userRole.IsSelected = false;
                }
                model.Add(userRole);
            }

            return Ok(role);
        }
    }
}
