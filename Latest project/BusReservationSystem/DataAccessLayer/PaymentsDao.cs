using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class PaymentsDao : IPaymentsDao
    {
        public bool AddBusDetail(Payments payments)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.Payments.Add(payments);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<Payments> FetchAllDetails()
        {
            List<Payments> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Payments> allPayments = db.Payments;
                    if (allPayments.Count() > 0)
                    {
                        businessDetails =
                            allPayments
                             .Select(
                                (Payments a) =>
                                     new Payments
                                     {
                                        PaymentId = a.PaymentId,
                                        CardType = a.CardType,
                                        BankName = a.BankName,
                                        CardNo = a.CardNo,  
                                        CardHolderName = a.CardHolderName,
                                        TotalAmount = a.TotalAmount,    
                                        BookingId = a.BookingId,
                                        Booking = a.Booking,

                                     }
                             )
                             .ToList<Payments>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Payments FetchDetailsById(int id)
        {
            Payments businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Payments> alldetails = db.Payments;
                    var matchingDetails = alldetails.Where(p => p.BookingId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        Payments p = matchingDetails.First<Payments>();
                        businessDetails = new Payments
                        {

                            PaymentId = p.PaymentId,
                            CardType = p.CardType,
                            BankName = p.BankName,
                            CardNo = p.CardNo,
                            CardHolderName = p.CardHolderName,
                            TotalAmount = p.TotalAmount,
                            BookingId = p.BookingId,
                            Booking = p.Booking,


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



        public bool InsertPaymentsInfo(Payments p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Payments> allInfo = db.Payments;
                    Payments entityModelObject = new Payments
                    {
                        PaymentId = p.PaymentId,
                        CardType = p.CardType,
                        BankName = p.BankName,
                        CardNo = p.CardNo,
                        CardHolderName = p.CardHolderName,
                        TotalAmount = p.TotalAmount,
                        BookingId = p.BookingId,
                        Booking = p.Booking,

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


        public bool InsertPaymentsInfo(PaymentsDao p)
        {
            throw new NotImplementedException();
        }

        List<PaymentsDao> IPaymentsDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }



        PaymentsDao IPaymentsDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

