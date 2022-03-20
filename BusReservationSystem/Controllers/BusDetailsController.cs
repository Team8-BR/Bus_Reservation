using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;


namespace BusReservationSystem.Controllers
{
    
    [Route("busDetailsApi/[controller]")]
    [ApiController]
    public class BusDetailsController : Controller
    {
        private IBusDetailsDao busDetailsDao;
        public BusDetailsController(IBusDetailsDao busDetailsDao)
        {
            busDetailsDao = busDetailsDao;
        }

        [HttpGet]
        public IActionResult FetchAllDetails()
        {
            var fetchedData = busDetailsDao.FetchAllDetails();
            return this.Ok(fetchedData);
        }
        [HttpGet]
        [Route("{BusTypeId}")]
        public IActionResult FetchDetailsById(int id)
        {
            BusDetailsDao busDetailsDao = new BusDetailsDao();
            var fetchedData = busDetailsDao.FetchDetailsById(id);
            return this.Ok(fetchedData);

        }
        [HttpPost]
        public IActionResult InsertBusInfo(BusDetailsDao bus)
        {
            BusDetailsDao busDetailsDao =  new BusDetailsDao();
            var result = busDetailsDao.InsertBusInfo(bus);
            return this.CreatedAtAction(
                "InsertBusInfo",
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







