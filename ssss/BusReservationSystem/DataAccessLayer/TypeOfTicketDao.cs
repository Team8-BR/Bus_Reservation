using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class TypeOfTicketDao : ITypeOfTicketDao
    {
        public bool InsertTypeOfTicketInfo(TypeOfTicketModel p)
    {
        int result = 0;
        try
        {
            using (var db = new BustravelContext())
            {
                DbSet<TypeOfTicket> allInfo = db.TypeOfTicket;
                TypeOfTicket entityModelObject = new TypeOfTicket
                {
                    TicketTypeId = p.TicketTypeId,
                    TicketType = p.TicketType,


                };
                allInfo.Add(entityModelObject);
                result = db.SaveChanges();
            }
            return result > 0;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public List<TypeOfTicketModel> FetchAllDetails()
    {
        List<TypeOfTicketModel> businessDetails = null;
        try
        {
            using (var db = new BustravelContext())
            {
                DbSet<TypeOfTicket> allEntityBus = db.TypeOfTicket;
                businessDetails = allEntityBus
                .Select(a =>
                new TypeOfTicketModel
                {
                    TicketTypeId =a.TicketTypeId,   
                    TicketType =a.TicketType,


                }
                         )
                         .ToList<TypeOfTicketModel>();

            }

            return businessDetails;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public TypeOfTicketModel FetchDetailsById(int id)
    {
        TypeOfTicketModel businessDetails = null;
        try
        {
            using (var db = new BustravelContext())
            {
                DbSet<TypeOfTicket> alldetails = db.TypeOfTicket;
                var matchingDetails = alldetails.Where(p => p.TicketTypeId == id);
                if (matchingDetails != null && matchingDetails.Count() > 0)
                {
                    TypeOfTicket p = matchingDetails.First<TypeOfTicket>();
                    businessDetails = new TypeOfTicketModel
                    {
                        TicketTypeId = p.TicketTypeId,
                        TicketType = p.TicketType,
                         

                    };
                }
            }
            return businessDetails;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
}
}


