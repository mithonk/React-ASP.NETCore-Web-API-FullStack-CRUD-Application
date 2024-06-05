using Microsoft.EntityFrameworkCore;

namespace Project_1.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MITHONK\\SQLEXPRESS;Database=Project1;Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
