﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tar1.Models;

namespace AkimShifts.Controllers
{
    public class ApplyShiftController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/<controller>/5
        [HttpGet]
        [Route("api/ApplyShift/{Unitid:int}")]
        public List<ApplyShift> Get(int Unitid)
        {
            ApplyShift appS = new ApplyShift();
            return appS.GetAS(Unitid);
        }
        [HttpGet]
        [Route("api/ApplyShift/Block")]
        public List<ApplyShift> Get(string User, string Unit)
        {
            ApplyShift appS = new ApplyShift();
            return appS.GetApplyShift(Unit,User);
        }
        // POST api/<controller>
        public void Post([FromBody]List<ApplyShift> AS)
        {
            ApplyShift appS = new ApplyShift();
            appS.InsertApplyShift(AS);
        }
        // PUT api/<controller>/5
        public void Put([FromBody]ApplyShift AS)
        {
            AS.UpdateApplyShift();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}