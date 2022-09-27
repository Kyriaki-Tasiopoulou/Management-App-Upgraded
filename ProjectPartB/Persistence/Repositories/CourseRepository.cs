using ProjectPartB.Core.Entities;
using ProjectPartB.Core.IRepositories;

namespace ProjectPartB.Persistence.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(MySchoolContext context)
            : base(context)
        {
        }

        public MySchoolContext MySchoolContext => Context as MySchoolContext;
    }
}