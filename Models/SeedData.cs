using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectContext>>()))
            {
                context.Category.AddRange(
                    new Category
                    {
                        CategoryName = "Appetizers",
                        Description = "Appetizers are small dishes of foods that can be used to snack on before the main meal."
                    }
                );
                context.SaveChanges();

                if (context.Recipe.Any())
                {
                    return;
                }

                context.Recipe.AddRange(
                    new Recipe
                    {
                        Title = "Lentils",
                        CategoryName = "Appetizers",
                        Ingredients = "3 Cups Lentils, 1 Cup Celery, 1 Garlic Clove, 1.5 Cups Carrots, 2 Cups Potatoes, 1/2 Cup Onion, 1 Cup Cilanto, 5 Cups Water",
                        Instructions = "Add water, lentils, and garlic clove to a large pot on medium heat to cook. When boiling add the vegetables in the pot and simmer until the vegetables are soft.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 4}
                        },
                        Category = context.Category.Find(1)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}