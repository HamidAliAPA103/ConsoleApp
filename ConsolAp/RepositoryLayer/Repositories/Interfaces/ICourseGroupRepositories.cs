using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    interface ICourseGroupRepositories<T> where T : BaseEntity
    {
        void CreatGroup(T data);
        void UpdateGroup(T data);
        void DeleteGroup(int id);
        T GetGroupById(Predicate<T> predicate);
        List<T> GetAllGroupsByTeacher(Predicate<T> predicate);

        List<T> GetAllGroupsByRoom(Predicate<T> predicate);
        List<T> GetAllGroups(Predicate<T> predicate);

        List<T> SearchMethodForGroupsByName(Predicate<T> predicate);
        
    }
}
