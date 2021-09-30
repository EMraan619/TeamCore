
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCRUD.Models
{
    public class Mapper
    {
        public static Data.Entities.Student Map(Models.StudentModel student)
        {
            return new Data.Entities.Student()
            {
                Id = student.id,
                Name = student.name,
                
            };

        }
        public static IEnumerable<Models.StudentModel> Map(IEnumerable<Data.Entities.Student> student) => student.Select(Map);

        public static Models.StudentModel Map(Data.Entities.Student student)
        {
            return new Models.StudentModel()
            {
                id = student.Id,
                name = student.Name,
                course =(Map(student.Course).ToList()==null)?null: Map(student.Course).ToList()
            };
        }
        public static Data.Entities.Course MapCourse(Models.CourseModel course,int id)
        {
            return new Data.Entities.Course()
            {
                
                Title = course.title,
                nameId=id
            };

        }
        public static Models.CourseModel MapCourse(Data.Entities.Course course)
        {
            return new Models.CourseModel()
            {
                id = course.Id,
                title = course.Title,
                studentid = course.name.Id
            };

        }
        public static Data.Entities.User MapUser(Models.StudentModel user)
        {
            return new Data.Entities.User()
            {
                
                Username = user.Username,
                Password=user.Password,
            
            };

        }
        public static IEnumerable<Models.CourseModel> Map(IEnumerable<Data.Entities.Course> course) => course.Select(MapCourse);

    }
}
