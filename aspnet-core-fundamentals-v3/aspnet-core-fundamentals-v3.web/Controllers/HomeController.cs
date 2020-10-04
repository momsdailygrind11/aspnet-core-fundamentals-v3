using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_fundamentals_v3.web.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerData _customerData;

        public HomeController(ICustomerData customerData)
        {
            _customerData = customerData;
        }

        public IActionResult Index()
        {
            var model = _customerData.GetAll();
            return View(model);
        }
      
    


    }
}
