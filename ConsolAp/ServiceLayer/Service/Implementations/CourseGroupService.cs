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

        public void DeleteGroup(int id)
        {
            var group = AppDbConText<CourseGroup>.datas.Find(g => g.id == id);

            if (group is null)
            {
                Console.WriteLine("Null deyer yazilmaz");
            }
            AppDbConText<CourseGroup>.datas.Remove(group);
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

        public List<CourseGroup> GetAllGroups()
        {
            return _groupRepository.GetAllGroups();
        }

        public List<CourseGroup> GetAllGroupsByRoom(int room)
        {
            throw new NotImplementedException();
        }

        public List<CourseGroup> GetAllGroupsByTeacher(string teacher)
        {
            throw new NotImplementedException();
        }


        public List<CourseGroup> SearchMethodForGroupsByName(string name)
        {
            throw new NotImplementedException();
        }

        public CourseGroup UpdateGroup(CourseGroup courseGroup)
        {
            throw new NotImplementedException();
        }
    }
}




