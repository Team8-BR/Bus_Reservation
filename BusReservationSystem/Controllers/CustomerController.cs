using BusReservationSystem.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusReservationSystem.Controllers
{

    [Route("customerApi/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private ICustomerDao CustomerDao;
        public CustomerController(ICustomerDao customerDao)
        {
            customerDao = customerDao;
        }

        [HttpGet]
        public IActionResult FetchAllDetails()
        {
            var fetchedData = CustomerDao.FetchAllDetails();
            return this.Ok(fetchedData);
        }
        [HttpGet]
        [Route("{UserId}")]
        public IActionResult FetchDetailsById(int id)
        {
            CustomerDao customerDao = new CustomerDao();
            var fetchedData = customerDao.FetchDetailsById(id);
            return this.Ok(fetchedData);

        }
        [HttpPost]
        public IActionResult InsertCustomerInfo(CustomerDao customer)
        {
            CustomerDao customerDao = new CustomerDao();
            var result = customerDao.InsertCustomerInfo(customer);
            return this.CreatedAtAction(
                "InsertCustomerInfo",
                new
                {
                    StatusCode = 201,
                    Response = result,
                    Data = customer,
                }
                );
        }
    }
}

