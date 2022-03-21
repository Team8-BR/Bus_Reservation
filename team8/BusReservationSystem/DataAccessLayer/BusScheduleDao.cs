using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{

    public class BusScheduleDao : IBusScheduleDao
    {
        public bool InsertBusScheduleInfo(BusScheduleModel p)
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
        public List<BusScheduleModel> FetchAllDetails()
        {
            List<BusScheduleModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusSchedule> allEntityBus = db.BusSchedule;
                    businessDetails = allEntityBus
                    .Select(a =>
                    new BusScheduleModel
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


                    }
                             )
                             .ToList<BusScheduleModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusScheduleModel FetchDetailsById(int id)
        {
            BusScheduleModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusSchedule> alldetails = db.BusSchedule;
                    var matchingDetails = alldetails.Where(p => p.ScheduleId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusSchedule p = matchingDetails.First<BusSchedule>();
                        businessDetails = new BusScheduleModel
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


    
    




        

