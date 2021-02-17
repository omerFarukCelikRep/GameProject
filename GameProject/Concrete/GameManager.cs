using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class GameManager : IGameService
    {
        public void Sell(Customer customer, Game game)
        {
            Console.WriteLine(game.Name + " Sold to " + customer.FirstName + " " + customer.LastName);
        }
    }
}
