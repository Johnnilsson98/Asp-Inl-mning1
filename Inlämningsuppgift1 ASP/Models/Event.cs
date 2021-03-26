using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1_ASP.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public int OrganizerId { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
        public int SpotsAvailable { get; set; }
        public List<Attendee> Attendees { get; set; }
    }
}
