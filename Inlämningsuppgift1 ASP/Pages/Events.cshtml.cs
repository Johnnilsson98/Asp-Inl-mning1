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
    public class EventsModel : PageModel
    {
        private readonly EventDbContext _context;

        public EventsModel(EventDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }
    }
}
