using MedicalUser.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalUser.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Drug> Drug { get; set; }

        public DbSet<Test> Test { get; set; }

        public DbSet<Appointment> Appointment { get; set; }
    }
}
