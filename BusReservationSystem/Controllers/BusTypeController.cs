using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusReservationSystem.Controllers
{
    [Route("busTypeApi/[controller]")]
    [ApiController]
    public class BusTypeController : Controller
    {
        private IBusTypeDao busTypeDao;
        public BusTypeController(IBusTypeDao busTypeDao)
        {
            busTypeDao = busTypeDao;
        }

        [HttpGet]
        public IActionResult FetchAllDetails()
        {
            var fetchedData = busTypeDao.FetchAllDetails();
            return this.Ok(fetchedData);
        }
        [HttpGet]
        [Route("{BusTypeId}")]
        public IActionResult FetchDetailsById(int id)
        {
            BusTypeDao busTypeDao = new BusTypeDao();
            var fetchedData = busTypeDao.FetchDetailsById(id);
            return this.Ok(fetchedData);

        }
        [HttpPost]
        public IActionResult InsertBusTypeInfo(BusTypeDao bus)
        {
            BusTypeDao busTypeDao = new BusTypeDao();
            var result = busTypeDao.InsertBusTypeInfo(bus);
            return this.CreatedAtAction(
                "InsertBusTypeInfo",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = bus,
                }
                );
        }
    }
}

