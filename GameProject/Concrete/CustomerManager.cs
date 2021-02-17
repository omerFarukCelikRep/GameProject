using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerManager : BaseManager<Customer>
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfReal(customer))
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " Added");
            }
            else
            {
                throw new Exception("Not a Valid Exception");
            }
        }

        public override void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Updated");
        }

        public override void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Deleted");
        }
    }
}
