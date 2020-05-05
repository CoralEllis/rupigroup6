using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tar1.Models;

namespace Tar1.Controllers
{
    public class OfficialController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5

        public List<OfficialShift> Get(int Unitid)
        {
            OfficialShift OS = new OfficialShift();
            return OS.GetOS(Unitid);
        }

        // POST api/<controller>
        public void Post([FromBody]List<OfficialShift> OffShiftArr)
        {
            OfficialShift OS = new OfficialShift();
            OS.InsertOffShift(OffShiftArr);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}