using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Exceptions;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Implementations
{
    public  class StudentRepositor : IStudentRepository<Student>
    {
        public void CreatStudent(Student data)
        {
            try
            {
                if (data is null) throw new NotFoundExceptions("Student not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
        }

        public void DeleteStudent(Student data )
        {
            AppDbConText<Student >.datas.Remove ( data );
        }

        public Student GetstudentById(Predicate<Student> predicate)
        {
            return predicate != null ? AppDbConText<Student>.datas.Find(predicate) : null;
        }
        public List<Student> GetAllStudentByGroupId(Predicate<Student> predicate)
        {
            return predicate != null ? AppDbConText<Student>.datas.FindAll(predicate) : AppDbConText<Student>.datas;
        }

        public List<Student> GetStudentByAge(Predicate<Student> predicate)
        {
            return predicate != null ? AppDbConText<Student>.datas.FindAll(predicate) : AppDbConText<Student>.datas;
        }


        public List<Student> SearchMethodForStudentsByName(Predicate<Student> predicate)
        {
            return predicate != null ? AppDbConText<Student>.datas.FindAll(predicate) : AppDbConText<Student>.datas;
        }

        public void UpdateStudenr(Student data)
        {
            throw new NotImplementedException();
        }
    }
}
