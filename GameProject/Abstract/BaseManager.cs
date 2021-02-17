using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseManager<T> : IService<T>
    {
        public virtual void Add(T entity)
        {
            Console.WriteLine("Added");
        }

        public virtual void Delete(T entity)
        {
            Console.WriteLine("Deleted");
        }

        public virtual void Update(T entity)
        {
            Console.WriteLine("Updated");
        }
    }
}
