using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Services;

ServiceProvider _serviceProvider;
SeedingService _seedingService;
BasicQueryService _basicQueryService;

//Create container to hold services for dependency injection
var services = new ServiceCollection();

//Add services to the service container
services.AddDbContext<ApplicationDbContext>();
services.AddScoped<SeedingService>();
services.AddScoped<BasicQueryService>();

_serviceProvider = services.BuildServiceProvider();

//Retrieve instance of SeedingService from the container
_seedingService = _serviceProvider.GetRequiredService<SeedingService>();
_basicQueryService = _serviceProvider.GetRequiredService<BasicQueryService>();

//Call method to seed
await _seedingService.SeedDatabase();

Instructor? instructor = await _basicQueryService.GetInstructorById(3);

Console.WriteLine($"\nDept: {instructor.Department.Name}\n");

var jsonOptions = new JsonSerializerOptions { WriteIndented = true };

Console.WriteLine(JsonSerializer.Serialize(instructor, jsonOptions));

List<string> instrNames = await _basicQueryService.GetAllInstructorName();

foreach(string name in instrNames) {
    Console.WriteLine($"Name: {name}");
}

List<string> deptNames = await _basicQueryService.GetDeptNamesWithMoreThanOneCourse();

foreach(string name in deptNames) {
    Console.WriteLine($"Name: {name}");
}

List<string> deptMostCourses = await _basicQueryService.GetDeptWithMostCourses();

foreach(string name in deptMostCourses) {
    Console.WriteLine(name);
}

// the fitnessgram pacer test is a multistage aerobic capacity test that gets progressively harder as it continues