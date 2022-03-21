using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IBusScheduleDao
    {
        bool InsertBusScheduleInfo(BusScheduleModel p);
        BusScheduleModel FetchDetailsById(int id);

        List<BusScheduleModel> FetchAllDetails();

        
    }
}
