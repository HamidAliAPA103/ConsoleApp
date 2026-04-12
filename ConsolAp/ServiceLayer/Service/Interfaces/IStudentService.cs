using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interfaces
{
     interface IStudentService
    {
        Student CreateStudent(int groupId, Student student);
        Student UpdateStudent(int id, Student student);
        Student Getstudentbyid(int id);
        void DeleteStudent(int id);

        List<Student> GetAllStudentsByGroupId(int groupId);
        List<Student> SearchMethodForStudentsByName(string name);
        List<Student> GetStudentsByAge(int age);

    }
}
