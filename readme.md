<h1 align="center"> 📝 Dev To Do List </h1>
<p align="center">
    <img src="https://user-images.githubusercontent.com/22736436/210109840-9329065a-0c8f-40b6-bc30-f43864ba4f0e.gif" alt="demo" height="395">
</p>
<hr />

## 🔍 About
This is a simple Todo List type application with a backend and frontend (focused on the backend with ASP.Net Core) that i use to study and apply some concepts used in real world applications problems. It was built from the beginning, the built of a solid API, and the final stage, publish in the Cloud.

## 🧑‍💻 Technologies
* C# 
* ASP.Net Core
* Swagger
* Serilog
* Blazor
* Style: https://getuikit.com/v2/docs
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

## 🤝 Communication between BackEnd and FrontEnd:
API consumed by Blazor Web Assembly.
To execute it the api must be running in second plan.

## ✨ Show your support
Give a ⭐️ if this project helped you or inspired you in some way!
Get in touch with me: <a href="https://www.linkedin.com/in/marioalvesneto/">LinkedIn</a><br>
Made with 💜 by Mario Alves.
