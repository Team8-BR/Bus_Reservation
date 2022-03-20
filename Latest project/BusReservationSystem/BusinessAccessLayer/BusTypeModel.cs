using BusReservationSystem.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class BusTypeModel
    {
        [Key]
        [Column("BusTypeId")]
        public int BusTypeId { get; set; }
        public string BusType1 { get; set; }

        
    }
}
   