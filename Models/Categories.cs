using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Category
    {
        public int CategoryID {get; set;}
        public string Description {get; set;}
        public int RecipeID {get; set;} // Foreign Key
    }
}