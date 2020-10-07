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
        private ICustomerData _customerData;
        private readonly IGreeter _greeter;

        public HomeController(ICustomerData customerData,
            IGreeter greeter)
        {
            _customerData = customerData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Customers = _customerData.GetAll();
            model.CurrentMessage = _greeter.GetGreeting();
            return View(model);
        }
        public IActionResult Details(int id)
        {
           Customer cust = _customerData.Get(id);
            if(cust == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(cust);
        }
        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost()]
        public IActionResult Create(Customer model)
        {
            var customer = new Customer
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                OptInNewsletter = model.OptInNewsletter,
                Type = model.Type
            };
            _customerData.Save(customer);

            return RedirectToAction(nameof(Details), new { id = customer.Id });
        }







    }
}
