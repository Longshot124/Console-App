using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Models
{
    public class Student
    {
        int _id;
        string _fullName;
        public byte GroupNumber;
        public bool Type;

        public Student(int id,string fullName,byte groupNumber,bool type)
        {
            _id = id;
            FullName = fullName;
            GroupNumber = groupNumber;
            Type = type;
        }

        public int Id 
        { get 
            {
                return _id;
            } 
           
        }

        public string FullName 
        {   get 
            {
                return _fullName;
            } 
            set 
            {
                if (value.Contains(' '))
                {
                    FullName = value;
                }
                else
                {
                    Console.WriteLine("Enter correct Name and Surname");
                }
            }
        }
    }
}
