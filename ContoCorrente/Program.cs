using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome dell'intestatario");
            string name = Console.ReadLine();
            Console.WriteLine("Cognome dell'intestatario");
            string surname = Console.ReadLine();
            Conto conto = new Conto(name, surname);
            string op = "";
            double tot;
            while ( op!= "5"){
                Console.WriteLine("Quale operazione vuoi effettuare?");
                Console.WriteLine("1 - APRIRE UN CONTO");
                Console.WriteLine("2 - VERSAMENTO");
                Console.WriteLine("3 - PRELIEVO");
                Console.WriteLine("4 - VISUALIZZA CONTO");
                Console.WriteLine("5 - ESCI");
                op = Console.ReadLine();
                switch(op)
                {
                    case "1":
                        if (conto.contoAperto) Console.WriteLine("Conto già aperto");
                        else
                        {
                            Console.WriteLine("Con quanto vuoi aprire il conto? Minimo 1000$");
                            tot = Convert.ToDouble(Console.ReadLine());
                            conto.aprireConto(tot);
                        }
                        break;
                    
                    case "2":
                        if (conto.contoAperto)
                        {
                            Console.WriteLine("A quanto ammonta il versamento?");
                            tot = Convert.ToDouble(Console.ReadLine());
                            conto.versamento(tot);
                        }
                        else Console.WriteLine("Conto non aperto, aprine uno");
                        break;
                    case "3":
                        if (conto.contoAperto)
                        {
                            Console.WriteLine("A quanto ammonta il prelievo?");
                            tot = Convert.ToDouble(Console.ReadLine());
                            conto.prelievo(tot);
                        }
                        else Console.WriteLine("Conto non aperto, aprine uno");
                        break;
                    case "4":
                        if (conto.contoAperto)
                            Console.WriteLine(conto.statoConto());
                        else Console.WriteLine("Conto non aperto, aprine uno");
                        break;
                    case "5":
                        Console.WriteLine("Stai uscendo dall'app,premi invio per uscire");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
