using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IPaymentsDao
    {
        PaymentsDao fetchDetailsById(int id);

        List<PaymentsDao> FetchAllDetails();



        bool InsertPaymentsInfo(PaymentsDao p);

    }
}
