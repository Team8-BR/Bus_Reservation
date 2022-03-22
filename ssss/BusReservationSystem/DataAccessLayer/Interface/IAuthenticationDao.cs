using BusReservationSystem.BusinessAccessLayer;

namespace BusReservationSystem.DataAccessLayer.Interface
{
    public interface IAuthenticationDao
    {
        bool AuthenticateUser(LoginModel userInfo);
    }
}



