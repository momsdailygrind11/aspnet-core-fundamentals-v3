using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_fundamentals_v3.web
{
    public class ConfigurationGreeter : IGreeter
    {
        public IConfiguration Configuration { get; }
        public ConfigurationGreeter(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetGreeting()
        {
            return Configuration["Greeting"];
        }


    }
}
