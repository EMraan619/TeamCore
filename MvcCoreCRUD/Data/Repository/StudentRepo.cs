using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class StudentRepo : IStudentRepo
    {
        StudentContext context;
        public StudentRepo(StudentContext _context)
        {
            context = _context;
        }
        public void Add(Student student,User user)
        {
            context.Add(student);
            context.SaveChanges();
            user.StudentId = context.student.OrderByDescending(s => s.Id).FirstOrDefault().Id;
          
            context.Add(user);
            context.SaveChanges();
        }

        public void AddCourse(Course course)
        {
            context.Add(course);
            context.SaveChanges();
        }

        public void DeleteStudentById(int id)
        {
            if (id > 0)
            {
                
                var data1 = context.student.Where(s => s.Id == id).Include("Course").FirstOrDefault();
                context.Remove(data1);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"Cannot Found the data by that id ={id}");
            }
        }

        public void Edit(Student student)
        {
           if(student!=null)
            {
                context.Entry(student).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Student GetStudentById(int id)
        {
            if (id != 0)
            {
                return context.student.Where(s => s.Id == id).Include("Course").FirstOrDefault();
            }
            else
                return null;
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.student.Include("Course").ToList();
        }

        public User ValidateUser(User user)
        {
            var data = context.user.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            if (data != null)
            {
                return data;
            }
            else
            {
                return null;
            }
        }
    }
}
