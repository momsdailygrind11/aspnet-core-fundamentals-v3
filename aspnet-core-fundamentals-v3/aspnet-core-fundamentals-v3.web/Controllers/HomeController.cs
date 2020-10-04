using aspnet_core_fundamentals_v3.web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_fundamentals_v3.web.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            var model = new CustomerModel
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "432-987-5555"
            };
            return View(model);
        }
      
    


    }
}
