using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class BusDetailsDao : IBusDetailsDao
    {
        public bool InsertBusDetailsInfo(BusDetailsModel p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusDetails> allInfo = db.BusDetails;
                    BusDetails entityModelObject = new BusDetails
                    {
                        BusId = p.BusId,
                        RegistrationNumber = p.RegistrationNumber,
                        TotalSeats = p.TotalSeats,
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
        public List<BusDetailsModel> FetchAllDetails()
        {
            List<BusDetailsModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusDetails> allEntityBus = db.BusDetails;
                    businessDetails = allEntityBus
                    .Select(a =>
                    new BusDetailsModel
                    {
                        BusId = a.BusId,
                        RegistrationNumber = a.RegistrationNumber,
                        TotalSeats = a.TotalSeats,
                        BusTypeId = a.BusTypeId,

                    }
                    )
                    .ToList<BusDetailsModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusDetailsModel FetchDetailsById(int id)
        {
            BusDetailsModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusDetails> alldetails = db.BusDetails;
                    var matchingDetails = alldetails.Where(p => p.BusId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusDetails p = matchingDetails.First<BusDetails>();
                        businessDetails = new BusDetailsModel
                        {

                            BusId = p.BusId,
                            RegistrationNumber = p.RegistrationNumber,
                            TotalSeats = p.TotalSeats,
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




        public int DeleteBusDetails(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusDetails> busDetailsz = db.BusDetails;

                    BusDetails busDetails1 = busDetailsz.Where(p => p.BusId == id).FirstOrDefault();
                    busDetailsz.Remove(busDetails1);
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

       
    
    




        
