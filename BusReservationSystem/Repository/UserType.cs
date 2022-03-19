using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class UserType
    {
        public UserType()
        {
            Login = new HashSet<Login>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public virtual ICollection<Login> Login { get; set; }
    }
}
