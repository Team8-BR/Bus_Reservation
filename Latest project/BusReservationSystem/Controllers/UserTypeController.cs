using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusReservationSystem.Controllers
{

    [Route("userTypeApi/[controller]")]
    [ApiController]
    public class UserTypeController : Controller
    {
        private IUserTypeDao userTypeDao;
        public UserTypeController(IUserTypeDao userTypeDao)
        {
            userTypeDao = userTypeDao;
        }

        [HttpGet]
        public IActionResult FetchAllDetails()
        {
            var fetchedData = userTypeDao.FetchAllDetails();
            return this.Ok(fetchedData);
        }
        [HttpGet]
        [Route("{UserTypeId}")]
        public IActionResult FetchDetailsById(int id)
        {
            UserTypeDao userTypeDao = new UserTypeDao();
            var fetchedData = userTypeDao.FetchDetailsById(id);
            return this.Ok(fetchedData);

        }
        [HttpPost]
        public IActionResult InsertUserTypeInfo(UserTypeDao user)
        {
            UserTypeDao userTypeDao = new UserTypeDao();
            var result = userTypeDao.InsertUserTypeInfo(user);
            return this.CreatedAtAction(
                "InsertUserTypeInfo",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = user,
                }
                );
        }
    }
}
   
