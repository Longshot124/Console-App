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
                Groups.Add(group);

            }
            foreach (Group existedGroup in Groups)
            {
                if (group.No.ToLower().Trim()!=existedGroup.No.ToLower().Trim())
                {
                    Groups.Add(group);
                    return $"{group.No} group successfully created";
                }
            }
            return "Group can't created";
        }

        public string CreateStudent(string name,string surname,string groupNumber,byte studentPoint)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
           // ||groupNumber<=0||studentPoint<0)               
            {
                Console.WriteLine("Please enter correct Information");
            }
            else
            {
                Student student = new Student(name,surname,groupNumber,studentPoint);

                Students.Add(student);
                Group group = new Group();
                group.Students.Add(student);
                return $"{student.FullName()} successfully added";
            }
            return "Student can't added to group";


            //else
            //{
            //    Students.Add(student);
            //}
            //Student student = new Student(name,surname,groupNumber,studentPoint);

            //foreach (Student existedStudent in Students)
            //{
            //    if (student.Name != existedStudent.Name)
            //    {
            //        //Students.Add(student);
            //        Group group = new Group();
            //        group.Students.Add(student);
            //        return $"{student.FullName()} successfully added";
            //    }
            //    else
            //    {
            //        return "This student already exist";
            //    }
            //}
            //return "Student can't added to group";


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
                else
                {
                    Console.WriteLine("Can't find group");
                }
            }
            return null;
        }

        public void RemoveStudent (string name, string surname, string groupNumber)

        {
            Student student = new Student();
            foreach (Student removeStudent in Students)
            {
                if (student.FullName()==removeStudent.FullName())
                {
                    Students.Remove(student);
                    Console.WriteLine("Student removed from group");
                }
                else
                {
                    Console.WriteLine("Can't find student, please enter correct student name and surname");
                }
            }
            
        }

        public void ShowAllGroups()
        {
            if (Groups.Count>0)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(Convert.ToString(group.No));
                }
            }
            else
            {
                Console.WriteLine("There is no group");
            }
            
        }

        public void ShowAllStudentOfGroup(string no)
        {
            Group group = FindGroup(no);
            if (group !=null)
            {
                foreach (Student student in Students)
                {
                    Console.WriteLine(student.Name+student.Surname);
                }
            }
            else
            {
                Console.WriteLine("There are no students");
            }
            
        }

        public void ShowAllStudentsOfAcademy()
        {
            if (Students.Count>1||Groups.Count>1)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                    foreach (Student student in Students)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
            else
            {
                 Console.WriteLine("There are no students in course");
            }
            
        }
    }
}
