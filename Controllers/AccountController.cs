using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class AccountController : Controller
    {
        [Route("signup")]
        public IActionResult signup()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public IActionResult signup(SignUpUserModel userModel)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
