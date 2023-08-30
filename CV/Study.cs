using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    internal class Study
    {
        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }

        public Study() { }

        public Study(string qualifica, string istituto, string tipo, string dal, string al)
        {
            Qualifica = qualifica; Istituto = istituto; Tipo = tipo; Dal = dal; Al = al;    
        }


    }
}
