using Microsoft.EntityFrameworkCore;
using DTO;

namespace DAL.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Batch> Batches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlite("Data Source=/Users/ranjit/projects/Assignment-DatabaseConnectivity/Test1.db");
        }
    }
}
