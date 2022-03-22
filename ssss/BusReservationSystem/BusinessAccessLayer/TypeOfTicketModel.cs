using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class TypeOfTicketModel
    {

        [Key]
        [Column("TicketTypeId")]
        public int TicketTypeId { get; set; }
        public string TicketType { get; set; }
    }
}
