using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodRegistryApp1.Models;

namespace FoodRegistryApp1.Pages.Foods
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Food Food { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Food = await _context.Foods.FindAsync(id);

            if (Food == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

