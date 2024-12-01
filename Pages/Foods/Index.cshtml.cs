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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Food> Foods { get; set; }

        public async Task OnGetAsync()
        {
            Foods = await _context.Foods.ToListAsync();
        }
    }
}
