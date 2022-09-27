using ProjectPartB.Core.Entities;
using ProjectPartB.Core.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Persistence.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(MySchoolContext context)
            : base(context)
        {
        }

        public IEnumerable<Course> GetStudentsPerCourse(int pageIndex, int pageSize)
        {
            return MySchoolContext.Courses
                .Include("Students")
                .OrderBy(x => x.Title)
                .Skip(pageIndex)
                .Take(pageSize)
                .ToList();
        }

        public IEnumerable<Student> PrintAStudentWithMultiCourses(int pageIndex, int pageSize)
        {
            return MySchoolContext.Students
                .Include("Courses")
                .OrderBy(x => x.FirstName)
                .Skip(pageIndex)
                .Take(pageSize)
                .ToList();
        }

        public IEnumerable<Assignment> PrintStudentsToReturnAssignments(int pageIndex, int pageSize)
        {
            return MySchoolContext.Assignments
                .Include("Course")
                .OrderBy(x => x.Title)
                .Skip(pageIndex)
                .Take(pageSize)
                .ToList();
        }

        public MySchoolContext MySchoolContext => Context as MySchoolContext;
    }
}