using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Keyboards.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KeyboardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KeyboardContext>>()))
            {
                // Look for any Keyboards.
                if (context.Keyboard.Any())
                {
                    return;   // DB has been seeded
                }

                context.Keyboard.AddRange(
                    new Keyboard
                    {
                        Color = "Blue",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Clicky",
                        Pressure = 55
                    },
                    new Keyboard
                    {
                        Color = "Red",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Linear",
                        Pressure = 45
                    },
                    new Keyboard
                    {
                        Color = "Brown",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Non-Click",
                        Pressure = 50
                    },
                    new Keyboard
                    {
                        Color = "Blakc",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Linear",
                        Pressure = 65
                    },
                    new Keyboard
                    {
                        Color = "Green",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Clicky",
                        Pressure = 75
                    }
                );
                context.SaveChanges();
            }
        }
    }
}