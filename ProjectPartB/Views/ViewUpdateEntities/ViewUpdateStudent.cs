using ProjectPartB.Core.Entities;
using ProjectPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Views.ViewUpdateEntities
{
    public class ViewUpdateStudent
    {
        public int ChooseStudentToUpdate(IEnumerable<Student> students)
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
            Console.WriteLine($"Choose a student by Id, that you want to update.");
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