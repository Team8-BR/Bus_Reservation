using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
        public interface IBusTypeDao
        {
            BusTypeDao fetchDetailsById(int id);

            List<BusTypeDao> FetchAllDetails();

            int DeleteBusType(int id);

            bool InsertBusTypeInfo(BusTypeDao p);

        }
    }



