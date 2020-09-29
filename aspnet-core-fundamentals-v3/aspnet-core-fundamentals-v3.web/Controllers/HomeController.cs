using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_fundamentals_v3.web.Controllers
{
    public class HomeController
    {
        public string Index(string id)
        {
            return "Hello from a controller" + id;
        }
      
    


    }
}
