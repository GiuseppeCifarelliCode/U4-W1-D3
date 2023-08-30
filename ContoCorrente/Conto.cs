using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoCorrente
{
    internal class Conto
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private double Saldo { get; set; }

        public bool contoAperto = false;

        public void aprireConto(double tot)
        {                      
                Saldo = 0;
            if (tot >= 1000)
            {
                contoAperto = true;
                versamento(tot);
            }
            else Console.WriteLine("Versamento insufficiente");
            
        }

        public double versamento(double tot)
        {
            if(contoAperto) return Saldo += tot;
            else
            {
                Console.WriteLine("Non esiste un conto, premi 1 per aprire un conto");
                return Saldo;
            }
        }

        public double prelievo(double tot)
        {
            if (contoAperto)
            {
                if (Saldo - tot < 0)
                {
                    Console.WriteLine("Saldo non sufficiente per il prelievo");
                    return Saldo;
                }
                else return Saldo -= tot;
            }
            else
            {
                Console.WriteLine("Non esiste un conto, premi 1 per aprire un conto");
                return Saldo;
            }

        }

        public string statoConto()
        {
            return $"Conto intestato a {Name} {Surname} con saldo {Saldo}";
        }

        public Conto() { }

        public Conto(string name, string surname) {
            Name = name;
            Surname = surname;
        }

    
    }
}
