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

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet]
        [Route("api/Exception/Special")]
        public List<Exceptions> Get(DateTime start, DateTime end, int unitid)
        {
            Exceptions e = new Exceptions();
           return e.GetSpecialExcep(start,end,unitid);
        }
        // POST api/<controller>
        public void Post([FromBody]List<Exceptions> ExcptArr)
        {
            Exceptions e = new Exceptions();
            e.InsertExceptions(ExcptArr);
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