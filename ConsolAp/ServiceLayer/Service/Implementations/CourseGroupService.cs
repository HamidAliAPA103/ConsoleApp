using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Implementations;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Implementations
{
    public class CourseGroupService : ICourseGroupService
    {

        private CourseGroupRepository _groupRepository;
        private int count=1;
        public CourseGroupService()
        {
            _groupRepository = new CourseGroupRepository();
            
        }

        public CourseGroup CreatGroup(CourseGroup courseGroup)
        {
            courseGroup.id = count;
            _groupRepository.CreatGroup(courseGroup);
            count++;
            return courseGroup;
        }

        public CourseGroup GetGroupById(int id)
        {
            var group = AppDbConText<CourseGroup>.datas.Find(g => g.id == id);

            if (group is null)
            {
                Console.WriteLine("Null deyer olmaz");
            }

            return group;
        }
        public void DeleteGroup(int id)
        {
           CourseGroup courseGroup = GetGroupById (id);

            _groupRepository.DeleteGroup (courseGroup);
        }

        public List<CourseGroup> GetAllGroups()
        {
            return _groupRepository.GetAllGroups();
        }

        public List<CourseGroup> SearchMethodForGroupsByName(string name)
        {
            return _groupRepository.GetAllGroups(l=>l.Name.ToLower().Trim() == name.ToLower().Trim() );
        }
        public CourseGroup UpdateGroup(int id,CourseGroup courseGroup)
        {
            CourseGroup dbcourseGroup = GetGroupById (id);

            if (dbcourseGroup is null) return null ;

            dbcourseGroup.id = id;

            _groupRepository.UpdateGroup (dbcourseGroup);

            return GetGroupById (id);

        }
        public List<CourseGroup> GetAllGroupsByRoom(int room)
        {
            throw new NotImplementedException();
        }

        public List<CourseGroup> GetAllGroupsByTeacher(string teacher)
        {
            throw new NotImplementedException();
        }




    }
}




