using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Implementations
{
    public class StudentRepository : IRepositories<Student>
    {
        public void Add(Student data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

     

        public List<Student> GetAll(Predicate<Student> predicate)
        {
            throw new NotImplementedException();
        }


        public Student GetById(Predicate<Student> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Student data)
        {
            throw new NotImplementedException();
        }
    }
}
