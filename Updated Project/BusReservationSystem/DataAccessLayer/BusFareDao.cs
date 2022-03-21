using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class BusFareDao : IBusFareDao
    {
        public bool InsertBusFareInfo(BusFareModel p)
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
        public List<BusFareModel> FetchAllDetails()
        {
            List<BusFareModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusFare> allEntityFare = db.BusFare;
                    businessDetails = allEntityFare
                    .Select(a =>
                    new BusFareModel
                    {
                        FareId = a.FareId,
                        RouteId = a.RouteId,
                        FareAmount = a.FareAmount,
                        BusTypeId = a.BusTypeId,
                    }
                    )
                    .ToList<BusFareModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusFareModel FetchDetailsById(int id)
        {
            BusFareModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusFare> alldetails = db.BusFare;
                    var matchingDetails = alldetails.Where(p => p.FareId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusFare p = matchingDetails.First<BusFare>();
                        businessDetails = new BusFareModel
                        {
                            FareId = p.FareId,
                            RouteId = p.RouteId,
                            FareAmount = p.FareAmount,
                            BusTypeId = p.BusTypeId,
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