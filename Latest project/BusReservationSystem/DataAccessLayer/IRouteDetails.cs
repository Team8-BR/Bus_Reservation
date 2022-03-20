using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IRouteDetailsDao
    {
        RouteDetailsDao fetchDetailsById(int id);

        List<RouteDetailsDao> FetchAllDetails();

        bool InsertRouteInfo(RouteDetailsDao p);

    }
}
