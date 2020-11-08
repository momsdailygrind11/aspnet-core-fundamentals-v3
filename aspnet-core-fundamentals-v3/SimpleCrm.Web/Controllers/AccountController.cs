using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCrm.Web.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCrm.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Register(RegisterUserViewModel model)
        {
            return NoContent(); //TODO: validate model, register the user
        }
    }
}
