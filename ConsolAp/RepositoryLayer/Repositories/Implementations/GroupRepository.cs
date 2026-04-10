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
    public class GroupRepository : IRepositories<CourseGroup>
    {
        public void Add(CourseGroup data)
        {
           try
            {
                if (data is null) throw new NotFoundExceptions("Data not found!");

                AppDbConText<CourseGroup>.datas.Add(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
        }

        public void Delete(int id)
        {
            
        }

   

        public List<CourseGroup> GetAll(Predicate<CourseGroup> predicate)
        {
            throw new NotImplementedException();
        }

      
        public CourseGroup GetById(Predicate<CourseGroup> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(CourseGroup data)
        {
            throw new NotImplementedException();
        }
    }
}
