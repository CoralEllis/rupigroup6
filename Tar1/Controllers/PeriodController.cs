using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tar1.Models;

namespace AkimShifts.Controllers
{
    public class PeriodController : ApiController
    {
        // GET api/<controller>
        public void Get()
        {
         
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("api/Period/Id")]
        public List<Period> Get(string id)
        {
            int Unitid = Convert.ToInt32(id);
            Period period = new Period();
            return period.GetAllRelavnt(Unitid);
        }
        [HttpGet]
        [Route("api/Period/{id:int}")]
        public bool Get(int id)
        {
            Period p = new Period();
           return p.GetPer(id);
        }
    

        // POST api/<controller>
        public void Post([FromBody]Period p)
        {
            p.InsertPeriod();
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