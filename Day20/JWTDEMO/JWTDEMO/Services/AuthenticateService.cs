using JWTDEMO.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace JWTDEMO.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly AppSettings _appSettings;
       public AuthenticateService(IOptions<AppSettings> appSettings) 
       {
             _appSettings = appSettings.Value;
       }
        private List<User> users = new List<User>()
        {
            new User{UserId=1,FirstName="shivam",LastName="Vishwakarma",UserName="Shivam150",Password = "Shivam@123"}
        };

        public User Authenticate(string userName, string password)
        {
            var user = users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
            // return null it user is not found
            if (user == null) return null;
            // If user is found
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Key);
            var tokenDiscriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name,user.UserId.ToString()),
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Version,"V3.1")
            }),
                Expires = DateTime.UtcNow.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDiscriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.Password = null;
            return user;
        }

    }
}
