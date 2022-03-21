using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class TicketBookingModel
    {
        [Key]
        [Column("BookingId")]
        public int BookingId { get; set; }
        public int? AvailableSeats { get; set; }
        public decimal? Fare { get; set; }
        public DateTime? DateOfBooking { get; set; }
        public DateTime? OnwardJourneyDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? CustomerId { get; set; }
        public int? TicketTypeId { get; set; }
        public int? ScheduleId { get; set; }




    }
}
