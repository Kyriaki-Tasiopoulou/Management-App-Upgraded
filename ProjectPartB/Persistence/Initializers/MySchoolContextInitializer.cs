using System;
using System.Collections.Generic;
using System.Data.Entity;
using ProjectPartB;
using ProjectPartB.Core.Entities;
using ProjectPartB.Core.Enums;
using ProjectPartB.HelperClasses.PairEntities;

namespace ProjectPartA_UnitOfWork_Sql.Persistence.Initializers
{
    public class MySchoolContextInitializer : DropCreateDatabaseAlways<MySchoolContext>
    {
        protected override void Seed(MySchoolContext context)
        {
            #region Seeding Courses

            // Seeding Courses
            Course c1 = new Course() { Title = "C#", Stream = "CB-8", Type = CourseType.FullTime, StartDate = new DateTime(2021, 10, 11), EndDate = new DateTime(2022, 04, 11) };
            Course c2 = new Course() { Title = "C#", Stream = "CB-8", Type = CourseType.PartTime, StartDate = new DateTime(2021, 10, 11), EndDate = new DateTime(2022, 01, 11) };
            Course c3 = new Course() { Title = "Java", Stream = "CB-8", Type = CourseType.FullTime, StartDate = new DateTime(2021, 11, 20), EndDate = new DateTime(2022, 04, 11) };
            Course c4 = new Course() { Title = "Java", Stream = "CB-8", Type = CourseType.PartTime, StartDate = new DateTime(2021, 11, 20), EndDate = new DateTime(2022, 01, 11) };
            #endregion

            #region Seeding Trainers

            // Seeding Trainers
            Trainer t1 = new Trainer() { FirstName = "Panos", LastName = "Sakelarios", Subject = "C#, Java" };
            Trainer t2 = new Trainer() { FirstName = "Stauros", LastName = "Gouleas", Subject = "C#" };
            Trainer t3 = new Trainer() { FirstName = "George", LastName = "Kessopoulos", Subject = "Java" };
            Trainer t4 = new Trainer() { FirstName = "Hlias", LastName = "Karagewrgos", Subject = "Java" };
            Trainer t5 = new Trainer() { FirstName = "Xarhs", LastName = "Papamixahl", Subject = "C#, Java" };
            #endregion

            #region Seeding Students

            // Seeding Students
            Student s1 = new Student() { FirstName = "Labros", LastName = "Papadimitriou", DateOfBirth = new DateTime(1992, 07, 18), TuitionFees = 2500 };
            Student s2 = new Student() { FirstName = "Giannis", LastName = "Mpatsinilas", DateOfBirth = new DateTime(1992, 10, 20), TuitionFees = 4000 };
            Student s3 = new Student() { FirstName = "Michalhs", LastName = "Kiaoulias", DateOfBirth = new DateTime(1991, 05, 13), TuitionFees = 3000 };
            Student s4 = new Student() { FirstName = "Viktoria", LastName = "Rontirh", DateOfBirth = new DateTime(1990, 12, 20), TuitionFees = 3500 };
            Student s5 = new Student() { FirstName = "Vera", LastName = "Romanou", DateOfBirth = new DateTime(1992, 06, 17), TuitionFees = 2500 };
            Student s6 = new Student() { FirstName = "Kostas", LastName = "Merzioths", DateOfBirth = new DateTime(1992, 07, 18), TuitionFees = 2500 };
            Student s7 = new Student() { FirstName = "Eygenios", LastName = "Kastanou", DateOfBirth = new DateTime(1989, 02, 10), TuitionFees = 2000 };
            Student s8 = new Student() { FirstName = "Apostolhs", LastName = "Galanhs", DateOfBirth = new DateTime(1993, 07, 28), TuitionFees = 5500 };
            Student s9 = new Student() { FirstName = "Parhs", LastName = "Fountoulhs", DateOfBirth = new DateTime(1988, 05, 22), TuitionFees = 3000 };
            Student s10 = new Student() { FirstName = "Thodwrhs", LastName = "Safos", DateOfBirth = new DateTime(1994, 01, 07), TuitionFees = 2500 };
            Student s11 = new Student() { FirstName = "Giwrgos", LastName = "Galazios", DateOfBirth = new DateTime(1994, 06, 18), TuitionFees = 2000 };
            Student s12 = new Student() { FirstName = "Manos", LastName = "Papoutsakhs", DateOfBirth = new DateTime(1993, 10, 16), TuitionFees = 4000 };
            Student s13 = new Student() { FirstName = "Evripidhs", LastName = "Papadakhs", DateOfBirth = new DateTime(1991, 05, 23), TuitionFees = 3000 };
            Student s14 = new Student() { FirstName = "Ismhnh", LastName = "Pardalakh", DateOfBirth = new DateTime(1990, 10, 19), TuitionFees = 3500 };
            Student s15 = new Student() { FirstName = "Rania", LastName = "Xatzinikolaou", DateOfBirth = new DateTime(1989, 07, 17), TuitionFees = 2500 };
            Student s16 = new Student() { FirstName = "Petros", LastName = "Tsalkas", DateOfBirth = new DateTime(1993, 02, 18), TuitionFees = 5500 };
            Student s17 = new Student() { FirstName = "Nikos", LastName = "Kalpakos", DateOfBirth = new DateTime(1990, 03, 08), TuitionFees = 3000 };
            Student s18 = new Student() { FirstName = "Alexhs", LastName = "Papastergiou", DateOfBirth = new DateTime(1985, 07, 25), TuitionFees = 5000 };
            Student s19 = new Student() { FirstName = "Nikos", LastName = "Ioannoglou", DateOfBirth = new DateTime(1987, 06, 23), TuitionFees = 3500 };
            Student s20 = new Student() { FirstName = "Vasiliki", LastName = "Flevarh", DateOfBirth = new DateTime(1991, 02, 17), TuitionFees = 2000 };
            #endregion

            #region Seeding Assignments
            // Seeding Assignments
            Assignment a1 = new Assignment() { Title = "Addition_C#_Full", Description = "Add 2 Numbers", SubDateTime = new DateTime(2021, 10, 30), OralMark = 40, TotalMark = 100 };
            Assignment a2 = new Assignment() { Title = "Substract_C#_Full", Description = "Substract 2 Numbers", SubDateTime = new DateTime(2021, 11, 25), OralMark = 40, TotalMark = 100 };
            Assignment a3 = new Assignment() { Title = "Multiply_C#_Full", Description = "Multiply 2 Numbers", SubDateTime = new DateTime(2021, 12, 30), OralMark = 40, TotalMark = 100 };
            Assignment a4 = new Assignment() { Title = "Division_C#_Full", Description = "Divide 2 Numbers", SubDateTime = new DateTime(2022, 01, 27), OralMark = 40, TotalMark = 100 };
            Assignment a5 = new Assignment() { Title = "Power_C#_Full", Description = "Find Power of 111", SubDateTime = new DateTime(2022, 02, 28), OralMark = 40, TotalMark = 100 };
            Assignment a6 = new Assignment() { Title = "Square_C#_Full", Description = "Find Square of 10", SubDateTime = new DateTime(2022, 03, 18), OralMark = 40, TotalMark = 100 };
            Assignment a7 = new Assignment() { Title = "Complex_C#_Full", Description = "Create a Complex Number", SubDateTime = new DateTime(2022, 04, 05), OralMark = 40, TotalMark = 100 };
            Assignment a8 = new Assignment() { Title = "Addition_C#_Part", Description = "Add 3 Numbers", SubDateTime = new DateTime(2021, 10, 15), OralMark = 60, TotalMark = 100 };
            Assignment a9 = new Assignment() { Title = "Substract_C#_Part", Description = "Substract 3 Numbers", SubDateTime = new DateTime(2021, 10, 30), OralMark = 60, TotalMark = 100 };
            Assignment a10 = new Assignment() { Title = "Multiply_C#_Part", Description = "Multiply 3 Numbers", SubDateTime = new DateTime(2021, 11, 09), OralMark = 60, TotalMark = 100 };
            Assignment a11 = new Assignment() { Title = "Division_C#_Part", Description = "Divide 3 Numbers", SubDateTime = new DateTime(2021, 11, 22), OralMark = 60, TotalMark = 100 };
            Assignment a12 = new Assignment() { Title = "Power_C#_Part", Description = "Find Power of 222", SubDateTime = new DateTime(2021, 12, 10), OralMark = 60, TotalMark = 100 };
            Assignment a13 = new Assignment() { Title = "Square_C#_Part", Description = "Find Square of 15", SubDateTime = new DateTime(2021, 12, 22), OralMark = 60, TotalMark = 100 };
            Assignment a14 = new Assignment() { Title = "Complex_C#_Part", Description = "Create two Complex Numbers", SubDateTime = new DateTime(2022, 01, 08), OralMark = 60, TotalMark = 100 };
            Assignment a15 = new Assignment() { Title = "Addition_Java_Full", Description = "Add 4 Numbers", SubDateTime = new DateTime(2021, 10, 23), OralMark = 40, TotalMark = 100 };
            Assignment a16 = new Assignment() { Title = "Substract_Java_Full", Description = "Substract 4 Numbers", SubDateTime = new DateTime(2021, 11, 18), OralMark = 40, TotalMark = 100 };
            Assignment a17 = new Assignment() { Title = "Multiply_Java_Full", Description = "Multiply 4 Numbers", SubDateTime = new DateTime(2021, 12, 22), OralMark = 40, TotalMark = 100 };
            Assignment a18 = new Assignment() { Title = "Division_Java_Full", Description = "Divide 4 Numbers", SubDateTime = new DateTime(2022, 01, 21), OralMark = 40, TotalMark = 100 };
            Assignment a19 = new Assignment() { Title = "Power_Java_Full", Description = "Find Power of 333", SubDateTime = new DateTime(2022, 02, 21), OralMark = 40, TotalMark = 100 };
            Assignment a20 = new Assignment() { Title = "Square_Java_Full", Description = "Find Square of 20", SubDateTime = new DateTime(2022, 03, 14), OralMark = 40, TotalMark = 100 };
            Assignment a21 = new Assignment() { Title = "Complex_Java_Full", Description = "Create three Complex Numbers", SubDateTime = new DateTime(2022, 04, 01), OralMark = 40, TotalMark = 100 };
            Assignment a22 = new Assignment() { Title = "Addition_Java_Part", Description = "Add 4 Numbers", SubDateTime = new DateTime(2021, 10, 17), OralMark = 60, TotalMark = 100 };
            Assignment a23 = new Assignment() { Title = "Substract_Java_Part", Description = "Substract 4 Numbers", SubDateTime = new DateTime(2021, 10, 28), OralMark = 60, TotalMark = 100 };
            Assignment a24 = new Assignment() { Title = "Multiply_Java_Part", Description = "Multiply 4 Numbers", SubDateTime = new DateTime(2021, 11, 06), OralMark = 60, TotalMark = 100 };
            Assignment a25 = new Assignment() { Title = "Division_Java_Part", Description = "Divide 4 Numbers", SubDateTime = new DateTime(2021, 11, 19), OralMark = 60, TotalMark = 100 };
            Assignment a26 = new Assignment() { Title = "Power_Java_Part", Description = "Find Power of 444", SubDateTime = new DateTime(2021, 12, 08), OralMark = 60, TotalMark = 100 };
            Assignment a27 = new Assignment() { Title = "Square_Java_Part", Description = "Find Square of 25", SubDateTime = new DateTime(2021, 12, 20), OralMark = 60, TotalMark = 100 };
            Assignment a28 = new Assignment() { Title = "Complex_Java_Part", Description = "Create four Complex Numbers", SubDateTime = new DateTime(2022, 01, 06), OralMark = 60, TotalMark = 100 };

            #endregion

            #region Pairting All Entities
            //Pair Trainers with courses
            SeedPairEntity.PairCourseTrainer(c2, t1);
            SeedPairEntity.PairCourseTrainer(c4, t1);
            SeedPairEntity.PairCourseTrainer(c1, t2);
            SeedPairEntity.PairCourseTrainer(c3, t3);
            SeedPairEntity.PairCourseTrainer(c3, t4);
            SeedPairEntity.PairCourseTrainer(c2, t5);
            SeedPairEntity.PairCourseTrainer(c4, t5);

            //Pair Students with Courses
            SeedPairEntity.PairCourseStudent(c1, s1);
            SeedPairEntity.PairCourseStudent(c1, s2);
            SeedPairEntity.PairCourseStudent(c1, s3);
            SeedPairEntity.PairCourseStudent(c1, s4);
            SeedPairEntity.PairCourseStudent(c1, s5);
            SeedPairEntity.PairCourseStudent(c1, s6);
            SeedPairEntity.PairCourseStudent(c3, s7);
            SeedPairEntity.PairCourseStudent(c3, s8);
            SeedPairEntity.PairCourseStudent(c3, s9);
            SeedPairEntity.PairCourseStudent(c2, s10);
            SeedPairEntity.PairCourseStudent(c4, s10);
            SeedPairEntity.PairCourseStudent(c2, s11);
            SeedPairEntity.PairCourseStudent(c4, s11);
            SeedPairEntity.PairCourseStudent(c2, s12);
            SeedPairEntity.PairCourseStudent(c4, s12);
            SeedPairEntity.PairCourseStudent(c2, s13);
            SeedPairEntity.PairCourseStudent(c4, s13);
            SeedPairEntity.PairCourseStudent(c2, s14);
            SeedPairEntity.PairCourseStudent(c4, s14);
            SeedPairEntity.PairCourseStudent(c2, s15);
            SeedPairEntity.PairCourseStudent(c4, s15);
            SeedPairEntity.PairCourseStudent(c2, s16);
            SeedPairEntity.PairCourseStudent(c4, s16);
            SeedPairEntity.PairCourseStudent(c2, s17);
            SeedPairEntity.PairCourseStudent(c4, s17);
            SeedPairEntity.PairCourseStudent(c2, s18);
            SeedPairEntity.PairCourseStudent(c4, s18);
            SeedPairEntity.PairCourseStudent(c2, s19);
            SeedPairEntity.PairCourseStudent(c4, s19);
            SeedPairEntity.PairCourseStudent(c2, s20);
            SeedPairEntity.PairCourseStudent(c4, s20);

            //Pair Assignments with Courses
            SeedPairEntity.PairCourseAssignment(c1, a1);
            SeedPairEntity.PairCourseAssignment(c1, a2);
            SeedPairEntity.PairCourseAssignment(c1, a3);
            SeedPairEntity.PairCourseAssignment(c1, a4);
            SeedPairEntity.PairCourseAssignment(c1, a5);
            SeedPairEntity.PairCourseAssignment(c1, a6);
            SeedPairEntity.PairCourseAssignment(c1, a7);
            SeedPairEntity.PairCourseAssignment(c2, a8);
            SeedPairEntity.PairCourseAssignment(c2, a9);
            SeedPairEntity.PairCourseAssignment(c2, a10);
            SeedPairEntity.PairCourseAssignment(c2, a11);
            SeedPairEntity.PairCourseAssignment(c2, a12);
            SeedPairEntity.PairCourseAssignment(c2, a13);
            SeedPairEntity.PairCourseAssignment(c2, a14);
            SeedPairEntity.PairCourseAssignment(c3, a15);
            SeedPairEntity.PairCourseAssignment(c3, a16);
            SeedPairEntity.PairCourseAssignment(c3, a17);
            SeedPairEntity.PairCourseAssignment(c3, a18);
            SeedPairEntity.PairCourseAssignment(c3, a19);
            SeedPairEntity.PairCourseAssignment(c3, a20);
            SeedPairEntity.PairCourseAssignment(c3, a21);
            SeedPairEntity.PairCourseAssignment(c4, a22);
            SeedPairEntity.PairCourseAssignment(c4, a23);
            SeedPairEntity.PairCourseAssignment(c4, a24);
            SeedPairEntity.PairCourseAssignment(c4, a25);
            SeedPairEntity.PairCourseAssignment(c4, a26);
            SeedPairEntity.PairCourseAssignment(c4, a27);
            SeedPairEntity.PairCourseAssignment(c4, a28);
            #endregion

            #region Populate MyDatabase
            // Populate MyDatabase
            IList<Course> courses = new List<Course>() { c1, c2, c3, c4 };
            IList<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            IList<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            IList<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };
            #endregion

            context.Courses.AddRange(courses);
            context.Trainers.AddRange(trainers);
            context.Students.AddRange(students);
            context.Assignments.AddRange(assignments);
            context.SaveChanges();

            base.Seed(context);

        }
    }
}
