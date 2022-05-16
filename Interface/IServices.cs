using Console_Application.Enum;
using Console_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Interface
{
    interface IServices
    {
        public List<Group> Groups { get; }
        public List<Student> Students { get; }
        //public List<Student> StudentsOfAcademy { get; }
        public string CreateStudent(string name,string surname, string groupNumber, byte studentPoint);
        public void RemoveStudent(string name,string surname,string groupNumber);
        public string CreateNewGroup(string no,Category category);
        public void ShowAllGroups();
        public void EditGroup(string oldNo, string newNo);
        public void ShowAllStudentOfGroup(string no);
        public void ShowAllStudentsOfAcademy();

        
    }
}
