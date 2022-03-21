using BusReservationSystem.BusinessAccessLayer;
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
        public bool InsertRouteDetailsInfo(RouteDetailsModel p)
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
        public List<RouteDetailsModel> FetchAllDetails()
        {
            List<RouteDetailsModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<RouteDetails> allEntityBus = db.RouteDetails;
                    businessDetails = allEntityBus
                    .Select(a =>
                    new RouteDetailsModel
                    {
                        RouteId = a.RouteId,
                        DepartureStation = a.DepartureStation,
                        DestinationStation = a.DestinationStation,
                        Duration = a.Duration,

                    }
                    )
                    .ToList<RouteDetailsModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RouteDetailsModel FetchDetailsById(int id)
        {
            RouteDetailsModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<RouteDetails> alldetails = db.RouteDetails;
                    var matchingDetails = alldetails.Where(p => p.RouteId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        RouteDetails p = matchingDetails.First<RouteDetails>();
                        businessDetails = new RouteDetailsModel
                        {

                            RouteId = p.RouteId,
                            DepartureStation = p.DepartureStation,
                            DestinationStation = p.DestinationStation,
                            Duration = p.Duration,


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




        public int DeleteRouteDetails(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<RouteDetails> routeDetailsz = db.RouteDetails;

                    RouteDetails routeDetails1 = routeDetailsz.Where(p => p.RouteId == id).FirstOrDefault();
                    routeDetailsz.Remove(routeDetails1);
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
