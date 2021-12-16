using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class TemplateContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(connectionString: "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DENEME_DB;Trusted_Connection=True;MultipleActiveResultSets=true");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public virtual DbSet<Template> Templates { get; set; }
    }
}
