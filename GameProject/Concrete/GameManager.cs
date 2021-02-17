using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class GameManager : BaseManager<Game>
    {
        List<Game> games;
        public GameManager()
        {
            games = new List<Game>();
        }

        public override void Add(Game game)
        {
            games.Add(game);
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
