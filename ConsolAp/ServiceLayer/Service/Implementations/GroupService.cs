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
    class GroupService : IGroupService
    {

        private GroupRepository groupRepository;
        private int count;
        public GroupService()
        {
            groupRepository = new GroupRepository();
            count = 1;
        }
        public CourseGroup Add(CourseGroup courseGroup)
        {
            courseGroup.id = count;
            groupRepository.Add(courseGroup);
            count++;
            return courseGroup;
        }

        public void Delete(int id)
        {
            var group = AppDbConText<CourseGroup>.datas.Find(g => g.id == id);

            if( group is null)
            {
                Console.WriteLine("Null deyer yazilmaz");
            }
            AppDbConText<CourseGroup>.datas.Remove(group);
            


        }

        public CourseGroup GetById(int id)
        {
            var group = AppDbConText<CourseGroup>.datas.Find(g => g.id == id);

            if ( group is null)
            {
                Console.WriteLine("Null deyer olmaz");
            }

           return group;

            
        }

        public CourseGroup Update(int id, CourseGroup courseGroup)
        {
            throw new NotImplementedException();
        }
    }
}
