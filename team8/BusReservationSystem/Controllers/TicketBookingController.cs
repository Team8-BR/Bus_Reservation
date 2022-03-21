using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TicketBookingController : Controller
    {
        private ITicketBookingDao _ticketDao;
        public TicketBookingController(ITicketBookingDao ticketDao)
        {
            this._ticketDao = ticketDao;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_ticketDao.FetchAllDetails());
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
                return this.Ok(_ticketDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }



        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertTicketBookingInfo(TicketBookingModel Ticket)
        {
            var result = _ticketDao.InsertTicketBookingInfo(Ticket);
            return this.CreatedAtAction(
            "InsertTicketBookingInfo",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Ticket
            }
            );
        }
    }
}

