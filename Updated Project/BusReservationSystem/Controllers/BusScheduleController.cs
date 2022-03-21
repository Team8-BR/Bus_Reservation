using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusScheduleController : Controller
    {
        private IBusScheduleDao _scheduleDao;
        public BusScheduleController(IBusScheduleDao scheduleDao)
        {
            this._scheduleDao = scheduleDao;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_scheduleDao.FetchAllDetails());
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
                return this.Ok(_scheduleDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }



        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertBusScheduleInfo(BusScheduleModel Schedule)
        {
            var result = _scheduleDao.InsertBusScheduleInfo(Schedule);
            return this.CreatedAtAction(
            "InsertBusScheduleInfo",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Schedule
            }
            );
        }
    }
}


