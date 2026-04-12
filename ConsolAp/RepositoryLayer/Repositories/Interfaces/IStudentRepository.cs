using DomainLayer.Common;
using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    interface IStudentRepository<T> where T : BaseEntity
    {
        void CreatStudent(T data);
        void UpdateStudenr(T data);
        void DeleteStudent(Student data);
        T GetstudentById(Predicate<T> predicate);
        List<T> GetStudentByAge(Predicate<T> predicate);
        List<T> GetAllStudentByGroupId(Predicate<T> predicate);
        List<T> SearchMethodForStudentsByName(Predicate<T> predicate);

    }
}
