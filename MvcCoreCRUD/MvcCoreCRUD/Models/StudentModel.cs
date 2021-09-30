using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCRUD.Models
{
    public class StudentModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<CourseModel> course { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
