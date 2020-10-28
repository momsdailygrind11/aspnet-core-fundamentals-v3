using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace SimpleCrm.Web.ViewComponents
{
	public class GreetingViewComponent : ViewComponent
	{
		private readonly IGreeter greeter;

		public GreetingViewComponent(IGreeter greeter)
        {
			this.greeter = greeter;
        }
		public Task<IViewComponentResult> InvokeAsync()
		{
			var model = greeter.GetGreeting();
			return Task.FromResult<IViewComponentResult>(View("Default", model));
		}
	}
}
