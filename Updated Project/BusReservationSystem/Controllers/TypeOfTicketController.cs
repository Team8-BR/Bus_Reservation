using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{
    public class TypeOfTicketController : Controller
    {
        private ITypeOfTicketDao _ticketDao;
        public TypeOfTicketController(ITypeOfTicketDao ticketDao)
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
        public IActionResult InsertTypeOfTicketInfo(TypeOfTicketModel Ticket)
        {
            var result = _ticketDao.InsertTypeOfTicketInfo(Ticket);
            return this.CreatedAtAction(
            "InsertTypeOfTicketInfo",
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

