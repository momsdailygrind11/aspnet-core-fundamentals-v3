using SimpleCrm.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ICustomerData _customerData;
       

        public HomeController(ICustomerData customerData)
        {
            _customerData = customerData;
           
        }
        [AllowAnonymous]

        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Customers = _customerData.GetAll();
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
        public IActionResult Edit(int id)
        {
            var customer = _customerData.Get(id);
            if(customer == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var model = new CustomerEditViewModel
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                OptInNewsletter = customer.OptInNewsletter,
                Type = customer.Type

            };
            return View(model);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public IActionResult Edit(CustomerEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = _customerData.Get(model.Id);
                if (customer == null)
                {   
                    return RedirectToAction(nameof(Index));
                }

                customer.FirstName = model.FirstName;
                customer.LastName = model.LastName;
                customer.PhoneNumber = model.PhoneNumber;
                customer.OptInNewsletter = model.OptInNewsletter;
                customer.Type = model.Type;

                _customerData.Update(customer);
                return RedirectToAction(nameof(Details), new { id = customer.Id });
            }

            return View(model);
        }
        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public IActionResult Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                var customer = new Customer
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    OptInNewsletter = model.OptInNewsletter,
                    Type = model.Type
                };
                _customerData.Add(customer);

                return RedirectToAction(nameof(Details), new { id = customer.Id });
            }
            return View();
        }







    }
}
