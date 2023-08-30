using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] numArray = new int[n];
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Inserisci un numero");
                int numero = Convert.ToInt16(Console.ReadLine());
                numArray[i] = numero;
            }

            int sum = 0;

            for (int i = 0;i < n; i++) {
            sum += numArray[i];
            }

            double avg = sum / n;
            Console.WriteLine($"La somma è {sum} mentre la media è {avg}");
            Console.ReadLine();
        
        }
    }
}
