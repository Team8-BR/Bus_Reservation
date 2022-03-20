using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class BusFare
    {
        public BusFare()
        {
            BusSchedule = new HashSet<BusSchedule>();
        }

        public int FareId { get; set; }
        public int? RouteId { get; set; }
        public decimal? FareAmount { get; set; }
        public int? BusTypeId { get; set; }

        public virtual BusType BusType { get; set; }
        public virtual RouteDetails Route { get; set; }
        public virtual ICollection<BusSchedule> BusSchedule { get; set; }
    }
}
  