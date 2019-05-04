using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Review
    {
        public int ReviewID {get; set;}

        [Range(1, 5)]
        [Required]
        public int Score {get; set;}
        public int RecipeID {get; set;} // Foreign Key
        public Recipe Recipe {get; set;} // Navigation property. Each review belongs to one recipe.
    }
}