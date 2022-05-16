using Console_Application.Models;
using Console_Application.Services;
using System;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our academy");
            int selection;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1.Create Group");
                Console.WriteLine("2.Add Student");
                Console.WriteLine("3.Edit Group");
                Console.WriteLine("4.Remove Student");
                Console.WriteLine("5.Show All Groups");
                Console.WriteLine("6.Show All students of group");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        MenuService.CreateCourseMenu();
                        break;
                    case 2:
                        MenuService.CreateStudentAddMenu();
                        break;
                    case 3:
                        MenuService.EditGroupMenu();
                        break;
                    case 4:
                        MenuService.RemoveStudentMenu();
                        break;
                    case 5:
                        MenuService.ShowAllGrupsMenu();
                        break;
                    case 6:
                        MenuService.ShowAllStudentsOfGroupMenu();
                        break;
                    
                    default:
                        Console.WriteLine("oops program can't understand you");
                        break;
                }
            } while (selection!=0);

            
            
        }
    }
}
