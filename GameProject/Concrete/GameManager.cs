using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class GameManager : BaseManager<Game>
    {
        public override void Add(Game game)
        {
            Console.WriteLine(game.Name + " Game Added");
        }

        public override void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Game Deleted");
        }

        public override void Update(Game game)
        {
            Console.WriteLine(game.Name + " Game Added");
        }
    }
}
