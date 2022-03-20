using BusReservationSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class CustomerModel
    {
        [Key]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string ContactNo { get; set; }
        public int? UserId { get; set; }

       
    }
}
