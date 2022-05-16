using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Models
{
    public class Student
    {
        public  int Id;
        //private uint _id;
        public string Name;
        public string Surname;
        public string GroupNumber;
        public byte StudentPoint;
        public bool Guarantee;
        public static uint count;

        public Student(string name, string surname, string groupNumber,byte studentPoint)
        {
            
            Name = name;
            Surname = surname;
            GroupNumber = groupNumber;
            StudentPoint = studentPoint;
            
            
        }
        public Student()
        {

        }

        //public uint Id
        //{
        //    get
        //    {
        //        return _id;
        //    }
        //    //set
        //    //{
        //    //    Id = value;
        //    //}

        //}

        public string FullName()
        {
           return $"Name : {Name} \n Surname : {Surname} \n GroupNumber : {GroupNumber} \n Id : {Id}";
        }


    }
}
