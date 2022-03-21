using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class RouteDetails
    {
        public RouteDetails()
        {
            BusFare = new HashSet<BusFare>();
            BusSchedule = new HashSet<BusSchedule>();
        }

        public int RouteId { get; set; }
        public string DepartureStation { get; set; }
        public string DestinationStation { get; set; }
        public TimeSpan? Duration { get; set; }

        public virtual ICollection<BusFare> BusFare { get; set; }
        public virtual ICollection<BusSchedule> BusSchedule { get; set; }
    }
}
