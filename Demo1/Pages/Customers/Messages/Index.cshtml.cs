using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Demo1.Data;

namespace Demo1.Pages.Customers.Messages
{
    public class IndexModel : PageModel
    {
        private readonly Demo1.Data.ApplicationDbContext _context;

        public IndexModel(Demo1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Message> Message { get;set; }

        public async Task OnGetAsync()
        {
            Message = await _context.Message.ToListAsync();
        }
    }
}
