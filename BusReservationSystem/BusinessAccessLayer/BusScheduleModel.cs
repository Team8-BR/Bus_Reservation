using BusReservationSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class BusScheduleModel
    {
        [Key]
        [Column("ScheduleId")]
        public int ScheduleId { get; set; }
        public int BusId { get; set; }
        public string DriverName { get; set; }
        public int RouteId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? BookedSeats { get; set; }
        public int? AvailableSeats { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public int FareId { get; set; }

        
    }
}
