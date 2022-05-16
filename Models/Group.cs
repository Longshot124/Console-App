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
        public List<Student> Students;
        public static int count = 100;
        

        public Group(string no,Category category)
        {
            No = no;
            IsOnline = false;
            switch (category)
            {
                case Category.Programming:
                    No = $"P" + No;
                    break;
                case Category.Design:
                    No = $"D" + No;
                    break;
                case Category.SytemAdministration:
                    No = $"SA" + No;
                    break;
                default:
                    break;
            }
            Category = category;
        }
        public Group()
        {
            Students = new List<Student>();
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
        


    }
}
