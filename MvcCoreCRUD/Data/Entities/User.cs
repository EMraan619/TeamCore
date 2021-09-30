using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("tb_user")]
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student student { get; set; }

    }
}
