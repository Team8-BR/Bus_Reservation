using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class BusFareDao : IBusFareDao
    {
        public bool AddBusDetail(BusFare fare)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.BusFare.Add(fare);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<BusFare> FetchAllDetails()
        {
            List<BusFare> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusFare> allBusFare = db.BusFare;
                    if (allBusFare.Count() > 0)
                    {
                        businessDetails =
                            allBusFare
                             .Select(
                                (BusFare a) =>
                                     new BusFare
                                     {
                                         FareId = a.FareId,
                                         RouteId = a.RouteId,
                                         FareAmount = a.FareAmount,
                                         BusTypeId = a.BusTypeId,
                                         BusType = a.BusType,
                                         Route = a.Route,
                                         BusSchedule = a.BusSchedule,

                                     }
                             )
                             .ToList<BusFare>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusFare FetchDetailsById(int id)
        {
            BusFare businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusFare> alldetails = db.BusFare;
                    var matchingDetails = alldetails.Where(p => p.BusTypeId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusFare p = matchingDetails.First<BusFare>();
                        businessDetails = new BusFare
                        {

                            FareId = p.FareId,
                            RouteId = p.RouteId,
                            FareAmount = p.FareAmount,
                            BusTypeId = p.BusTypeId,
                            BusType = p.BusType,
                            Route = p.Route,
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

       

        public bool InsertBusFareInfo(BusFare p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusFare> allInfo = db.BusFare;
                    BusFare entityModelObject = new BusFare
                    {
                        FareId = p.FareId,
                        RouteId = p.RouteId,
                        FareAmount = p.FareAmount,
                        BusTypeId = p.BusTypeId,
                        BusType = p.BusType,
                        Route = p.Route,
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


        public bool InsertBusFareInfo(BusFareDao p)
        {
            throw new NotImplementedException();
        }

        List<BusFareDao> IBusFareDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }

        BusFareDao IBusFareDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

