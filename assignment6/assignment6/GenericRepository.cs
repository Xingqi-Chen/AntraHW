using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6;

public interface IRepository<T>
{
    public void Add(T item);
    public void Remove(T item);
    public void Save();
    public IEnumerable<T> GetAll();
    public T GetById(int id);
}

public interface IEntity
{
    public int Id { get; set; }
}

public class GenericRepository<T> : IRepository<T> where T : class, IEntity
{
    private List<T> items = new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        foreach(T item in items)
        {
            if(item.Id == id)
            {
                return item;
            }
        }
        return null;
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Already save in memory");
    }
}
