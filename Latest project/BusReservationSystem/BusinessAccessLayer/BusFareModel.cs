using BusReservationSystem.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class BusFareModel
    {
        [Key]
        [Column("FareId")]
        public int FareId { get; set; }
        public int? RouteId { get; set; }
        public decimal? FareAmount { get; set; }
        public int? BusTypeId { get; set; }

        
    }
    }






