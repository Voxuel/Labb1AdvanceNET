using Labb1AdvanceNET.Models;

namespace Labb1AdvanceNET.Controllers;

public class BoxSameVolume : EqualityComparer<Box>
{
    public override bool Equals(Box? x, Box? y)
    {
        if (x.Volume == y.Volume)
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