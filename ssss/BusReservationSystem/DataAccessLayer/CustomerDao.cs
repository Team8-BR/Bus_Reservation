using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class CustomerDao : ICustomerDao
    {
        public bool InsertCustomerInfo(CustomerModel p)
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
        public List<CustomerModel> FetchAllDetails()
        {
            List<CustomerModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Customer> allEntityBus = db.Customer;
                    businessDetails = allEntityBus
                    .Select(a =>
                    new CustomerModel
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
                        
                    }
                    )
                    .ToList<CustomerModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CustomerModel FetchDetailsById(int id)
        {
            CustomerModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Customer> alldetails = db.Customer;
                    var matchingDetails = alldetails.Where(p => p.CustomerId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        Customer p = matchingDetails.First<Customer>();
                        businessDetails = new CustomerModel
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




        public int DeleteCustomer(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<Customer> customerz = db.Customer;

                    Customer customer1 = customerz.Where(p => p.CustomerId == id).FirstOrDefault();
                    customerz.Remove(customer1);
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

                        