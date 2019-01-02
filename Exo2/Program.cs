using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int.TryParse(Console.ReadLine(), out age);
            if (age < 18 && age > 0) // vérifier que l'age renseigné est entre 0 et 17ans
            {
                Console.WriteLine("vous etes donc mineur");
            }
            else if (age > 18)
            {
                Console.WriteLine("vous etes donc mineur");

            }
            else // on gère le cas ou la saisie est incorrect
            {
                Console.WriteLine("faux!");
            }
            Console.ReadKey();
        }
    }
}
