using BusReservationSystem.Repository;

namespace BusReservationSystem.BusinessAccessLayer
{
    public class PaymentsModel
    {
        
        public int PaymentId { get; set; }
        public string CardType { get; set; }
        public string BankName { get; set; }
        public string CardNo { get; set; }
        public string CardHolderName { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? BookingId { get; set; }

       
    }
}

