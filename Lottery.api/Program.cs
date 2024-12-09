using LotteryFactory.Core.Entities;
using LotteryFactory.Core.InterfaceRepository;
using LotteryFactory.Core.InterfaceService;
using LotteryFactory.Data;
using LotteryFactory.Data.Repository;
using LotteryFactory.Service.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<ILotteryService, LotteryService>();
builder.Services.AddScoped<IProductInLotteryService, ProductInLotteryService>();
builder.Services.AddScoped(typeof(IRepositoryManager<>), typeof(RepositoryManager<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddDbContext<DataContext>(option => option.UseSqlServer("Data Source = DESKTOP-SSNMLFD; Initial Catalog = Lottery-Factory; Integrated Security = true;"));
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
