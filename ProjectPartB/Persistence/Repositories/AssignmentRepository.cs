using ProjectPartB.Core.Entities;
using ProjectPartB.Core.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Persistence.Repositories
{
    public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(MySchoolContext context)
            : base(context)
        {
        }

        public IEnumerable<Course> GetAssignmentsPerCourse(int pageIndex, int pageSize)
        {
            return MySchoolContext.Courses
                .Include("Assignments")
                .OrderBy(x => x.Title)
                .Skip(pageIndex)
                .Take(pageSize)
                .ToList();
        }

        public IEnumerable<Student> PrintAssignmentsPerStudent(int pageIndex, int pageSize)
        {
            return MySchoolContext.Students
                .Include("Courses")
                .OrderBy(x => x.FirstName)
                .Skip(pageIndex)
                .Take(pageSize)
                .ToList();
        }

        public MySchoolContext MySchoolContext => Context as MySchoolContext;
    }
}