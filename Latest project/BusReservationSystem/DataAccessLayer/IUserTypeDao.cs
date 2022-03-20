using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface IUserTypeDao
    {
        UserTypeDao fetchDetailsById(int id);

        List<UserTypeDao> FetchAllDetails();

        int DeleteUserType(int id);


        bool InsertUserTypeInfo(UserTypeDao p);

    }
}
