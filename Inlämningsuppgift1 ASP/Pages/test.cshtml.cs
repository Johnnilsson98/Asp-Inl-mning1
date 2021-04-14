using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift1_ASP.Data;
using Inlämningsuppgift1_ASP.Models;

namespace Inlämningsuppgift1_ASP.Pages
{
    public class testModel : PageModel
    {
        private readonly Inlämningsuppgift1_ASP.Data.EventDbContext _context;

        public testModel(Inlämningsuppgift1_ASP.Data.EventDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.EventId == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
