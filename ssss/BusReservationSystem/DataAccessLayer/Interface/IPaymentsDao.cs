using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IPaymentsDao
    {
        bool InsertPaymentsInfo(PaymentsModel p);
        PaymentsModel FetchDetailsById(int id);

        List<PaymentsModel> FetchAllDetails();


    }
}
