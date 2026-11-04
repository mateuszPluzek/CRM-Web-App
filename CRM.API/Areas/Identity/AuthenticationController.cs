using CRM.Model.InputModels;
using CRM.Service.IService;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CRM.API.Areas.Identity
{
    [Area("Identity")]
    [DisplayName("Authentication Controller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        [DisplayName("Login")]
        public async Task<IActionResult> Login([FromBody] ApplicationUserLoginInputModel model)
        {
            var response = await _authenticationService.LoginAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("register")]
        [DisplayName("Register")]
        public async Task<IActionResult> Register([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await _authenticationService.RegisterAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("forgot-password")]
        [DisplayName("Forgot Password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await _authenticationService.ForgotPasswordAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("reset-password")]
        [DisplayName("Reset Password")]
        public async Task<IActionResult> ResetPassword([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await _authenticationService.ResetPasswordAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("change-password")]
        [DisplayName("Change Password")]
        public async Task<IActionResult> ChangePassword([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await _authenticationService.ChangePasswordAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }

        [HttpPost("refresh-token")]
        [DisplayName("Refresh Token")]
        public async Task<IActionResult> RefreshToken([FromBody] ApplicationUserRegisterInputModel model)
        {
            var response = await _authenticationService.RefreshTokenAsync(model);
            return response ? Ok(response) : StatusCode(500);
        }



    }
}
