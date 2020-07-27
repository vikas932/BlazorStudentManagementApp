using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentInformation.Web.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;
        public StudentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        //    public async Task<IEnumerable<Student>> getAllStudentInfo()
        //    {
        //        return ;
        //    }
        //}
    }
}
