using ProjectPartB.Core.Entities;
using ProjectPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Views.ViewPairEntities
{
    public class ViewPairCoursesStudent
    {
        public int ChooseCourseToMatch(IEnumerable<Course> courses)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"TITLE",space}{"STREAM",space}{"TYPE",space}{"STARTING DATE",space}{"ENDING DATE",space}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,space}{course.Title,space}{course.Stream,space}{course.Type,space}{course.StartDate.ToShortDateString(),space}{course.EndDate.ToShortDateString(),space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose a course by Id, that you want to add students to.");
            Console.ResetColor();
            string courseChoice;
            do
            {
                courseChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(courseChoice) || !courses.Select(s => s.Id).Contains(Convert.ToInt32(courseChoice)));
            return Convert.ToInt32(courseChoice);
        }

        public int ChooseStudentsToAddToCourse(IEnumerable<Student> students)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"FIRST NAME",space}{"LAST NAME",space}{"DATE OF BIRTH",space}{"TUITION FEES",space}");
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id,space}{student.FirstName,space}{student.LastName,space}{student.DateOfBirth.ToShortDateString(),space}{student.TuitionFees,space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Choose a student by Id, that you want to add to this course");
            Console.ResetColor();
            string studentChoice;
            do
            {
                studentChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(studentChoice) || !students.Select(s => s.Id).Contains(Convert.ToInt32(studentChoice)));
            return Convert.ToInt32(studentChoice);
        }
    }
}
