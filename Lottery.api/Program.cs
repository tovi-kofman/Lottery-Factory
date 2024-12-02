using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
using LotteryFactory.Data;
using LotteryFactory.Data.Repository;
using LotteryFactory.Service.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using MyProject.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddSingleton<DataContext<User>>();
builder.Services.AddScoped<ILotteryService, LotteryService>();
builder.Services.AddScoped<ILotteryRepository, LotteryRepository>();
builder.Services.AddSingleton<DataContext<Lottery>>();
builder.Services.AddControllers();
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
