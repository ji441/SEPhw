using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay1
{
    public class MyList<T>
    {
        List<T> values= new List<T>();
        public List<T> list { get { return values; } set { values = value; } }
        public void Add(T value)
        {
            values.Add(value);
        }
        public void Clear() { values.Clear(); } 
        public bool Contains(T value)
        {
            return values.Contains(value);
        }
        public T Remove(int index)
        {
            values.RemoveAt(index);
            T res = values[index];
            return res;
        }
        public void InsertAt(T value,int index)
        {
            values.Insert(index,value);

        }
        public void DeleteAt(int index)
        {
            values.RemoveAt(index);
        }
        public T Find(int index)
        {
            return values[index];
        }
    }
}
