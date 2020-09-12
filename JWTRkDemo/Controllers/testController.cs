using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JWTRkDemo.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            //comment added in jwtdev branch
            return View();
        }
    }
}
