using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            


        }
        public DbSet<Student> student { get; set; }
        public DbSet<Course> course { get; set; }

        public DbSet<User> user { get; set; }


    }

}
