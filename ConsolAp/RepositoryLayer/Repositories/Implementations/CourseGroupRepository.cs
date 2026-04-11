using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Exceptions;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseGroupRepository : ICourseGroupRepositories<CourseGroup>
    {
        public void CreatGroup(CourseGroup data)
        {
            try
            {
                if (data is null) throw new NotFoundExceptions("Data not found!");

                AppDbConText<CourseGroup>.datas.Add(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }


        public CourseGroup GetGroupById(Predicate<CourseGroup> predicate)
        {
            return predicate != null ? AppDbConText<CourseGroup>.datas.Find(predicate) : null;
        }
        public List<CourseGroup> GetAllGroups(Predicate<CourseGroup> predicate = null)
        {
           return predicate != null ? AppDbConText<CourseGroup>.datas.FindAll(predicate) : AppDbConText <CourseGroup >.datas;
        }
        public void DeleteGroup(int id)
        {
            throw new NotImplementedException();
        }


        public List<CourseGroup> GetAllGroupsByRoom(Predicate<CourseGroup> predicate)
        {
            throw new NotImplementedException();
        }

        public List<CourseGroup> GetAllGroupsByTeacher(Predicate<CourseGroup> predicate)
        {
            throw new NotImplementedException();
        }


        public List<CourseGroup> SearchMethodForGroupsByName(Predicate<CourseGroup> predicate)
        {
            throw new NotImplementedException();
        }

        public void UpdateGroup(CourseGroup data)
        {
            throw new NotImplementedException();
        }
    }
}
