﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace johnsommerville.com
{
    [Route("[controller]/[action]")]

    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnUrl = "/AccountInfo")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }
    }
}
