using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sell(Customer customer, List<Game> games, Campaign campaign);
    }
}
