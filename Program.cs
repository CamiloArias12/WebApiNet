using  FirstApi.Models;
using  FirstApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add services to the container.
builder.Services.Configure<DatabaseBook>(
    builder.Configuration.GetSection("DatabaseBook"));

builder.Services.AddControllers();
builder.Services.AddSingleton<BooksService>();

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
