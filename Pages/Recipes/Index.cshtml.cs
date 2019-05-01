using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project.Models.FinalProjectContext _context;

        public IndexModel(Final_Project.Models.FinalProjectContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString {get; set;}

        public SelectList Category {get; set;}
        [BindProperty(SupportsGet = true)]

        public string RecipeCategory {get; set;}

        public async Task OnGetAsync()
        {
            var categoryQuery = Category.Include(r => r.Recipe).OrderbBy(r => r.Category).Select(r => r.Category);
                                            
            var recipes = _context.Recipe.Include(r => r.Reviews).Select(r => r);

            if (!string.IsNullOrEmpty(SearchString))
            {
                recipes = recipes.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(RecipeCategory))
            {
                recipes = recipes.Where(x => x.CategoryName == RecipeCategory);
            }
            Category = new SelectList(await categoryQuery.Distinct().ToListAsync());
            Recipe = await recipes.ToListAsync();
        }
    }
}
