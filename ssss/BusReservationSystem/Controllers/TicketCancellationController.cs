using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class TicketCancellationController : Controller
        {
            private ITicketCancellationDao _cancellationDao;
            public TicketCancellationController(ITicketCancellationDao cancellationDao)
            {
                this._cancellationDao = cancellationDao;
            }

            [HttpGet]
            [Route("allDetails")]
            public IActionResult FetchAllData()
            {
                try
                {
                    return this.Ok(_cancellationDao.FetchAllDetails());
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
                    return this.Ok(_cancellationDao.FetchDetailsById(id));
                }
                catch (Exception ex)
                {
                    return this.BadRequest(ex.Message);
                }
            }


            [HttpPost]
            [Route("InsertData")]
            public IActionResult InsertTicketCancellationInfo(TicketCancellationModel Cancellation)
            {
                var result = _cancellationDao.InsertTicketCancellationInfo(Cancellation);
                return this.CreatedAtAction(
                "InsertData",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = Cancellation
                }
                );
            }

            [HttpDelete]
            [Route("id")]
            public IActionResult DeleteTicketCancellation(int id)
            {
                try
                {
                    var result = _cancellationDao.DeleteTicketCancellation(id);
                    return this.CreatedAtAction(
                      "DeleteTicketCancellation",
                      new
                      {
                          StatusCode = 201,
                          Response = result,
                          Data = id
                      }
                      );
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

        }
    }




