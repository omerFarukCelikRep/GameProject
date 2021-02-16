using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerManager : BaseCustomerManager
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
                base.Add(customer); 
            }
            else
            {
                throw new Exception("Not a Valid Exception");
            }
        }

        public override void Update(Customer customer)
        {
            base.Update(customer);
        }

        public override void Delete(Customer customer)
        {
            base.Delete(customer);
        }
    }
}
