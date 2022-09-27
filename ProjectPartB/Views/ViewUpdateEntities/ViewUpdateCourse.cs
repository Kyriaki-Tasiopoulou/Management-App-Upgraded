using ProjectPartB.Core.Entities;
using ProjectPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Views.ViewUpdateEntities
{
    public class ViewUpdateCourse
    {
        public int ChooseCourseToUpdate(IEnumerable<Course> courses)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"TITLE",space}{"STREAM",space}{"TYPE",space}{"START DATE",space}{"END DATE",space}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,space}{course.Title,space}{course.Stream,space}{course.Type,space}{course.StartDate.ToShortDateString(),space}{course.EndDate.ToShortDateString(),space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose a course by Id, that you want to update");
            Console.ResetColor();
            string courseChoice;
            do
            {
                courseChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(courseChoice) || !courses.Select(s => s.Id).Contains(Convert.ToInt32(courseChoice)));
            return Convert.ToInt32(courseChoice);
        }
    }
}