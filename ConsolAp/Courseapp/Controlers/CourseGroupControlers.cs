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
    public class CourseGroupControlers
    {
        CourseGroupService service = new();
        public void Creat()
        {
            Helper.ConsolColor(ConsoleColor.Cyan, "Add Group Name");
            string groupname = Console.ReadLine();
            Helper.ConsolColor(ConsoleColor.Cyan, "Add Group Teacher");
            string groupteacher = Console.ReadLine();
        room: Helper.ConsolColor(ConsoleColor.Cyan, "Add Group Room");
            string grouproom = Console.ReadLine();
            int room;
            bool isgrouproom = int.TryParse(grouproom, out room);
            if (isgrouproom)
            {
                CourseGroup group = new CourseGroup { Name = groupname, Teacher = groupteacher, Room = room };

                var result = service.CreatGroup(group);

                Helper.ConsolColor(ConsoleColor.Green, $"Group:{group.id} - Group name:{group.Name} - Group teacher:{group.Teacher} - Group room:{group.Room} ");

            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Add corret room type");
                goto room;
            }
        }

        public void GetbyId()
        {
            groupid: Helper.ConsolColor(ConsoleColor.Cyan, "Add Group Id");

            string groupid = Console.ReadLine();

            int id;

            bool isid = int.TryParse(groupid, out id);

            if (isid)
            {
                CourseGroup courseGroup = service.GetGroupById(id);
                if (courseGroup != null)
                {
                    Helper.ConsolColor(ConsoleColor.Green, $"Group:{courseGroup.id} - Group name:{courseGroup.Name} - Group teacher:{courseGroup.Teacher} - Group room:{courseGroup.Room} ");
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Group not found");
                    goto groupid;
                }
            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Add corret  Group Id Type");
                goto groupid;
            }
        }

        public void GetAll()
        {
            List<CourseGroup >  courseGroup = service.GetAllGroups ();
            if ( courseGroup.Count != 0)
            {
                foreach (var  group in courseGroup)
                {
                    Helper.ConsolColor(ConsoleColor.Green, $"Group:{group.id} - Group name:{group.Name} - Group teacher:{group.Teacher} - Group room:{group.Room} ");
                }
            }else
            {
                Helper.ConsolColor(ConsoleColor.Red,"Pleas add Group");
            }
        }

        public void Delete()  
        {
        delete: Helper.ConsolColor(ConsoleColor.Cyan, "Add Group Id");

            string groupid = Console.ReadLine();

            int id;

            bool isid = int.TryParse(groupid, out id);
            List<CourseGroup> courseGroups = new();
            if (courseGroups.Count == 0)
            {
                Helper.ConsolColor(ConsoleColor.DarkRed, "Your dont have Group");
            }
            else
            {
                if (isid)
                {
                    CourseGroup courseGroup = service.GetGroupById(id);
                    if (courseGroup != null)
                    {
                        service.DeleteGroup(id);
                        Helper.ConsolColor(ConsoleColor.Green, $"Group{id} deleted successfully");
                    }
                    else
                    {
                        Helper.ConsolColor(ConsoleColor.Red, "Group not found");

                    }
                }
                else
                {
                    Helper.ConsolColor(ConsoleColor.Red, "Add corret  Group Id Type");
                    goto delete;
                }
            }
        }

        public void SearchGroupName()
        {
            Helper.ConsolColor(ConsoleColor.Cyan , "Add Group Search Name");
            string name = Console.ReadLine();
            List <CourseGroup > courseGroups =service.SearchMethodForGroupsByName (name);

            if (courseGroups.Count != 0)
            {
                foreach (var group in courseGroups)
                {
                    Helper.ConsolColor(ConsoleColor.Green, $"Group:{group.id} - Group name:{group.Name} - Group teacher:{group.Teacher} - Group room:{group.Room} ");
                }
            }
            else
            {
                Helper.ConsolColor(ConsoleColor.Red, "Group not found");
            }

        }
        public void Update()
        {
          Helper.ConsolColor(ConsoleColor.Cyan, "Add Group Id");

            string groupid = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(groupid))
            {
                Helper.ConsolColor(ConsoleColor.DarkRed, "Update operation canseled");
            }

            int id;

            bool isid = int.TryParse(groupid, out id);

            if ( isid)
            {
                var findgroup = service.GetGroupById(id);

                if (findgroup != null)
                {
                    Helper.ConsolColor(ConsoleColor.DarkBlue, $"Curren name{findgroup.Name} Add new group name");

                    string newgroupname = Console.ReadLine();

                    Helper.ConsolColor(ConsoleColor.DarkBlue, $"Curren teacher name{findgroup.Teacher} Add new teacher name");

                    string newteachername = Console.ReadLine();
                }
            }

        }
          


    }
}
