using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class BusDetails
    {
        public BusDetails()
        {
            BusSchedule = new HashSet<BusSchedule>();
        }

        public int BusId { get; set; }
        public int? RegistrationNumber { get; set; }
        public int? TotalSeats { get; set; }
        public int? BusTypeId { get; set; }

        public virtual BusType BusType { get; set; }
        public virtual ICollection<BusSchedule> BusSchedule { get; set; }
    }
}
