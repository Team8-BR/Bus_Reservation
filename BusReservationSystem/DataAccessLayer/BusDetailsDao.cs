using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class BusDetailsDao : IBusDetailsDao
    {
    public bool AddBusDetail(BusDetails bus)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.BusDetails.Add(bus);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<BusDetails> FetchAllDetails()
        {
            List<BusDetails> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusDetails> allBusDetails = db.BusDetails;
                    if (allBusDetails.Count() > 0)
                    {
                        businessDetails =
                            allBusDetails
                             .Select(
                                (BusDetails a) =>
                                     new BusDetails
                                     {
                                         BusId = a.BusId,
                                         RegistrationNumber = a.RegistrationNumber,
                                         TotalSeats = a.TotalSeats,
                                         BusTypeId = a.BusTypeId,
                                         BusType = a.BusType,
                                         BusSchedule = a.BusSchedule,

                                     }
                             )
                             .ToList<BusDetails>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BusDetails FetchDetailsById(int id)
        {
            BusDetails businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<BusDetails> alldetails = db.BusDetails;
                    var matchingDetails = alldetails.Where(p => p.BusTypeId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        BusDetails p = matchingDetails.First<BusDetails>();
                        businessDetails = new BusDetails
                        {

                            BusId = p.BusId,
                            RegistrationNumber = p.RegistrationNumber,
                            TotalSeats = p.TotalSeats,
                            BusTypeId = p.BusTypeId,
                            BusType = p.BusType,
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

        

        public bool InsertBusInfo(BusDetails p)
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
                        BusType = p.BusType,
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
   

        public bool InsertBusInfo(BusDetailsDao p)
        {
            throw new NotImplementedException();
        }

        List<BusDetailsDao>  IBusDetailsDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }



        BusDetailsDao IBusDetailsDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

    
    




        
