using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_fundamentals_v3.web
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetAll();
    }
}
