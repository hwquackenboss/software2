using SchoolSystemCycling.Models.Dtos;
using SQLitePCL;

public class DepartmentDto{

    public int Id {get; set;}
    public required string Name {get; set;}
    public ICollection<InstructorDto> InstructorDtos { get; set; } = new List<InstructorDto>();

    public required string test {get; set;}
    public required string tests {get; set;}

    public required string yes {get; set;}
}