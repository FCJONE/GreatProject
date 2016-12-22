using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OLEG_
{
    public abstract class Project
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Autor { get; set; }

        public virtual List<Scheme> Schemes { get; set; }
    }
}