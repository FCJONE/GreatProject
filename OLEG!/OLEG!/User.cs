using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLEG_
{
    public class User
    {
        public short ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string MidName { get; set; }

        public bool Sex { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string NickName { get; set; }
        
        public List<Project> Projects { get; set; }
    }
}