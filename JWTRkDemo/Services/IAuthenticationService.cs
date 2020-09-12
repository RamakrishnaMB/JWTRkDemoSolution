using JWTRkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTRkDemo.Services
{
    public interface IAuthenticationService
    {
        User Authenticate(string userName, string passWord);
    }
}
