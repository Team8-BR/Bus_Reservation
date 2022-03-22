using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IUserTypeDao
    {
        bool InsertUserTypeInfo(UserTypeModel p);
        UserTypeModel FetchDetailsById(int id);

        int DeleteUserType(int id);

        List<UserTypeModel> FetchAllDetails();


    }
}
