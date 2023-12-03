> [!success]- Primary Constructors
> Before
> ``` csharp
> public StudentService
> {
> 	private readonly IStudentRepository _studentRepository;
> 	private readonly IStudentValidator _studentValidator;
> 	
> 	public StudentService(IStudentRepository studentRepository, IStudentValidator studentValidator)
> 	{
> 		_studentRepository = studentRepository;
> 		_studentValidator = studentValdator;
> 	}
> 
>      public void SaveStudent(Student student)
>      {
> 	     _studentValidator.ValidateStudent(student);
> 	     _studentRepository.SaveStudent(student);
>      }
> }
>```
>After
>```csharp
>public StudentService(IStudentRepository _studentRepository, IStudentValidator _studentValidator)
> {
>      public void SaveStudent(Student student)
>      {
> 	     _studentValidator.ValidateStudent(student);
> 	     _studentRepository.SaveStudent(student);
>      }
> }
>```

>[!tip]- Collection Expressions
>```csharp
>	var nums1 = new List<int>{ 1, 2, 3 };
>	List<int> nums2 = [1,2,3];
>	var foo = [..nums1, ..nums2];
>```

> [!note]- Alias Any Type
> ```csharp
> using Coord3 = (int x, int y, int z);
> Coord myCoord = (1, 0, 1);
> ```


>[!note]- Default Lambda Parameters
>```csharp
>var myFunc = (string pluralizeMe = "cat") => pluralizeMe + 's';
>```

> [!danger]- Interceptors
> ### What is it?
> Essentially, replace some functionality based on source file and line/column location dynamically. This is sort of like doing a full-text replacement of a method at compile time. (sometimes called monkey patching in other languages)
> ### Who is this for?
> Probably not you. Likely useful for Library creators and the core .NET team to improve performance and artifact sizes by enabling some AOT compilation
> ### Why is this bad?
> - Not bad if used by the right people, and interceptor code should probably be written by source generators because of its brittle nature with reliance on line and column numbers.
> - This is bad if used incorrectly. It's dangerous for user code and if you see it in user code, break out the holy water.
> ### Where might this be useful?
> - One example given from the folks at MS is with minimal APIs. At compile time, they could swap out the generic MapGet function call with a more explicit definition and save on performance.
> ### Other Concerns
> - How do we protect methods from being intercepted?
> - How can I work backwards from a piece of code that has been intercepted?
> - Does this break some rules on inversion of control