
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
    public class StudentService : IStudentService
    {
        private int _count = 1;
        private CourseGroupRepository _groupRepository;
        private StudentRepositor _studentRepositor;

        public StudentService()
        {
            _groupRepository = new CourseGroupRepository();
            _studentRepositor = new StudentRepositor();

            if (AppDbConText<Student>.datas.Count > 0)
            {
                _count = AppDbConText<Student>.datas.Max(s => s.id) + 1;
            }
        }

        public Student CreateStudent(int groupId, Student student)
        {
            var group = _groupRepository.GetGroupById(g => g.id == groupId);

            if (group is null || student is null)
            {
                return null;
            }

            student.id = _count;
            student.Group = group;
            _count++;

            AppDbConText<Student>.datas.Add(student);
            return student;
        }

        public Student Getstudentbyid(int id)
        {
            var student = AppDbConText<Student>.datas.Find(s => s.id == id);

            if (student is null)
            {
                Console.WriteLine("student not found");
            }

            return student;
        }

        public void DeleteStudent(int id)
        {
            var student = AppDbConText<Student>.datas.Find(s => s.id == id);

            if (student is null)
            {
                Console.WriteLine("student not found");
                return;
            }

            AppDbConText<Student>.datas.Remove(student);
           
        }

        public List<Student> GetStudentsByAge(int age)
        {
            var students = AppDbConText<Student>.datas
                .Where(s => s.Age == age)
                .ToList();

            if (students.Count == 0)
            {
                Console.WriteLine("student not fount age");
            }

            return students;
        }

        public List<Student> GetAllStudentsByGroupId(int groupId)
        {
            var students = AppDbConText<Student>.datas
                .Where(s => s.Group != null && s.Group.id == groupId)
                .ToList();

          

            return students;
        }

        public List<Student> SearchMethodForStudentsByName(string name)
        {
            var students = AppDbConText<Student>.datas
                .Where(s => !string.IsNullOrWhiteSpace(s.Name) &&
                            s.Name.ToLower().Contains(name.ToLower()))
                .ToList();
            return students;
        }

        public Student UpdateStudent(int id, Student student)
        {
            var Student = AppDbConText<Student>.datas.Find(s => s.id == id);

            return Student;
        }
    }
}
