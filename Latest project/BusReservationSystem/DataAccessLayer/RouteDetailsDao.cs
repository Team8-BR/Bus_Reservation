using BusReservationSystem.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class RouteDetailsDao : IRouteDetailsDao
    {
        public bool AddBusDetail(RouteDetails route)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.RouteDetails.Add(route);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<RouteDetails> FetchAllDetails()
        {
            List<RouteDetails> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<RouteDetails> allRouteDetails = db.RouteDetails;
                    if (allRouteDetails.Count() > 0)
                    {
                        businessDetails =
                            allRouteDetails
                             .Select(
                                (RouteDetails a) =>
                                     new RouteDetails
                                     {
                                         RouteId = a.RouteId,
                                         DepartureStation = a.DepartureStation,
                                         DestinationStation = a.DestinationStation,
                                         Duration = a.Duration,
                                         BusFare = a.BusFare,
                                         BusSchedule = a.BusSchedule,


                                     }
                             )
                             .ToList<RouteDetails>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RouteDetails FetchDetailsById(int id)
        {
            RouteDetails businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<RouteDetails> alldetails = db.RouteDetails;
                    var matchingDetails = alldetails.Where(p => p.RouteId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        RouteDetails p = matchingDetails.First<RouteDetails>();
                        businessDetails = new RouteDetails
                        {


                            RouteId = p.RouteId,
                            DepartureStation = p.DepartureStation,
                            DestinationStation = p.DestinationStation,
                            Duration = p.Duration,
                            BusFare = p.BusFare,
                            BusSchedule = p.BusSchedule,


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



        public bool InsertRouteInfo(RouteDetails p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<RouteDetails> allInfo = db.RouteDetails;
                    RouteDetails entityModelObject = new RouteDetails
                    {

                        RouteId = p.RouteId,
                        DepartureStation = p.DepartureStation,
                        DestinationStation = p.DestinationStation,
                        Duration = p.Duration,
                        BusFare = p.BusFare,
                        BusSchedule = p.BusSchedule,
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

        public int DeleteRouteDetails(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<RouteDetails> routeDetails = db.RouteDetails;

                    RouteDetails routeDetails1 = routeDetails.Where(p => p.RouteId == id).FirstOrDefault();
                    routeDetails.Remove(routeDetails1);
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


        public bool InsertRouteInfo(RouteDetailsDao p)
        {
            throw new NotImplementedException();
        }

        List<RouteDetailsDao> IRouteDetailsDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }



        RouteDetailsDao IRouteDetailsDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

    
