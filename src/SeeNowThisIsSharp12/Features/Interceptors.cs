using System.Runtime.CompilerServices;
namespace SeeNowThisIsSharp12
{
    public class Interceptors
    {
        public static void Go()
        {
            Console.WriteLine("John Was Here!");
        }
    }
    
    public static class InterceptorExample
    {
        // [InterceptsLocation("/Users/jowtow/source/repos/dotnet-8-mate/src/SeeNowThisIsSharp12/Program.cs", 
        //     line: 8, character: 14)]
        // public static void Go()
        // {
        //     Console.WriteLine("What the Fudge?!");
        // } 
    }
}


namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
    {
    }
}
