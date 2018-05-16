using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using budgeterData.Models;
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
        public IEnumerable<string> Get()
        {
            _userContext.Add(new User()
            {
                UserName = "Jerin",
                UserRealName = "Jerin Johnson",
                Password = "aa"
            });
            _userContext.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
