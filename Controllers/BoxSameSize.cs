using Labb1AdvanceNET.Models;

namespace Labb1AdvanceNET.Controllers;

public class BoxSameSize : EqualityComparer<Box>
{
    public override bool Equals(Box? x, Box? y)
    {
        if (x.Height == y.Height && x.Length == y.Length && x.Width == y.Width)
        {
            return true;
        }

        return false;
    }

    public override int GetHashCode(Box obj)
    {
        var hash = obj.Height ^ obj.Length ^ obj.Width;
        return hash.GetHashCode();
    }
}