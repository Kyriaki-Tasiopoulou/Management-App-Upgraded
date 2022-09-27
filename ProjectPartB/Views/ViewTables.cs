using ProjectPartB.Core.Entities;
using ProjectPartB.HelperClasses;
using System;
using System.Collections.Generic;
using ProjectPartB.HelperClasses.PrintTables;

namespace ProjectPartB.Views
{
    public class ViewTables
    {
        public static void PrintCourses(IEnumerable<Course> courses)
        {
            PrintCourseTable.PrintCourseTitle();
            PrintCourseTable.PrintCourseRows(courses);
        }

        public static void PrintTrainers(IEnumerable<Trainer> trainers)
        {
            PrintTrainerTable.PrintTrainerTitle();
            PrintTrainerTable.PrintTrainerRows(trainers);
        }

        public static void PrintStudents(IEnumerable<Student> students)
        {
            PrintStudentTable.PrintStudentTitle();
            PrintStudentTable.PrintStudentRows(students);
        }

        public static void PrintAssignments(IEnumerable<Assignment> assignments)
        {
            PrintAssignmentTable.PrintAssignmentTitle();
            PrintAssignmentTable.PrintAssignmentRows(assignments);
        }

        public static void PrintTrainersPerCourse(IEnumerable<Course> courses)
        {
            PrintCourseTrainerTable.PrintCourseTrainerTitle();
            PrintCourseTrainerTable.PrintCourseTrainerRows(courses);
        }

        public static void PrintStudentsPerCourse(IEnumerable<Course> courses)
        {
            PrintCourseStudentTable.PrintCourseStudentTitle();
            PrintCourseStudentTable.PrintCourseStudentRows(courses);
        }

        public static void PrintAssignmentsPerCourse(IEnumerable<Course> courses)
        {
            PrintCourseAssignmentTable.PrintCourseAssignmentTitle();
            PrintCourseAssignmentTable.PrintCourseAssignmentRows(courses);
        }

        public static void PrintAssignmentsPerStudent(IEnumerable<Student> students)
        {
            PrintStudentAssignmentTable.PrintStudentAssignmentTitle();
            PrintStudentAssignmentTable.PrintStudentAssignmentRows(students);
        }

        public static void PrintAStudentWithMultiCourses(IEnumerable<Student> students)
        {
            PrintStudentWithMultiCoursesTable.PrintStudentWithMultiCoursesTitle();
            PrintStudentWithMultiCoursesTable.PrintStudentWithMultiCoursesRows(students);
        }

        public static void PrintStudentsToReturnAssignments(IEnumerable<Assignment> assignments)
        {
            DateTime choice = PairInputDate.AskInputDate();
            List<int> calendarWeek = PairInputDate.MatchInputDateTime(choice);
            int count;
            PrintStudentsToReturnAssignmentsTable.PrintStudentsToReturnAssignmentsRows(assignments, calendarWeek, out count);
            if (count == 0) { Console.WriteLine($"No Students need to Sub an Assignment on {choice.ToShortDateString()}."); }
        }
    }
}
