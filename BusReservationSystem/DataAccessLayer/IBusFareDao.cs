using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
        public interface IBusFareDao
        {
            BusFareDao fetchDetailsById(int id);

            List<BusFareDao> FetchAllDetails();

            bool InsertBusFareInfo(BusFareDao p);

        }
    }

  