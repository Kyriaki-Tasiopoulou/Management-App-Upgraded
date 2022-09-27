using ProjectPartB.Core.Entities;
using ProjectPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartB.Views.ViewUpdateEntities
{
    public class ViewUpdateTrainer
    {
        public int ChooseTrainerToUpdate(IEnumerable<Trainer> trainers)
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
            Console.WriteLine($"Choose a trainer by Id, that you want to update");
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