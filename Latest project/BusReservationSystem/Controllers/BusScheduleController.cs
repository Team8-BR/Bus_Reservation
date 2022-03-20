using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusReservationSystem.Controllers
{
    [Route("busScheduleApi/[controller]")]
    [ApiController]
    public class BusScheduleController : Controller
    {
        private IBusScheduleDao busSchedulDao;
        public BusScheduleController(IBusScheduleDao busScheduleDao)
        {
            busScheduleDao = busScheduleDao;
        }

        [HttpGet]
        public IActionResult FetchAllDetails()
        {
            var fetchedData = busSchedulDao.FetchAllDetails();
            return this.Ok(fetchedData);
        }
        [HttpGet]
        [Route("{BusId}")]
        public IActionResult FetchDetailsById(int id)
        {
            BusScheduleDao busScheduleDao = new BusScheduleDao();
            var fetchedData = busScheduleDao.FetchDetailsById(id);
            return this.Ok(fetchedData);

        }
        [HttpPost]
        public IActionResult InsertBusScheduleInfo(BusScheduleDao schedule)
        {
            BusScheduleDao busScheduleDao = new BusScheduleDao();
            var result = busScheduleDao.InsertBusScheduleInfo(schedule);
            return this.CreatedAtAction(
                "InsertBusScheduleInfo",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = schedule,
                }
                );
        }
    }
}


