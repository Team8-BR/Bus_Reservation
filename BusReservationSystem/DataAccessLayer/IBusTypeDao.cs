using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
        public interface IBusTypeDao
        {
            BusTypeDao fetchDetailsById(int id);

            List<BusTypeDao> FetchAllDetails();

            bool InsertBusTypeInfo(BusTypeDao p);

        }
    }



