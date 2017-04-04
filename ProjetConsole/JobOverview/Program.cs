using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a1 = new DAL();//on appelle le constructeur de la classe DAL donc on instancie une nouvelle liste
            a1.ChargeFichier();// appel de la méthode charge fichier et chargement les données dans la nouvelle liste

            var listannexe = new List<Annexes>();
           // Annexes.SaisieAnnexe(listannexe);

            var personnes = new List<Personnes>();// on instancie une nouvelle liste de personnes
            Personnes.RemplissagePersonne(personnes);

            var métiers = new Métiers();//on appelle le constructeur par défault (sans paramétre) de la classe Métiers donc on instancie un nouveau métier
            métiers.RemplissageMétier();

            var activités = new Activités();//on appelle le constructeur par défault (sans paramétre) de la classe Métiers donc on instancie une nouvelle activité
                                            //Personnes p = new Personnes();
                                            //p = Personnes.TrouverNom(personnes, codePersonne);
                                            //Console.WriteLine("Nom : {0} Prénom : {1}", p.Prénom, p.Nom);
            activités.RemplissageActivité();

            int choix1 = 1; 
            int choix2;
            while (choix1 == 1 || choix1 == 2 || choix1 == 3)
            {
                Console.WriteLine("1 - Saisir des activités annexes.");
                Console.WriteLine("2 - Afficher des résultats.");
                Console.WriteLine("3 - Changer la durée restante d'une tâche.");
                Console.WriteLine("4 - Quitter.");
                choix1 = int.Parse(Console.ReadLine().Trim());
                switch (choix1)
                {
                    case 1:
                        Annexes.SaisieAnnexe(listannexe);
                        break;
                    case 2:
                        Console.WriteLine("1 - Concernant une activité.");
                        Console.WriteLine("2 - Concernant une personne.");
                        Console.WriteLine("3 - Concernant le pourcentage d'avance.");
                        Console.WriteLine("4 - Revenir au menu précédent.");
                        Console.WriteLine("5 - Quitter.");
                        choix2 = int.Parse(Console.ReadLine().Trim());
                        switch (choix2)
                        {
                            case 1:
                                Results.AfficherTravailActivité(a1.Data, activités);
                                break;
                            case 2:
                                Results.AfficherTravailPersonne(a1.Data, personnes);
                                break;
                            case 3:
                                Results.AfficherPourcentage(a1.Data);
                                break;
                            case 4:                            
                                break;
                            case 5:
                                choix1 = 4;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        if (Production.ChangerDuréeTache(a1.Data))
                            Console.WriteLine("Changement effectué avec succès.");
                        else
                            Console.WriteLine("Changement impossible !");
                            break;
                    default:

                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
