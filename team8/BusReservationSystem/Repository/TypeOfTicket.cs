using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class TypeOfTicket
    {
        public TypeOfTicket()
        {
            TicketBooking = new HashSet<TicketBooking>();
            TicketCancellation = new HashSet<TicketCancellation>();
        }

        public int TicketTypeId { get; set; }
        public string TicketType { get; set; }

        public virtual ICollection<TicketBooking> TicketBooking { get; set; }
        public virtual ICollection<TicketCancellation> TicketCancellation { get; set; }
    }
}
