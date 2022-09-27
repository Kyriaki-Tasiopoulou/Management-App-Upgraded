using ProjectPartB.Core.Entities;
using ProjectPartB.Core.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Persistence.Repositories
{
    public class TrainerRepository : Repository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(MySchoolContext context)
            : base(context)
        {
        }

        public IEnumerable<Course> GetTrainersPerCourse(int pageIndex, int pageSize)
        {
            return MySchoolContext.Courses
                .Include("Trainers")
                .OrderBy(x => x.Title)
                .Skip(pageIndex)
                .Take(pageSize)
                .ToList();
        }

        public MySchoolContext MySchoolContext => Context as MySchoolContext;

    }
}