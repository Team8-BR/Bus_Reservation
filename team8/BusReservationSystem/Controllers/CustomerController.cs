using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BusReservationSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private ICustomerDao _customerDao;
        public CustomerController(ICustomerDao customerDao)
        {
            this._customerDao = customerDao;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_customerDao.FetchAllDetails());
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
                return this.Ok(_customerDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }



        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertCustomerInfo(CustomerModel Customer)
        {
            var result = _customerDao.InsertCustomerInfo(Customer);
            return this.CreatedAtAction(
            "InsertCustomerInfo",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Customer
            }
            );

        }
    }
}


