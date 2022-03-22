using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class TicketCancellationDao : ITicketCancellationDao
    {
        public bool InsertTicketCancellationInfo(TicketCancellationModel p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<TicketCancellation> allInfo = db.TicketCancellation;
                    TicketCancellation entityModelObject = new TicketCancellation
                    {
                        CancellationId = p.CancellationId,
                        BookingId = p.BookingId,
                        RefundAmount = p.RefundAmount,
                        CancellationDate = p.CancellationDate,
                        TicketTypeId = p.TicketTypeId,
                        CustomerId = p.CustomerId,
                        ScheduleId = p.ScheduleId,
                        
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
        public List<TicketCancellationModel> FetchAllDetails()
        {
            List<TicketCancellationModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<TicketCancellation> allEntityBus = db.TicketCancellation;
                    businessDetails = allEntityBus
                    .Select(a =>
                    new TicketCancellationModel
                    {
                        CancellationId = a.CancellationId,
                        BookingId = a.BookingId,
                        RefundAmount = a.RefundAmount,
                        CancellationDate = a.CancellationDate,
                        TicketTypeId = a.TicketTypeId,
                        CustomerId = a.CustomerId,
                        ScheduleId = a.ScheduleId,
                    }
                    )
                    .ToList<TicketCancellationModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TicketCancellationModel FetchDetailsById(int id)
        {
            TicketCancellationModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<TicketCancellation> alldetails = db.TicketCancellation;
                    var matchingDetails = alldetails.Where(p => p.CancellationId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        TicketCancellation p = matchingDetails.First<TicketCancellation>();
                        businessDetails = new TicketCancellationModel
                        {

                            CancellationId = p.CancellationId,
                            BookingId = p.BookingId,
                            RefundAmount = p.RefundAmount,
                            CancellationDate = p.CancellationDate,
                            TicketTypeId = p.TicketTypeId,
                            CustomerId = p.CustomerId,
                            ScheduleId = p.ScheduleId,



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




        public int DeleteTicketCancellation(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<TicketCancellation> ticketCancellationz = db.TicketCancellation;

                    TicketCancellation ticketCancelltion1 = ticketCancellationz.Where(p => p.CancellationId == id).FirstOrDefault();
                    ticketCancellationz.Remove(ticketCancelltion1);
                    int rawAffected = db.SaveChanges();
                    return rawAffected;

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

       
