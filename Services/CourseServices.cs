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
        List<Student> _studentsOfAcademy = new List<Student>();
        public List<Group> Groups => _groups;
        public List<Student> Students => _students;
        public List<Student> StudentsOfAcademy => _studentsOfAcademy;

        public string CreateNewGroup(string no, Category category)
        {
            if (string.IsNullOrEmpty(no) || string.IsNullOrWhiteSpace(no))
            {
                Console.WriteLine("Please enter right group number");
            }

            Group group = new Group(no, category);

            if (Groups.Count==0)
            {
                _groups.Add(group);

            }
            foreach (Group existedGroup in Groups)
            {
                if (group.No.ToLower().Trim()!=existedGroup.No.ToLower().Trim())
                {
                    _groups.Add(group);
                    return $"{group.No} group successfully created";
                }
            }
            return "Group can't created";
        }

        public string CreateStudent(int id ,string name,string surname,byte groupNumber, byte studentPoint)
        {
            if (string.IsNullOrEmpty(name)||string.IsNullOrEmpty(surname)
                ||groupNumber<=0||studentPoint<0)
                
            {
                Console.WriteLine("Please enter correct Information");
            }
            Student student = new Student(id,name,surname,groupNumber,false,studentPoint);

            foreach (Student existedStudent in Students)
            {
                if (student.Id!=existedStudent.Id)
                {
                    _students.Add(student);
                    return $"{student.FullName()} successfully added";
                }
                else
                {
                    return "This student already exist";
                }
            }
            return "Student can't added to group";
              
            
        }

        public void EditGroup(string oldNo,string newNo)
        {
            if (FindGroup(newNo) ==null)
            {
                Group group = FindGroup(oldNo);
                if (group != null)
                {
                    group.No = newNo.ToUpper().Trim();
                    Console.WriteLine($"{group.No} successfully edited");

                }
                else
                {
                    Console.WriteLine($"There is no group to edit => {oldNo.ToUpper()}");

                }
            }
            else
            {
                Console.WriteLine($"Group for edit => {newNo.ToUpper()}");

            }
        }

        public Group FindGroup(string no) 
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim()==no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }

        public void RemoveStudent()
        {
            throw new NotImplementedException();
        }

        public void ShowAllGroups()
        {
            if (Groups.Count>0)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                }
            }
            else
            {
                Console.WriteLine("There is no group");
            }
            
        }

        public void ShowAllStudentOfGroup(Group group)
        {
            
        }

        public void ShowAllStudentsOfAcademy()
        {
            throw new NotImplementedException();
        }
    }
}
