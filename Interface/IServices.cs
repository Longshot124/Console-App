using Console_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Interface
{
    interface IServices
    {
        public void CreateStudent(Student student);
        public void RemoveStudent(Student student);
        public void CreateNewGroup(Group group);
        public void ShowAllGroups(Group group);
        public void EditGroup();
        public void ShowAllStudentOfGroup();
        public void ShowAllStudentsOfAcademy();

        public List<Group> Groups { get; }
        public List<Student> Students { get; }
    }
}
