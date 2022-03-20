using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IUserTypeDao
    {
        UserTypeDao fetchDetailsById(int id);

        List<UserTypeDao> FetchAllDetails();

        bool InsertUserTypeInfo(UserTypeDao p);

    }
}
