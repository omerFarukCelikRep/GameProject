using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                ID = 1,
                FirstName = "Ömer Faruk",
                LastName = "Çelik",
                DateOfBirth = new DateTime(1995, 1, 1),
                NationalityID = "12345678901"
            };

            Customer customer2 = new Customer
            {
                ID = 2,
                FirstName = "Ali",
                LastName = "Veli",
                DateOfBirth = new DateTime(1986, 1, 1),
                NationalityID = "12345678901"
            };

            CustomerManager customerManager = new CustomerManager(new EDevletServiceAdapter());
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.Update(customer2);
            customerManager.Delete(customer1);

            Game game = new Game { ID = 1, Name = "Call Of Duty", PublishDate = new DateTime(2018, 11, 11) };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            List<Game> gameList = new List<Game>();
            gameList.Add(game);

            Campaign campaign = new Campaign
            {
                ID = 1,
                Name = "Kış İndirimleri",
                StartDate = new DateTime(2021, 2, 15),
                EndDate = new DateTime(2021, 4, 1)
            };

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(customer1, gameList, campaign);
        }
    }
}
