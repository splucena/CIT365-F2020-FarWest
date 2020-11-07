using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorMegaDesk.Data;


namespace RazorMegaDesk.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorMegaDeskContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorMegaDeskContext>>()))
            {
                // Look for any surface materials.
                if (context.SurfaceMaterial.Any())
                {
                    return;   // DB has been seeded
                }

                context.SurfaceMaterial.AddRange(
                    new SurfaceMaterial
                    {
                        Material = "Laminate",
                        Cost = 100
                    },

                    new SurfaceMaterial
                    {
                        Material = "Oak",
                        Cost = 200
                    },

                    new SurfaceMaterial
                    {
                        Material = "Rosewood",
                        Cost = 300
                    },

                    new SurfaceMaterial
                    {
                        Material = "Veneer",
                        Cost = 125
                    },

                    new SurfaceMaterial
                    {
                        Material = "Pine",
                        Cost = 50
                    }

                );

                if (context.ProductionTime.Any())
                {
                    return; 
                }

                context.ProductionTime.AddRange(
                    new ProductionTime
                    {
                        Days = 3,
                        Description = "Rush - 3 Days"
                    },

                    new ProductionTime
                    {
                        Days = 5,
                        Description = "Rush - 5 Days"
                    },

                    new ProductionTime
                    {
                        Days = 7,
                        Description = "Rush - 7 Days"
                    },

                    new ProductionTime
                    {
                        Days = 14,
                        Description = "Normal - 14 Days"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}

