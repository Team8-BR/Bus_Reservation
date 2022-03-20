using BusReservationSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class RouteDetailsModel
    {
        [Key]
        [Column("RouteId")]
        public int RouteId { get; set; }
        public string DepartureStation { get; set; }
        public string DestinationStation { get; set; }
        public TimeSpan? Duration { get; set; }

       
    }
}
