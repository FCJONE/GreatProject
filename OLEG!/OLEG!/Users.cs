using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLEG_
{
    public class User
    {
        private short ID { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string MidName { get; set; }
        private bool Sex { get; set; }
        private string EMail { get; set; }
        private string PasswordHash { get; set; }
        private string NickName { get; set; }
    }
}