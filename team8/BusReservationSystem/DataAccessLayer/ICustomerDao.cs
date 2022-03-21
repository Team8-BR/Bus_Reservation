using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface ICustomerDao
    {
        bool InsertCustomerInfo(CustomerModel p);
        CustomerModel FetchDetailsById(int id);

        int DeleteCustomer(int id);

        List<CustomerModel> FetchAllDetails();


    }
}
