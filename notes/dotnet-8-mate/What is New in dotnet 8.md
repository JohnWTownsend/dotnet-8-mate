# _What's New In .NET 8?_

---

___In case you missed it!___
> [!tip]- November
>  - ... Is for .NET! .NET Conf happened!
> 	 - If you missed it, all the videos are still available on YouTube!!
> 	 - https://www.dotnetconf.net/
>  - Every November, a new major version of .NET releases!

> [!tip]- Support
> ```csharp
> if (releaseNo % 2 == 0)
>	return "LTS"
>else
>	return "STS"
>```

> [!tip]- Also Support
> .NET 6 & 7 End of support in 2024!
> - .NET 7 --> May 14th, 2024
> - .NET 6 --> November 12, 2024

---
___What's New?___
>[!info]- ... Everything!
> - 💜 C# 12 
> - 🌎 ASP.NET Core Updates 
> - 📈 EF Core 8 
> - 💪 Performance 
> - 👓 Visual Studio Updates
> - 🌴 MAUI Improvements
> - ☁️ Aspire
> - 🔥 Blazor
> - ... and so much more!!

---
___Let's get into it!___
- 🤖 [[dotnet 8 | .NET 8]] 
- 💜 [[CSharp 12| C# 12]]
- 🌎 [[ASP.NET Core]]
- 📈 [[EF Core 8]]
- 💪 [[Performance]]
- 👓 [[Visual Studio]]
- 🌴 [[MAUI]]
- ☁️ [[Aspire]]
- ... and so much more!!
---
___. NET 8___
> [!note] Logging / Open Telemetry Improvements
>  - New guidance on use of ILogger and new decorators for ease of logging complex objects
>  - Easier setup to APM agnostic Logging, Metrics, and Traces

---
___C# 12___
> [!success] Primary Constructors
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

___C# 12___
>[!tip] Collection Expressions
>```csharp
>	var nums1 = new List < int > { 1, 2, 3 };
>	List < int > nums2 = [1,2,3];
>	var foo = [..nums1, ..nums2];
>```
---

___C# 12___
> [!note] Alias Any Type
> ```csharp
> using Coord3 = (int x, int y, int z);
> Coord myCoord = (1, 0, 1);
> ```
---

___C# 12___
>[!note] Default Lambda Parameters
>```csharp
>var myFunc = (string pluralizeMe = "cat") => pluralizeMe + 's';
>```
---

___C# 12___
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


---
___ASP.NET Core___
> [!tip] Blazor
> - Hybrid of static WASM code and use of server-side rendering.
> - Enhanced Server Side Rendering
>	- Static Server Rendering
>	- Enhanced navigation -
>	- Stream rendering - Placeholder loading for things that may take a while on load
---

___ASP.NET Core___
> [!abstract] Native AOT
> Again, things are small and speedy. Not a whole lot that we'll have to do, but will make our lives better.
---

___ASP.NET Core___
>[!todo] Improved Auth Setup
> Easier setup of auth for SPAs using new ```MapIdentityApi``` extension method

---
 ___EF Core___
> [!tip] Complex Types
>  a way to use a class as a grouping of reusable columns in EF. For instance if you wanted to reuse address fields for shipping, billing, etc. You could create a ComplexType for Address and reuse that class in multiple entity types. The use of Complex Types can lead to more concise code and easier mapping.
---

>[!note] Raw SQL Queries for Unmapped Types
> this allows users to query the database using raw SQL similar to the way you'd query using the Dapper ORM and also allows mapping the results of the query to a C# class. In previous versions of EF, the class for SqlQuery would need to bemapped to the DbContext via a DbSet. In EF8, unmapped types can also be queried in this way.
---

>[!abstract] Much more
> - Primitive Collection Support
> - JSON Column enhancements
> - DateOnly and TimeOnly support in model building
> - Hierarchyid datatype support for SQL Server


---
___Performance___
Over 1250 Performance improvements

![[Pasted image 20231203112826.png]]

---

<iframe src="https://giphy.com/embed/yXVO50FJIJMSQ" width="480" height="378" frameBorder="0" class="giphy-embed" allowFullScreen></iframe>

https://devblogs.microsoft.com/dotnet/performance-improvements-in-net-8/

---
 ___Visual Studio 17.8___
>[!tip] Endpoints Explorer

>[!note] Pull Requests

>[!bug] Improved Debugging 

> [!info] Http Request Engine

---
___MAUI___

>[!danger] If you are on Xamarin, you need to get to MAUI before May

---
 ___Aspire___
Evolution of dotnet Tye.

Original dream was to make microservices or "cloud native" easy

A stack for building cloud native apps with .NET

- Telemetry
- Resilience
- Config
- Health Checks
- Composition
---

![[Pasted image 20231203113412.png]]