using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift1_ASP.Models;

namespace Inlämningsuppgift1_ASP.Data
{
    public class EventDbContext : DbContext
    {
        public EventDbContext (DbContextOptions<EventDbContext> options)
            : base(options)
        {
        }

        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Organizer> Organizer { get; set; }

        public void seed()
        {
            //this.Attendee.RemoveRange(this.Attendee);
            //this.Event.RemoveRange(this.Event);
            //this.Organizer.RemoveRange(this.Organizer);

            this.Event.AddRange(new List<Event>()
            {
                new Event(){Title = "Partaj", Description = "Fest", Place = "Halmstad", Address = "Tullgatan", Date = "27/3", SpotsAvailable = 101},
                new Event(){Title = "Partaj2", Description = "Fest2", Place = "Halmstad2", Address = "Tullgatan2", Date = "28/3", SpotsAvailable = 102},
                new Event(){Title = "Partaj3", Description = "Fest3", Place = "Halmstad3", Address = "Tullgatan3", Date = "29/3", SpotsAvailable = 103},
                new Event(){Title = "Partaj4", Description = "Fest4", Place = "Halmstad4", Address = "Tullgatan4", Date = "27/4", SpotsAvailable = 104}
            });
        }
    }
}
