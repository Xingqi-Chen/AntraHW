using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6;

public class MyStack<T>
{
    private List<T> items = new List<T>();
    public int Count()
    {
        return items.Count;
    }

    public T Pop()
    {
        if(items.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public void Push(T value)
    {
        items.Add(value);
    }
}
