- Complex Types - a way to use a class as a grouping of reusable columns in EF. For instance if you wanted to reuse address fields for shipping, billing, etc. You could create a ComplexType for Address and reuse that class in multiple entity types. The use of Complex Types can lead to more concise code and easier mapping.
- Raw SQL Queries for Unmapped Types - this allows users to query the database using raw SQL similar to the way you'd query using the Dapper ORM and also allows mapping the results of the query to a C# class. In previous versions of EF, the class for SqlQuery would need to bemapped to the DbContext via a DbSet. In EF8, unmapped types can also be queried in this way.
- Much more:

- Primitive Collection Support
- JSON Column enhancements
- DateOnly and TimeOnly support in model building
- Hierarchyid datatype support for SQL Server