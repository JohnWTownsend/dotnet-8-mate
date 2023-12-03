namespace SeeNowThisIsSharp12.Features;

public static class PrimaryConstructor 
{
    public static void Go()
    {
        var studentService = new StudentService(new StudentLogger());
        var studentsThatStartWithJ = studentService.GetStudents('J');
    }
}

file class StudentLogger
{
    public void Log(string message) => Console.WriteLine(message);
}

file class StudentService(StudentLogger _logger)
{
    private List<Student> GetStudents() => new List<Student>
    {
        new Student("John", "Townsend"),
        new Student("Kevin", "Logan"),
        new Student("Brian", "Behm"),
        new Student("Jack", "Donovan"),
    };

    public List<Student> GetStudents(char startsWith)
    {
        var studentsThatStartWithChar = GetStudents().Where(x => x.FirstName.StartsWith(startsWith));
        _logger.Log($"{studentsThatStartWithChar.Count()} students that start with {startsWith}");
        return studentsThatStartWithChar.ToList();
    }
}

file record Student(string FirstName, string LastName);