using DevToDoList.API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DevTodoList");

builder.Services.AddDbContext<DevTodoDbContext>(
    o => o.UseInMemoryDatabase("DevTodoDb")
);

// builder.Services.AddDbContext<DevTodoDbContext>(
//     // o => o.UseInMemoryDatabase("DevTodoDb")
//     o => o.UseSqlServer(connectionString)
// );

// Configuration to Serilog database registration.
// builder.Host.ConfigureAppConfiguration((hostingContext, config) => {
//     Serilog.Log.Logger = new LoggerConfiguration()
//         .Enrich.FromLogContext()
//         .WriteTo.MSSqlServer(connectionString,
//             sinkOptions: new MSSqlServerSinkOptions() {
//                 AutoCreateSqlTable = true,
//                 TableName = "Logs"
//             })
//         .WriteTo.Console()
//         .CreateLogger();
// }).UseSerilog();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo {
        Title = "DevTodoList.API",
        Version = "v1",
        Contact = new OpenApiContact {
            Name = "Mario Alves",
            Email = "marioalvesneto@hotmail.com",
            Url = new Uri("https://www.linkedin.com/in/marioalvesneto/")
        }
    });

    var xmlFile = "DevTodoList.API.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (true) // For production in Azure
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
