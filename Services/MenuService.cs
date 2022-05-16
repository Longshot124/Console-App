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
        public static Student student = new Student();
        public static void CreateCourseMenu() 
        {
            Group group = new Group();
            object category;
            string answer;
            Console.WriteLine("Please choose the category");
            foreach (var item in System.Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }
            bool resultCategory = System.Enum.TryParse(typeof(Category), Console.ReadLine(), out category);

            Console.WriteLine("Please enter group Number");
            group.No = Console.ReadLine();
            Console.WriteLine("Is this group oline?");
            answer = Console.ReadLine();
            if (answer.ToLower().Trim() == "yes") 
            {
                group.IsOnline = true;
            }
            else
            {
                group.IsOnline = false;
            }

            if (resultCategory)
            {
                
            }
            courseServices.CreateNewGroup(group.No,(Category)category);
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
