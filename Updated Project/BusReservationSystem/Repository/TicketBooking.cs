using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class TicketBooking
    {
        public TicketBooking()
        {
            Payments = new HashSet<Payments>();
            TicketCancellation = new HashSet<TicketCancellation>();
        }

        public int BookingId { get; set; }
        public int? AvailableSeats { get; set; }
        public decimal? Fare { get; set; }
        public DateTime? DateOfBooking { get; set; }
        public DateTime? OnwardJourneyDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? CustomerId { get; set; }
        public int? TicketTypeId { get; set; }
        public int? ScheduleId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual BusSchedule Schedule { get; set; }
        public virtual TypeOfTicket TicketType { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<TicketCancellation> TicketCancellation { get; set; }
    }
}
