using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public string CardType { get; set; }
        public string BankName { get; set; }
        public string CardNo { get; set; }
        public string CardHolderName { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? BookingId { get; set; }

        public virtual TicketBooking Booking { get; set; }
    }
}
