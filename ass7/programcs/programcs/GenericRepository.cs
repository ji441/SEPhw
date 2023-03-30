using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay1
{
    public class GenericRepository<T> : IRepository<T> where T : IHasId
    {
        List<T> values =  new List<T>();
        public List<T> list { get { return values; } set { values = value; } }

        public void Add(T entity)
        {
            values.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return values;
        }

        public T? GetById(int id)
        {
            foreach (var t in values) { 
                if (t.Id == id) { return t; }
                    
            }
            Console.WriteLine("the id is not found.\n")
            return default;
        }

        public void Remove(T item)
        {
            values.Remove(item);
        }

        public void Save()
        {
            list = values;
        }
    }
}
