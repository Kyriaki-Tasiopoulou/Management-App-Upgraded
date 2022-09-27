using ProjectPartB.Core.Entities;
using ProjectPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Views.ViewPairEntities
{
    public class ViewPairCoursesTrainer
    {
        public int ChooseCourseToMatch(IEnumerable<Course> courses)
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
            Console.WriteLine("Choose a course by Id, that you want to add trainers to.");
            Console.ResetColor();
            string courseChoice;
            do
            {
                courseChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(courseChoice) || !courses.Select(s => s.Id).Contains(Convert.ToInt32(courseChoice)));
            return Convert.ToInt32(courseChoice);
        }

        public int ChooseTrainersToAddToCourse(IEnumerable<Trainer> trainers)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"FIRST NAME",space}{"LAST NAME",space}{"SUBJECT",space}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Id,space}{trainer.FirstName,space}{trainer.LastName,space}{trainer.Subject,space}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Choose a trainer by Id, that you want to add to this course");
            Console.ResetColor();
            string trainerChoice;
            do
            {
                trainerChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(trainerChoice) || !trainers.Select(t => t.Id).Contains(Convert.ToInt32(trainerChoice)));
            return Convert.ToInt32(trainerChoice);
        }
    }
}
