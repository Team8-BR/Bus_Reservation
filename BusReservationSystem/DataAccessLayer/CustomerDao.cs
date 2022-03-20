using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class CustomerDao : ICustomerDao
    {
        public bool AddBusDetail(Customer customer)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.Customer.Add(customer);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<Customer> FetchAllDetails()
        {
            List<Customer> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Customer> allCustomer = db.Customer;
                    if (allCustomer.Count() > 0)
                    {
                        businessDetails =
                            allCustomer
                             .Select(
                                (Customer a) =>
                                     new Customer
                                     {
                                         CustomerId = a.CustomerId,
                                         FirstName = a.FirstName,
                                         LastName = a.LastName,
                                         DateOfBirth = a.DateOfBirth,
                                         Gender = a.Gender, 
                                         EmailId = a.EmailId,
                                         Address = a.Address,
                                         City = a.City,
                                         Pincode = a.Pincode,
                                         ContactNo = a.ContactNo,
                                         UserId = a.UserId,
                                         User = a.User,
                                         TicketBooking = a.TicketBooking,
                                         TicketCancellation = a.TicketCancellation,
                                     }
                             )
                             .ToList<Customer>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Customer FetchDetailsById(int id)
        {
           Customer businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Customer> alldetails = db.Customer;
                    var matchingDetails = alldetails.Where(p => p.UserId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        Customer p = matchingDetails.First<Customer>();
                        businessDetails = new Customer
                        {

                            CustomerId = p.CustomerId,
                            FirstName = p.FirstName,
                            LastName = p.LastName,
                            DateOfBirth = p.DateOfBirth,
                            Gender = p.Gender,
                            EmailId = p.EmailId,
                            Address = p.Address,
                            City = p.City,
                            Pincode = p.Pincode,
                            ContactNo = p.ContactNo,
                            UserId = p.UserId,
                            User = p.User,
                            TicketBooking = p.TicketBooking,
                            TicketCancellation = p.TicketCancellation,
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



        public bool InsertCustomerInfo(Customer p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Customer> allInfo = db.Customer;
                    Customer entityModelObject = new Customer
                    {
                        CustomerId = p.CustomerId,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        DateOfBirth = p.DateOfBirth,
                        Gender = p.Gender,
                        EmailId = p.EmailId,
                        Address = p.Address,
                        City = p.City,
                        Pincode = p.Pincode,
                        ContactNo = p.ContactNo,
                        UserId = p.UserId,
                        User = p.User,
                        TicketBooking = p.TicketBooking,
                        TicketCancellation = p.TicketCancellation,

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


        public bool InsertCustomerInfo(CustomerDao p)
        {
            throw new NotImplementedException();
        }

        List<CustomerDao> ICustomerDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }



        CustomerDao ICustomerDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

    
