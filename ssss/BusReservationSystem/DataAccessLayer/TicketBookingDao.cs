using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class TicketBookingDao : ITicketBookingDao
    {
        public bool InsertTicketBookingInfo(TicketBookingModel p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<TicketBooking> allInfo = db.TicketBooking;
                    TicketBooking entityModelObject = new TicketBooking
                    {
                       BookingId = p.BookingId,
                       AvailableSeats = p.AvailableSeats,
                       Fare = p.Fare,
                       DateOfBooking = p.DateOfBooking,
                       OnwardJourneyDate = p.OnwardJourneyDate,
                       ReturnDate = p.ReturnDate,
                       CustomerId = p.CustomerId,
                       TicketTypeId = p.TicketTypeId,
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
        public List<TicketBookingModel> FetchAllDetails()
        {
            List<TicketBookingModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<TicketBooking> allEntityBus = db.TicketBooking;
                    businessDetails = allEntityBus
                    .Select(a =>
                    new TicketBookingModel
                    {
                        BookingId = a.BookingId,
                        AvailableSeats = a.AvailableSeats,
                        Fare = a.Fare,
                        DateOfBooking = a.DateOfBooking,
                        OnwardJourneyDate = a.OnwardJourneyDate,
                        ReturnDate = a.ReturnDate,
                        CustomerId = a.CustomerId,
                        TicketTypeId = a.TicketTypeId,
                        ScheduleId = a.ScheduleId,


                    }
                             )
                             .ToList<TicketBookingModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TicketBookingModel FetchDetailsById(int id)
        {
            TicketBookingModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<TicketBooking> alldetails = db.TicketBooking;
                    var matchingDetails = alldetails.Where(p => p.BookingId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        TicketBooking p = matchingDetails.First<TicketBooking>();
                        businessDetails = new TicketBookingModel
                        {
                            BookingId = p.BookingId,
                            AvailableSeats = p.AvailableSeats,
                            Fare = p.Fare,
                            DateOfBooking = p.DateOfBooking,
                            OnwardJourneyDate = p.OnwardJourneyDate,
                            ReturnDate = p.ReturnDate,
                            CustomerId = p.CustomerId,
                            TicketTypeId = p.TicketTypeId,
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
    }
}