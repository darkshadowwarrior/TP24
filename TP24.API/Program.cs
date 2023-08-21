using TP24.Data.Repositories;
using TP24.Services.Interfaces;
using TP24.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IRepository, PayloadRepository>();
builder.Services.AddScoped<IPayloadService, PayloadService>();
builder.Services.AddScoped<IPayloadMapper, PayloadMapper>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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