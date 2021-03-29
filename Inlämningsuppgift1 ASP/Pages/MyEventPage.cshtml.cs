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
    public class MyEventPageModel : PageModel
    {
        private readonly EventDbContext _context;

        public MyEventPageModel(EventDbContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get;set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendee.Where
                (a => a.AttendeeId == 1)
                .Include(e => e.Event)
                .FirstOrDefaultAsync();
        }
    }
}
