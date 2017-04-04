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
            var a1 = new DAL();//on appelle le constructeur de la classe DAL donc on instancie une nouvelle liste
            a1.ChargeFichier();// appel de la méthode charge fichier et chargement les données dans la nouvelle liste


            var personnes = new List<Personnes>();// on instancie une nouvelle liste de personnes


            //ici on remplit la liste<personnes> en créant de nouvelles personnes en appellant le constructeur qui prend les trois paramètres du nom, Prénom et code métier dans personne //on lui asssocie un métier grâce à l'enum CodeMétiers
            personnes.Add(new Personnes("Geneviève", "Leclerq", CodeMétiers.ANA));
            personnes.Add(new Personnes("Angèle", "Ferrand", CodeMétiers.ANA));
            personnes.Add(new Personnes("Balthazar", "Normand", CodeMétiers.CDP));
            personnes.Add(new Personnes("Raymond", "Fisher", CodeMétiers.DEV));
            personnes.Add(new Personnes("Lucien", "Butler", CodeMétiers.DEV));
            personnes.Add(new Personnes("Roseline", "Beaumont", CodeMétiers.DEV));
            personnes.Add(new Personnes("Marguerite", "Weber", CodeMétiers.DES));
            personnes.Add(new Personnes("Hilaire", "Klein", CodeMétiers.TES));
            personnes.Add(new Personnes("Nino", "Palmer", CodeMétiers.TES));


            var métiers = new Métiers();//on appelle le constructeur par défault (sans paramétre) de la classe Métiers donc on instancie un nouveau métier
            var activités = new Activités();//on appelle le constructeur par défault (sans paramétre) de la classe Métiers donc on instancie une nouvelle activité
            Personnes p = new Personnes();
            p = Personnes.TrouverNom(personnes, codePersonne);
            Console.WriteLine("Nom : {0} Prénom : {1}", p.Prénom, p.Nom);


            Console.ReadKey();
        }
    }
}
