using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace budgeterData.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }
        static DbContextOptions<UserContext> options { get; set; }

        public DbSet<User> users { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string firstname { get; set; }
        public string LastName { get; set; }
        public string token { get; set; }
    }
}
