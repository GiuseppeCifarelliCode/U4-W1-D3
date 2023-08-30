using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string[] array = new string[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Inserisci un nome");
                nome = Console.ReadLine();
                array[i] = nome;
            }
            Console.WriteLine("Quale nome vuoi cercare?");
            string searchedName = Console.ReadLine();
            if (array.Contains(searchedName))
            {
                Console.WriteLine(searchedName + " Il nome cercato è presente");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Il nome cercato non è presente");
                Console.ReadLine();
            }

            }
    }
}
