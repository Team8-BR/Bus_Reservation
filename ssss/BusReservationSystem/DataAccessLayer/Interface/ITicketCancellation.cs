using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface ITicketCancellationDao
    {
        bool InsertTicketCancellationInfo(TicketCancellationModel p);
        TicketCancellationModel FetchDetailsById(int id);

        int DeleteTicketCancellation(int id);

        List<TicketCancellationModel> FetchAllDetails();


    }
}
