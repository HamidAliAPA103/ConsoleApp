using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interfaces
{
    interface ICourseGroupService
    {
  
        CourseGroup  CreatGroup(CourseGroup courseGroup );
        CourseGroup  UpdateGroup(int id,CourseGroup courseGroup  );
        void DeleteGroup(int id);
        CourseGroup  GetGroupById(int id);
        List<CourseGroup > GetAllGroupsByTeacher(string teacher );

        List<CourseGroup > GetAllGroupsByRoom(int room);
        List<CourseGroup> GetAllGroups();

        List<CourseGroup> SearchMethodForGroupsByName(string name );

    }
}
