using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusReservationSystem.Controllers
{

        [Route("busFareApi/[controller]")]
        [ApiController]
        public class BusFareController : Controller
        {
            private IBusFareDao busFareDao;
            public BusFareController(IBusFareDao busFareDao)
            {
                busFareDao = busFareDao;
            }

            [HttpGet]
            public IActionResult FetchAllDetails()
            {
                var fetchedData = busFareDao.FetchAllDetails();
                return this.Ok(fetchedData);
            }
            [HttpGet]
            [Route("{FareId}")]
            public IActionResult FetchDetailsById(int id)
            {
                BusFareDao busFareDao = new BusFareDao();
                var fetchedData = busFareDao.FetchDetailsById(id);
                return this.Ok(fetchedData);

            }
            [HttpPost]
            public IActionResult InsertBusfareInfo(BusFareDao fare)
            {
                BusFareDao busFareDaoo = new BusFareDao();
                var result = busFareDao.InsertBusFareInfo(fare);
                return this.CreatedAtAction(
                    "InsertBusFareInfo",
                    new
                    {
                        StatusCode = 201,
                        Response = result,
                        Data = fare, 
                    }
                    );
            }
        }
    }


