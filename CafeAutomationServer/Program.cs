using CafeAutomationBLL.Managers;
using CafeAutomationBLL.Utils;
using CafeAutomationDAL.BaseModel;
using CafeAutomationDAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionStrings = builder.Configuration.GetSection("ConnectionString").Get<ConnectionString>();
builder.Services.AddDbContext<CafeautomationappContext>(o =>
{
    o.UseMySQL(ConnectionString.CafeAutomationDbase);
    o.EnableSensitiveDataLogging();
});
builder.Services.AddScoped<AuthManager>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
