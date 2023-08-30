using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    internal class Experience
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }

        public Experience() { }

        public Experience(string azienda, string job, string dal, string al, string description, string compiti)
        {
            Azienda = Azienda;
            JobTitle = job;
            Dal = dal;
            Al = al;
            Descrizione = description;
            Compiti = compiti;
        }
    }
}
