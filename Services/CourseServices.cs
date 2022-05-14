using Console_Application.Enum;
using Console_Application.Interface;
using Console_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Services
{
    class CourseServices : IServices
    {
        List<Group> _groups = new List<Group>();
        List<Student> _students = new List<Student>();
        public List<Group> Groups => _groups;

        public List<Student> Students => _students;


        public void CreateNewGroup(Group group, Category category)
        {
            
        }

        

        public void CreateStudent()
        {
            
        }

       

        public void EditGroup()
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        public void ShowAllGroups(Group group)
        {
            foreach (Group _group in _groups)
            {
                
            }
        }

        public void ShowAllStudentOfGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowAllStudentsOfAcademy()
        {
            throw new NotImplementedException();
        }
    }
}
