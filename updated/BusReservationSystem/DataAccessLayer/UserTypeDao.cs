using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusReservationSystem.DataAccessLayer
{
    public class UserTypeDao : IUserTypeDao
    {
        public bool InsertUserTypeInfo(UserTypeModel p)
        {
            int result = 0;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<UserType> allInfo = db.UserType;
                    UserType entityModelObject = new UserType
                    {
                      UserTypeId = p.UserTypeId,
                      UserTypeName = p.UserTypeName,
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
        public List<UserTypeModel> FetchAllDetails()
        {
            List<UserTypeModel> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<UserType> allEntityType = db.UserType;
                    businessDetails = allEntityType
                    .Select(a =>
                    new UserTypeModel
                    {
                        UserTypeId =a.UserTypeId,
                        UserTypeName =a.UserTypeName,
                    }
                    )
                    .ToList<UserTypeModel>();

                }

                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public UserTypeModel FetchDetailsById(int id)
        {
            UserTypeModel businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<UserType> alldetails = db.UserType;
                    var matchingDetails = alldetails.Where(p => p.UserTypeId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        UserType p = matchingDetails.First<UserType>();
                        businessDetails = new UserTypeModel
                        {
                            UserTypeId =p.UserTypeId,
                            UserTypeName =p.UserTypeName,
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




        public int DeleteUserType(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<UserType> userTypez = db.UserType;

                    UserType userType1 = userTypez.Where(p => p.UserTypeId == id).FirstOrDefault();
                    userTypez.Remove(userType1);
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



