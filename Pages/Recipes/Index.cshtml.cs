using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

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

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}
