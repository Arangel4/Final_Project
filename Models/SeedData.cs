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
                if (context.Category.Any())
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
                        CategoryName = "Breakfast",
                        Description = "Breakfast would include all meals that would be eaten in the morning."
                    },

                    new Category
                    {
                        CategoryName = "Entrees",
                        Description = "Entrees include all main meals. There would include recipes that can be used for lunch and dinner."
                    },

                    new Category
                    {
                        CategoryName = "Desserts",
                        Description = "Desserts are the sweet dishes."
                    },

                    new Category
                    {
                        CategoryName = "Beverages",
                        Description = "Beverages include all drinks that are made."
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
                        Title = "Strawberry Mojito",
                        CategoryName = "Beverages",
                        Ingredients = "White Sugar for Rimming, 2 Large Limes Quartered, ½ Mint Leaves, 7 Strawberries Quartered, 1 Cup White Sugar, 1 Cup White Rum , 2 Cups Club Soda, 8 Cups Ice Cubes",
                        Instructions = "1) Pour 1/4 to 1/2 inch of sugar onto a small, shallow plate. Run one of the lime quarters around the rim of each cocktail glass, then dip the glasses into the sugar to rim; set aside. 2) Squeeze all of the lime quarters into a sturdy glass pitcher. Toss the juiced limes into the pitcher along with the mint, strawberries, and 1 cup of sugar. Crush the fruits together with a muddler to release the juices from the strawberries and the oil from the mint leaves. Stir in the rum and club soda until the sugar has dissolved. Pour into the sugared glasses over ice cubes to serve.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 3},
                            new Review {Score = 4},
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(5)
                    },

                    new Recipe
                    {
                        Title = "Angel Chicken Pasta",
                        CategoryName = "Entrees",
                        Ingredients = "6 Boneless Chicken Breast Halves, ¼ Cup Butter, 1 Package Dry Italian-Style Salad Dressing Mix, ½ Cup White Wine, 1 Can Condensed Golden Mushroom Soup, 4 oz Cream Cheese with Chives, 1 Lb Angel Hair Pasta",
                        Instructions = "1) Preheat oven to 325 degrees F (165 degrees C). 2) In a large saucepan, melt butter over low heat. Stir in the package of dressing mix. Blend in wine and golden mushroom soup. Mix in cream cheese, and stir until smooth. Heat through, but do not boil. Arrange chicken breasts in a single layer in a 9x13 inch baking dish. Pour sauce over. 3) Bake for 60 minutes in the preheated oven. Twenty minutes before the chicken is done, bring a large pot of lightly salted water to a rolling boil. Cook pasta until al dente, about 5 minutes. Drain. Serve chicken and sauce over pasta.",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 3}
                        },
                        Category = context.Category.Find(3)
                    },

                    new Recipe
                    {
                        Title = "Deviled Eggs",
                        CategoryName = "Appetizers",
                        Ingredients = "12 Eggs, 3 Tbsp Mayonnaise, 1 ½ Tbsp Dill Pickle Relish, 1 Tbsp White Sugar, 1 Tsp Yellow Mustard, 1 Tsp Cider Vinegar, 1 Tsp Paprika",
                        Instructions = "1) Place eggs in a large pot and cover with cold salted water. Bring salt water to a boil and immediately remove pot from heat. Cover pot and let eggs stand in hot water for 15 minutes. Pour hot water out of pot and run cold water over eggs until completely cool. Peel eggs and cut in half lengthwise. 2) Separate the yolks from the whites of each egg. Mash the yolks in a bowl. Add mayonnaise, pickle relish, sugar, yellow mustard, vinegar, salt, and pepper to egg yolks and mix until smooth. Spoon yolk mixture into the egg whites and sprinkle paprika over yolk filling. Refrigerate until chilled, at least 1 hour.",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(1)
                    },

                    new Recipe
                    {
                        Title = "Ginger Cookies",
                        CategoryName = "Desserts",
                        Ingredients = "2 ¼ Cup Flour, 2 Tsp Ground Ginger, 1 Tsp Baking Soda, ¾ Tsp Ground Cinnamon, ½ Tsp Ground Cloves, ¼ Tsp Salt, ¾ Cup Margarine Softened, 1 Cup White Sugar, 1 Egg, 1 Tbsp Water, ¼ Cup Molasses, 2 Tbsp White Sugar",
                        Instructions = "1) Preheat oven to 350 degrees F (175 degrees C). Sift together the flour, ginger, baking soda, cinnamon, cloves, and salt. Set aside. 2) In a large bowl, cream together the margarine and 1 cup sugar until light and fluffy. Beat in the egg, then stir in the water and molasses. Gradually stir the sifted ingredients into the molasses mixture. Shape dough into walnut sized balls, and roll them in the remaining 2 tablespoons of sugar. Place the cookies 2 inches apart onto an ungreased cookie sheet, and flatten slightly. 3) Bake for 8 to 10 minutes in the preheated oven. Allow cookies to cool on baking sheet for 5 minutes before removing to a wire rack to cool completely. Store in an airtight container.",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 2},
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(4)
                    },

                    new Recipe
                    {
                        Title = "Pico de Gallo Chicken Quesadillas",
                        CategoryName = "Entrees",
                        Ingredients = "2 Tomatoes Diced, 1 Onion Finely Chopped, 2 Limes Juiced, 2 Tbsp Chopped Fresh Cilantro, 1 Jalapeno Pepper Seeded and Minced, Salt and Pepper to taste, 2 Tbs Olive Oil, 2 Boneless Chicken Breast Cut into Strips, ½ Onion Thinly Sliced, 1 Green Bell Pepper Thinly Sliced, 2 Garlic Cloves Minced, 4 Flour Tortillas, 1 Cup Shredded Monterey Jack Cheese, ¼ Cup Sour Cream ",
                        Instructions = "1) In a small bowl, combine tomatoes, onion, lime juice, cilantro, jalapeno, salt, and pepper. Set pico de gallo aside. 2) In a large skillet, heat 1 tablespoon olive oil. Add chicken and saute until cooked through and juices run clear. Remove chicken from skillet and set aside. 3) Put the remaining 1 tablespoon of olive oil in the hot skillet and saute the sliced onion and green pepper until tender. Stir in the minced garlic and saute until the aroma is strong. Mix in half of the pico de gallo and chicken breast meat. Set aside; keep warm. 4)In a heavy skillet, heat one flour tortilla. Spread 1/4 cup shredded cheese on the tortilla and top with 1/2 the chicken mixture. Sprinkle another 1/4 cup cheese over the chicken and top with another tortilla. When bottom tortilla is lightly brown and cheese has started to melt, flip quesadilla and cook on the opposite side. Remove quesadilla from skillet and cut into quarters. Repeat with remaining ingredients. Serve quesadillas with sour cream and remaining pico de gallo.",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 2}
                        },
                        Category = context.Category.Find(3)
                    },

                    new Recipe
                    {
                        Title = "Lentils",
                        CategoryName = "Entrees",
                        Ingredients = "3 Cups Lentils, 1 Cup Celery, 1 Garlic Clove, 1.5 Cups Carrots, 2 Cups Potatoes, 1/2 Cup Onion, 1 Cup Cilanto, 5 Cups Water",
                        Instructions = "1) Add water, lentils, and garlic clove to a large pot on medium heat to cook. When boiling add the vegetables in the pot and simmer until the vegetables are soft.",
                        Reviews = new List<Review> {
                            new Review {Score = 4}
                        },
                        Category = context.Category.Find(3)
                    },

                    new Recipe
                    {
                        Title = "Jalapeno Poppers",
                        CategoryName = "Appetizers",
                        Ingredients = "12 Jalapeno Peppers, 1 Package Cream Cheese, 12 Slices Jalapeno Bacon, 1 Tbsp Cajun Seasoning",
                        Instructions = "1) Preheat the oven's broiler and set the oven rack about 6 inches from the heat source. 2) Fill the jalapeno peppers with cream cheese. Sprinkle the Cajun seasoning on top, then wrap each stuffed jalapeno with a slice of bacon. Secure with a toothpick. Arrange the wrapped jalapeno peppers in a single layer, face down on a broiler rack. 3) Broil in the preheated oven until the bacon becomes crisp, 8 to 15 minutes on each side.",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(1)
                    },

                    new Recipe
                    {
                        Title = "Breakfast Casserole",
                        CategoryName = "Breakfasts",
                        Ingredients = "3 Cups Hash Browns, ¾ Cup Shredded Pepper Jack Cheese, 1 Cup Cooked Ham Diced, ¼ Cup Chopped Green Onions, 4 Eggs, 1 Can Evaporated Milk, ¼ Tsp Black Pepper, 1/8 Tsp Salt",
                        Instructions = "1) Preheat oven to 350 degrees F (175 degrees C). Grease a 2 quart baking dish. 2) Arrange hash brown potatoes evenly in the bottom of the prepared dish. Sprinkle with pepper jack cheese, ham, and green onions. 3) In a medium bowl, mix the eggs, evaporated milk, pepper, and salt. Pour the egg mixture over the potato mixture in the dish. The dish may be covered and refrigerated at this point for several hours or overnight. 4) Bake for 40 to 45 minutes (or 55 to 60 minutes if made ahead and chilled) in the preheated oven, or until a knife inserted in the center comes out clean. Let stand 5 minutes before serving.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 2},
                            new Review {Score = 2}
                        },
                        Category = context.Category.Find(2)
                    },

                    new Recipe
                    {
                        Title = "Seven Layer Tex Mex Dip",
                        CategoryName = "Appetizers",
                        Ingredients = "1 Can Refried Beans, 1 Cup Guacamole, ¼ Cup Mayonnaise, 1 Container Sour Cream, 1 Package Taco Seasoning Mix, 2 Cups Shredded Cheddar Cheese, 1 Tomato, Chopped, ¼ Cup Chopped Green Onions, ¼ Cup Black Olives Drained",
                        Instructions = "1) In a large serving dish, spread the refried beans. Layer the guacamole on top of the beans. 2) In a medium bowl, mix the mayonnaise, sour cream and taco seasoning mix. Spread over the layer of guacamole. 3) Sprinkle a layer of Cheddar cheese over the mayonnaise mixture layer. Sprinkle tomato, green onions and black olives over the cheese.",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 2},
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(1)
                    },

                    new Recipe
                    {
                        Title = "Moscow Mule",
                        CategoryName = "Beverages",
                        Ingredients = "Ice , ½ Fresh Lime, 2 oz Vodka, 4 oz Ginger Beer, 2 Lime Slices",
                        Instructions = "1) Fill a tall glass with ice. Squeeze 1/2 lime over ice. Pour vodka over ice and top with ginger beer. Garnish with lime slices.",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 3}
                        },
                        Category = context.Category.Find(5)
                    },

                    new Recipe
                    {
                        Title = "Breakfast Muffins",
                        CategoryName = "Breakfasts",
                        Ingredients = "¾ Lbs Sausage, 1/8 Cup Chopped Onion, 1/8 Cup Chopped Green Bell Pepper, 1 Can Biscuit Dough, 3 Eggs, 3 Tbsp Milk, ½ Cup Shredded Colby-Monterey Jack Cheese",
                        Instructions = "1) Preheat oven to 400 degrees F (200 degrees C). 2)In a large, deep skillet over medium-high heat, combine sausage, onion and green pepper. Cook until sausage is evenly brown. Drain, crumble, and set aside. 3) Separate the dough into 10 individual biscuits. Flatten each biscuit out, then line the bottom and sides of 10 muffin cups. Evenly distribute sausage mixture between the cups. Mix together the eggs and milk, and divide between the cups. Sprinkle tops with shredded cheese. 4) Bake in preheated oven for 18 to 20 minutes, or until filling is set.",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 2}
                        },
                        Category = context.Category.Find(2)
                    },

                    new Recipe
                    {
                        Title = "Spicy Shrimp Tacos",
                        CategoryName = "Entrees",
                        Ingredients = "20 Medium Shrimp, 6 Flour Tortillas, 2 Cups Cabbage, 1/4 Cup Cilantro, 1 Jalapeno, 1/4 Red Onion, 1 Tbsp Honey, 2 Tbsp Lime Juice, 1/4 Cup Greek Yogurt, 1 Tbsp Sriracha, 2 Tbsp Olive Oil, 1 Tsp Paprika",
                        Instructions = "1) Combine Shrimp, oil, and spices in a medium bowl. Heat a large skillet on high heat for 2 minutes. Add a teaspoon of oil to the pan and shrimp. Cook shrimp until pink and cooked through. 2) Combine all the ingredients in a large bowl until mixed through.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 4},
                            new Review {Score = 5},
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(3)
                    },

                    new Recipe
                    {
                        Title = "Eggnog",
                        CategoryName = "Beverages",
                        Ingredients = "4 Cups Milk, 5 Whole Coves, ½ Tsp Vanilla Extract, 1 Tsp Ground Cinnamon, 12 Egg Yolks, 1 ½ Cup Sugar, 2 ½ Cup Light Rum, 4 Cups Light Cream, 2 Tsp Vanilla Extract, ½ Tsp Ground Nutmeg",
                        Instructions = "1) Combine milk, cloves, 1/2 teaspoon vanilla, and cinnamon in a saucepan, and heat over lowest setting for 5 minutes. Slowly bring milk mixture to a boil. 2) In a large bowl, combine egg yolks and sugar. Whisk together until fluffy. Whisk hot milk mixture slowly into the eggs. Pour mixture into saucepan. Cook over medium heat, stirring constantly for 3 minutes, or until thick. Do not allow mixture to boil. Strain to remove cloves, and let cool for about an hour. 3) Stir in rum, cream, 2 teaspoon vanilla, and nutmeg. Refrigerate overnight before serving.",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 5},
                            new Review {Score = 2}
                        },
                        Category = context.Category.Find(5)
                    },

                    new Recipe
                    {
                        Title = "Salsa Verde",
                        CategoryName = "Appetizers",
                        Ingredients = "1 lb Tomatillos Husked, ½ Cup Finely Chopped Onion, 1 Tsp Minced Garlic, 1 Serrano Chile Pepper Minced, 2 Tbsp Chopped Cilantro, 1 Tbsp Chopped Oregano, 1 Tsp Ground Cumin, 1 ½ Tsp Salt, 2 Cups Water",
                        Instructions = "1) Place tomatillos, onion, garlic, and chile pepper into a saucepan. Season with cilantro, oregano, cumin, and salt; pour in water. Bring to a boil over high heat, then reduce heat to medium-low, and simmer until the tomatillos are soft, 10 to 15 minutes. 2) Using a blender, carefully puree the tomatillos and water in batches until smooth",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 1}
                        },
                        Category = context.Category.Find(1)
                    },

                    new Recipe
                    {
                        Title = "Pancakes",
                        CategoryName = "Breakfasts",
                        Ingredients = "¾ Cup Milk, 2 Tbsp White Vinegar, 1 Cup All-Purpose Flour, 2 Tbsp White Sugar, 1 Tsp Baking Power, ½ Tsp Baking Soda, ½ Tsp Salt , 1 Egg, 2 Tbsp Butter Melted",
                        Instructions = "1) Combine milk with vinegar in a medium bowl and set aside for 5 minutes to sour. 2) Combine flour, sugar, baking powder, baking soda, and salt in a large mixing bowl. Whisk egg and butter into soured milk. Pour the flour mixture into the wet ingredients and whisk until lumps are gone. 3) Heat a large skillet over medium heat, and coat with cooking spray. Pour 1/4 cupfuls of batter onto the skillet, and cook until bubbles appear on the surface. Flip with a spatula, and cook until browned on the other side.",
                        Reviews = new List<Review> {
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(2)
                    },

                    new Recipe
                    {
                        Title = "Horchata",
                        CategoryName = "Beverages",
                        Ingredients = "1 Cup Uncooked White Long-Grain Rice, 5 Cups Water, ½ Cup Milk, ½ Tbsp Vanilla Extract, ½ Tbsp Ground Cinnamon, 2/3 Cup White Sugar",
                        Instructions = "1) Pour the rice and water into the bowl of a blender; blend until the rice just begins to break up, about 1 minute. Let rice and water stand at room temperature for a minimum of 3 hours. 2) Strain the rice water into a pitcher and discard the rice. Stir the milk, vanilla, cinnamon, and sugar into the rice water. Chill and stir before serving over ice.",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 4},
                            new Review {Score = 4}
                        },
                        Category = context.Category.Find(5)
                    },

                    new Recipe
                    {
                        Title = "Brownies",
                        CategoryName = "Desserts",
                        Ingredients = "¾ Cup Butter Melted, 1 ½ Cup White Sugar, 1 ½ Tsp Vanilla Extract, 3 Eggs, ¾ Cup Flour, ½ Cup Unsweetened Cocoa Powder, ½ Tsp Baking Powder, ½ Tsp Salt",
                        Instructions = "1) Preheat oven to 350 degrees F (175 degrees C). Grease an 8 inch square pan. 2) In a large bowl, blend melted butter, sugar and vanilla. Beat in eggs one at a time. Combine the flour, cocoa, baking powder and salt. Gradually blend into the egg mixture. Spread the batter into the prepared pan. 3) Bake in preheated oven for 40 to 45 minutes, or until brownies begin to pull away from the sides of the pan. Let brownies cool, then cut into squares.",
                        Reviews = new List<Review> {
                            new Review {Score = 4},
                            new Review {Score = 3},
                            new Review {Score = 1},
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(4)
                    },

                    new Recipe
                    {
                        Title = "Blueberry Smoothie",
                        CategoryName = "Beverages",
                        Ingredients = "1 Cup Blueberries, 1 Container Plain Yogurt, ¾ Cup 2% Reduced-Fat Milk, 2 Tbsp White Sugar, ½ Tsp Vanilla Extract, 1/8 Tsp Ground Nutmeg",
                        Instructions = "1) Blend the blueberries, yogurt, milk, sugar, vanilla, and nutmeg in a blender until frothy, scraping down the sides of the blender with a spatula occasionally. Serve immediately.",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 3}
                        },
                        Category = context.Category.Find(5)
                    },

                    new Recipe
                    {
                        Title = "Vietanmese Spring Rolls",
                        CategoryName = "Appetizers",
                        Ingredients = "2 Oz Rice Vermicelli, 8 Rice Wrappers, 8 Large Cooked Shrimp Peeled and Cut in Half, 1 1/3 Tbsp Chopped Basil, 3 Tbsp Chopped Mint Leaves, 3 Tbsp Chopped Cilantro, 2 Leaves Lettuce Chopped",
                        Instructions = "1) Bring a medium saucepan of water to boil. Boil rice vermicelli 3 to 5 minutes, or until al dente, and drain. 2) Fill a large bowl with warm water. Dip one wrapper into the hot water for 1 second to soften. Lay wrapper flat. In a row across the center, place 2 shrimp halves, a handful of vermicelli, basil, mint, cilantro and lettuce, leaving about 2 inches uncovered on each side. Fold uncovered sides inward, then tightly roll the wrapper, beginning at the end with the lettuce. Repeat with remaining ingredients.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 5},
                        },
                        Category = context.Category.Find(1)
                    },

                    new Recipe
                    {
                        Title = "Lemon Bars",
                        CategoryName = "Desserts",
                        Ingredients = "1 Cup Flour, ¼ Cup Confectioner Sugar, ¼ Cup Butter, 1 Cup White Sugar, 2 Tbsp Flour, ½ Tsp Baking Powder, 2 Eggs, 3 Tbsp Lemon Juice, 1 Tbsp Lemon Zest",
                        Instructions = "1) Preheat oven to 350 degrees F (175 degrees C). 2) To make Bottom Layer: Mix one cup flour and 1/4 cup confectioners sugar. Melt the butter and stir into flour mixture. 3) Press flat and even into an 8x8 inch baking dish. Bake for 20 minutes. 4) While baking, make the top layer: Mix 1 cup sugar, 2 tablespoons flour, and the baking powder. 5) Beat eggs and add to mixture, stirring well. Add lemon juice and rind, mix again. 6) Pour over bottom layer; Bake at 350 for 25 minutes. Cool a little, cut into squares while warm.",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 4},
                            new Review {Score = 1}
                        },
                        Category = context.Category.Find(4)
                    },

                    new Recipe
                    {
                        Title = "Omelet",
                        CategoryName = "Breakfasts",
                        Ingredients = "2 Eggs, 1 Cup Baby Spinach Leaves, 1 ½ Tbsp Grated Parmesan Cheese, ¼ Tsp Onion Power, 1/8 Tsp Nutmeg, Salt and Pepper to Taste",
                        Instructions = "1) In a bowl, beat the eggs, and stir in the baby spinach and Parmesan cheese. Season with onion powder, nutmeg, salt, and pepper. 2) In a small skillet coated with cooking spray over medium heat, cook the egg mixture about 3 minutes, until partially set. Flip with a spatula, and continue cooking 2 to 3 minutes. Reduce heat to low, and continue cooking 2 to 3 minutes, or to desired doneness.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 4},
                            new Review {Score = 5}
                        },
                        Category = context.Category.Find(2)
                    },

                    new Recipe
                    {
                        Title ="Bloody Mary",
                        CategoryName = "Beverages",
                        Ingredients = "1 Bottle Tomato Juice, 1 ½ Tbsp Celery Salt, 1 ½ Tsp Ground Black Pepper, 3 Tbsp Worcestershire Sauce, 1 ½ Tsp Tabasco Sauce",
                        Instructions = "1) In a large jar or bottle, combine the tomato juice, celery salt, pepper, Worcestershire sauce, and hot pepper sauce. Secure the lid and shake, or stir to mix until well blended. Store in the refrigerator for up to one week.",
                        Reviews = new List<Review> {
                            new Review {Score = 3}
                        },
                        Category = context.Category.Find(5)
                    },

                    new Recipe
                    {
                        Title = "Monkey Bread",
                        CategoryName = "Desserts",
                        Ingredients = "3 Packages Biscuit Dough, 1 Cup White Sugar, 2 Tsp Ground Cinnamon, ½ Cup Margarine, 1 Cup Brown Sugar",
                        Instructions = "1) Preheat oven to 350 degrees F (175 degrees C). Grease one 9 or 10 inch Bundt pan. 2) Mix white sugar and cinnamon in a plastic bag. Cut biscuits into quarters. Shake 6 to 8 biscuit pieces in the sugar cinnamon mix. Arrange pieces in the bottom of the prepared pan. Continue until all biscuits are coated and placed in pan. 3) In a small saucepan, melt the margarine with the brown sugar over medium heat. Boil for 1 minute. Pour over the biscuits. 4) Bake at 350 degrees F (175 degrees C) for 35 minutes. Let bread cool in pan for 10 minutes, then turn out onto a plate. Do not cut! The bread just pulls apart.",
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 3}
                        },
                        Category = context.Category.Find(4)
                    },

                    new Recipe
                    {
                        Title = "Chinese Pepper Steak",
                        CategoryName = "Entrees",
                        Ingredients = "1 Lbs Beef Top Sirloin Steak, ¼ Cup Soy Sauce, 2 Tbsp White Sugar , 2 Tbsp Cornstarch, ½ Tsp Ground Ginger, 3 Tbsp Vegetable Oil, 1 Red Onion Cut Up, 1 Green Bell Pepper Cut Up, 2 Tomatoes Cut Up",
                        Instructions = "1) Slice the steak into 1/2-inch thick slices across the grain. 2) Whisk together soy sauce, sugar, cornstarch, and ginger in a bowl until the sugar has dissolved and the mixture is smooth. Place the steak slices into the marinade, and stir until well-coated. 3) Heat 1 tablespoon of vegetable oil in a wok or large skillet over medium-high heat, and place 1/3 of the steak strips into the hot oil. Cook and stir until the beef is well-browned, about 3 minutes, and remove the beef from the wok to a bowl. Repeat twice more, with the remaining beef, and set the cooked beef aside. 4) Return all the cooked beef to the hot wok, and stir in the onion. Toss the beef and onion together until the onion begins to soften, about 2 minutes, then stir in the green pepper. Cook and stir the mixture until the pepper has turned bright green and started to become tender, about 2 minutes, then add the tomatoes, stir everything together, and serve.",
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 4}
                        },
                        Category = context.Category.Find(3)
                    },

                    new Recipe
                    {
                        Title = "Quiche",
                        CategoryName = "Breakfasts",
                        Ingredients = "1 ½ Cup Shredded Swiss Cheese, 4 Tsp Flour, ½ Cup Cooked Ham Diced, 3 Eggs, 1 Cup Milk, ¼ Tsp Salt, ¼ Tsp Dry Mustard, 1 Pie Crust",
                        Instructions = "1) In medium bowl, toss 4 teaspoons flour with the grated cheese. Sprinkle mixture into the pie shell. On top of cheese, sprinkle 1/2 cup of diced ham. 2) In medium bowl, combine eggs, milk or cream, and then add salt and mustard powder. Beat until smooth and pour over cheese and ham. 3) Put piece of plastic wrap large enough to overlap sides over top of quiche, then a piece of foil, and seal well around the edges. (plastic keeps the foil from sticking to the food). Place prepared quiche in freezer. 4) When ready to prepare, preheat oven to 400 degrees F (200 degrees C.) Remove foil and plastic wrap. Put foil around edge of crust to protect it. 5) Bake in the preheated oven for 60 minutes, or until filling is set and crust is golden brown.",
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 3},
                            new Review {Score = 2}
                        },
                        Category = context.Category.Find(2)
                    },

                    new Recipe
                    {
                        Title = "Tres Leches",
                        CategoryName = "Desserts",
                        Ingredients = "1 ½ Cup Flour, 1 Tsp Baking Powder, ½ Cup Unsalted Butter, 1 Cup White Sugar, 5 Eggs, ½ Tsp Vanilla Extract, 2 Cups Whole Milk, 1 Can Sweetened Condensed Milk, 1 Can Evaporated Milk, 1 ½ Cups Heavy Whipping Cream, 1 Cup White , 1 Tsp Vanilla Extract",
                        Instructions = "1) Preheat oven to 350 degrees F (175 degrees C). Grease and flour one 9x13 inch baking pan. 2) Sift flour and baking powder together and set aside. 3) Cream butter or margarine and the 1 cup sugar together until fluffy. Add eggs and the 1/2 teaspoon vanilla extract; beat well. 4) Add the flour mixture to the butter mixture 2 tablespoons at a time; mix until well blended. Pour batter into prepared pan. 5) Bake at 350 degrees F (175 degrees C) for 30 minutes. Pierce cake several times with a fork. 6) Combine the whole milk, condensed milk, and evaporated milk together. Pour over the top of the cooled cake. 7) Whip whipping cream, the remaining 1 cup of the sugar, and the remaining 1 teaspoon vanilla together until thick. Spread over the top of cake. Be sure and keep cake refrigerated",
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 4},
                            new Review {Score = 3}
                        },
                        Category = context.Category.Find(4)
                    }
                );
                context.SaveChanges();   
            }
        }
    }
}