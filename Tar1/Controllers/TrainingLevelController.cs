﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tar1.Models;

namespace AkimShifts.Controllers
{
    public class TrainingLevelController : ApiController
    {
        // GET api/<controller>
        public List<TrainingLevel> Get()
        {
            TrainingLevel TL = new TrainingLevel();
            return TL.GetTrainingLevel();
        }

        // GET api/<controller>/5
        public List<User> Get(int id)
        {
            User u = new User();
            return u.getGuides(id);
        }

        // POST api/<controller>
        public void Post([FromBody]TrainingLevel tl)
        {
            tl.InsertTrainingLevel();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] TrainingLevel tl)
        {
            tl.UpdateTL(id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}