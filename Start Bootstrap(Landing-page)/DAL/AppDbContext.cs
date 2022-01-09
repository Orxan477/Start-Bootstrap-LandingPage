using Microsoft.EntityFrameworkCore;
using Start_Bootstrap_Landing_page_.Models;
using System.Collections.Generic;

namespace Start_Bootstrap_Landing_page_.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }
       public DbSet<Information> Informations { get; set; }

    }
}
