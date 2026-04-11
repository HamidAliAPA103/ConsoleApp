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
            CourseGroupControlers   courseGroupControlers = new();
            
             start: Helper.ConsolColor(ConsoleColor.Cyan, "Select one options! ");
            Helper.ConsolColor(ConsoleColor.Yellow, "1 - Creat group\n2 - Get group  by id\n3 - GetAll Group\n4 - Delete Library\n5 - Update Library ");

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
                            courseGroupControlers.GetAll ();
                            goto start;
                    }
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red , $"Add corret options type");
                    goto start;
                }
            }
        }
    }

 
}
