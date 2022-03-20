using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class BusType
    {
        public BusType()
        {
            BusDetails = new HashSet<BusDetails>();
            BusFare = new HashSet<BusFare>();
        }

        public int BusTypeId { get; set; }
        public string BusType1 { get; set; }

        public virtual ICollection<BusDetails> BusDetails { get; set; }
        public virtual ICollection<BusFare> BusFare { get; set; }
    }
}
