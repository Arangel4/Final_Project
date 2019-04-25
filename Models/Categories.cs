using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Category
    {
        public int CategoryID {get; set;}
        public string CategoryName {get; set;}
        public string Description {get; set;}
        public List<Recipe> Recipes {get; set;} // Navigation property. A category can have several recipes.
    }
}