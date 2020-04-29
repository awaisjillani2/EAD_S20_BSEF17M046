//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//using Microsoft.IdentityModel.Tokens;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;

//namespace webApi.Controllers
//{
//    public class ValuesController : ApiController
//    {


//        [HttpGet]
//        public object GetToken(String login, String pass)
//        {
//            Console.WriteLine(login);
//            string key = "my_secret_key_12345";
//            var issuer = "http://mysite.com";
//            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
//            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

//            var permClaims = new List<Claim>();
//            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
//            permClaims.Add(new Claim("valid", "1"));
//            permClaims.Add(new Claim("userid", "1"));
//            permClaims.Add(new Claim("name", "bilal"));

//            var token = new JwtSecurityToken(issuer,
//                            issuer,
//                            permClaims,
//                            expires: DateTime.Now.AddDays(1),
//                            signingCredentials: credentials);
//            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);
//            return new { data = jwt_token };


//        }


//        [HttpPost]
//        public String GetName1()
//        {
//            if (User.Identity.IsAuthenticated)
//            {
//                var identity = User.Identity as ClaimsIdentity;
//                if (identity != null)
//                {
//                    IEnumerable<Claim> claims = identity.Claims;
//                }
//                return "Valid";
//            }
//            else
//            {
//                return "Invalid";
//            }
//        }

//        [Authorize]
//        [HttpPost]
//        public Object GetName2()
//        {
//            var identity = User.Identity as ClaimsIdentity;
//            if (identity != null)
//            {
//                IEnumerable<Claim> claims = identity.Claims;
//                var name = claims.Where(p => p.Type == "name").FirstOrDefault()?.Value;
//                return new
//                {
//                    data = name
//                };

//            }

//            return null;
//        }
//    }
//}
