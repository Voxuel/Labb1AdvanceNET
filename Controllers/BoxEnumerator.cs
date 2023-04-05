using System.Collections;
using Labb1AdvanceNET.Models;

namespace Labb1AdvanceNET.Controllers;

public class BoxEnumerator : IEnumerator<Box>
{
    private BoxCollection? _boxes;
    private int _currentIndex;
    private Box? _currentBox;

    public BoxEnumerator(BoxCollection boxes)
    {
        _boxes = boxes;
        _currentIndex = -1;
        _currentBox = default;
    }
    
    public bool MoveNext()
    {
        if (++_currentIndex >= _boxes.Count)
        {
            return false;
        }
        else
        {
            _currentBox = _boxes[_currentIndex];
        }

        return true;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    public Box Current => _currentBox;

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }
}