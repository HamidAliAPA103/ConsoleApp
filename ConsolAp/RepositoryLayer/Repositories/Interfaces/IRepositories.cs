using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    interface IRepositories<T> where T : BaseEntity 
    {
        void Add(T data);
        void Update(T data);
        void Delete(int id);
        T GetById(Predicate<T> predicate );
        List<T> GetAll(Predicate<T> predicate);
    }
}
