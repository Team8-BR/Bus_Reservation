using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class Login
    {
        public Login()
        {
            Customer = new HashSet<Customer>();
        }

        public int UserId { get; set; }
        public string Password { get; set; }
        public int? UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
