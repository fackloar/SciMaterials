using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SciMaterials.DAL.AUTH.Interfaces;

namespace SciMaterials.Auth.Utilits;

public interface IAuthUtils : IAuthUtils<IdentityUser>
{ }

public class AuthUtils : IAuthUtils
{
    private readonly IConfiguration _configuration;
    private string _secretKey;

    public AuthUtils(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public string CreateSessionToken(IdentityUser user, IList<string> roles)
    {
        var config = _configuration.GetSection("SecretTokenKey");
        _secretKey = config["Key"];
        
        JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        
        byte[] key = Encoding.ASCII.GetBytes(_secretKey);

        //Claims
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id),
            new(ClaimTypes.Name, user.Email),
            new(ClaimTypes.Email, user.Email)
        };

        foreach (var role in roles)
        {
            claims.Add(new(ClaimTypes.Role, role));
        }

        var securityTokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims.ToArray()),
                
            Expires = DateTime.Now.AddMinutes(15),

            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
            
        SecurityToken securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

        return jwtSecurityTokenHandler.WriteToken(securityToken);
    }
}