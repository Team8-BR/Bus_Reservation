using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IBusDetailsDao
    {
        BusDetailsDao fetchDetailsById(int id);

        List<BusDetailsDao> FetchAllDetails();
        int DeleteBusDetails(int id);


        bool InsertBusInfo(BusDetailsDao p);

    }
}