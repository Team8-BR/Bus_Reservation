using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IBusFareDao
    {
        bool InsertBusFareInfo(BusFareModel p);
        BusFareModel FetchDetailsById(int id);

        List<BusFareModel> FetchAllDetails();


    }
}

  