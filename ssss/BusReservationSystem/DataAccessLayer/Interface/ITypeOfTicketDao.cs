using BusReservationSystem.BusinessAccessLayer;
using System.Collections.Generic;

namespace BusReservationSystem.DataAccessLayer
{
    public interface ITypeOfTicketDao
    {
        bool InsertTypeOfTicketInfo(TypeOfTicketModel p);
        TypeOfTicketModel FetchDetailsById(int id);

        List<TypeOfTicketModel> FetchAllDetails();


    }
}
