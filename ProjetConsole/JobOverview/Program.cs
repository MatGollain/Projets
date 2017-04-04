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
            string codePersonne = "GL";

            personnes.Add(new Personnes("Geneviève", "Leclerq", CodeMétiers.ANA));
            personnes.Add(new Personnes("Angèle", "Ferrand", CodeMétiers.ANA));
            personnes.Add(new Personnes("Balthazar", "Normand", CodeMétiers.CDP));
            personnes.Add(new Personnes("Raymond", "Fisher", CodeMétiers.DEV));
            personnes.Add(new Personnes("Lucien", "Butler", CodeMétiers.DEV));
            personnes.Add(new Personnes("Roseline", "Beaumont", CodeMétiers.DEV));
            personnes.Add(new Personnes("Marguerite", "Weber", CodeMétiers.DES));
            personnes.Add(new Personnes("Hilaire", "Klein", CodeMétiers.TES));
            personnes.Add(new Personnes("Nino", "Palmer", CodeMétiers.TES));

            Personnes p = new Personnes();         
            p = Personnes.TrouverNom(personnes, codePersonne);
            Console.WriteLine("Nom : {0} Prénom : {1}", p.Prénom, p.Nom);

            Console.ReadKey();
        }
    }
}
