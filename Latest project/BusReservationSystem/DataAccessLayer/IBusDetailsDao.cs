using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IBusDetailsDao
    {
        BusDetailsDao fetchDetailsById(int id);

        List<BusDetailsDao> FetchAllDetails();

        bool InsertBusInfo(BusDetailsDao p);

    }
}