using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using Assignment3.Entities;
using Assignment3.BAL;

namespace webApi.Controllers
{
    [EnableCors(origins: "https://localhost:44368", headers: "*", methods: "*")]

    public class userApiController : ApiController
    {
        [HttpPost]
        public int SaveUser(UserDTO dto)
        {
            var result = UserBO.SaveUser(dto);
            return result;
        }
    }
}


//            if (Assignment3.BAL.UserBO.SaveUser()!=0)
//            {
//                BAL.BO.insertUser(name, login, pass);
//                string key = "my_secret_key_12345";
//                var issuer = "http://mysite.com";
//                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
//                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

//                var permClaims = new List<Claim>();
//                permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
//                permClaims.Add(new Claim("valid", "1"));
//                permClaims.Add(new Claim("userid", login));
//                permClaims.Add(new Claim("pass", pass));

//                var token = new JwtSecurityToken(issuer,
//                                issuer,
//                                permClaims,
//                                expires: DateTime.Now.AddDays(1),
//                                signingCredentials: credentials);
//                var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

//                return new { data = jwt_token };
//            }
//            else
//                return new { data = "Invalid" };
//        }
//        [Authorize]
//        [HttpGet]
//        public object getChildFolders(int pId)
//        {
//            var list = BAL.BO.getChildFolders(pId);
//            return list;
//        }
//        public static Boolean checkName(String fname, Int32 pId)
//        {
//            return BAL.BO.checkName(fname, pId);
//        }
//        [Authorize]
//        [HttpGet]
//        public object createFolder(String folderName, Int32 parentId)
//        {
//            if (checkName(folderName, parentId) == false)
//            {
//                BAL.BO.createFolder(folderName, parentId);
//                var h = new
//                {
//                    msg = "Succesfull Created"
//                };
//                return h;
//            }
//            else
//            {
//                var h = new
//                {
//                    msg = "sameNameNotAllowed"
//                };
//                return h;
//            }


//        }
//        [HttpGet]
//        public int sum(std std)
//        {
//            return std.temp;
//        }
//        //[Authorize]
//        [HttpGet]
//        public int test()
//        {
//            return 1;
//        }
//    }
//    public class std
//    {
//        public int temp { get; set; }
//    }
//}
