# MvcMovieTutorial
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-2.1

## Extra Notes
[With regards to step "Add a new field to an ASP.NET Core MVC app"](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/new-field?view=aspnetcore-2.1)


```
// After the part where you drop the current database to recreate 
// with the new schema changes, namely after the command

dotnet ef database drop

// You can just run this to add the changes as an additional migration
// Note: this will keep the "InitialCreate" migration you have created previously

dotnet ef migrations add addRatingsColumnToMoviesTable

// P.S. addRatingsColumnToMoviesTable is just a migration name, 
// it can be anything you like, best if it makes sense

// CLI command to see the list of migrations you have in your current project
dotnet ef migrations list

// You can run the update command to update the database thereafter
dotnet ef database update

```

[Reference](https://github.com/aspnet/Docs/issues/8389)