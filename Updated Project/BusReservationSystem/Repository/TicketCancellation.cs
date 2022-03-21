using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class TicketCancellation
    {
        public int CancellationId { get; set; }
        public int? BookingId { get; set; }
        public decimal? RefundAmount { get; set; }
        public DateTime? CancellationDate { get; set; }
        public int? TicketTypeId { get; set; }
        public int? CustomerId { get; set; }
        public int? ScheduleId { get; set; }

        public virtual TicketBooking Booking { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual BusSchedule Schedule { get; set; }
        public virtual TypeOfTicket TicketType { get; set; }
    }
}
