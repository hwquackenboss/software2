using SchoolSystemCycling.Models.Entities;
using SchoolSystemCycling.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SchoolSystemCycling.Models.Dtos;

namespace SchoolSystemCycling.Services;

public class BasicQueryService {
    private readonly ApplicationDbContext _context;

    public BasicQueryService(ApplicationDbContext context) {
        _context = context;
    }

    public async Task<InstructorDto?> GetInstructorDtoByIdWithDept(int instructorId){
        
        
        
        return await _context.Instructors
            .Where(instr => instr.Id == instructorId)
            .Include(instr => instr.Department)
            .Select(instr => {})
            .SingleOrDefaultAsync();
    }
}