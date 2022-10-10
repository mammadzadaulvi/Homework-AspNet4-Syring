using Microsoft.EntityFrameworkCore;
using Syring.Models;

namespace Syring.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<DoctorComponent> DoctorComponents { get; set; }
        public DbSet<MedicalComponent> MedicalComponents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComponent> ProductComponents { get; set; }
    }
}
