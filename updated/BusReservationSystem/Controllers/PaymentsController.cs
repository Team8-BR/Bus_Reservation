using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : Controller
    {
        private IPaymentsDao _payDao;
        public PaymentsController(IPaymentsDao payDao)
        {
            this._payDao = payDao;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_payDao.FetchAllDetails());
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
                return this.Ok(_payDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }



        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertPaymentsInfo(PaymentsModel Pay)
        {
            var result = _payDao.InsertPaymentsInfo(Pay);
            return this.CreatedAtAction(
            "InsertpaymentsInfo",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Pay
            }
            );
        }
    }
}


