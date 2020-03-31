# Travel API

#### C# ASP.NET Core Web API Exercise for [Epicodus](https://www.epicodus.com/), 03.30.2020

#### By [**Adela Darmansyah**](https://ayohana.github.io/portfolio/)

## Description

**A basic web API that allows users to GET and POST reviews about various travel destinations around the world.**

## User Stories

- [x] As a user, I want to GET and POST reviews about travel destinations.
- [x] As a user, I want to GET reviews by country or city.
- [x] As a user, I want to see the most popular travel destinations by overall rating (of range 0-5).
- [x] As a user, I want to PUT and DELETE reviews, but only if I wrote them. _(Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)_
- [x] As a user, I want to look up random destinations just for fun.

## Notes

* In CLI, `dotnet new webapi` generated this application's scaffolding.
* Setup the database by adding these packages:
  * `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0` 
  * `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
* To seed data into the database, add the following to `TravelAPIContext` class:
  ```
  ...
  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Review>()
        .HasData(
            new Review { ReviewId = 1, Destination = "Hawaii", Title = "Coconuts Yes!", Description = "Always ask for them.", Rating = 3, user_name="Amy" },
            new Review { ReviewId = 2, Destination = "Seattle", Title = "The Emerald City", Description = "Mhm", Rating = 3, user_name="Bob" },
            new Review { ReviewId = 3, Destination = "Denver", Title = "Hiking Paradise", Description = "Bring your hiking shoes with you!", Rating = 3, user_name="Amy" },
            new Review { ReviewId = 4, Destination = "New York", Title = "Walk, walk, walk", Description = "So little time, so much distance to travel", Rating = 5, user_name="Bob" },
            new Review { ReviewId = 5, Destination = "Chicago", Title = "Good 'ol Chicago", Description = "Dunkin donuts all around!", Rating = 5, user_name="Amy" }
        );
  }
  ...
  ```
* Feature applied - API Versioning:
  * Generally, an API starts with Version 1.0. That way, when we make breaking changes at some point in the future, we can push these changes to Version 2.0. We can then leave Version 1.0 available for enterprises that don't have time to update to Version 2.0 just yet, or might need to make updates to their own code to deal with the changes first. If we're making smaller changes to an API, we might not upgrade to 2.0 - instead, 1.1 would suffice.
  * Tutorial: ![API Versioning in .NET Core](https://neelbhatt.com/2018/04/21/api-versioning-in-net-core/)
  * Update TravelAPI.csproj:
  ```
  ...
  <PackageReference Include="Microsoft.AspNetCore.Mvc.Versioning" Version="4.1.0" />
  ...
  ```

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: adela.yohana@gmail.com.

## Technologies Used

* C#
* MVC Pattern
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/) (Windows OS)
* [MySQL](https://dev.mysql.com/downloads/file/?id=484919) (Windows OS)
* [EF Core](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)