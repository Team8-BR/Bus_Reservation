using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IBusTypeDao
    {
        bool InsertBusTypeInfo(BusTypeModel p);
        BusTypeModel FetchDetailsById(int id);

        int DeleteBusType(int id);

        List<BusTypeModel> FetchAllDetails();


    }
}



