using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IBusDetailsDao
    {
        bool InsertBusDetailsInfo(BusDetailsModel p);
        BusDetailsModel FetchDetailsById(int id);

        int DeleteBusDetails(int id);

        List<BusDetailsModel> FetchAllDetails();


    }
}
