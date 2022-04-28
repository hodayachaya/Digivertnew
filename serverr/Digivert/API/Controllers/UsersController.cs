using API.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        DBEntities DB = new DBEntities();
        // login users
        [Route("api/User/LoginUser")]
        [HttpPost]
        public DTOusers LoginUser(string name, int password)
        {
            DTOusers u = BL.UsersManegment.LoginUser(name, password);
            return u;
        }


        // register user
        [Route("api/User/RegisterUser")]
        [HttpPost]
        public string RegisterUser(DTOusers newUser)
        {
            DTOusers u = BL.UsersManegment.RegisterUser(newUser);

            return "succes" + "" + u.firstName+""+u.lastName+"!";
        }

        // update user
        [Route("api/User/UpdateUser")]
        [HttpPost]
        public string UpdateUser(DTOusers updateUser)
        {
            DTOusers u = BL.UsersManegment.UpdateUser(updateUser);

            return "succes";
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
