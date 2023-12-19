using Microsoft.Extensions.Configuration;
using PetCareConnectDAL.DataAccess;
using PetCareConnectDAL.Repository;
using System.Data.Common;
using System.Data.SqlClient;


var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<DbConnection>(sp => new SqlConnection(builder.Configuration.GetConnectionString("techno")));
builder.Services.AddTransient(sp => new SqlConnection(configuration.GetConnectionString("techno")));
builder.Services.AddScoped<IArticlesRepository, ArticlesServices>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();