using Courseapp.Controlers;
using Courseapp.Helpers;
using DomainLayer.Entities;
using ServiceLayer.Service.Implementations;
using System.Text.RegularExpressions;

namespace Courseapp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            CourseGroupControlers courseGroupControlers = new();
            StudentControlers studentControlers = new();

             start: Helper.ConsolColor(ConsoleColor.Cyan, "Select one options! ");
            GetMenu();

            while (true)
            {

                string selectoption = Console.ReadLine();
                int selectnum;
                bool isselectoption = int.TryParse(selectoption, out selectnum);

                if (isselectoption)
                {
                    switch (selectnum)
                    {
                        case (int)Menus.Creat:
                            courseGroupControlers.Creat();
                            goto start;
                        case (int)Menus.GetbyId :
                            courseGroupControlers.GetbyId();
                            goto start;
                        case (int)Menus.GetAll :
                            courseGroupControlers.GetAll();
                            goto start;
                        case (int)Menus.Delete :
                            courseGroupControlers.Delete();
                            goto start;
                        case (int)Menus.Update :
                            courseGroupControlers.Update();
                            goto start;
                        case (int)Menus.SearchGroupName:
                            courseGroupControlers.SearchGroupName();
                            goto start;
                        case (int)Menus.GetByRoom :
                            courseGroupControlers.GetByRoom();
                            goto start;
                        case (int)Menus.GetByTeacher :
                            courseGroupControlers.GetByTeacher();
                            goto start;
                        case (int)Menus.CreateStudent:
                             studentControlers.CreateStudent();
                            goto start;
                        case (int)Menus.GetStudentById:
                             studentControlers.GetStudentById();
                            goto start;
                        case (int)Menus.GetStudentByAge:
                             studentControlers.GetStudentByAge();
                            goto start;
                        case (int)Menus.DeleteStudent:
                             studentControlers.DeleteStudent();
                            goto start;
                        case (int)Menus.StudentsByName:
                             studentControlers.StudentsByName();
                            goto start;
                        case (int)Menus.AllStudentsGroupID :
                             studentControlers.AllStudentsGroupID();
                            goto start;
                        case (int)Menus.StudensBySurName  :
                             studentControlers.StudensBySurName();
                            goto start;
                    }
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, $"Add corret options type");
                    goto start;
                }
            }
        }

        public static void GetMenu()
        {
            Helper.ConsolColor(ConsoleColor.Yellow, "1 - Creat group\n2 - Get group  by id\n3 - GetAll Group\n4 - Delete Group\n5 - Update Group\n6 - Search Group Name\n7 - Get group  by room\n8 - Get group  by teacher\n9 - Creat student\n10 - Get student by id \n11 - Get Student by Age\n12 - Delete Student\n13 - Get Student by name\n14 - All student by ID Group\n15 - Get Student by surname");
        }
    }



}
