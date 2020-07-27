using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformation.Api.Models
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly AppDbContext appDbContext;

        public SubjectRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Subject GetSubject(int subjectId)
        {
            return appDbContext.Subjects
                .FirstOrDefault(d => d.SubjectId == subjectId);
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return appDbContext.Subjects;
        }
    }
}
