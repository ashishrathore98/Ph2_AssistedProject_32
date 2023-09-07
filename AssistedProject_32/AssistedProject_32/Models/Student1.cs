using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssistedProject_32.Models
{
    public class GenericDBContext : DbContext
    {
        public GenericDBContext()
           : base("School1Entities")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
