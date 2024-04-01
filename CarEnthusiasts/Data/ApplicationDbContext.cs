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
                }); ;

            modelBuilder
                .Entity<CarModel>()
                .HasData(new CarModel()
                {
                    Id = 1,
                    Name = "5 Series (E39)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9e/BMW_M5_E39_%28Blue%29.jpg",
                    BrandId = 2,
                    ProductionStartYear = 1996,
                    ProductionEndYear = 2003
                },
                new CarModel()
                {
                    Id = 2,
                    Name = "5 Series (G30)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a7/BMW_5_SERIES_%28G30%29_HONG_KONG.jpg",
                    BrandId = 2,
                    ProductionStartYear = 2017,
                    ProductionEndYear = 2023
                },
                new CarModel()
                {
                    Id = 3,
                    Name = "A4 (B9)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/80/AUDI_A4L_%28B9%29_China_%2812%29.jpg",
                    BrandId = 1,
                    ProductionStartYear = 2015,
                    ProductionEndYear = 2024
                },
                new CarModel()
                {
                    Id = 4,
                    Name = "A6 (C7)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e4/AUDI_A6L_C7_China_%2832%29.jpg",
                    BrandId = 1,
                    ProductionStartYear = 2011,
                    ProductionEndYear = 2018
                },
                new CarModel()
                {
                    Id = 5,
                    Name = "E-Class (W212)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ae/MERCEDES-BENZ_E-CLASS_SEDAN_%28W212%29_China.jpg",
                    BrandId = 3,
                    ProductionStartYear = 2009,
                    ProductionEndYear = 2016
                },
                new CarModel()
                {
                    Id = 6,
                    Name = "S-Class (W222)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/50/MERCEDES-BENZ_S-CLASS_%28W222%29_China_%2823%29.jpg",
                    BrandId = 3,
                    ProductionStartYear = 2013,
                    ProductionEndYear = 2020
                },
                new CarModel()
                {
                    Id = 7,
                    Name = "911 GT3 RS",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/67/2016_Porsche_911_GT3_RS_Grey_FOS22.jpg",
                    BrandId = 4,
                    ProductionStartYear = 2011,
                    ProductionEndYear = 2020
                },
                new CarModel()
                {
                    Id = 8,
                    Name = "Taycan",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e2/PORSCHE_TAYCAN_China_%289%29.jpg",
                    BrandId = 4,
                    ProductionStartYear = 2020,
                    ProductionEndYear = 2024
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
    }
}
