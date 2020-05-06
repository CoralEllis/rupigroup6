﻿using System.Collections.Generic;
using System.Web.Http;
using Tar1.Models;

namespace AkimShifts.Controllers
{
    public class ApartmentTypeController : ApiController
    {
        // GET api/<controller>
        public List<ApartmentType> Get()
        {
            ApartmentType A = new ApartmentType();
            return A.get();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]ApartmentType APT)
        {
            APT.InsertAPT();
        }


        // PUT api/<controller>/5
        public void Put(int id, [FromBody]ApartmentType AT)
        {
            AT.UpdateAT(id);
        }


        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}