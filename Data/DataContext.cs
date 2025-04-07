using FaleMais.Entities;
using Microsoft.EntityFrameworkCore;

namespace FaleMais.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<DDD> DDD { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }
        public DbSet<Plano> Plano { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DDD>().HasData(
                new DDD(1, "011"),
                new DDD(2, "016"),
                new DDD(3, "017"),
                new DDD(4, "018")
            );

            modelBuilder.Entity<Plano>().HasData(
                new Plano(1, "FaleMais 30", 30),
                new Plano(2, "FaleMais 60", 60),
                new Plano(3, "FaleMais 120", 120)
            );

            modelBuilder.Entity<Tarifa>().HasData(
                new Tarifa(1, 1.90, 1, 2),
                new Tarifa(2, 2.90, 2, 1),
                new Tarifa(3, 1.70, 1, 3),
                new Tarifa(4, 2.70, 3, 1),
                new Tarifa(5, 0.90, 1, 4),
                new Tarifa(6, 1.90, 4, 1),
                new Tarifa(7, 1.50, 2, 3),
                new Tarifa(8, 2.00, 3, 2),
                new Tarifa(9, 1.00, 2, 4),
                new Tarifa(10, 1.20, 4, 2),
                new Tarifa(11, 1.40, 3, 4),
                new Tarifa(12, 2.20, 4, 3)
            );
        }
    }
}
