using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class TicketCancellationModel
    {
        [Key]
        [Column("BusId")]

        public int CancellationId { get; set; }
        public int? BookingId { get; set; }
        public decimal? RefundAmount { get; set; }
        public DateTime? CancellationDate { get; set; }
        public int? TicketTypeId { get; set; }
        public int? CustomerId { get; set; }
        public int? ScheduleId { get; set; }




    }
}
