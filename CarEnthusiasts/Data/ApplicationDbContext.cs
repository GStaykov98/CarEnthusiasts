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
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.EnableSensitiveDataLogging();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.
                Entity<ForumTopicFollower>()
                .HasKey(pk => new { pk.FollowerId, pk.ForumTopicId });

            modelBuilder
                .Entity<TuningPartCarModel>()
                .HasKey(pk => new { pk.CarModelId, pk.TuningPartId });


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

            modelBuilder
                .Entity<ForumTopic>()
                .HasData(new ForumTopic()
                {
                    Id = 1,
                    Title = "BMW 5 Series E39 common problems",
                    TopicType = Models.Enums.ForumTopicType.CommonProblems,
                    CreatedOn = DateTime.Now,
                    FollowerCounter = 0,
                    LikeCounter = 0,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.",
                    CreatorId = "5ac561d9-127e-4017-8e82-19372d14c26a"
                },
                new ForumTopic()
                {
                    Id = 2,
                    Title = "General talk about cars",
                    TopicType = Models.Enums.ForumTopicType.General,
                    CreatedOn = DateTime.Now - TimeSpan.FromDays(5),
                    FollowerCounter = 0,
                    LikeCounter = 0,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.",
                    CreatorId = "5ac561d9-127e-4017-8e82-19372d14c26a"
                },
                new ForumTopic()
                {
                    Id = 3,
                    Title = "BMW 7 Series E65 car meet",
                    TopicType = Models.Enums.ForumTopicType.CarMeets,
                    CreatedOn = DateTime.Now,
                    FollowerCounter = 0,
                    LikeCounter = 0,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.",
                    CreatorId = "5ac561d9-127e-4017-8e82-19372d14c26a"
                },
                new ForumTopic()
                {
                    Id = 4,
                    Title = "I have a question about the engine of the new S-Class",
                    TopicType = Models.Enums.ForumTopicType.TechnicalQuestions,
                    CreatedOn = DateTime.Now - TimeSpan.FromDays(3),
                    FollowerCounter = 0,
                    LikeCounter = 0,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in est massa. Praesent id erat quam. Etiam ornare enim non dui venenatis bibendum. Suspendisse iaculis tempus leo, in condimentum urna pulvinar ac. Suspendisse eu nisl nec augue ornare eleifend. Nam vulputate tincidunt elit, non egestas ante laoreet nec. Cras ultricies urna semper purus auctor, eget vulputate erat dapibus. Aliquam a blandit mi. Morbi vitae suscipit augue. Aliquam non scelerisque leo, at laoreet purus. Donec mi mauris, ullamcorper sit amet nunc et, molestie mollis purus. Curabitur convallis tristique tellus, quis porttitor ipsum dictum eget.\r\n\r\nNam imperdiet eu ipsum et aliquam. Suspendisse eleifend congue consectetur. Suspendisse potenti. Nunc nec condimentum ligula. Morbi metus nulla, viverra eget laoreet at, tempor id diam. Nunc nibh justo, tristique vitae luctus in, sodales vel justo. Ut gravida vel ante et egestas. Fusce feugiat diam non aliquet fringilla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.\r\n\r\nAliquam semper rhoncus rhoncus. Praesent pellentesque arcu eros, in ornare velit bibendum sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Suspendisse potenti. Sed quis ante enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam accumsan ac libero quis tristique. Maecenas rhoncus finibus odio a finibus.",
                    CreatorId = "5ac561d9-127e-4017-8e82-19372d14c26a"
                });

            modelBuilder
                .Entity<TuningPartCategory>()
                .HasData(new TuningPartCategory()
                {
                    Id = 1,
                    Name = "Sport seats",
                    ImageUrl = "https://ic.carid.com/braum/seats/brr1x-whbs_0.jpg"
                }, 
                new TuningPartCategory()
                {
                    Id = 2,
                    Name = "Sport steering wheels",
                    ImageUrl = "https://evilspeed.eu/cdn/shop/products/Sport-Line-Competition-Steering-Wheel---Black-Suede-Black-Spokes-300mm_5587e715-5391-43c3-96eb-eb3f6a60d290.jpg?v=1666288910"
                },
                new TuningPartCategory()
                {
                    Id = 3,
                    Name = "Body kits",
                    ImageUrl = "https://image.made-in-china.com/2f0j00WFCleYPIYrpz/High-Quality-M4-Style-Body-Kit-for-BMW-4-Series-F32-F33-F36-420I-428I-Front-Bumper-Rear-Bumper-Side-Skirts-Wing-Spoiler.webp"
                }, 
                new TuningPartCategory()
                {
                    Id = 4,
                    Name = "Turbo kits",
                    ImageUrl = "https://www.turbozentrum.de/media/image/product/173750/lg/turbo-garrett-g40-900.jpg"
                },
                new TuningPartCategory()
                {
                    Id = 5,
                    Name = "Spoilers",
                    ImageUrl = "https://m.media-amazon.com/images/I/5151jRy7evL.jpg"
                },
                new TuningPartCategory()
                {
                    Id = 6,
                    Name = "Rims",
                    ImageUrl = "https://realtruck.com/production/fuel-black-red-reaction-wheels-01/6b053c7ab45cb34b2fd8df96b85ab902.jpg"
                });

            modelBuilder
                .Entity<TuningPart>()
                .HasData(new TuningPart()
                {
                    Id = 1,
                    CategoryId = 1,
                    Quantity = 5,
                    Price = 249.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/71x5FmPr53L.jpg",
                    Name = "2 Pieces Universal Racing Seats,With Dual Lock Sliders",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                }, 
                new TuningPart()
                {
                    Id = 2,
                    CategoryId = 1,
                    Quantity = 2,
                    Price = 135.50,
                    ImageUrl = "https://www.outcastgarage.com/cdn/shop/products/BRR1R-BKRP_1_1800x1800.jpg?v=1540248523",
                    Name = "BRAUM Racing Elite-R Series Racing Seats",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 3,
                    CategoryId = 2,
                    Quantity = 10,
                    Price = 59.85,
                    ImageUrl = "https://cdn.autostyle.co.za/wp-content/uploads/2022/06/28183552/X1-022CA.jpg",
                    Name = "Type-R Sports Steering Wheel (Black & Carbon Fibre Design)",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 4,
                    CategoryId = 2,
                    Quantity = 3,
                    Price = 74.29,
                    ImageUrl = "https://www.kmpdrivetrain.com/wp-content/uploads/2020/04/4SW-01-600x600.png",
                    Name = "KMP E-sport racing wheel",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 5,
                    CategoryId = 3,
                    Quantity = 7,
                    Price = 849.99,
                    ImageUrl = "https://www.motortrend.com/uploads/2021/10/rocket-bunny-gr86-complete-aero-kit-copy.png",
                    Name = "Rocket bunny kit",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 6,
                    CategoryId = 3,
                    Quantity = 6,
                    Price = 1250,
                    ImageUrl = "https://i.ytimg.com/vi/LkHUeJROh7M/maxresdefault.jpg",
                    Name = "Porsche 911 GT3 wide body kit",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 7,
                    CategoryId = 4,
                    Quantity = 8,
                    Price = 1249.99,
                    ImageUrl = "https://titanmotorsports.com/cdn/shop/products/FRB586PortTopMountKit-1.jpg?v=1655318711",
                    Name = "Single turbo universal kit",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 8,
                    CategoryId = 4,
                    Quantity = 6,
                    Price = 1789,
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0055/2098/2086/products/TurboKitMain_1000x.jpg?v=1651772131",
                    Name = "Twin turbo universal kit",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 9,
                    CategoryId = 5,
                    Quantity = 23,
                    Price = 283,
                    ImageUrl = "https://i5.walmartimages.com/asr/8d2e309d-a02c-4ce8-8792-e21ff8193728.65fff7edfb470d3f39bdcd0968ed110f.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF",
                    Name = "Tbest Rear Spoiler",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 10,
                    CategoryId = 5,
                    Quantity = 54,
                    Price = 129,
                    ImageUrl = "https://www.swapshopracing.com/contents/media/l_carb-a690-nrg-05-.jpg",
                    Name = "NRG Universal 69\" Black Real Carbon Fiber Spoiler",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 11,
                    CategoryId = 6,
                    Quantity = 23,
                    Price = 449.23,
                    ImageUrl = "https://cdn4.wheelbasealloys.com/product-images/product-219413_108741_600.jpg",
                    Name = "Vossen CVT Graphite 20\" Alloy Wheels",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                },
                new TuningPart()
                {
                    Id = 12,
                    CategoryId = 6,
                    Quantity = 43,
                    Price = 549.89,
                    ImageUrl = "https://audiocityusa.com/shop/images/P/0-forgiato-forged-wheels-forgiato-blocco-gloss-black-with-mango-orange-accents-rims-audiocityusa-01-04.jpg",
                    Name = "21\" Forgiato Wheels Blocco Gloss Black",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et ultricies mi. Aenean ornare venenatis turpis quis faucibus. Etiam rhoncus massa a dolor interdum, sit amet fringilla metus pellentesque. Quisque eleifend libero id elit ullamcorper, quis aliquet lacus commodo. Suspendisse aliquam, erat ut sollicitudin eleifend, massa arcu pretium odio, in ultrices ante nisi ut dui. Suspendisse metus justo, congue a diam vel, semper tristique massa."
                });

            modelBuilder
                .Entity<TuningPartCarModel>()
                .HasData(new TuningPartCarModel
                {
                    CarModelId = 3,
                    TuningPartId = 1
                },
                new TuningPartCarModel
				{
					TuningPartId = 1,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 1,
					CarModelId = 7
				},
				new TuningPartCarModel
				{
					TuningPartId = 2,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 2,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 2,
					CarModelId = 7
				},
				new TuningPartCarModel
				{
					TuningPartId = 3,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 3,
					CarModelId = 8
				},
				new TuningPartCarModel
				{
					TuningPartId = 4,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 4,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 4,
					CarModelId = 7
				},
				new TuningPartCarModel
				{
					TuningPartId = 4,
					CarModelId = 8
				},
				new TuningPartCarModel
				{
					TuningPartId = 5,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 5,
					CarModelId = 2
				},
				new TuningPartCarModel
				{
					TuningPartId = 5,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 5,
					CarModelId = 4
				},
				new TuningPartCarModel
				{
					TuningPartId = 5,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 5,
					CarModelId = 6
				},
				new TuningPartCarModel
				{
					TuningPartId = 6,
					CarModelId = 7
				},
				new TuningPartCarModel
				{
					TuningPartId = 7,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 7,
					CarModelId = 2
				},
				new TuningPartCarModel
				{
					TuningPartId = 7,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 7,
					CarModelId = 4
				},
				new TuningPartCarModel
				{
					TuningPartId = 7,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 7,
					CarModelId = 6
				},
				new TuningPartCarModel
				{
					TuningPartId = 8,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 8,
					CarModelId = 2
				},
				new TuningPartCarModel
				{
					TuningPartId = 8,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 8,
					CarModelId = 4
				},
				new TuningPartCarModel
				{
					TuningPartId = 8,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 8,
					CarModelId = 6
				},
				new TuningPartCarModel
				{
					TuningPartId = 9,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 9,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 9,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 9,
					CarModelId = 7
				},
				new TuningPartCarModel
				{
					TuningPartId = 10,
					CarModelId = 2
				},
				new TuningPartCarModel
				{
					TuningPartId = 10,
					CarModelId = 4
				},
				new TuningPartCarModel
				{
					TuningPartId = 10,
					CarModelId = 6
				},
				new TuningPartCarModel
				{
					TuningPartId = 10,
					CarModelId = 8
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 2
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 4
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 6
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 7
				},
				new TuningPartCarModel
				{
					TuningPartId = 11,
					CarModelId = 8
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 1
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 2
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 3
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 4
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 5
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 6
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 7
				},
				new TuningPartCarModel
				{
					TuningPartId = 12,
					CarModelId = 8
				});

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ForumTopic> ForumTopics { get; set; }
        public DbSet<ForumTopicFollower> ForumTopicsFollowers { get; set; }
        public DbSet<TuningPart> TuningParts { get; set;}
        public DbSet<TuningPartCategory> TuningPartCategories { get; set; }
        public DbSet<TuningPartCarModel> TuningPartsCarModels { get; set; }
    }
}
