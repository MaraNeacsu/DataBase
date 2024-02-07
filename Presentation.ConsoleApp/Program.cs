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

    services.AddSingleton<AddressRepository>();
    services.AddSingleton<CategoryRepository>();
    services.AddSingleton<RoleRepository>();
    services.AddSingleton<ProductRepository>();
    services.AddSingleton<CustomerRepository>();

    services.AddSingleton<AddressService>();
    services.AddSingleton<CategoryService>();
    services.AddSingleton<RoleService>();
    services.AddSingleton<ProductService>();
    services.AddSingleton<CustomerService>();

    services.AddSingleton<ConsoleUI>();


}).Build();

var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();

