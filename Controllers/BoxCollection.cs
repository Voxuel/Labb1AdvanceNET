using System.Collections;
using Labb1AdvanceNET.Models;

namespace Labb1AdvanceNET.Controllers;

public class BoxCollection : ICollection<Box>
{
    private List<Box> _boxes;

    public BoxCollection()
    {
        _boxes = new List<Box>();
    }

    public Box this[int index]
    {
        get => _boxes[index];
        set => _boxes[index] = value;
    }
    public IEnumerator<Box> GetEnumerator()
    {
        return new BoxEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Box item)
    {
        if (!Contains(item) || !Contains(item,new BoxSameVolume()))
        {
            _boxes.Add(item);
        }
        else
        {
            Console.WriteLine($"Box with sizing : H{item.Height}, L{item.Length}, W{item.Width}" +
                              $" already exists in the collection");
        }
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(Box item)
    {
        foreach (var box in _boxes)
        {
            if (box.Equals(item))
            {
                return true;
            }
        }

        return false;
    }

    public bool Contains(Box item, BoxSameVolume comparer)
    {
        foreach (var box in _boxes)
        {
            if (comparer.Equals(box, item))
            {
                return true;
            }
        }

        return false;
    }

    public void CopyTo(Box[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(Box item)
    {
        throw new NotImplementedException();
    }

    public int Count => _boxes.Count;
    public bool IsReadOnly => false;
}