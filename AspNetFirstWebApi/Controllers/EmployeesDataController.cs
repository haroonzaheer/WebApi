using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesDataController : ControllerBase
    {
        public string[] myEmployees = { "Haroon", "Adil", "Usama" };

        [HttpGet]
        public string[] GetEmployees()
        {
            return myEmployees;
        }

        [HttpGet("{id}")]
        public string GetEmployeesById(int id)
        {
            return myEmployees[id];
        }

    }
}
