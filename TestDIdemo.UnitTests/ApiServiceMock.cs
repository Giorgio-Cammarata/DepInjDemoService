using DIdemoLibrary;
using DIdemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDIdemo.UnitTests
{
    public class ApiServiceMock : IApiService
    {
        public Customer GetCustomer(int id)
        {
            if (id is 2)
            {
                return new Customer
                {
                    Id = 2,
                    Name = "Test-Mock-Name",
                    Surname = "Test-Mock-Surname"
                };
            }
            return null;
        }
    }
}
