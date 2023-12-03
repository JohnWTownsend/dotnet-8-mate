namespace SeeNowThisIsSharp12.Features;

public class CollectionExpressions
{
    public static void Go()
    {
        var nums1 = new List<int> {1,2,3};
        List<int> nums2 = [4,5,6];
        List<int> nums3 = [..nums1, ..nums2];
        Console.WriteLine(string.Join(',', nums3));
    }
}
