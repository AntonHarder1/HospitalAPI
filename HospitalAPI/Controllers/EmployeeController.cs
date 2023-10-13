using HospitalAPI.Managers;
using HospitalAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeManager _manager = new EmployeeManager();


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(_manager.GetAll());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{patientId}")]
        public ActionResult<Employee> GetByEmployeemerNumber(int exerciseNumber)
        {
            Employee exercise = _manager.GetByEmployeeNumber(exerciseNumber);
            if (exercise == null) return NotFound();
            return Ok(exercise);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Employee> Post(Employee newEmployee)
        {
            return _manager.Add(newEmployee);
        }

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[HttpDelete]
        //public ActionResult<Employee> Delete(int exerciseNumber)
        //{
        //    Employee exercise = _manager.Delete(exerciseNumber);
        //    if (exercise == null) return NotFound();
        //    return Ok(exercise);
        //}
    }
}
