using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IBusScheduleDao
    {
        BusScheduleDao fetchDetailsById(int id);

        List<BusScheduleDao> FetchAllDetails();

        bool InsertBusScheduleInfo(BusScheduleDao p);

    }
}
