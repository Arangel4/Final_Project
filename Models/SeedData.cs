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
                if (context.Recipe.Any())
                {
                    return;
                }

                context.Category.AddRange(
                    new Category
                    {
                        CategoryName = "Appetizers",
                        Description = "Appetizers are small dishes of foods that can be used to snack on before the main meal."
                    },

                    new Category
                    {
                        CategoryName = "Entrees",
                        Description = "Entrees include all main meals. There would include recipes that can be used for lunch and dinner."
                    },

                    new Category
                    {
                        CategoryName = "Breakfast",
                        Description = "Breakfast would include all meals that would be eaten in the morning."
                    },

                    new Category
                    {
                        CategoryName = "Soups",
                        Description = "Soups consider all liquid mixtures and or substances."
                    },

                    new Category
                    {
                        CategoryName = "Beverages",
                        Description = "Beverages include all drinks that are made."
                    },

                    new Category
                    {
                        CategoryName = "Desserts",
                        Description = "Desserts are the sweet dishes."
                    }
                );

                context.Recipe.AddRange(
                    new Recipe
                    {
                        Title = "Lentils",
                        CategoryName = "Soups",
                        Ingredients = "3 Cups Lentils, 1 Cup Celery, 1 Garlic Clove, 1.5 Cups Carrots, 2 Cups Potatoes, 1/2 Cup Onion, 1 Cup Cilanto, 5 Cups Water",
                        Instructions = "Add water, lentils, and garlic clove to a large pot on medium heat to cook. When boiling add the vegetables in the pot and simmer until the vegetables are soft.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Recipe
                    {
                        Title = "Spicy Shrimp Tacos",
                        CategoryName = "Entrees",
                        Ingredients = "20 Medium Shrimp, 6 Flour Tortillas, 2 Cups Cabbage, 1/4 Cup Cilantro, 1 Jalapeno, 1/4 Red Onion, 1 Tbsp Honey, 2 Tbsp Lime Juice, 1/4 Cup Greek Yogurt, 1 Tbsp Sriracha, 2 Tbsp Olive Oil, 1 Tsp Paprika",
                        Instructions = "Combine Shrimp, oil, and spices in a medium bowl. Heat a large skillet on high heat for 2 minutes. Add a teaspoon of oil to the pan and shrimp. Cook shrimp until pink and cooked through., Combine all the ingredients in a large bowl until mixed through."
                    }
                );
            }
        }
    }
}