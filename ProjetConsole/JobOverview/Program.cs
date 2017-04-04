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

            var listannexe = new List<Annexes>();
            Annexes.SaisieAnnexe(listannexe);


            string saisiea, saisieb, saisiec;
            Console.WriteLine("Quelle est la version de logiciel sur laquelle vous voulez avoir une information, 1.00 ou 2.00?");
            saisiea = Console.ReadLine();
            Console.WriteLine("Pour quelle personne voulez-vous avoir une information?");
            saisieb = Console.ReadLine();
            Console.WriteLine("Pour quelle activité voulez-vous avoir une information?");
            saisiec = Console.ReadLine();
            CodeActivités saisiecprim = (CodeActivités)Enum.Parse(typeof(CodeActivités), saisiec);


            Console.WriteLine("Sur la version {0}, {1} a réalisé {2} jours de travail, et il lui reste {3} jours de planifiés.", saisiea, saisieb,,);
            Console.WriteLine("Sur la version {0}, la durée de travail réalisée a dépassé de {1} la durée prévue, ce qui représente un pourcentage proche de {2}", saisiea,,);
            Console.WriteLine("La durée de travail réalisée pour l'activité {0} sur la version {1} est de {2}", saisiec, saisiea,);

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
                                            //Personnes p = new Personnes();
                                            //p = Personnes.TrouverNom(personnes, codePersonne);
                                            //Console.WriteLine("Nom : {0} Prénom : {1}", p.Prénom, p.Nom);


            Console.ReadKey();
        }
    }
}
