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

        start: Helper.ConsolColor(ConsoleColor.Cyan, "Select one options! ");
            Helper.ConsolColor(ConsoleColor.Yellow, "1 - Creat group\n2 - Get group  by id\n3 - GetAll Group\n4 - Delete Group\n5 - Update Group\n6 - Search Group Name ");

            while (true)
            {

                string selectoption = Console.ReadLine();
                int selectnum;
                bool isselectoption = int.TryParse(selectoption, out selectnum);

                if (isselectoption)
                {
                    switch (selectnum)
                    {
                        case 1:
                            courseGroupControlers.Creat();
                            goto start;
                        case 2:
                            courseGroupControlers.GetbyId();
                            goto start;
                        case 3:
                            courseGroupControlers.GetAll();
                            goto start;
                        case 4:
                            courseGroupControlers.Delete();
                            goto start;
                        case 5:
                            courseGroupControlers.Update();
                            goto start;
                        case 6:
                            courseGroupControlers.SearchGroupName();
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
    }


}
