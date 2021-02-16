using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Added");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Deleted");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Updated");
        }
    }
}
