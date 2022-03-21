using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface ITicketBookingDao
    {
        bool InsertTicketBookingInfo(TicketBookingModel p);
        TicketBookingModel FetchDetailsById(int id);

        List<TicketBookingModel> FetchAllDetails();


    }
}
