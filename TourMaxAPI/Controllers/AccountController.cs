using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TourMaxAPI.ViewModel;

namespace TourMaxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<AccountController> _logger;
        private readonly UserManager<TourUser> _userManager;
        private readonly SignInManager<TourUser> _signInManager;
        public AccountController(IConfiguration configuration, ILogger<AccountController> logger, UserManager<TourUser> userManager, SignInManager<TourUser> signInManager)
        {
            _configuration = configuration;
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("/Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model, bool isPersistent)
        {
            //Log.Information("Call login action")
            isPersistent = false;
            _logger.LogInformation("Call Login action");
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            //var user = AuthenticateUser(model);
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent, true);
            if (result.Succeeded)
            {
                var token = GenerateAuthenticatedUserToken();
                return Ok(token);
            }
            return BadRequest(ModelState);
        }
        [HttpPost("/Register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = new TourUser();
            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.UserName = model.UserName;
            user.Created = DateTime.Now;

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //await _signInManager.SignInAsync(user, isPersistent : true);
                return Ok(result);
            }
            return BadRequest(ModelState);
     
        }
      

        private string GenerateAuthenticatedUserToken()
        {
            var signKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]));

            var credential = new SigningCredentials(signKey, SecurityAlgorithms.HmacSha256);
            var claim = new[]
            {
                new Claim(ClaimTypes.Name, " "),
                new Claim(ClaimTypes.Email, " "),
                new Claim(ClaimTypes.MobilePhone, " ")
            };
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"], claim, notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(30), credential).ToString();
            return token;


        }
    }
}
