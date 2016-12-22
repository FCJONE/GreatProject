using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OLEG_
{
    public class Database
    {
        public class ProjectsContext : DbContext
        {
            public DbSet<Project> Projects { get; set; }
        }

        public class UserContext : DbContext
        {
            public DbSet<User> Users { get; set; }
        }

        public void Create()
        {
            var db = new ProjectsContext();
        }
    }
}