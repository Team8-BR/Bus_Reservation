using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BusDetailsController : Controller
    {
        private IBusDetailsDao _busDao;
        public BusDetailsController(IBusDetailsDao busDao)
        {
            this._busDao = busDao;
        }

        [HttpGet]
        [Route("allDetails")]
        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_busDao.FetchAllDetails());
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
                return this.Ok(_busDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertBusDetailsInfo(BusDetailsModel Bus)
        {
            var result = _busDao.InsertBusDetailsInfo(Bus);
            return this.CreatedAtAction(
            "InsertData",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Bus
            }
            );
        }
  
        [HttpDelete]
        [Route("id")]
            public IActionResult DeleteBusDetails(int id)
            {
                try
                {
                    var result = _busDao.DeleteBusDetails(id);
                    return this.CreatedAtAction(
                      "DeleteBusDetails",
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









