using Courseapp.Helpers;
using DomainLayer.Entities;
using ServiceLayer.Service.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseapp.Controlers
{
    public class StudentControlers
    {
        StudentService studentService = new();
        CourseGroupService GroupService = new();
        public void CreateStudent()

        {
        StudentID: Helper.ConsolColor(ConsoleColor.Cyan, "Add Group Id");

            string groupid = Console.ReadLine();

            int id;

            bool isid = int.TryParse(groupid, out id);

            if (isid)
            {

                var findgroup = GroupService.GetGroupById(id);

                if (findgroup is null)
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Group not found");
                    goto StudentID;
                }

            Studentname: Helper.ConsolColor(ConsoleColor.Blue, "Add student name");

                string studentname = Console.ReadLine();

                if (string.IsNullOrEmpty(studentname))
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Pleas add name");
                    goto Studentname;
                }

            Studentsurmane: Helper.ConsolColor(ConsoleColor.Blue, "Add student surname");

                string studentsurname = Console.ReadLine();

                if (string.IsNullOrEmpty(studentsurname))
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Pleas add surname");
                    goto Studentsurmane;
                }

            Studentage: Helper.ConsolColor(ConsoleColor.Blue, "Add student age");

                string studentage = Console.ReadLine();

                if (string.IsNullOrEmpty(studentage))
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Pleas add age");
                    goto Studentage;
                }

                int age;

                bool isage = int.TryParse(studentage, out age);

                Student student = new Student { Name = studentname, Age = age, Surname = studentsurname };

                var result = studentService.CreateStudent(id, student);

                if (result != null)
                {
                    Helper.ConsolColor(ConsoleColor.Green, $"Student ID:{student.id} - Student name:{student.Name} - Student surname:{student.Surname} - Student Age : {student.Age} - Student Group : {result.Group.Name} ");
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Student not creat");
                }

            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Add correct ID type");
                goto StudentID;
            }
        }

        public void GetStudentById()
        {
        StudentID: Helper.ConsolColor(ConsoleColor.Cyan, "Add student Id");
            string studentid = Console.ReadLine();
            if (string.IsNullOrEmpty(studentid))
            {
                Helper.ConsolColor(ConsoleColor.Red, "Pleas add Id");
                goto StudentID;
            }
            int id;
            bool isid = int.TryParse(studentid, out id);

            if (isid)
            {
                Student student = studentService.Getstudentbyid(id);

                if (student != null)
                {
                    Helper.ConsolColor(ConsoleColor.Green, $"Student ID:{student.id} - Student name:{student.Name} - Student surname:{student.Surname} - Student Age : {student.Age} - Student Group : {student.Group.Name} ");
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Student not found");
                    goto StudentID;
                }
            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Add corret ID type");
                goto StudentID;
            }
        }

        public void GetStudentByAge()
        {
        Studentage: Helper.ConsolColor(ConsoleColor.Cyan, "Add student age");
            string studentid = Console.ReadLine();
            if (string.IsNullOrEmpty(studentid))
            {
                Helper.ConsolColor(ConsoleColor.Red, "Pleas add age");
                goto Studentage;
            }
            int age;
            bool isid = int.TryParse(studentid, out age);

            if (isid)
            {
                List<Student> student = studentService.GetStudentsByAge(age);

                if (student != null)
                {
                    foreach (var ages in student)
                    {
                        Helper.ConsolColor(ConsoleColor.Green, $"Student ID:{ages.id} - Student name:{ages.Name} - Student surname:{ages.Surname} - Student Age : {ages.Age} - Student Group : {ages.Group.Name} ");
                    }
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Student not found");
                    goto Studentage;
                }
            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Add corret ID type");
                goto Studentage;
            }
        }
        public void DeleteStudent()
        {
        Delete: Helper.ConsolColor(ConsoleColor.Cyan, "Add student Id");
            string studentid = Console.ReadLine();
            if (string.IsNullOrEmpty(studentid))
            {
                Helper.ConsolColor(ConsoleColor.Red, "Pleas add Id");
                goto Delete;
            }
            int id;
            bool isid = int.TryParse(studentid, out id);

            if (isid)
            {
                Student student = studentService.Getstudentbyid(id);
                if (student != null)
                {
                    studentService.DeleteStudent(id);
                    Helper.ConsolColor(ConsoleColor.Cyan, $"Student ID : {id} delete succesfully");
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, $"You dont have a Student this ID{id}");
                }
            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Add corret ID type");
            }
        }
        public void StudentsByName()
        {
           name: Helper.ConsolColor(ConsoleColor.Cyan, "Add Student Name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Helper.ConsolColor(ConsoleColor.Red, "Pleas add name");
                goto name;
            }

            List<Student> students = studentService.SearchMethodForStudentsByName(name);

            if (students.Count != 0)
            {
                foreach (Student student in students)
                {
                    Helper.ConsolColor(ConsoleColor.Green, $"Student ID:{student.id} - Student name:{student.Name} - Student surname:{student.Surname} - Student Age : {student.Age} - Student Group : {student.Group.Name} ");
                }
            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, $"Dont have a Student this name{name}");
                goto name;
            }

        }

        public void AllStudentsGroupID()
        {
        GroupID: Helper.ConsolColor(ConsoleColor.Cyan, "Add group Id");
            string studentid = Console.ReadLine();
            if (string.IsNullOrEmpty(studentid))
            {
                Helper.ConsolColor(ConsoleColor.Red, "Pleas add Id");
                goto GroupID;
            }
            int id;
            bool isid = int.TryParse(studentid, out id);

            if (isid)
            {
                List <Student > students =studentService.GetAllStudentsByGroupId (id);

                if (students.Count != 0)
                {
                    foreach (Student student in students)
                    {
                        Helper.ConsolColor(ConsoleColor.Green, $"Student ID:{student.id} - Student name:{student.Name} - Student surname:{student.Surname} - Student Age : {student.Age} - Student Group : {student.Group.Name} ");
                    }
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, "This group dont have a student");
                    goto GroupID;
                }
            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Pleas add corret ID type");
                goto GroupID;
            }
        }


    }
}

