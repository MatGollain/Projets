using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public abstract class Taches //la classe est abstraite et on ne peut pas l'instancier. On pourra instancier seulement ses dérivés.//classe POCO
    {
        #region Propriétés
        public int NumTache { get; set; }
        public int DuréeTravailRéalisé { get; set; }
        public string LibTache { get; set; }
        #endregion
    }

    public class Production : Taches// Taches est l'ancêtre de production //classe POCO
    {
        #region Propriétés
        public string CodePersonne { get; set; }
        public CodeActivités ActivitéTache { get; set; }
        public DateTime DateDébutTravail { get; set; }
        public int DuréeTravailPrévu { get; set; }
        public int DuréeTravailRestant { get; set; }
        public string Version { get; set; }
        #endregion

        #region Méthode publique

        public static bool ChangerDuréeTache(List<Production> data)
        {
            int code, duree;
            Console.WriteLine("Quel tâche voulez-vous changer? identifiant :");
            code = int.Parse(Console.ReadLine());
            Console.WriteLine("Nouvelle valeur de la durée :");
            duree = int.Parse(Console.ReadLine());

            foreach (var t in data)
            {
                if (t.NumTache == code)
                {
                    t.DuréeTravailRestant = duree;
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
    public class Annexes : Taches// Tâches est l'ancêtre de annexe
    {
        #region Propriétés
        public static int Compteur { get; set; } = 0;
        public DateTime DateAnnexe { get; set; }
        #endregion

        #region Constructeurs
        public Annexes()
        {
            Compteur++;
            NumTache = Compteur;
        }
        #endregion

        #region Méthodes publiques
        public static void SaisieAnnexe(List<Annexes> listannexe)
        {

            string saisie1, saisie2, saisie3, saisie4;
            int saisieprim;
            DateTime saisietemps;
            Console.Write("Bonjour! ");            
            do
            {

                Console.WriteLine("Veuillez saisir une tâche annexe :");
                saisie1 = Console.ReadLine();
                Console.WriteLine("Combien de temps avez-vous alloué à cette tâches?:");
                saisie2 = Console.ReadLine();
                saisieprim = int.Parse(saisie2);
                Console.WriteLine("A quelle date cette tâche a-t-elle été effectuée? jj/mm/aaaa:");
                saisie3 = Console.ReadLine();
                saisietemps = DateTime.Parse(saisie3);
                Console.WriteLine("Avez-vous une autre tâche annexe à saisir oui/non? :");
                saisie4 = Console.ReadLine();
                saisie4 = saisie4.ToLower();
                var taches = new Annexes()
                {
                    LibTache = saisie1,
                    DuréeTravailRéalisé = saisieprim,
                    DateAnnexe = saisietemps
                };
                listannexe.Add(taches);
            }
            while (saisie4.CompareTo("oui")==0);
            
        }
        #endregion

    }
}
