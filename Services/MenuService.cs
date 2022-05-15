using Console_Application.Enum;
using Console_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Services
{
    static class MenuService
    {
        public static CourseServices courseServices = new CourseServices();
        public static void CreateCourseMenu() 
        {
            Group group = new Group();

            Console.WriteLine($"Please choose the selection");

            object category;
            bool categoryResult = System.Enum.TryParse(typeof(Category), Console.ReadLine(),out category);
            byte selection = 0;
            Console.WriteLine("1.Yes \n 2.No");
            if (selection==1)
            {
                group.IsOnline = true;
            }
            if (selection==2)
            {
                group.IsOnline = false;
            }
            else
            {
                Console.WriteLine("Please select one of the variants");
            }



        }
        //public static void CreateNewGroupMenu()
        //{
        //    Console.WriteLine("Please enter new group number");
        //    string No = Console.ReadLine();
        //    Console.WriteLine("Please choose group category");
        //    Category category =
        //}
        public static void CreateStudentAddMenu()
        {
            Console.WriteLine("Please enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter student surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter groupNumber");
            string groupNumber = Console.ReadLine();
            Console.WriteLine("Please enter student Points");
            byte studentPoint = Convert.ToByte(Console.ReadLine());

            courseServices.CreateStudent(name, surname,groupNumber,studentPoint);
        }
        public static void EditGroupMenu() 
        {
            Console.WriteLine("Please enter group number which you search");
            string oldNo = Console.ReadLine();
            Console.WriteLine("Please enter new group number ");
            string newNo = Console.ReadLine();
            courseServices.EditGroup(oldNo,newNo);
        }
        public static void RemoveStudentMenu() 
        {
            Console.WriteLine("Please enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter student surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter group number");
            string groupNumber = Console.ReadLine();
            courseServices.RemoveStudent(name,surname,groupNumber);
        }

        public static void ShowAllGrupsMenu ()
        {
            courseServices.ShowAllGroups();
        }
        

    }
}
