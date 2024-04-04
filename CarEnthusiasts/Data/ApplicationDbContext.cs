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
                    ProductionEndYear = 2003,
                    Length = 4775,
                    Width = 1800,
                    Height = 1435,
                    Weigth = 1610,
                    DriveWheel = "Rear wheel drive"
                },
                new CarModel()
                {
                    Id = 2,
                    Name = "5 Series (G30)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a7/BMW_5_SERIES_%28G30%29_HONG_KONG.jpg",
                    BrandId = 2,
                    ProductionStartYear = 2017,
                    ProductionEndYear = 2023,
                    Length = 4936,
                    Width = 1868,
                    Height = 1466,
                    Weigth = 1540,
                    DriveWheel = "Rear wheel drive"

                },
                new CarModel()
                {
                    Id = 3,
                    Name = "A4 (B9)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/80/AUDI_A4L_%28B9%29_China_%2812%29.jpg",
                    BrandId = 1,
                    ProductionStartYear = 2015,
                    ProductionEndYear = 2024,
                    Length = 4726,
                    Width = 1842,
                    Height = 1427,
                    Weigth = 1510,
                    DriveWheel = "All wheel drive"
                },
                new CarModel()
                {
                    Id = 4,
                    Name = "A6 (C7)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e4/AUDI_A6L_C7_China_%2832%29.jpg",
                    BrandId = 1,
                    ProductionStartYear = 2011,
                    ProductionEndYear = 2018,
                    Length = 4915,
                    Width = 1874,
                    Height = 1468,
                    Weigth = 1625,
                    DriveWheel = "Front wheel drive"
                },
                new CarModel()
                {
                    Id = 5,
                    Name = "E-Class (W212)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ae/MERCEDES-BENZ_E-CLASS_SEDAN_%28W212%29_China.jpg",
                    BrandId = 3,
                    ProductionStartYear = 2009,
                    ProductionEndYear = 2016,
                    Length = 4868,
                    Width = 1854,
                    Height = 1470,
                    Weigth = 1730,
                    DriveWheel = "Rear wheel drive"
                },
                new CarModel()
                {
                    Id = 6,
                    Name = "S-Class (W222)",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/50/MERCEDES-BENZ_S-CLASS_%28W222%29_China_%2823%29.jpg",
                    BrandId = 3,
                    ProductionStartYear = 2013,
                    ProductionEndYear = 2020,
                    Length = 5116,
                    Width = 1899,
                    Height = 1496,
                    Weigth = 1975,
                    DriveWheel = "All wheel drive"
                },
                new CarModel()
                {
                    Id = 7,
                    Name = "911 GT3 RS",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/67/2016_Porsche_911_GT3_RS_Grey_FOS22.jpg",
                    BrandId = 4,
                    ProductionStartYear = 2011,
                    ProductionEndYear = 2020,
                    Length = 4557,
                    Width = 1880,
                    Height = 1297,
                    Weigth = 1430,
                    DriveWheel = "Rear wheel drive"
                },
                new CarModel()
                {
                    Id = 8,
                    Name = "Taycan",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e2/PORSCHE_TAYCAN_China_%289%29.jpg",
                    BrandId = 4,
                    ProductionStartYear = 2020,
                    ProductionEndYear = 2024,
                    Length = 4963,
                    Width = 1966,
                    Height = 1381,
                    Weigth = 2305,
                    DriveWheel = "All wheel drive"
                });

            modelBuilder
                .Entity<CarEngine>()
                .HasData(new CarEngine()
                {
                    Id = 1,
                    Name = "M5",
                    HorsePower = 400,
                    Torque = 500,
                    Displacement = 4941,
                    Type = "V8",
                    Aspiration = "Naturally aspirated",
                    Acceleration = 5.3,
                    TopSpeed = 250,
                    CarModelId = 1,
                    Gearbox = "6 gears manual gearbox"
                },
                new CarEngine()
                {
                    Id = 2,
                    Name = "530D",
                    HorsePower = 193,
                    Torque = 410,
                    Displacement = 2926,
                    Type = "I6",
                    Aspiration = "Turbocharger",
                    Acceleration = 7.8,
                    TopSpeed = 230,
                    CarModelId = 1,
                    Gearbox = "6 gears manual gearbox"
                },
                new CarEngine()
                {
                    Id = 3,
                    Name = "M550i",
                    HorsePower = 530,
                    Torque = 750,
                    Displacement = 4395,
                    Type = "I6",
                    Aspiration = "Twin-power turbo",
                    Acceleration = 3.8,
                    TopSpeed = 250,
                    CarModelId = 2,
                    Gearbox = "8 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 4,
                    Name = "520i",
                    HorsePower = 184,
                    Torque = 290,
                    Displacement = 1998,
                    Type = "I4",
                    Aspiration = "Twin-power turbo",
                    Acceleration = 7.8,
                    TopSpeed = 235,
                    CarModelId = 2,
                    Gearbox = "8 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 5,
                    Name = "2.0 TFSI Ultra",
                    HorsePower = 190,
                    Torque = 320,
                    Displacement = 1984,
                    Type = "I4",
                    Aspiration = "Turbocharger",
                    Acceleration = 7.2,
                    TopSpeed = 240,
                    CarModelId = 3,
                    Gearbox = "6 gears manual gearbox"
                },
                new CarEngine()
                {
                    Id = 6,
                    Name = "3.0 TDI",
                    HorsePower = 272,
                    Torque = 600,
                    Displacement = 2967,
                    Type = "V6",
                    Aspiration = "Turbocharger",
                    Acceleration = 5.3,
                    TopSpeed = 250,
                    CarModelId = 3,
                    Gearbox = "8 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 7,
                    Name = "3.0 TDI",
                    HorsePower = 204,
                    Torque = 280,
                    Displacement = 2773,
                    Type = "V6",
                    Aspiration = "Naturally aspirated",
                    Acceleration = 7.7,
                    TopSpeed = 240,
                    CarModelId = 4,
                    Gearbox = "8 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 8,
                    Name = "3.0 TFSI",
                    HorsePower = 310,
                    Torque = 440,
                    Displacement = 2995,
                    Type = "V6",
                    Aspiration = "Supercharger",
                    Acceleration = 5.5,
                    TopSpeed = 250,
                    CarModelId = 4,
                    Gearbox = "7 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 9,
                    Name = "E 350",
                    HorsePower = 272,
                    Torque = 350,
                    Displacement = 3498,
                    Type = "V6",
                    Aspiration = "Naturally aspirated",
                    Acceleration = 7.2,
                    TopSpeed = 250,
                    CarModelId = 5,
                    Gearbox = "7 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 10,
                    Name = "AMG E 63 V8 BiTurbo",
                    HorsePower = 525,
                    Torque = 700,
                    Displacement = 5461,
                    Type = "V8",
                    Aspiration = "BiTurbo",
                    Acceleration = 4.3,
                    TopSpeed = 250,
                    CarModelId = 5,
                    Gearbox = "7 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 11,
                    Name = "S 350d",
                    HorsePower = 258,
                    Torque = 620,
                    Displacement = 2987,
                    Type = "V6",
                    Aspiration = "Turbocharger",
                    Acceleration = 6.5,
                    TopSpeed = 250,
                    CarModelId = 6,
                    Gearbox = "9 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 12,
                    Name = "AMG S 63 V8 BiTurbo",
                    HorsePower = 525,
                    Torque = 700,
                    Displacement = 5461,
                    Type = "V8",
                    Aspiration = "BiTurbo",
                    Acceleration = 4.3,
                    TopSpeed = 250,
                    CarModelId = 6,
                    Gearbox = "7 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 13,
                    Name = "GT3 RS 4.0",
                    HorsePower = 520,
                    Torque = 470,
                    Displacement = 3996,
                    Type = "V6",
                    Aspiration = "Naturally aspirated",
                    Acceleration = 3.2,
                    TopSpeed = 312,
                    CarModelId = 7,
                    Gearbox = "7 gears automatic gearbox"
                },
                new CarEngine()
                {
                    Id = 14,
                    Name = "Turbo S 93.4 kWh",
                    HorsePower = 761,
                    Torque = 1050,
                    Displacement = 800,
                    Type = "Electric",
                    Aspiration = "Naturally aspirated",
                    Acceleration = 2.8,
                    TopSpeed = 260,
                    CarModelId = 8,
                    Gearbox = "2 gears automatic gearbox"
                });

            modelBuilder
                .Entity<News>()
                .HasData(new News()
                {
                    Id = 1,
                    Title = "Lexus with GR Corolla Power 'Highly Likely' to Enter Production",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus hendrerit tincidunt gravida. Phasellus congue pulvinar purus, dapibus sagittis augue convallis id. Nulla tristique lacus neque, at convallis sem tempus at. Nunc sollicitudin quis arcu id tincidunt. Curabitur in odio vitae nunc suscipit pharetra. Nullam id tortor non mauris faucibus rutrum. Suspendisse sed ligula quis urna mattis efficitur. Donec a gravida arcu, at gravida odio. Pellentesque ultricies tempor eros. Donec nec libero quis turpis placerat hendrerit. Aliquam blandit vehicula libero eu feugiat. Ut a fringilla quam, nec vulputate nunc. Proin quis tortor a odio imperdiet venenatis eget sed ligula. Nulla vel dolor dictum, aliquet eros ac, aliquet dolor. Nulla fringilla volutpat ante, a consectetur erat semper et. Integer efficitur scelerisque felis non lacinia.\r\n\r\nSed vel felis at enim consectetur gravida a vitae felis. Duis vitae cursus sapien. Curabitur porta ipsum sit amet tellus tristique, sed dapibus est dictum. Sed posuere diam elit, non viverra est semper et. In dictum, velit facilisis varius volutpat, tellus dui elementum nisl, nec fermentum lorem elit id ligula. Vestibulum lobortis semper lectus eu dapibus. Sed ipsum libero, commodo a lacus ut, fermentum tempor metus. Pellentesque sagittis arcu a sollicitudin tincidunt. Aenean in pellentesque lectus. Vivamus commodo ultrices ligula, vitae tristique eros accumsan non. Pellentesque quis bibendum felis. Mauris mauris neque, interdum quis arcu eleifend, commodo lacinia lectus. Etiam accumsan est neque, sed aliquet erat euismod nec. Fusce ultrices ante in dui ornare, ac ornare risus consectetur. Nullam ut egestas arcu.\r\n\r\nAliquam eget dolor neque. Nullam cursus ornare ex, eget lobortis augue tincidunt et. Duis augue est, accumsan sit amet placerat ut, rutrum suscipit lacus. Vestibulum ultrices ut elit eget fringilla. Etiam vel dolor eget felis tincidunt pretium non non orci. Donec sit amet egestas tellus, ac imperdiet nibh. Cras sed viverra dui, vel posuere quam. Pellentesque at blandit leo. Donec ut suscipit eros, vitae interdum libero. Donec imperdiet id metus non fermentum. Nulla quis efficitur metus. Integer vitae ipsum eget magna viverra tristique id id nunc. Duis metus velit, faucibus eu neque mollis, euismod eleifend massa.\r\n\r\nCras efficitur aliquam tortor vel consequat. Ut sodales eget mi sit amet porta. Vestibulum laoreet sit amet ante euismod eleifend. Nulla elementum consequat nunc ut vulputate. Vestibulum vel auctor lacus. Sed euismod condimentum volutpat. Pellentesque finibus iaculis lorem. Maecenas congue eleifend turpis in porta.\r\n\r\nFusce lacinia tincidunt tellus et malesuada. Proin non consectetur arcu. Cras lacinia sem eu purus finibus suscipit. Fusce sapien urna, bibendum in sem et, suscipit pretium dolor. Aenean malesuada, massa at mattis varius, odio velit laoreet dui, nec fermentum tortor libero quis orci. Donec diam sapien, convallis at justo a, tincidunt facilisis elit. Nullam a arcu id sem interdum consequat. Quisque porttitor non augue quis finibus. Quisque at ornare enim.",
                    ImageUrl = "https://cdn.motor1.com/images/mgl/BXNkj6/s1/2024-lexus-lbx-morizo-rr-concept.webp",
                    CreatedOn = DateTime.Now
                },
                new News()
                {
                    Id = 2,
                    Title = "The New Renault Captur Gets Esprit Alpine Trim, Loses Leather",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus hendrerit tincidunt gravida. Phasellus congue pulvinar purus, dapibus sagittis augue convallis id. Nulla tristique lacus neque, at convallis sem tempus at. Nunc sollicitudin quis arcu id tincidunt. Curabitur in odio vitae nunc suscipit pharetra. Nullam id tortor non mauris faucibus rutrum. Suspendisse sed ligula quis urna mattis efficitur. Donec a gravida arcu, at gravida odio. Pellentesque ultricies tempor eros. Donec nec libero quis turpis placerat hendrerit. Aliquam blandit vehicula libero eu feugiat. Ut a fringilla quam, nec vulputate nunc. Proin quis tortor a odio imperdiet venenatis eget sed ligula. Nulla vel dolor dictum, aliquet eros ac, aliquet dolor. Nulla fringilla volutpat ante, a consectetur erat semper et. Integer efficitur scelerisque felis non lacinia.\r\n\r\nSed vel felis at enim consectetur gravida a vitae felis. Duis vitae cursus sapien. Curabitur porta ipsum sit amet tellus tristique, sed dapibus est dictum. Sed posuere diam elit, non viverra est semper et. In dictum, velit facilisis varius volutpat, tellus dui elementum nisl, nec fermentum lorem elit id ligula. Vestibulum lobortis semper lectus eu dapibus. Sed ipsum libero, commodo a lacus ut, fermentum tempor metus. Pellentesque sagittis arcu a sollicitudin tincidunt. Aenean in pellentesque lectus. Vivamus commodo ultrices ligula, vitae tristique eros accumsan non. Pellentesque quis bibendum felis. Mauris mauris neque, interdum quis arcu eleifend, commodo lacinia lectus. Etiam accumsan est neque, sed aliquet erat euismod nec. Fusce ultrices ante in dui ornare, ac ornare risus consectetur. Nullam ut egestas arcu.\r\n\r\nAliquam eget dolor neque. Nullam cursus ornare ex, eget lobortis augue tincidunt et. Duis augue est, accumsan sit amet placerat ut, rutrum suscipit lacus. Vestibulum ultrices ut elit eget fringilla. Etiam vel dolor eget felis tincidunt pretium non non orci. Donec sit amet egestas tellus, ac imperdiet nibh. Cras sed viverra dui, vel posuere quam. Pellentesque at blandit leo. Donec ut suscipit eros, vitae interdum libero. Donec imperdiet id metus non fermentum. Nulla quis efficitur metus. Integer vitae ipsum eget magna viverra tristique id id nunc. Duis metus velit, faucibus eu neque mollis, euismod eleifend massa.\r\n\r\nCras efficitur aliquam tortor vel consequat. Ut sodales eget mi sit amet porta. Vestibulum laoreet sit amet ante euismod eleifend. Nulla elementum consequat nunc ut vulputate. Vestibulum vel auctor lacus. Sed euismod condimentum volutpat. Pellentesque finibus iaculis lorem. Maecenas congue eleifend turpis in porta.\r\n\r\nFusce lacinia tincidunt tellus et malesuada. Proin non consectetur arcu. Cras lacinia sem eu purus finibus suscipit. Fusce sapien urna, bibendum in sem et, suscipit pretium dolor. Aenean malesuada, massa at mattis varius, odio velit laoreet dui, nec fermentum tortor libero quis orci. Donec diam sapien, convallis at justo a, tincidunt facilisis elit. Nullam a arcu id sem interdum consequat. Quisque porttitor non augue quis finibus. Quisque at ornare enim.",
                    ImageUrl = "https://cdn.motor1.com/images/mgl/8Avv8M/s1/renault-captur-2024.webp",
                    CreatedOn = DateTime.Now - TimeSpan.FromDays(1)
                },
                new News()
                {
                    Id = 3,
                    Title = "The 2024 Mitsuoka Ryugi is a Fake British Sedan Based on a Corolla",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus hendrerit tincidunt gravida. Phasellus congue pulvinar purus, dapibus sagittis augue convallis id. Nulla tristique lacus neque, at convallis sem tempus at. Nunc sollicitudin quis arcu id tincidunt. Curabitur in odio vitae nunc suscipit pharetra. Nullam id tortor non mauris faucibus rutrum. Suspendisse sed ligula quis urna mattis efficitur. Donec a gravida arcu, at gravida odio. Pellentesque ultricies tempor eros. Donec nec libero quis turpis placerat hendrerit. Aliquam blandit vehicula libero eu feugiat. Ut a fringilla quam, nec vulputate nunc. Proin quis tortor a odio imperdiet venenatis eget sed ligula. Nulla vel dolor dictum, aliquet eros ac, aliquet dolor. Nulla fringilla volutpat ante, a consectetur erat semper et. Integer efficitur scelerisque felis non lacinia.\r\n\r\nSed vel felis at enim consectetur gravida a vitae felis. Duis vitae cursus sapien. Curabitur porta ipsum sit amet tellus tristique, sed dapibus est dictum. Sed posuere diam elit, non viverra est semper et. In dictum, velit facilisis varius volutpat, tellus dui elementum nisl, nec fermentum lorem elit id ligula. Vestibulum lobortis semper lectus eu dapibus. Sed ipsum libero, commodo a lacus ut, fermentum tempor metus. Pellentesque sagittis arcu a sollicitudin tincidunt. Aenean in pellentesque lectus. Vivamus commodo ultrices ligula, vitae tristique eros accumsan non. Pellentesque quis bibendum felis. Mauris mauris neque, interdum quis arcu eleifend, commodo lacinia lectus. Etiam accumsan est neque, sed aliquet erat euismod nec. Fusce ultrices ante in dui ornare, ac ornare risus consectetur. Nullam ut egestas arcu.\r\n\r\nAliquam eget dolor neque. Nullam cursus ornare ex, eget lobortis augue tincidunt et. Duis augue est, accumsan sit amet placerat ut, rutrum suscipit lacus. Vestibulum ultrices ut elit eget fringilla. Etiam vel dolor eget felis tincidunt pretium non non orci. Donec sit amet egestas tellus, ac imperdiet nibh. Cras sed viverra dui, vel posuere quam. Pellentesque at blandit leo. Donec ut suscipit eros, vitae interdum libero. Donec imperdiet id metus non fermentum. Nulla quis efficitur metus. Integer vitae ipsum eget magna viverra tristique id id nunc. Duis metus velit, faucibus eu neque mollis, euismod eleifend massa.\r\n\r\nCras efficitur aliquam tortor vel consequat. Ut sodales eget mi sit amet porta. Vestibulum laoreet sit amet ante euismod eleifend. Nulla elementum consequat nunc ut vulputate. Vestibulum vel auctor lacus. Sed euismod condimentum volutpat. Pellentesque finibus iaculis lorem. Maecenas congue eleifend turpis in porta.\r\n\r\nFusce lacinia tincidunt tellus et malesuada. Proin non consectetur arcu. Cras lacinia sem eu purus finibus suscipit. Fusce sapien urna, bibendum in sem et, suscipit pretium dolor. Aenean malesuada, massa at mattis varius, odio velit laoreet dui, nec fermentum tortor libero quis orci. Donec diam sapien, convallis at justo a, tincidunt facilisis elit. Nullam a arcu id sem interdum consequat. Quisque porttitor non augue quis finibus. Quisque at ornare enim.",
                    ImageUrl = "https://cdn.motor1.com/images/mgl/JOBVYn/s1/2024-mitsuoka-ryugi.webp",
                    CreatedOn = DateTime.Now - TimeSpan.FromDays(2)
                });

            modelBuilder
                .Entity<Review>()
                .HasData(new Review()
                {
                    Id = 1,
                    Title = "The Toyota Prius Prime Makes Most EVs Obsolete",
                    ImageUrl = "https://cdn.motor1.com/images/mgl/koEWrQ/s1/2024-toyota-prius-prime-review.webp",
                    CreatedOn = DateTime.Now,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus hendrerit tincidunt gravida. Phasellus congue pulvinar purus, dapibus sagittis augue convallis id. Nulla tristique lacus neque, at convallis sem tempus at. Nunc sollicitudin quis arcu id tincidunt. Curabitur in odio vitae nunc suscipit pharetra. Nullam id tortor non mauris faucibus rutrum. Suspendisse sed ligula quis urna mattis efficitur. Donec a gravida arcu, at gravida odio. Pellentesque ultricies tempor eros. Donec nec libero quis turpis placerat hendrerit. Aliquam blandit vehicula libero eu feugiat. Ut a fringilla quam, nec vulputate nunc. Proin quis tortor a odio imperdiet venenatis eget sed ligula. Nulla vel dolor dictum, aliquet eros ac, aliquet dolor. Nulla fringilla volutpat ante, a consectetur erat semper et. Integer efficitur scelerisque felis non lacinia.\r\n\r\nSed vel felis at enim consectetur gravida a vitae felis. Duis vitae cursus sapien. Curabitur porta ipsum sit amet tellus tristique, sed dapibus est dictum. Sed posuere diam elit, non viverra est semper et. In dictum, velit facilisis varius volutpat, tellus dui elementum nisl, nec fermentum lorem elit id ligula. Vestibulum lobortis semper lectus eu dapibus. Sed ipsum libero, commodo a lacus ut, fermentum tempor metus. Pellentesque sagittis arcu a sollicitudin tincidunt. Aenean in pellentesque lectus. Vivamus commodo ultrices ligula, vitae tristique eros accumsan non. Pellentesque quis bibendum felis. Mauris mauris neque, interdum quis arcu eleifend, commodo lacinia lectus. Etiam accumsan est neque, sed aliquet erat euismod nec. Fusce ultrices ante in dui ornare, ac ornare risus consectetur. Nullam ut egestas arcu.\r\n\r\nAliquam eget dolor neque. Nullam cursus ornare ex, eget lobortis augue tincidunt et. Duis augue est, accumsan sit amet placerat ut, rutrum suscipit lacus. Vestibulum ultrices ut elit eget fringilla. Etiam vel dolor eget felis tincidunt pretium non non orci. Donec sit amet egestas tellus, ac imperdiet nibh. Cras sed viverra dui, vel posuere quam. Pellentesque at blandit leo. Donec ut suscipit eros, vitae interdum libero. Donec imperdiet id metus non fermentum. Nulla quis efficitur metus. Integer vitae ipsum eget magna viverra tristique id id nunc. Duis metus velit, faucibus eu neque mollis, euismod eleifend massa.\r\n\r\nCras efficitur aliquam tortor vel consequat. Ut sodales eget mi sit amet porta. Vestibulum laoreet sit amet ante euismod eleifend. Nulla elementum consequat nunc ut vulputate. Vestibulum vel auctor lacus. Sed euismod condimentum volutpat. Pellentesque finibus iaculis lorem. Maecenas congue eleifend turpis in porta.\r\n\r\nFusce lacinia tincidunt tellus et malesuada. Proin non consectetur arcu. Cras lacinia sem eu purus finibus suscipit. Fusce sapien urna, bibendum in sem et, suscipit pretium dolor. Aenean malesuada, massa at mattis varius, odio velit laoreet dui, nec fermentum tortor libero quis orci. Donec diam sapien, convallis at justo a, tincidunt facilisis elit. Nullam a arcu id sem interdum consequat. Quisque porttitor non augue quis finibus. Quisque at ornare enim."
                },
                new Review()
                {
                    Id = 2,
                    Title = "The Mercedes-Benz E450 Has One Mission: Comfort Above Everything",
                    ImageUrl = "https://cdn.motor1.com/images/mgl/W8MYJN/s1/2024-mercedes-e450-4matic-review.webp",
                    CreatedOn = DateTime.Now - TimeSpan.FromDays(2),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus hendrerit tincidunt gravida. Phasellus congue pulvinar purus, dapibus sagittis augue convallis id. Nulla tristique lacus neque, at convallis sem tempus at. Nunc sollicitudin quis arcu id tincidunt. Curabitur in odio vitae nunc suscipit pharetra. Nullam id tortor non mauris faucibus rutrum. Suspendisse sed ligula quis urna mattis efficitur. Donec a gravida arcu, at gravida odio. Pellentesque ultricies tempor eros. Donec nec libero quis turpis placerat hendrerit. Aliquam blandit vehicula libero eu feugiat. Ut a fringilla quam, nec vulputate nunc. Proin quis tortor a odio imperdiet venenatis eget sed ligula. Nulla vel dolor dictum, aliquet eros ac, aliquet dolor. Nulla fringilla volutpat ante, a consectetur erat semper et. Integer efficitur scelerisque felis non lacinia.\r\n\r\nSed vel felis at enim consectetur gravida a vitae felis. Duis vitae cursus sapien. Curabitur porta ipsum sit amet tellus tristique, sed dapibus est dictum. Sed posuere diam elit, non viverra est semper et. In dictum, velit facilisis varius volutpat, tellus dui elementum nisl, nec fermentum lorem elit id ligula. Vestibulum lobortis semper lectus eu dapibus. Sed ipsum libero, commodo a lacus ut, fermentum tempor metus. Pellentesque sagittis arcu a sollicitudin tincidunt. Aenean in pellentesque lectus. Vivamus commodo ultrices ligula, vitae tristique eros accumsan non. Pellentesque quis bibendum felis. Mauris mauris neque, interdum quis arcu eleifend, commodo lacinia lectus. Etiam accumsan est neque, sed aliquet erat euismod nec. Fusce ultrices ante in dui ornare, ac ornare risus consectetur. Nullam ut egestas arcu.\r\n\r\nAliquam eget dolor neque. Nullam cursus ornare ex, eget lobortis augue tincidunt et. Duis augue est, accumsan sit amet placerat ut, rutrum suscipit lacus. Vestibulum ultrices ut elit eget fringilla. Etiam vel dolor eget felis tincidunt pretium non non orci. Donec sit amet egestas tellus, ac imperdiet nibh. Cras sed viverra dui, vel posuere quam. Pellentesque at blandit leo. Donec ut suscipit eros, vitae interdum libero. Donec imperdiet id metus non fermentum. Nulla quis efficitur metus. Integer vitae ipsum eget magna viverra tristique id id nunc. Duis metus velit, faucibus eu neque mollis, euismod eleifend massa.\r\n\r\nCras efficitur aliquam tortor vel consequat. Ut sodales eget mi sit amet porta. Vestibulum laoreet sit amet ante euismod eleifend. Nulla elementum consequat nunc ut vulputate. Vestibulum vel auctor lacus. Sed euismod condimentum volutpat. Pellentesque finibus iaculis lorem. Maecenas congue eleifend turpis in porta.\r\n\r\nFusce lacinia tincidunt tellus et malesuada. Proin non consectetur arcu. Cras lacinia sem eu purus finibus suscipit. Fusce sapien urna, bibendum in sem et, suscipit pretium dolor. Aenean malesuada, massa at mattis varius, odio velit laoreet dui, nec fermentum tortor libero quis orci. Donec diam sapien, convallis at justo a, tincidunt facilisis elit. Nullam a arcu id sem interdum consequat. Quisque porttitor non augue quis finibus. Quisque at ornare enim."
                },
                new Review()
                {
                    Id = 3,
                    Title = "The Acura MDX Type S Is So Close to Greatness",
                    ImageUrl = "https://cdn.motor1.com/images/mgl/1ZKQWq/s1/2024-acura-mdx-type-s-review.webp",
                    CreatedOn = DateTime.Now - TimeSpan.FromDays(4),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus hendrerit tincidunt gravida. Phasellus congue pulvinar purus, dapibus sagittis augue convallis id. Nulla tristique lacus neque, at convallis sem tempus at. Nunc sollicitudin quis arcu id tincidunt. Curabitur in odio vitae nunc suscipit pharetra. Nullam id tortor non mauris faucibus rutrum. Suspendisse sed ligula quis urna mattis efficitur. Donec a gravida arcu, at gravida odio. Pellentesque ultricies tempor eros. Donec nec libero quis turpis placerat hendrerit. Aliquam blandit vehicula libero eu feugiat. Ut a fringilla quam, nec vulputate nunc. Proin quis tortor a odio imperdiet venenatis eget sed ligula. Nulla vel dolor dictum, aliquet eros ac, aliquet dolor. Nulla fringilla volutpat ante, a consectetur erat semper et. Integer efficitur scelerisque felis non lacinia.\r\n\r\nSed vel felis at enim consectetur gravida a vitae felis. Duis vitae cursus sapien. Curabitur porta ipsum sit amet tellus tristique, sed dapibus est dictum. Sed posuere diam elit, non viverra est semper et. In dictum, velit facilisis varius volutpat, tellus dui elementum nisl, nec fermentum lorem elit id ligula. Vestibulum lobortis semper lectus eu dapibus. Sed ipsum libero, commodo a lacus ut, fermentum tempor metus. Pellentesque sagittis arcu a sollicitudin tincidunt. Aenean in pellentesque lectus. Vivamus commodo ultrices ligula, vitae tristique eros accumsan non. Pellentesque quis bibendum felis. Mauris mauris neque, interdum quis arcu eleifend, commodo lacinia lectus. Etiam accumsan est neque, sed aliquet erat euismod nec. Fusce ultrices ante in dui ornare, ac ornare risus consectetur. Nullam ut egestas arcu.\r\n\r\nAliquam eget dolor neque. Nullam cursus ornare ex, eget lobortis augue tincidunt et. Duis augue est, accumsan sit amet placerat ut, rutrum suscipit lacus. Vestibulum ultrices ut elit eget fringilla. Etiam vel dolor eget felis tincidunt pretium non non orci. Donec sit amet egestas tellus, ac imperdiet nibh. Cras sed viverra dui, vel posuere quam. Pellentesque at blandit leo. Donec ut suscipit eros, vitae interdum libero. Donec imperdiet id metus non fermentum. Nulla quis efficitur metus. Integer vitae ipsum eget magna viverra tristique id id nunc. Duis metus velit, faucibus eu neque mollis, euismod eleifend massa.\r\n\r\nCras efficitur aliquam tortor vel consequat. Ut sodales eget mi sit amet porta. Vestibulum laoreet sit amet ante euismod eleifend. Nulla elementum consequat nunc ut vulputate. Vestibulum vel auctor lacus. Sed euismod condimentum volutpat. Pellentesque finibus iaculis lorem. Maecenas congue eleifend turpis in porta.\r\n\r\nFusce lacinia tincidunt tellus et malesuada. Proin non consectetur arcu. Cras lacinia sem eu purus finibus suscipit. Fusce sapien urna, bibendum in sem et, suscipit pretium dolor. Aenean malesuada, massa at mattis varius, odio velit laoreet dui, nec fermentum tortor libero quis orci. Donec diam sapien, convallis at justo a, tincidunt facilisis elit. Nullam a arcu id sem interdum consequat. Quisque porttitor non augue quis finibus. Quisque at ornare enim."
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
