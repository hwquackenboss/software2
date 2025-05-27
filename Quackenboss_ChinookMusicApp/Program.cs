using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ChinookMusicApp.Data;

ServiceProvider _serviceProvider;

//Create container to hold services for dependency injection
var services = new ServiceCollection();

//Add services to the service container
services.AddDbContext<ApplicationDbContext>();


_serviceProvider = services.BuildServiceProvider();

using (var scope = _serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    context.Database.EnsureCreated();
    
}
//Retrieve instance of SeedingService from the container


//Call method to seed

