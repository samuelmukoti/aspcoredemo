using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Demo1.Data;

namespace Demo1.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly Demo1.Data.ApplicationDbContext _context;

        public DetailsModel(Demo1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.Where(m => m.Id == id)
                                              .Include(m => m.Messages)
                                              .SingleOrDefaultAsync();

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
