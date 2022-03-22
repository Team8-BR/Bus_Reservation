using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class PaymentsDao : IPaymentsDao
    {
        public bool InsertPaymentsInfo(PaymentsModel p)
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
        public List<PaymentsModel> FetchAllDetails()
        {
            List<PaymentsModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Payments> allEntityBus = db.Payments;
                    businessDetails = allEntityBus
                    .Select(a =>
                    new PaymentsModel
                    {
                        PaymentId = a.PaymentId,
                        CardType = a.CardType,
                        BankName = a.BankName,
                        CardNo = a.CardNo,
                        CardHolderName = a.CardHolderName,
                        TotalAmount = a.TotalAmount,
                        BookingId = a.BookingId,

                    }
                             )
                             .ToList<PaymentsModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PaymentsModel FetchDetailsById(int id)
        {
            PaymentsModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Payments> alldetails = db.Payments;
                    var matchingDetails = alldetails.Where(p => p.PaymentId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                         Payments p = matchingDetails.First<Payments>();
                        businessDetails = new PaymentsModel
                        {
                            PaymentId = p.PaymentId,
                            CardType = p.CardType,
                            BankName = p.BankName,
                            CardNo = p.CardNo,
                            CardHolderName = p.CardHolderName,
                            TotalAmount = p.TotalAmount,
                            BookingId = p.BookingId,



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
