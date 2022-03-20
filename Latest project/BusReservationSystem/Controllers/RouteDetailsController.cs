﻿using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusReservationSystem.Controllers
{

    [Route("routeDetailsApi/[controller]")]
    [ApiController]
    public class RouteDetailsController : Controller
    {
        private IRouteDetailsDao routeDetailsDao;
        public RouteDetailsController(IRouteDetailsDao routeDetailsDao)
        {
            routeDetailsDao = routeDetailsDao;
        }

        [HttpGet]
        public IActionResult FetchAllDetails()
        {
            var fetchedData = routeDetailsDao.FetchAllDetails();
            return this.Ok(fetchedData);
        }
        [HttpGet]
        [Route("{RouteId}")]
        public IActionResult FetchDetailsById(int id)
        {
            RouteDetailsDao routeDetailsDao = new RouteDetailsDao();
            var fetchedData = routeDetailsDao.FetchDetailsById(id);
            return this.Ok(fetchedData);

        }
        [HttpPost]
        public IActionResult InsertRouteInfo(RouteDetailsDao route)
        {
            RouteDetailsDao routeDetailsDao = new RouteDetailsDao();
            var result = routeDetailsDao.InsertRouteInfo(route);
            return this.CreatedAtAction(
                "InsertRouteInfo",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = route,
                }
                );
        }
    }
}

