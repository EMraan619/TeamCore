using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetStudents();
        void Add(Student student,User user);
        void Edit(Student student);
        Student GetStudentById(int id);
        void DeleteStudentById(int id);

        void AddCourse(Course course);

        User ValidateUser(User user);


    }

}
