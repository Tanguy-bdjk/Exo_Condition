using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection fujita = new NameValueCollection();
            fujita.Add("F0", "Dégats leger");
            fujita.Add("F1", "Dégâts modérés ");
            fujita.Add("F2", "Dégâts importants");
            fujita.Add("F3", "Dégâts considérables");
            fujita.Add("F4", "Dégâts dévastateurs ");
            fujita.Add("F5", "Dégâts incroyables");

            Console.WriteLine("type de tornade ? ");
            string type = Console.ReadLine();
            switch (type)

            {

                case "F0":
                    Console.WriteLine(fujita["F0"]);
                    break;
                case "F1":
                    Console.WriteLine(fujita["F1"]);
                    break;
                case "F2":
                    Console.WriteLine(fujita["F2"]);
                    break;
                case "F3":
                    Console.WriteLine(fujita["F3"]);
                    break;
                case "F4":
                    Console.WriteLine(fujita["F4"]);
                    break;
                case "F5":
                    Console.WriteLine(fujita["F5"]);
                    break;
                default:

                    Console.WriteLine("Bonjour inconnu");

                    break;

            }
        }
    }
}
