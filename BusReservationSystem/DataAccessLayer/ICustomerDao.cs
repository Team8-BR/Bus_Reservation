using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface ICustomerDao
    {
        CustomerDao fetchDetailsById(int id);

        List<CustomerDao> FetchAllDetails();

        bool InsertCustomerInfo(CustomerDao p);
    }
}
