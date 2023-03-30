using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testclass1;

public class MyStack<T>
{
    List<T> mylist = new List<T>();
    public T Pop() {
        T res = mylist[0];
        mylist.RemoveAt(0); 
        return res; 
    }
    public void Push(T t)
    {
        mylist.Add(t);
    }
    public int Count()
    {
        return mylist.Count;
    }
    public List<T> list1 { get { return mylist; }
        set { mylist = value; }
    }

}
