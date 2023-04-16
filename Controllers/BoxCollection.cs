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
        if (!Contains(item, out var diff))
        {
            _boxes.Add(item);
        }
        else
        {
            Console.WriteLine(diff);
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

    public bool Contains(Box item, EqualityComparer<Box> comparer)
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

    public bool Contains(Box item, out string diff)
    {
        diff = "";
        
        foreach (var box in _boxes)
        {
            if (new BoxSameSize().Equals(box, item))
            {
                diff = $"A box with sizing {item.Height}x{item.Length}x{item.Width}" +
                       $" already exists in the collection";
                return true;
            }
            else if (new BoxSameVolume().Equals(box, item))
            {
                diff = $"A box with volume {box.Volume} already exists in the collection";
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
        for (int i = 0; i < _boxes.Count; i++)
        {
            Box tmp = _boxes[i];
            if (new BoxSameSize().Equals(tmp, item))
            {
                _boxes.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    public int Count => _boxes.Count;
    public bool IsReadOnly => false;
}