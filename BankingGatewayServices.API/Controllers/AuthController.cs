using BankingGatewayServices.Application.Dtos.AuthDtos;
using BankingGatewayServices.Application.IServices;
using BankingGatewayServices.Domain.Database.BankClientDB;
using BankingGatewayServices.Persistence.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BankingGatewayServices.API.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AuthController : BaseController
    {
        private readonly UserManager<Clientes> _userManager;
        private readonly SignInManager<Clientes> _signInManager;
        private readonly ITokenServices _token;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserService _userService;

        public AuthController(UserManager<Clientes> userManager, SignInManager<Clientes> signInManager,
                              ITokenServices token, RoleManager<IdentityRole> roleManager , IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _token = token;
            _roleManager = roleManager;
            _userService = userService;
        }

        [HttpPost("Login")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if (user == null) {
                await Task.Delay(100); // Introduce slight delay to mitigate timing attacks
                return Unauthorized(new ApiResponse(401 , "Invalid credentials."));
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (!signInResult.Succeeded) {
                await Task.Delay(500); 
                return Unauthorized(new ApiResponse(401, "Invalid credentials."));
            }

            var token = await _token.CreateToken(user, _userManager);

            return Ok(new UserDto(user.DisplayName, loginDto.Email, token));
        }


        [HttpPost("Register")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiValidationErrorResponse), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            if (CheckEmailExists(registerDto.Email).Result.Value)
                return BadRequest(new ApiValidationErrorResponse
                {
                    Errors = new[] { "This email already exists." }
                });

            var roleResult = await _roleManager.CreateAsync(new IdentityRole("Visitor"));

            var user = _userService.CreateUserFromDto(registerDto);

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded) return BadRequest(new ApiResponse(400));

            return Ok(new UserDto(registerDto.DisplayName, registerDto.Email, await _token.CreateToken(user, _userManager)));
        }


        [HttpGet("CheckEmailExists")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> CheckEmailExists(string Email)
        {
            var userExists = await _userManager.FindByEmailAsync(Email) != null;
            if (!userExists ) return BadRequest(new ApiResponse(400, "Invalid email format."));
            return Ok(!userExists);
        }

        [RequireHttps]
        [Authorize]
        [HttpGet("GetCurrentUser")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var Email = User.FindFirstValue(ClaimTypes.Email);

            if (Email == null) 
                return BadRequest(new ApiResponse(400, "Email claim is missing."));

            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
                return NotFound(new ApiResponse(404 ,"User not found."));

            return Ok(new UserDto(user.DisplayName, Email, await _token.CreateToken(user, _userManager)));
        }



    }
}
