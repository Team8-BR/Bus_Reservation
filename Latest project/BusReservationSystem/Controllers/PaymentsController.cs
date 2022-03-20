using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusReservationSystem.Controllers
{
    [Route("paymentsApi/[controller]")]
    [ApiController]
    public class PaymentsController : Controller
    {
        private IPaymentsDao paymentsDao;
        public PaymentsController(IPaymentsDao paymentsDao)
        {
            paymentsDao = paymentsDao;
        }

        [HttpGet]
        public IActionResult FetchAllDetails()
        {
            var fetchedData = paymentsDao.FetchAllDetails();
            return this.Ok(fetchedData);
        }
        [HttpGet]
        [Route("{BookingId}")]
        public IActionResult FetchDetailsById(int id)
        {
            PaymentsDao paymentsDao = new PaymentsDao();
            var fetchedData = paymentsDao.FetchDetailsById(id);
            return this.Ok(fetchedData);

        }
        [HttpPost]
        public IActionResult InsertPaymentsInfo(PaymentsDao payments)
        {
            PaymentsDao paymentsDao = new PaymentsDao();
            var result = paymentsDao.InsertPaymentsInfo(payments);
            return this.CreatedAtAction(
                "InsertPaymentsInfo",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = payments,
                }
                );
        }
    }
}

