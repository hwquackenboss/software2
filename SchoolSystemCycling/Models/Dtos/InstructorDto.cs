using SchoolSystemCycling.Models.Entities;

namespace SchoolSystemCycling.Models.Dtos;

public class InstructorDto {
    public required string LastName { get; set; }
    public required string DepartmentName { get; set; }

    public int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName {get; set;}

    public DepartmentDto? Department {get; set;}
   
    public int DepartmentId { get; set; }

    public DateTime JoiningDate {get; set;}

   
}