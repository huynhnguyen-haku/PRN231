using Microsoft.IdentityModel.Tokens;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Utils
{
    public class JwtUtils
    {
        public static string GenerateJwtToken(Account account)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var key = config["Jwt:Key"];
            var issuer = config["Jwt:Issuer"];
            var audience = config["Jwt:Audience"];

            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();

            //Here is secret key
            SymmetricSecurityKey secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Jti, account.AccountId.ToString()),
                new Claim("Email", account.Email),
                new Claim(ClaimTypes.Role, account.Role)
            };

            //Add expiredTime of token
            var expires = DateTime.Now.AddMinutes(30);

            //Create token
            var token = new JwtSecurityToken(issuer, audience, claims, notBefore: DateTime.Now, expires, credentials);
            return jwtHandler.WriteToken(token);
        }
    }
}
