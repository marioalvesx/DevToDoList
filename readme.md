<p align="center">

</p>
<h1 align="center"> 📝 Dev To Do List </h1>

## 🔍 About
This is a simple Todo List type application with a backend and frontend (focused on the backend with ASP.Net Core) that i use to study and apply some concepts used in real world applications problems. It was built from the beginning, the built of a solid API, and the final stage, publish in the Cloud.

## 🧑‍💻 Technologies
* C# 
* ASP.Net Core
* Swagger
* Serilog
* Blazor
* EF Core
* Azure App Service

## ⚙️ How to execute?
After cloning the application locally, in your VSCode just run the command
```bash
dotnet build
```
and after that:
```bash
dotnet run
```
Remember that to show the frontend of the application the backend must be running. 
You also need to have the database installed locally and configured with the correct credentials in the 'appsettings.json' file:

```json
"ConnectionStrings": {
    "CustomerRegistrationConnection": "Server=YourServerNameHere; Database=CustomerRegistrationDb; Integrated Security=True; trustServerCertificate=true;"
  }
```

And the Entity Framework installed with the following packages:
- **Microsoft.EntityFrameworkCore.InMemory**
- **Microsoft.EntityFrameworkCore.SQLServer**
- **Microsoft.EntityFrameworkCore.Design**

## Communication beetween BackEnd and FrontEnd:
...

## ✨ Show your support
Give a ⭐️ if this project helped you or inspired you in some way!
Get in touch with me: <a href="https://www.linkedin.com/in/marioalvesneto/">LinkedIn</a><br>
Made with 💜 by Mario Alves.
