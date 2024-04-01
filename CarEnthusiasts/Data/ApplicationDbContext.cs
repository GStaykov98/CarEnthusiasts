using CarEnthusiasts.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CarBrand>()
                .HasData(new CarBrand()
                {
                    Id = 1,
                    Name = "Audi",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ae/Logo_audi.jpg"
                },
                new CarBrand()
                {
                    Id = 2,
                    Name = "BMW",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ea/BMW_logo_%28white_%2B_grey_background_square%29.svg"
                },
                new CarBrand()
                {
                    Id = 3,
                    Name = "Mercedes-Benz",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e6/Mercedes-Benz_logo_2.svg"
                },
                new CarBrand()
                {
                    Id = 4,
                    Name = "Porsche",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/44/Porsche_hood_emblem.png"
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
    }
}
