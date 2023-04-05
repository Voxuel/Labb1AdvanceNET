using Labb1AdvanceNET.Controllers;

namespace Labb1AdvanceNET.Models;

public class Box: IEquatable<Box>
{

    public Box(int h, int l, int w)
    {
        Height= h;
        Length = l;
        Width= w;
    }
    public int Height{ get; set; }
    public int Length { get; set; }
    public int Width{ get; set; }

    public bool Equals(Box? other)
    {
        if (new BoxSameSize().Equals(this, other) || new BoxSameVolume().Equals(this,other))
        {
            return true;
        }

        return false;
    }
}