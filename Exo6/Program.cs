using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Renseignez le mois pour connaitre la saison : ");
            String month = Console.ReadLine();

            switch (month) //Switch commence par évaluer la variable qui lui est passée entre parenthèses.
            {

                case "janvier":
                    Console.WriteLine("c'est l'hiver");
                    break;
                case "février":
                    Console.WriteLine("c'est l'hiver");
                    break;
                case "mars":
                    Console.WriteLine("c'est l'hiver");
                    break;
                case "avril":
                    Console.WriteLine("printemps");
                    break;
                case "mai":
                    Console.WriteLine("primtemps");
                    break;
                case "juin":
                    Console.WriteLine("c'est l'été");
                    break;
                case "juillet":
                    Console.WriteLine("c'est l'été");
                    break;
                case "aout":
                    Console.WriteLine("c'est l'été");
                    break;
                case "septembre":
                    Console.WriteLine("c'est l'automne");
                    break;
                case "octobre":
                    Console.WriteLine("c'est l'automne");
                    break;
                case "novembre":
                    Console.WriteLine("c'est l'automne");
                    break;
                case "décembre":
                    Console.WriteLine("c'est l'hiver");
                    break;
                default:
                    Console.WriteLine("Bonjour inconnu");
                    break;
            }
            Console.ReadKey();
        }
    }
}
