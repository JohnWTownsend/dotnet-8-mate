namespace SeeNowThisIsSharp12;

using SeeNowThisIsSharp12.Features;
using Coord2 = (int x, int y);
public class AliasAnyType2
{
    public void Foo()
    {
        Coord2 coord2 = AliasAnyType.TranslateCoord3ToCoord2((1,2,3));
        Console.WriteLine(coord2);
    }
}
