using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lab4.Data;
using System;
using System.Linq;
namespace Lab4.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab4Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Lab4Context>>()))
            {
                // Look for any cars.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }
                context.Car.AddRange(
                    new Car
                    {
                        Brand = "Audi",
                        Model = "e-tron GT quattro",
                        YearOfManufacture = DateTime.Parse("2022-1-1"),
                        FuelType = "Petrol",
                        Price = 100000M
                    },
                    new Car
                    {
                        Brand = "Audi",
                        Model = "A1 Sportback",
                        YearOfManufacture = DateTime.Parse("2019-1-1"),
                        FuelType = "Diesel",
                        Price = 25000M
                    },
                    new Car
                    {
                        Brand = "Audi",
                        Model = "S3",
                        YearOfManufacture = DateTime.Parse("2019-1-1"),
                        FuelType = "Petrol",
                        Price = 50000M
                    },
                    new Car
                    {
                        Brand = "Audi",
                        Model = "A6 Avant",
                        YearOfManufacture = DateTime.Parse("2020-1-1"),
                        FuelType = "Diesel",
                        Price = 70000M
                    },
                    new Car
                    {
                        Brand = "Citroen",
                        Model = "Berlingo",
                        YearOfManufacture = DateTime.Parse("2022-1-1"),
                        FuelType = "Petrol",
                        Price = 30000M
                    },
                    new Car
                    {
                        Brand = "Citroen",
                        Model = "C5 Aircross",
                        YearOfManufacture = DateTime.Parse("2018-1-1"),
                        FuelType = "Petrol",
                        Price = 27000M
                    },
                    new Car
                    {
                        Brand = "Citroen",
                        Model = "C3",
                        YearOfManufacture = DateTime.Parse("2017-1-1"),
                        FuelType = "Petrol",
                        Price = 12000M
                    },
                    new Car
                    {
                        Brand = "Citroen",
                        Model = "DS4",
                        YearOfManufacture = DateTime.Parse("2012-1-1"),
                        FuelType = "Petrol",
                        Price = 10000M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}