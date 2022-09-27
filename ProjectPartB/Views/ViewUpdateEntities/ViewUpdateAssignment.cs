using ProjectPartB.Core.Entities;
using ProjectPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Views.ViewUpdateEntities
{
    public class ViewUpdateAssignment
    {
        public int ChooseAssignmentToUpdate(IEnumerable<Assignment> assignments)
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"ID",space}{"TITLE",space}{"DESCRIPTION",space}{"SUB DATE TIME",space + 10}{"ORAL MARK",space + 15}{"TOTAL MARK",space}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Id,space}{assignment.Title,space}{assignment.Description,space}{assignment.SubDateTime.ToShortDateString(),space + 10}{assignment.OralMark,space + 15}{assignment.TotalMark,space}");
            }
            Console.WriteLine();
            Console.WriteLine($"Choose an assignment by Id, that you want to update.");
            Console.ResetColor();
            string assignmentsChoice;
            do
            {
                assignmentsChoice = Console.ReadLine();
            } while (!Validation.IsProperNumber(assignmentsChoice) || !assignments.Select(s => s.Id).Contains(Convert.ToInt32(assignmentsChoice)));
            return Convert.ToInt32(assignmentsChoice);
        }
    }
}