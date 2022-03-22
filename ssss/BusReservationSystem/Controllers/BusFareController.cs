using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class BusFareController : Controller
        {
        private IBusFareDao _fareDao;
        public BusFareController(IBusFareDao fareDao)
        {
            this._fareDao = fareDao;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_fareDao.FetchAllDetails());
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
                return this.Ok(_fareDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertBusFareInfo(BusFareModel Fare)
        {
            var result = _fareDao.InsertBusFareInfo(Fare);
            return this.CreatedAtAction(
            "InsertBusFareInfo",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Fare
            }
            );
        }
    }
}
