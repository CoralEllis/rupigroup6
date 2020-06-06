using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tar1.Models;

namespace AkimShifts.Controllers
{
    public class ShiftsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public List<Shift> Get(int id)
        {
           Shift s = new Shift();
           return s.GetShifts(id);
        }
        [HttpGet]
        [Route("api/Shifts/Per")]
        public List<Shift> Get(int uid, DateTime startperiod)
        {
            Shift s = new Shift();
            return s.GetShiftsByPeriod(uid, startperiod);
        }

        // POST api/<controller>
        public void Post([FromBody]List<Shift> ShiftArr)
        {
            Shift s = new Shift();
            s.PostShifts(ShiftArr);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]Shift Shift)
        {
            Shift.UpdateShiftInfo();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}