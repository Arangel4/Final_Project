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

        public IList<Recipe> Recipe { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 5;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        public SelectList SortList {get; set;}
        public string CategoryName {get; set;}

        public async Task OnGetAsync()
        {
            var recipes = _context.Recipe.Include(r => r.Reviews).Include(r => r.Category).Select(r => r);

            var query = _context.Recipe.Select(r => r);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem { Text = "Title Ascending", Value = "first_asc" },
                new SelectListItem { Text = "Title Descending", Value = "first_desc" },
                new SelectListItem { Text = "Category Ascending", Value = "sec_asc" },
                new SelectListItem { Text = "Category Descending", Value = "sec_desc" }
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(r => r.Title);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(r => r.Title);
                    break;
                 case "sec_asc":
                    query = query.OrderBy(r => r.Category);
                    break;
                case "sec_desc":
                    query = query.OrderByDescending(r => r.Category);
                    break;
            }
            var Recipe = await recipes.ToListAsync();

            Recipe = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
