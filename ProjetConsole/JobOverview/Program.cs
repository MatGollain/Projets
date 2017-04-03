using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new DAL();
            a1.ChargeFichier();// appel charger fichier et charge les données


            var personnes = new List<Personnes>();
            var métiers = new Métiers();
            var activités = new Activités();

           

            Console.ReadKey();
        }
    }
}
