using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class BusTypeDao : IBusTypeDao
    {
        public bool AddBusDetail(BusType bus)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.BusType.Add(bus);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<BusType> FetchAllDetails()
        {
            List<BusType> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusType> allBusType = db.BusType;
                    if (allBusType.Count() > 0)
                    {
                        businessDetails =
                            allBusType
                             .Select(
                                (BusType a) =>
                                     new BusType
                                     {
                                        
                                         BusTypeId = a.BusTypeId,
                                         BusType1 = a.BusType1,
                                         BusDetails = a.BusDetails,
                                         BusFare = a.BusFare,

                                     }
                             )
                             .ToList<BusType>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusType FetchDetailsById(int id)
        {
            BusType businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusType> alldetails = db.BusType;
                    var matchingDetails = alldetails.Where(p => p.BusTypeId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusType p = matchingDetails.First<BusType>();
                        businessDetails = new BusType
                        {

                            BusTypeId = p.BusTypeId,
                            BusType1 = p.BusType1,
                            BusDetails = p.BusDetails,
                            BusFare = p.BusFare,


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

        
        public bool InsertBusTypeInfo(BusType p)
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
                        BusDetails = p.BusDetails,
                        BusFare = p.BusFare,


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


        public bool InsertBusTypeInfo(BusTypeDao p)
        {
            throw new NotImplementedException();
        }

        List<BusTypeDao> IBusTypeDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }

       

        BusTypeDao IBusTypeDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}

    
    




     
