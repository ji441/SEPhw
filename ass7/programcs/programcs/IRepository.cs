using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay1
{
    public interface IRepository<T> where T : IHasId
    {
        List<T> list { get; set; } 
        public void Add(T entity);
        public void Remove(T item);
        public void Save();
        public IEnumerable<T> GetAll();
        public T? GetById(int id);
    }
}
