using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace SimpleCrm.Web.ViewComponents
{
    public class LoginLogoutViewComponent : ViewComponent
    {
        private readonly UserManager<CrmUser> userManager;
        public LoginLogoutViewComponent(UserManager<CrmUser> userManager)
        {
            this.userManager = userManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var user = userManager.Users
                .FirstOrDefault(x => x.UserName == User.Identity.Name);
            return Task.FromResult<IViewComponentResult>(View(user));
        }
    }
}
