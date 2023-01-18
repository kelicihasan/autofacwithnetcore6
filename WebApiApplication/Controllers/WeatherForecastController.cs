using Microsoft.AspNetCore.Mvc;
using WebApiApplication.Services;

namespace WebApiApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public WeatherForecastController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
             return _customerRepository.GetAll();
        }
    }
}