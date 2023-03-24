# Bakery Auth 

#### By Mitchell Gantz

_This web app allows adding of new Treats and Flavors, and assigning Treats Flavors and Flavors Treats._

## Technologies Used

* C#
* .Net 6
* ASP.Net EF Core 6
* MySQL
* LINQ

### Objectives 

* The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update, and delete functionality. All users should be able to have read functionality.
*  There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
*  A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements

#### To run this project, you will need:
* .NET 6.0
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

* .NET Core CLI
```
dotnet tool install --global dotnet-ef --version 6.0.0
 dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
 dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0
```

1. Clone this repo to your workspace.

2. Navigate to the `BakeAuth` directory.

3. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=BakeAuth;uid=root;pwd=epicodus;",
  }
}
```

4. Install dependencies within the `BakeAuth` directory
```
$ dotnet restore
````

5. Build and run the program 
 ```
 $ dotnet run
 ```


## Known Bugs

* No known bugs.


## License

**MIT License**

Copyright (c) 2022 Mitchell Gantz

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.