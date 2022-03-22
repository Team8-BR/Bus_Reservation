using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class BusTypeDao : IBusTypeDao
    {
        public bool InsertBusTypeInfo(BusTypeModel p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusType> allInfo = db.BusType;
                    BusType entityModelObject = new BusType
                    {
                        BusTypeId = p.BusTypeId,
                        BusType1 = p.BusType1,
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
        public List<BusTypeModel> FetchAllDetails()
        {
            List<BusTypeModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusType> allEntityType = db.BusType;
                    businessDetails = allEntityType
                    .Select(a =>
                    new BusTypeModel
                    {
                       BusTypeId = a.BusTypeId,
                       BusType1 = a.BusType1,
                    }
                    )
                    .ToList<BusTypeModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusTypeModel FetchDetailsById(int id)
        {
            BusTypeModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusType> alldetails = db.BusType;
                    var matchingDetails = alldetails.Where(p => p.BusTypeId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusType p = matchingDetails.First<BusType>();
                        businessDetails = new BusTypeModel
                        { 
                            BusTypeId = p.BusTypeId,
                            BusType1 = p.BusType1
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




        public int DeleteBusType(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusType> busTypez = db.BusType;

                    BusType busType1 = busTypez.Where(p => p.BusTypeId == id).FirstOrDefault();
                    busTypez.Remove(busType1);
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




