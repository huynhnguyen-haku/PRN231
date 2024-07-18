using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Payload.Request;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Utils;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthenticationRequest request)
        {
            //Debug here
            Account account = DataSource.Accounts.FirstOrDefault(a => a.Email.Equals(request.Email) &&
                                                                       a.Password.Equals(request.Password));

            if (account == null) return BadRequest("Incorrect Email or Password");

            var token = JwtUtils.GenerateJwtToken(account);
            return Ok(token);
            //End debug here
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(AuthenticationRequest request)
        {
            Account account = DataSource.Accounts.FirstOrDefault(a => a.Email.Equals(request.Email));

            if (account != null) return BadRequest("The Email has already");

            Account newAccount = new Account()
            {
                AccountId = Guid.NewGuid(),
                FullName = String.Empty,
                Email = request.Email,
                Password = request.Password,
                Role = "Customer"
            };

            var token = JwtUtils.GenerateJwtToken(newAccount);
            return Ok(token);
        }

        [Authorize]
        [HttpGet("getAll")]
        public async Task<IActionResult> Test()
        {
            return Ok(DataSource.Accounts.ToList());
        }
    }
}
