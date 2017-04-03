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
            a1.ChargeFichier();// appele  charger fichier et charge les données


            var personnes = new List<Personnes>();
            var métiers = new Métiers();
            var activités = new Activités();

            métiers.add(new Métiers(CodeMétier.ANA, "Analyste");
            métiers.add(new Métiers(CodeMétier.CDP, "Chef de projet");
            métiers.add(new Métiers(CodeMétier.DEV, "Développeur");
            métiers.add(new Métiers(CodeMétier.DES, "Designer");
            métiers.add(new Métiers(CodeMétier.TES, "Testeur");


            activités.add(new Activités(CodeActivités.DBE, "Définition de besoins");
            activités.add(new Activités(CodeActivités.ARF, "Architecture fonctionnelle");
            activités.add(new Activités(CodeActivités.ANF, "Analyse fonctionnelle");
            activités.add(new Activités(CodeActivités.DES, "Design");
            activités.add(new Activités(CodeActivités.INF, "Infographie");
            activités.add(new Activités(CodeActivités.ART, "Architecture technique");
            activités.add(new Activités(CodeActivités.ANT, "Analyse technique");
            activités.add(new Activités(CodeActivités.DEV, "Développement");
            activités.add(new Activités(CodeActivités.RPT, "Rédaction de plan de test");
            activités.add(new Activités(CodeActivités.TES, "Test");
            activités.add(new Activités(CodeActivités.GDP, "Gestion de projet");


            Console.ReadKey();
        }
    }
}
