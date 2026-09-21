using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using TaskBusinessLayer;
using TaskBusinessLayer.Security;
using TaskDTOs.DTOsLogin;

namespace Task_Managment_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        public IActionResult Login([FromBody] DTOLogin LoginRequest)
        {
            var User = Users.GetUserByEamil(LoginRequest.Email);

            if (User == null)
            {
                return Unauthorized("Invalid credentials");
            }

            bool isValidPassword = PasswordHasherService.VerifyPassword(User.Password, LoginRequest.Password);

            if (!isValidPassword)
            {
                return Unauthorized("Invalid credentials");
            }


            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,User.UserId.ToString()),
                new Claim(ClaimTypes.Email,User.Email),
                new Claim(ClaimTypes.Role,User.RoleInfo.Name)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(""));

            var cridet = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var token=new JwtSecurityToken(
                issuer :"TaskApi"
                ,audience : "TaskApiUser"
                ,claims:claims
                ,expires: DateTime.Now.AddMinutes(30)
                ,signingCredentials :cridet
                
                );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });

        }


    }
}
