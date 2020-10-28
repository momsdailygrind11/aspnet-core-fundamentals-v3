using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetAll();

        Customer Get(int id);
        void Add(Customer customer);
        void Update(Customer customer);

    }
}
