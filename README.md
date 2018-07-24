# MyRetail RESTful Service

## Built with

 - ASP.NET Core 2.1
 - MongoDB
 - Bootstrap


## Getting started

### Prerequisites to run locally:

 - .NET Core SDK 2.1 or higher: https://www.microsoft.com/net/download
 - A version of Visual Studio or Visual Studio Code
 - MongoDB
 
## To run the application:

Create Database:
```
use RedSky
db.createCollection("RedSky")
db.RedSky.insertOne({product:{item:{tcin:"13860428",product_description:{title:"The Big Lebowski (Blu-ray)", price: 15.50}}}})
db.RedSky.insertOne({product:{item:{tcin:"836541838",product_description:{title:"The Little Mermaid", price: 18.50}}}})
```
   

### Configure connection string in appsettings.json

```
dotnet restore
dotnet build
dotnet run
```
