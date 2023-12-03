namespace SeeNowThisIsSharp12;

public class DefaultLambdaParams
{
    public static void Go()
    {
        MakePlural("jowtow");
        MakePlural();

        var makePlural2 = (string stringToPluralize = "Dog") 
            => stringToPluralize.EndsWith('y') ? stringToPluralize[0..^1] + "ies" : stringToPluralize + 's';

        var pluralDog = makePlural2();
        Console.WriteLine($"Dog => {pluralDog}");
        var pluralPuppy = makePlural2("Puppy");
        Console.WriteLine($"Puppy => {pluralPuppy}");
    }

    public static string MakePlural(string stringToPluralize = "Dog") => stringToPluralize + 's';
}
