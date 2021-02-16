using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Added");
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Deleted");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Updated");
        }
    }
}
