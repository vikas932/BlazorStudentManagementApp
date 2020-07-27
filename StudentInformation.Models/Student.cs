using System;

namespace StudentInformation.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int SubjectId { get; set; }
    }
}
