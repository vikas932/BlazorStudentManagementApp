using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformation.Api.Models
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentInfo();
        Task<Student> GetStudentDetailsById(int studentId);
        
    }
}
