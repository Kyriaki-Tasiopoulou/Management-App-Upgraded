using ProjectPartB.Core;
using ProjectPartB.Core.IRepositories;
using ProjectPartB.Persistence.Repositories;

namespace ProjectPartB.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MySchoolContext _context;

        public UnitOfWork(MySchoolContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Trainers = new TrainerRepository(_context);
            Students = new StudentRepository(_context);
            Assignments = new AssignmentRepository(_context);
        }

        public ICourseRepository Courses { get; }
        public ITrainerRepository Trainers { get; }
        public IStudentRepository Students { get; }
        public IAssignmentRepository Assignments { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}