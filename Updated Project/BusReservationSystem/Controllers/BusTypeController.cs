using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusTypeController : Controller
    {
        private IBusTypeDao _typeDao;
        public BusTypeController(IBusTypeDao typeDao)
        {
            this._typeDao = typeDao;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_typeDao.FetchAllDetails());
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
                return this.Ok(_typeDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertBusTypeInfo(BusTypeModel Type)
        {
            var result = _typeDao.InsertBusTypeInfo(Type);
            return this.CreatedAtAction(
            "InsertData",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Type
            }
            );
        }

        [HttpDelete]
        [Route("id")]
        public IActionResult DeleteBusType(int id)
        {
            try
            {
                var result = _typeDao.DeleteBusType(id);
                return this.CreatedAtAction(
                  "DeleteBusType",
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