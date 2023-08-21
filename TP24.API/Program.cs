using Microsoft.EntityFrameworkCore;
using TP24.Data.Contexts;
using TP24.Data.Interfaces;
using TP24.Data.Repositories;
using TP24.Services.Interfaces;
using TP24.Services.Mappers;
using TP24.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPayloadMapper, PayloadMapper>();
builder.Services.AddScoped<IStatisticsService, StatisticsService>();
builder.Services.AddScoped<IPayloadService, PayloadService>();
builder.Services.AddScoped<IPayloadRepository, PayloadRepository>();
builder.Services.AddScoped<IStatisticsRepository, StatisticsRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TpContext>(options => options.UseInMemoryDatabase(databaseName: "AuthorDb"));
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