using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class EDevletServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfReal(Customer customer)
        {
            return true;
        }
    }
}
