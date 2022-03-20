using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{

    public class BusScheduleDao : IBusScheduleDao
    {
        public bool AddBusDetail(BusSchedule schedule)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.BusSchedule.Add(schedule);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<BusSchedule> FetchAllDetails()
        {
            List<BusSchedule> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusSchedule> allBusSchedule = db.BusSchedule;
                    if (allBusSchedule.Count() > 0)
                    {
                        businessDetails =
                            allBusSchedule
                             .Select(
                                (BusSchedule a) =>
                                     new BusSchedule
                                     {
                                         ScheduleId = a.ScheduleId,
                                         BusId = a.BusId,
                                         DriverName = a.DriverName,
                                         RouteId = a.RouteId,
                                         DepartureDate = a.DepartureDate,
                                         ArrivalDate = a.ArrivalDate,
                                         BookedSeats = a.BookedSeats,   
                                         AvailableSeats = a.AvailableSeats,
                                         ArrivalTime = a.ArrivalTime,
                                         DepartureTime = a.DepartureTime,
                                         FareId = a.FareId,
                                         TicketBooking = a.TicketBooking,
                                         TicketCancellation = a.TicketCancellation, 
                                    

                                     }
                             )
                             .ToList<BusSchedule>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusSchedule FetchDetailsById(int id)
        {
            BusSchedule businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusSchedule> alldetails = db.BusSchedule;
                    var matchingDetails = alldetails.Where(p => p.BusId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusSchedule p = matchingDetails.First<BusSchedule>();
                        businessDetails = new BusSchedule
                        {
                            ScheduleId = p.ScheduleId,
                            BusId = p.BusId,
                            DriverName = p.DriverName,
                            RouteId = p.RouteId,
                            DepartureDate = p.DepartureDate,
                            ArrivalDate = p.ArrivalDate,
                            BookedSeats = p.BookedSeats,
                            AvailableSeats = p.AvailableSeats,
                            ArrivalTime = p.ArrivalTime,
                            DepartureTime = p.DepartureTime,
                            FareId = p .FareId,
                            TicketBooking = p.TicketBooking,
                            TicketCancellation = p.TicketCancellation,



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



        public bool InsertBusSchedulwInfo(BusSchedule p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusSchedule> allInfo = db.BusSchedule;
                    BusSchedule entityModelObject = new BusSchedule
                    {
                        ScheduleId = p.ScheduleId,
                        BusId = p.BusId,
                        DriverName = p.DriverName,
                        RouteId = p.RouteId,
                        DepartureDate = p.DepartureDate,
                        ArrivalDate = p.ArrivalDate,
                        BookedSeats = p.BookedSeats,
                        AvailableSeats = p.AvailableSeats,
                        ArrivalTime = p.ArrivalTime,
                        DepartureTime = p.DepartureTime,
                        FareId = p.FareId,
                        TicketBooking = p.TicketBooking,
                        TicketCancellation = p.TicketCancellation,


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


        public bool InsertBusScheduleInfo(BusScheduleDao p)
        {
            throw new NotImplementedException();
        }

        List<BusScheduleDao> IBusScheduleDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }



        BusScheduleDao IBusScheduleDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

    
    




        

