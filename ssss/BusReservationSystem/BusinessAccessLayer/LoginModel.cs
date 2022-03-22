using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class LoginModel
    {
        
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
        public string Password { get; set; }
        public int? UserTypeId { get; set; }


    }
}

