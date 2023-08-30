using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Curriculum Curricula = new Curriculum();
            Curricula.infoPersonali = new User("Giuseppe", "Cifarelli", 132387241, "cifaCode@gmail.com");
           
            Study firstStudy = new Study("Superiore", "Scientifico Tecnologico", "Liceo", "2008", "2013");
            Study secondStudy = new Study("Alta Formazione", "EPICODE", "Azienda", "05/2023", "11/2023");
            Curricula.formazione.Add(firstStudy);
            Curricula.formazione.Add(secondStudy);

            Experience firstExp = new Experience("Errebi", "Consulente", "10/2021", "05/2023", "Consulente del Lavoro", "Assunzioni,Licenziamenti,INPS,INAIL");
            Experience secondExp = new Experience("EPICODE", "Studente", "05/2023", "11/2023", "Studente", "Full Stack");
            Curricula.lavoro.ExperienceList.Add(firstExp);
            Curricula.lavoro.ExperienceList.Add(secondExp);




        Console.WriteLine("Giuseppe Cifarelli's CV");
            Console.WriteLine("++++ START User Information ++++");
            Console.WriteLine(Curricula.infoPersonali.Name);
            Console.WriteLine(Curricula.infoPersonali.Surname);
            Console.WriteLine(Curricula.infoPersonali.Phone);
            Console.WriteLine(Curricula.infoPersonali.Email);
            Console.WriteLine("++++ END User Information ++++");
            Console.WriteLine("++++ START User Studies ++++");
            foreach (var item in Curricula.formazione)
            {
                Console.WriteLine(item.Qualifica);
                Console.WriteLine(item.Istituto);
                Console.WriteLine(item.Tipo);
                Console.WriteLine(item.Dal);
                Console.WriteLine(item.Al);
            }
            Console.WriteLine("++++ END User Studies ++++");
            Console.WriteLine("++++ START User Works ++++");
            foreach (var item in Curricula.lavoro.ExperienceList) {
                Console.WriteLine(item.Azienda);
                Console.WriteLine(item.JobTitle);
                Console.WriteLine(item.Dal);
                Console.WriteLine(item.Al);
                Console.WriteLine(item.Descrizione);
                Console.WriteLine(item.Compiti);
            }
            Console.WriteLine("++++ END User Works ++++");
            Console.ReadLine();

        }
    }
}
