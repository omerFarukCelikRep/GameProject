using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Game Added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Game Deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Game Added");
        }
    }
}
