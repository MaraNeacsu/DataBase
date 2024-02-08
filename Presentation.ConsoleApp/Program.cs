using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infrastructure.Context;
using System;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ConsoleApp.Repositories;
using ConsoleApp.Services;
using ConsoleApp;




var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext <DataContext> (x => x.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Projects\DataBase\Infrastructure\Data\data_base.mdf; Integrated Security = True; Connect Timeout = 30"));

    services.AddScoped<AddressRepository>();
    services.AddScoped<CategoryRepository>();
    services.AddScoped<RoleRepository>();
    services.AddScoped<ProductRepository>();
    services.AddScoped<CustomerRepository>();

    services.AddScoped<AddressService>();
    services.AddScoped<CategoryService>();
    services.AddScoped<RoleService>();
    services.AddScoped<ProductService>();
    services.AddScoped<CustomerService>();

    services.AddSingleton<ConsoleUI>();


}).Build();

var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();

