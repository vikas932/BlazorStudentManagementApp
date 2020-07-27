using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentInformation.Api.Models;
using System;
using StudentInformation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformation.Api.Contoller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllStudentInfo()
        {
            return Ok(await studentRepository.GetAllStudentInfo());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentDetailsById(int id)
        {
            var result = await studentRepository.GetStudentDetailsById(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
