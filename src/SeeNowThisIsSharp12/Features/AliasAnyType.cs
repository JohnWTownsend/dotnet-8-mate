namespace SeeNowThisIsSharp12.Features;
using Coord3 = (int x, int y, int z);
public class AliasAnyType
{
    public static void Go()
    {
        var coord3 = (1,0,1);
        var result = TranslateCoord3ToCoord2(coord3);
        Console.WriteLine(result);
    }

    public static (int x, int y) TranslateCoord3ToCoord2(Coord3 coord3)
    {
        return (coord3.x, coord3.y);
    }
}
