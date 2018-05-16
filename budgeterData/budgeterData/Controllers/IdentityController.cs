using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using budgeterData.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace budgeterData.Controllers
{
    [Route("api/[controller]")]
    public class IdentityController : Controller
    {
        private readonly UserContext _userContext;
        public IdentityController(UserContext userContext)
        {
            _userContext = userContext;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [EnableCors("ng2_policy")]
        public User Post([FromBody]User user)
        {
            user= _userContext.users.FirstOrDefault(
                a => a.UserName == user.UserName
              && a.Password == user.Password) as User;

            user.token = "jithin";
            return user;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
