using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class Customer
    {
        public Customer()
        {
            TicketBooking = new HashSet<TicketBooking>();
            TicketCancellation = new HashSet<TicketCancellation>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string ContactNo { get; set; }
        public int? UserId { get; set; }

        public virtual Login User { get; set; }
        public virtual ICollection<TicketBooking> TicketBooking { get; set; }
        public virtual ICollection<TicketCancellation> TicketCancellation { get; set; }
    }
}
