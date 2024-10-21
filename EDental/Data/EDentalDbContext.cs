using EDental.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace EDental.Data;

public class EDentalDbContext : DbContext
{
    public DbSet<Doctors> Doctors { get; set; }
    public DbSet<Diagnosis> Diagnosis { get; set; }
    public DbSet<Procurement> Procurement { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MYPC\\SQLEXPRESS;Initial Catalog=EDental;Integrated Security=True; TrustServerCertificate=True");
    }
}
