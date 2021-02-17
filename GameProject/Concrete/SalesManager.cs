using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Customer customer, List<Game> games, Campaign campaign)
        {
            if (DateTime.Compare(campaign.StartDate, DateTime.Now) < 0)
            {
                foreach (Game game in games)
                {
                    Console.WriteLine(game.Name + " Sold to " + customer.FirstName + " " + customer.LastName);
                }
            }
        }
    }
}
