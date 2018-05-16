using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using budgeterData.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace budgeterData.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserContext _userContext;
        public UsersController(UserContext userContext) {
            _userContext = userContext;
        }
        // GET api/users
        [HttpGet]
        [EnableCors("ng2_policy")]
        public IEnumerable<User> Get()
        {
            return _userContext.users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/users
        [HttpPost]
        [EnableCors("ng2_policy")]
        public void Post([FromBody]User User)
        {
            _userContext.Add(User);
            _userContext.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
