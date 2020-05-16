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

        public List<User> Get()
        {
            User u = new User();
            List<User> U = u.GetUsers();
            return U;
        }

        // GET api/<controller>/5

        [HttpGet]
        [Route("api/User/{id:int}")]
        public List<User> Get(int id)
        {
            User u = new User();

            if (id == 0)
            {
                return u.getManager();
            }
            //else
            //return u.GetUnitUsers(id);
        }

        [HttpGet]
        [Route("api/User/{shift}")]
        public List<User> Get(string shift)
        {
            User u = new User();
         return u.GetAvailableGuides(shift);
        }
        [HttpGet]
        [Route("api/User/WorkUnit/{unidDate}")]
        public List<User> Get(string unitDate)
        {
            string[] infor = unitDate.Split('|');
            int unit = Convert.ToInt32(infor[0]);
            DateTime date = Convert.ToDateTime(infor[1]);
            User u = new User();
            return u.GetUnitUsers(unit, date);
        }

        // POST api/<controller>
        public void Post([FromBody]User user)
        {
            user.InsertUser();
        }

        // PUT api/<controller>/5
        public void Put(string id, [FromBody]User u)
        {
            if(id == "abc")
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