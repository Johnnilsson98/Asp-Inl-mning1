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
    public class JoinEventModel : PageModel
    {
        private readonly EventDbContext _context;

        public JoinEventModel(EventDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
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

            var attendee = await _context.Attendee.Where
                (a => a.AttendeeId == 1)
                .Include(e => e.Event)
                .FirstOrDefaultAsync();

            var join = await _context.Event.Where
                (e => e.EventId == id)
                .FirstOrDefaultAsync();

            join.SpotsAvailable = join.SpotsAvailable - 1; // Får lägga till en koll på att man inte redan är med i eventet


            attendee.Event.Add(join);
            await _context.SaveChangesAsync();
            return RedirectToPage("/MyEventPage");

        }
    }
}
