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

> [!note]- Alias Any Type

> [!danger]- Interceptors