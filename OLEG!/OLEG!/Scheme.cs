using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLEG_
{
    public abstract class Scheme
    {
        public string ID { get; set; }

        public string SchemeName { get; set; }

        public string Autor { get; set; }

        public virtual Project Projectt { get; set; }
        
        //public int BlocksCount { get; set; } //Леопольд ХО

    }
}