using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.Services;

public class BasicQueryService {

    private readonly ApplicationDbContext _context;

    public BasicQueryService(ApplicationDbContext context) {

        _context = context;

    }

    public async Task<List<string>> GetAllInstructorName() {
        
        return await _context.Instructors
        .Select(Instructor => Instructor.FirstName)
        .ToListAsync();
        
    }

    public async Task<List<string>> GetDeptNamesWithMoreThanOneCourse() {

        return await _context.Departments
        .Where(dept => dept.Courses.Count > 1)
        .Select(dept => dept.Name)
        .ToListAsync();

    }

    public async Task<List<string>> GetDeptWithMostCourses() {

        return await _context.Departments
        .OrderBy(dept => dept.Courses.Count)
        .Take(1)
        .Select(Department => Department.Name)
        .ToListAsync();

    }

}