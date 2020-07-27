using Microsoft.EntityFrameworkCore;
using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformation.Api.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext appDbContext;

        public StudentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Student>> GetAllStudentInfo()
        {
            return await appDbContext.Students.ToListAsync();
        }

        public async Task<Student> GetStudentDetailsById(int studentId)
        {
            return await appDbContext.Students
                .FirstOrDefaultAsync(e => e.StudentId == studentId);
        }
    }
}
