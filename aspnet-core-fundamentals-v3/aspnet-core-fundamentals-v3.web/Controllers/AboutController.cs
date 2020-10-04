using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace aspnet_core_fundamentals_v3.web.Controllers
{
    [Route("About")]

    public class AboutController
    {
        [Route("ph")]
        public string Phone()
        {
            return "636-900-2497";
        }

        [Route("add")]
        public string Address()
        {
            return "USA";
        }
    }
   
}
