using CafeAutomationBLL.Managers;
using CafeAutomationBLL.Utils;
using CafeAutomationDAL.BaseModel;
using CafeAutomationDAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
});
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

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors();
}

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();

});
app.MapControllers();

app.Run();
