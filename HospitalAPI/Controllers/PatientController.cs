using HospitalAPI.Managers;
using HospitalAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientManager _manager = new PatientManager();


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Patient>> GetAll()
        {
            return Ok(_manager.GetAll());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{employeeId}")]
        public ActionResult<Patient> GetByPatientmerNumber(int exerciseNumber)
        {
            Patient exercise = _manager.GetByPatientNumber(exerciseNumber);
            if (exercise == null) return NotFound();
            return Ok(exercise);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Patient> Post(Patient newPatient)
        {
            return _manager.Add(newPatient);
        }

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[HttpDelete]
        //public ActionResult<Patient> Delete(int exerciseNumber)
        //{
        //    Patient exercise = _manager.Delete(exerciseNumber);
        //    if (exercise == null) return NotFound();
        //    return Ok(exercise);
        //}
    }
}
