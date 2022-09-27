using ProjectPartB.Core.Entities;
using System.Data.Entity;
using ProjectPartA_UnitOfWork_Sql.Persistence.Initializers;

namespace ProjectPartB
{
    public class MySchoolContext : DbContext
    {
        public MySchoolContext() : base("name=MySchoolContext")
        {
            Database.SetInitializer<MySchoolContext>(new MySchoolContextInitializer());
            Database.Initialize(true);
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
    }
}