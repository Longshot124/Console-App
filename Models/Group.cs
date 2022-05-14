using Console_Application.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Models
{
    public class Group
    {
        public string No;
        public Category Category;
        public bool IsOnline;
        byte _limit;
        List<Student> students = new List<Student>();
        public static int count = 100;
        //List<Group> groups = new List<Group>();

        public Group(string no,Category category)
        {
            switch (category)
            {
                case Category.Programming:
                    No = $"P" + count;
                    break;
                case Category.Design:
                    No = $"D" + count;
                    break;
                case Category.SytemAdministration:
                    No = $"SA" + count;
                    break;
                default:
                    break;
            }
            Category = category;
        }

        public byte Limit { 
            get 
            {
                return _limit;
            } 
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    Console.WriteLine("This group is online ");
                }
                else if (IsOnline)
                {
                    _limit = 10;
                    Console.WriteLine("This group is offline");
                }
               
            } 
        }
        //public void AddStudent(Student student) 
        //{
        //    students.Add(student);
        //}


    }
}
