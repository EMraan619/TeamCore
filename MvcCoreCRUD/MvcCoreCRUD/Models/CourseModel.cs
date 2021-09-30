using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCRUD.Models
{
    public class CourseModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public int  studentid { get; set; }
    }
}
