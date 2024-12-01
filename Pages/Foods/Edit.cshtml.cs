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
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var foodToUpdate = await _context.Foods.FindAsync(id);

            if (foodToUpdate == null)
            {
                return NotFound();
            }

            foodToUpdate.FoodName = Food.FoodName;
            foodToUpdate.Calories = Food.Calories;
            foodToUpdate.Category = Food.Category;

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

