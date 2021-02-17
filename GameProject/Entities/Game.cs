using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
