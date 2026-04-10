using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interfaces
{
    interface IGroupService
    {
        CourseGroup Add(CourseGroup courseGroup);
        CourseGroup Update(int id , CourseGroup courseGroup );
        void Delete(int id);
        CourseGroup GetById(int id);
    }
}
