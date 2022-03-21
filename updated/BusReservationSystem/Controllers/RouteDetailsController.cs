using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RouteDetailsController : Controller
    {
        private IRouteDetailsDao _routeDao;
        public RouteDetailsController(IRouteDetailsDao routeDao)
        {
            this._routeDao = routeDao;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_routeDao.FetchAllDetails());
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
                return this.Ok(_routeDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertRouteDetailsInfo(RouteDetailsModel Route)
        {
            var result = _routeDao.InsertRouteDetailsInfo(Route);
            return this.CreatedAtAction(
            "InsertData",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Route
            }
            );
        }

        [HttpDelete]
        [Route("id")]
        public IActionResult DeleteRouteDetails(int id)
        {
            try
            {
                var result = _routeDao.DeleteRouteDetails(id);
                return this.CreatedAtAction(
                  "DeleteRouteDetails",
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









