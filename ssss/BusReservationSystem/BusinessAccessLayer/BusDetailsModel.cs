using BusReservationSystem.Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class BusDetailsModel
    {
        [Key]
        [Column("BusId")]
        public int BusId { get; set; }
        public int? RegistrationNumber { get; set; }
        public int? TotalSeats { get; set; }
        public int? BusTypeId { get; set; }

        

    }
}

        

        
