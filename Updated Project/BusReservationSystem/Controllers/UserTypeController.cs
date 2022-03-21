using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : Controller
    {
        private IUserTypeDao _userDao;
        public UserTypeController(IUserTypeDao userDao)
        {
            this._userDao = userDao;
        }


        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_userDao.FetchAllDetails());
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("fetchbyid")]
        public IActionResult FetchDataById(int id)
        {
            try
            {
                return this.Ok(_userDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertUserTypeInfo(UserTypeModel User)
        {
            var result = _userDao.InsertUserTypeInfo(User);
            return this.CreatedAtAction(
            "InsertData",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = User
            }
            );
        }

        [HttpDelete]
        [Route("id")]
        public IActionResult DeletUserType(int id)
        {
            try
            {
                var result = _userDao.DeleteUserType(id);
                return this.CreatedAtAction(
                  "DeleteUserType",
                  new
                  {
                      StatusCode = 201,
                      Response = result,
                      Data = id
                  }
                  );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
