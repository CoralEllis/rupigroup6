using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tar1.Models;

namespace AkimShifts.Controllers
{
    public class UserController : ApiController
    {
        // GET api/<controller>


        // GET api/<controller>/5
        [HttpGet]
        [Route("api/User/{id}/{password}")]
        public User Get(string id, string password)
        {
            User u = new User();
            return u.GetUsers(id, password);

        }
        [HttpGet]
        [Route("api/User/{id:int}")]
        public List<User> Get(int id)
        {
            User u = new User();
            return u.getManager();
        }

        [HttpGet]
        [Route("api/User/{shift}")]
        public List<User> Get(string shift)
        {
            User u = new User();
            return u.GetAvailableGuides(shift);
        }


        [HttpGet]
        [Route("api/User/WorkUnit")]
        public List<User> Get(int unit, DateTime Date)
        {

            User u = new User();
            return u.GetUnitUsers(unit, Date);
        }
        [HttpGet]
        [Route("api/User/WorkUnit/{start}/{end}/{unitid}")]
        public List<User> Get(DateTime start, DateTime end, int unitid)
        {
            User u = new User();
            return u.GetGuidesHours(start, end, unitid);
        }

        // POST api/<controller>
        public void Post([FromBody]User user)
        {
            user.InsertUser();
        }

        // PUT api/<controller>/5
        public void Put(string id, [FromBody]User u)
        {
            if (id == "abc")
            {
                u.updateManager();
            }
            else u.updateUser(id);
        }




        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}