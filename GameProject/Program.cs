using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

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

            BaseManager customerManager = new CustomerManager(new EDevletServiceAdapter());
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.Update(customer2);
            customerManager.Delete(customer1);

            Game game = new Game { ID = 1, Name = "Call Of Duty", PublishDate = new DateTime(2018, 11, 11) };

            GameManager gameManager = new GameManager();
            gameManager.Sell(customer1, game);
        }
    }
}
