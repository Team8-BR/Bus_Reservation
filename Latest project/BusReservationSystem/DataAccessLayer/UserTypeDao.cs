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
        public bool AddBusDetail(UserType user)
        {
            bool status = false;


            try
            {
                using (var db = new BustravelContext())
                {
                    db.UserType.Add(user);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
        public List<UserType> FetchAllDetails()
        {
            List<UserType> businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<UserType> allUserType = db.UserType;
                    if (allUserType.Count() > 0)
                    {
                        businessDetails =
                            allUserType
                             .Select(
                                (UserType a) =>
                                     new UserType
                                     {
                                         UserTypeId = a.UserTypeId,
                                         UserTypeName = a.UserTypeName,
                                         Login = a.Login,

                                     }
                             )
                             .ToList<UserType>();

                    }
                }
                return businessDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public UserType FetchDetailsById(int id)
        {
            UserType businessDetails = null;
            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<UserType> alldetails = db.UserType;
                    var matchingDetails = alldetails.Where(p => p.UserTypeId == id);
                    if (matchingDetails != null && matchingDetails.Count() > 0)
                    {
                        UserType p = matchingDetails.First<UserType>();
                        businessDetails = new UserType
                        {
                            UserTypeId = p.UserTypeId,
                            UserTypeName = p.UserTypeName,
                            Login = p.Login,

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


        public bool InsertUserTypeInfo(UserType p)
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
                        Login = p.Login,


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

        public int DeleteUserType(int id)
        {

            try
            {
                using (var db = new BustravelContext())
                {
                    DbSet<UserType> userType = db.UserType;

                    UserType userType1 = userType.Where(p => p.UserTypeId == id).FirstOrDefault();
                    userType.Remove(userType1);
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


        public bool InsertUserTypeInfo(UserTypeDao p)
        {
            throw new NotImplementedException();
        }

        List<UserTypeDao> IUserTypeDao.FetchAllDetails()
        {
            throw new NotImplementedException();
        }



        UserTypeDao IUserTypeDao.fetchDetailsById(int id)
        {
            throw new NotImplementedException();
        }


    }
}

        