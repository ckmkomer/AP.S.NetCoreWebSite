using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NIJ35NE\\SQL2022; database=CvCore2ApiDb; integrated security=true");
        }

        public DbSet<YCategory> yCategories{ get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
