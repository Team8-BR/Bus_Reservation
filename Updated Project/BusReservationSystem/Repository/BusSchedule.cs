using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class BusSchedule
    {
        public BusSchedule()
        {
            TicketBooking = new HashSet<TicketBooking>();
            TicketCancellation = new HashSet<TicketCancellation>();
        }

        public int ScheduleId { get; set; }
        public int BusId { get; set; }
        public string DriverName { get; set; }
        public int RouteId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? BookedSeats { get; set; }
        public int? AvailableSeats { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public int FareId { get; set; }

        public virtual BusDetails Bus { get; set; } 
        public virtual BusFare Fare { get; set; }
        public virtual RouteDetails Route { get; set; }
        public virtual ICollection<TicketBooking> TicketBooking { get; set; }
        public virtual ICollection<TicketCancellation> TicketCancellation { get; set; }
    }
}
