using BusReservationSystem.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class UserTypeModel
    {
        [Key]
        [Column("UserTypeId")]
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        
    }
}
