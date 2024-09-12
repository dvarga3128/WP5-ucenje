using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class EdunovaContext:DbContext
    {
        public EdunovaContext(DbContextOptions<EdunovaContext> opcije) : base(opcije) 
        {
        
        }
        
        public DbSet<Smjer> Smjerovi { get; set; }   

    }
}
