using HospitalAPI.Managers;
using HospitalAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmController : ControllerBase
    {
        private readonly AlarmManager _manager = new AlarmManager();


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Alarm>> GetAll()
        {
            return Ok(_manager.GetAll());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{deviceId}")]
        public ActionResult<Alarm> GetByAlarmmerNumber(int exerciseNumber)
        {
            Alarm exercise = _manager.GetByAlarmNumber(exerciseNumber);
            if (exercise == null) return NotFound();
            return Ok(exercise);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Alarm> Post(Alarm newAlarm)
        {
            return _manager.Add(newAlarm);
        }

        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[HttpDelete]
        //public ActionResult<Alarm> Delete(int exerciseNumber)
        //{
        //    Alarm exercise = _manager.Delete(exerciseNumber);
        //    if (exercise == null) return NotFound();
        //    return Ok(exercise);
        //}
    }
}
