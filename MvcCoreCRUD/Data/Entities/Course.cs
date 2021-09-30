using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("tb_Course")]
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int nameId { get; set; }
        public Student name { get; set; }
    }
}
