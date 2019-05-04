using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Recipe
    {
        public int RecipeID {get; set;}

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title {get; set;}
        public string Ingredients {get; set;}
        public string Instructions {get; set;}
        public List<Review> Reviews {get; set;} // Navigation property. A recipe can have many reviews.
        public int CategoryID {get; set;}
        public string CategoryName {get; set;}
        public Category Category {get; set;} // Navigation property. Each recipe belongs to one category.
    }
}