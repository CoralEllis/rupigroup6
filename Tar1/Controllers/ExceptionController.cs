using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tar1.Models;

namespace AkimShifts.Controllers
{
    public class ExceptionController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/Exception/per")]
        public List<Exceptions> Get(int Unit, DateTime Date)
        {
            Exceptions ex = new Exceptions();
            return ex.GetEx(Unit, Date);
        }

        [HttpGet]
        [Route("api/Exception/Special")]
        public List<Exceptions> Get(DateTime start, DateTime end, int unitid)
        {
            Exceptions e = new Exceptions();
            return e.GetSpecialExcep(start, end, unitid);
        }

        [HttpGet]
        [Route("api/Exception/Number")]
        public List<Exceptions> GetNumber(DateTime start, DateTime end, int unitid)
        {
            Exceptions e = new Exceptions();
            return e.GetExceptionsNum(start, end, unitid);
        }

        // POST api/<controller>
        public void Post([FromBody]List<Exceptions> ExcptArr)
        {
            Exceptions e = new Exceptions();
            e.InsertExceptions(ExcptArr);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]Exceptions Ex)
        {
            Ex.UpdateEx();
        }

        // DELETE api/<controller>/5
        public void Delete([FromBody] Exceptions Ex)
        {
            //Exceptions e = new Exceptions();
            //e.DelException(Ex);
            Ex.DelException();
        }
    }
}