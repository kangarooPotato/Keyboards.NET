using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Keyboards.Models;
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
                        Color = "Red",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Linear",
                        Pressure = 45
                    }
                );
                context.SaveChanges();
            }
        }
    }
}