using Microsoft.EntityFrameworkCore;
using TetrisServer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));

// Add Database Context
// builder.Services.AddDbContext<TetrisContext>(opt =>
//     opt.UseInMemoryDatabase("TetrisDB"));
builder.Services.AddDbContext<TetrisContext>(opt =>
    opt.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), serverVersion));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
