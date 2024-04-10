using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6;

public class MyList<T>
{
    private List<T> items = new List<T>();
    public void Add(T element)
    {
        items.Add(element);
    }

    public T Remove(int index)
    {
        if(index < 0 || index >= items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        T ret = items[index];
        items.RemoveAt(index);
        return ret;
    }

    public bool Contains(T element)
    {
        return items.Contains(element);
    }

    public void Clear()
    {
        items.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        items.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        items.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }
        return items[index];
    }


}
