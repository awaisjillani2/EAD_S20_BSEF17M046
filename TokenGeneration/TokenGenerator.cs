using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TokenGeneration
{
    public class TokenGenerator
    {
        public object GetToken(String login,string name)
        {
            string key = "my_secret_key_12345";
            var issuer = "http://mysite.com";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permClaims.Add(new Claim("login", login));
            permClaims.Add(new Claim("name", name));

            var token = new JwtSecurityToken(
                issuer,
                issuer,
                permClaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

            return  jwt_token;
        }
    }
}
