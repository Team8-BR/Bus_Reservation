using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IRouteDetailsDao
    {
        bool InsertRouteDetailsInfo(RouteDetailsModel p);
        RouteDetailsModel FetchDetailsById(int id);

        int DeleteRouteDetails(int id);

        List<RouteDetailsModel> FetchAllDetails();


    }
}
