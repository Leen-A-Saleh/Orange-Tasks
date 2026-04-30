using Microsoft.EntityFrameworkCore;
using StudentsCRUD.Models;
namespace StudentsCRUD.Data
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=stdCRUD;TrustServerCertificate=True;Trusted_Connection=True;");

        }
    }
}
